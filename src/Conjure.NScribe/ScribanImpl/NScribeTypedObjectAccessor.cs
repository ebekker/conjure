using System;
using System.Collections.Generic;
using System.Reflection;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;

namespace Conjure.NScribe.ScribanImpl
{
    public class NScribeTypedObjectAccessor : IObjectAccessor
    {
        private readonly MemberFilterDelegate _filter;
        private readonly Type _type;
        private readonly MemberRenamerDelegate _renamer;
        private readonly Dictionary<string, MemberInfo> _members;
        private PropertyInfo _indexer;

        public NScribeTypedObjectAccessor(Type targetType, MemberFilterDelegate filter, MemberRenamerDelegate renamer)
        {
            _type = targetType ?? throw new ArgumentNullException(nameof(targetType));
            _filter = filter;
            _renamer = renamer ?? StandardMemberRenamer.Default;
            _members = new Dictionary<string, MemberInfo>();
            PrepareMembers();
        }

        public Type IndexType { get; private set; }

        public int GetMemberCount(TemplateContext context, SourceSpan span, object target)
        {
            return _members.Count;
        }

        public IEnumerable<string> GetMembers(TemplateContext context, SourceSpan span, object target)
        {
            return _members.Keys;
        }

        public bool HasMember(TemplateContext context, SourceSpan span, object target, string member)
        {
            return _members.ContainsKey(member);
        }

        public bool TryGetValue(TemplateContext context, SourceSpan span, object target, string member, out object value)
        {
            value = null;
            MemberInfo memberAccessor;
            if (_members.TryGetValue(member, out memberAccessor))
            {
                var fieldAccessor = memberAccessor as FieldInfo;
                if (fieldAccessor != null)
                {
                    value = fieldAccessor.GetValue(target);
                    return true;
                }

                if (memberAccessor is MethodInfo methodInfo)
                {
                    value = new MethodCall
                    {
                        MethodName = methodInfo.Name,
                        Target = target,
                    };
                    return true;
                }

                var propertyAccessor = (PropertyInfo) memberAccessor;
                value = propertyAccessor.GetValue(target);
                return true;
            }
            return false;
        }

        public bool TryGetItem(TemplateContext context, SourceSpan span, object target, object index, out object value)
        {
            if (this._indexer is null)
            {
                value = default;
                return false;
            }
            value = this._indexer.GetValue(target, new []{index});
            return true;
        }

        public bool TrySetItem(TemplateContext context, SourceSpan span, object target, object index, object value)
        {
            if (_indexer is null)
            {
                return false;
            }
            _indexer.SetValue(target, value, new []{index});
            return true;
        }

        public bool HasIndexer => _indexer != null;

        public bool TrySetValue(TemplateContext context, SourceSpan span, object target, string member, object value)
        {
            MemberInfo memberAccessor;
            if (_members.TryGetValue(member, out memberAccessor))
            {
                var fieldAccessor = memberAccessor as FieldInfo;
                if (fieldAccessor != null)
                {
                    fieldAccessor.SetValue(target, value);
                }
                else if (memberAccessor is MethodInfo mi)
                {
                    return false;
                }
                else
                {
                    var propertyAccessor = (PropertyInfo)memberAccessor;
                    propertyAccessor.SetValue(target, value);
                }

                return true;
            }
            return false;
        }

        private void PrepareMembers()
        {
            var type = _type;

            while (type != null)
            {
                foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    var keep = field.GetCustomAttribute<ScriptMemberIgnoreAttribute>() == null;
                    if (keep && !field.IsStatic && field.IsPublic && !field.IsLiteral && (_filter == null || _filter(field)))
                    {
                        var newFieldName = Rename(field);
                        if (string.IsNullOrEmpty(newFieldName))
                        {
                            newFieldName = field.Name;
                        }

                        if (!_members.ContainsKey(newFieldName))
                        {
                            _members.Add(newFieldName, field);
                        }
                    }
                }

                foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    var keep = property.GetCustomAttribute<ScriptMemberIgnoreAttribute>() == null;

                    // Workaround with .NET Core, extension method is not working (retuning null despite doing property.GetMethod), so we need to inline it here
                    var getMethod = property.GetMethod;
                    if (keep && property.CanRead && !getMethod.IsStatic && getMethod.IsPublic && (_filter == null || _filter(property)))
                    {
                        var indexParameters = property.GetIndexParameters();
                        if (indexParameters.Length > 0)
                        {
                            IndexType = indexParameters[0].ParameterType;
                            _indexer = property;
                        }
                        else
                        {
                            var newPropertyName = Rename(property);
                            if (string.IsNullOrEmpty(newPropertyName))
                            {
                                newPropertyName = property.Name;
                            }

                            if (!_members.ContainsKey(newPropertyName))
                            {
                                _members.Add(newPropertyName, property);
                            }
                        }
                    }
                }

                var methodBindingFlags = BindingFlags.Instance | BindingFlags.Public;
                if (type.BaseType == typeof(object))
                    // Pull in all the methods of the base object as well
                    methodBindingFlags |= BindingFlags.DeclaredOnly;
                foreach (var method in type.GetMethods(methodBindingFlags))
                {
                    var keep = method.GetCustomAttribute<ScriptMemberIgnoreAttribute>() == null;
                    if (keep && !method.IsStatic && (_filter == null || _filter(method)))
                    {
                        var newMethodName = Rename(method);
                        if (string.IsNullOrEmpty(newMethodName))
                        {
                            newMethodName = method.Name;
                        }

                        if (!_members.ContainsKey(newMethodName))
                        {
                            _members.Add(newMethodName, method);
                        }
                    }
                }

                if (type.BaseType == typeof(object))
                {
                    break;
                }
                type = type.BaseType;
            }
        }

        private string Rename(MemberInfo member)
        {
            return _renamer(member);
        }
    }
}