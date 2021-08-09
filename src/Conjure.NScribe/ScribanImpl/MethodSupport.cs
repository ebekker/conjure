using System;
using System.Linq;
using System.Reflection;

namespace Conjure.NScribe.ScribanImpl
{
    public static class MethodSupport
    {
        public static object call(params object[] args)
        {
            if (args?.Length < 1 || args[0] is not MethodCall md)
                throw new Exception($"call must be piped from a method access");
            
            var type = md.Target.GetType();
            var methodArgs = new object[args.Length - 1];
            Array.Copy(args, 1, methodArgs, 0, methodArgs.Length);

            if (md.Method != null)
            {
                if (IsCallable(md.Method, methodArgs))
                {
                    return md.Method.Invoke(md.Target, methodArgs);
                }
                else
                {
                    throw new Exception("exact method signature does not support call arguments");
                }
            }

            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.Name == md.MethodName);
            
            foreach (var m in methods)
            {
                if (IsCallable(m, methodArgs))
                    return m.Invoke(md.Target, methodArgs);
            }

            throw new Exception("could not find matching method to call");
        }

        private static bool IsCallable(MethodInfo m, object[] methodArgs)
        {
            var parameters = m.GetParameters();
            if (parameters.Length != methodArgs.Length)
                return false;

            var argIndex = 0;
            foreach (var p in parameters)
            {
                if (methodArgs[argIndex] == null && p.ParameterType.IsValueType)
                    break;
                if (!p.ParameterType.IsAssignableFrom(methodArgs[argIndex].GetType()))
                    break;

                argIndex++;
            }
            return argIndex == parameters.Length;
        }

        public static MethodCall property(object value, string name, Type type = null)
        {
            if (value == null)
                return null;

            if (type == null)
                type = value.GetType();
            
            var meth = type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public)?.GetGetMethod();

            if (meth == null)
                return null;

            return new MethodCall
            {
                Target = value,
                Method = meth,
            };
        }

        public static MethodCall method(object value, string name, Type type = null)
        {
            if (value == null)
                return null;

            if (type == null)
                type = value.GetType();
            
            var meth = type.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(m => m.Name == name);

            if (meth == null)
                return null;

            return new MethodCall
            {
                Target = value,
                Method = meth,
            };
        }
        

        public static object @typeof(object value)
        {
            if (value == null)
                return "null";
            
            return value.GetType();
        }

        public static object typename(object value, bool asmQualified = false)
        {
            if (value == null)
                return "null";
            
            return asmQualified
                ? value.GetType().AssemblyQualifiedName
                : value.GetType().FullName;
        }

        public static MemberInfo member(object value, string name)
        {
            if (value == null)
                return null;
            
            return value.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name == name);
        }

        public static MemberInfo[] members(object value, string name, Type type = null)
        {
            if (value == null)
                return null;
            
            if (type != null)
                return type.GetMember(name, BindingFlags.Instance | BindingFlags.Public);

            return value.GetType().GetMember(name, BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public static Type @base(object value)
        {
            if (value == null)
                return null;
            
            return value.GetType().BaseType;
        }

        public static Type[] interfaces(object value, string name = null)
        {
            if (value == null)
                return null;
            
            if (name == null)
                return value.GetType().GetInterfaces();
            
            return new[] { value.GetType().GetInterface(name) };
        }
    }
}