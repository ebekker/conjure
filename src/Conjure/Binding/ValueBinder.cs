namespace Conjure.Binding
{

    using System.Linq.Expressions;
    using System.Reflection;

    public static class ValueBinder
    {
        public static ValueBinder<TValue> Create<TValue>(Expression<Func<TValue>> exp) =>
            new ValueBinder<TValue>(exp);

        public static ValueBinder<TInput, TValue> Create<TInput, TValue>(Expression<Func<TInput, TValue>> exp) =>
            new ValueBinder<TInput, TValue>(exp);
    }

    public class ValueBinder<TValue>
    {
        public ValueBinder(Expression<Func<TValue>> exp)
        {
            ValueExpression = exp;
            ParseBindingExpression();
        }

        public Expression<Func<TValue>> ValueExpression { get; private set; }
        public Expression<Func<object>> TargetRoot { get; private set; }
        public IEnumerable<ValuePathSegment> TargetPath { get; private set; }

        public Type TargetType { get; private set; }

        public MemberInfo ValueMember { get; private set; }

        public ValueGetter<TValue> Getter { get; private set; }
        public ValueSetter<TValue> Setter { get; private set; }

        public string ValueLabel { get; private set; }

        public bool TryGetValue(out TValue value)
        {
            bool canGet = false;

            if (ResolveTarget(out var target) && target != null)
            {
                if (Getter == null)
                {
                    value = (TValue)target;
                    canGet = true;
                }
                else if (target != null || Getter.IsStatic)
                {
                    value = Getter.Getter(target);
                    canGet = true;
                }
                else
                {
                    value = default;
                }
            }
            else
            {
                value = default;
            }

            return canGet;
        }

        public bool TrySetValue(TValue value)
        {
            bool canSet = false;

            if (ResolveTarget(out var target))
            {
                if (Setter != null && (target != null || Setter.IsStatic))
                {
                    Setter.Setter(target, value);
                    canSet = true;
                }
            }

            return canSet;
        }

        public bool CanSetValue => Setter != null;

        private bool ResolveTarget(out object target)
        {
            var targetResolved = true;
            var root = TargetRoot?.Compile().Invoke();
            target = root;

            foreach (var vps in TargetPath)
            {
                if (target != null || vps.IsStatic)
                {
                    target = vps.Getter(target);
                }
                else
                {
                    targetResolved = false;
                    break;
                }
            }

            return targetResolved;
        }

        private object Evaluate(Expression x)
        {
            if (x is ConstantExpression cx)
                return cx.Value;

            return Expression.Lambda(x).Compile().DynamicInvoke();
        }

        private void ParseBindingExpression()
        {
            var leafValue = ValueExpression.Body;

            // First resolve the leaf node Getter/Setter
            while (leafValue is UnaryExpression unaryEx)
            {
                leafValue = unaryEx.Operand;
            }

            if (leafValue is MemberExpression membEx)
            {
                ValueMember = membEx.Member;
                if (membEx.Member is PropertyInfo pi)
                {
                    ValueLabel = pi.Name;
                    if (pi.CanRead)
                    {
                        Getter = new ValueGetter<TValue>
                        {
                            Label = pi.Name,
                            TypedLabel = $"property[{pi.Name}]",
                            IsStatic = pi.GetMethod.IsStatic,
                            Getter = (target) => target != null || pi.GetMethod.IsStatic
                                ? (TValue)pi.GetValue(target) : default(TValue),
                        };
                    }
                    if (pi.CanWrite)
                    {
                        Setter = new ValueSetter<TValue>
                        {
                            Label = pi.Name,
                            TypedLabel = $"property[{pi.Name}]",
                            IsStatic = pi.SetMethod.IsStatic,
                            Setter = (target, value) =>
                            {
                                if (target != null || pi.SetMethod.IsStatic)
                                    pi.SetValue(target, value);
                            },
                        };
                    }

                    leafValue = membEx.Expression;
                }
                else if (membEx.Member is FieldInfo fi)
                {
                    ValueLabel = fi.Name;
                    Getter = new ValueGetter<TValue>
                    {
                        Label = fi.Name,
                        TypedLabel = $"field[{fi.Name}]",
                        IsStatic = fi.IsStatic,
                        Getter = (target) => (TValue)fi.GetValue(target),
                    };
                    Setter = new ValueSetter<TValue>
                    {
                        Label = fi.Name,
                        TypedLabel = $"field[{fi.Name}]",
                        IsStatic = fi.IsStatic,
                        Setter = (target, value) =>
                        {
                            if (target != null || fi.IsStatic)
                                fi.SetValue(target, value);
                        },
                    };

                    leafValue = membEx.Expression;
                }
            }
            else if (leafValue is MethodCallExpression cx)
            {
                ValueLabel = cx.Method.Name;
            }

            // Then resolve the full path of the expression to the value
            var nextValue = leafValue;
            var fullValuePath = new List<ValuePathSegment>();
            TargetType = leafValue?.Type;
            while (nextValue != null)
            {
                switch (nextValue)
                {
                    case ConstantExpression kx:
                        fullValuePath.Insert(0, new ValuePathSegment
                        {
                            Label = kx.Value?.GetType().Name ?? "Object",
                            TypedLabel = $"constant[{kx.Value}]",
                            IsStatic = false,
                            Getter = target => kx.Value,
                        });
                        if (kx.Type.IsValueType)
                        {
                            // Have to box it up
                            var convExp = Expression.Convert(nextValue, typeof(object));
                            TargetRoot = Expression.Lambda<Func<object>>(convExp);
                        }
                        else
                        {
                            TargetRoot = Expression.Lambda<Func<object>>(nextValue);
                        }
                        nextValue = null;
                        break;

                    case UnaryExpression ux when ux.NodeType == ExpressionType.Convert:
                        // Skip insert in path
                        nextValue = ux.Operand;
                        break;

                    case MemberExpression mx:
                        // Properties
                        if (mx.Member is PropertyInfo pi)
                        {
                            fullValuePath.Insert(0, new ValuePathSegment
                            {
                                Label = pi.Name,
                                TypedLabel = $"property[{pi.Name}]",
                                IsStatic = pi.GetMethod.IsStatic,
                                Getter = target => target != null || pi.GetMethod.IsStatic
                                    ? pi.GetValue(target)
                                    : null,
                            });
                            nextValue = mx.Expression;
                        }
                        // Fields
                        else if (mx.Member is FieldInfo fi)
                        {
                            fullValuePath.Insert(0, new ValuePathSegment
                            {
                                Label = fi.Name,
                                TypedLabel = $"field[{fi.Name}]",
                                IsStatic = fi.IsStatic,
                                Getter = target => fi.IsStatic || target != null
                                    ? fi.GetValue(target)
                                    : null,
                            });
                            nextValue = mx.Expression;
                        }
                        // Is there anything else?
                        else
                        {
                            throw new Exception("Don't know how to handle MEMBER expression of type "
                                + nextValue.NodeType + " rooted at " + nextValue?.ToString());
                        }
                        break;

                    case MethodCallExpression cx:
                        // Static
                        if (cx.Object == null)
                        {
                            // For extension methods, the first arg is effectively the receiver
                            nextValue = cx.Arguments.First();
                            fullValuePath.Insert(0, new ValuePathSegment
                            {
                                Label = cx.Method.Name,
                                TypedLabel = $"staticCall[{cx.Method.Name}]",
                                IsStatic = true,
                                Getter = target => target != null
                                    ? cx.Method.Invoke(null, cx.Arguments.Select(x => Evaluate(x)).ToArray())
                                    : null,
                            });
                        }
                        // Instance
                        else
                        {
                            nextValue = cx.Object;
                            fullValuePath.Insert(0, new ValuePathSegment
                            {
                                Label = cx.Method.Name,
                                TypedLabel = $"call[{cx.Method.Name}]",
                                IsStatic = false,
                                Getter = target => target != null
                                    ? cx.Method.Invoke(target, cx.Arguments.Select(x => Evaluate(x)).ToArray())
                                    : null,
                            });
                        }
                        // else
                        // {
                        //     throw new Exception("Don't know how to handle CALLER expression of type "
                        //         + getValue.NodeType + " rooted at " + getValue?.ToString());
                        // }
                        break;

                    default:
                        throw new Exception("Don't know how to handle expression of type "
                            + nextValue.NodeType + " (" + nextValue.GetType().FullName + ") rooted at " + nextValue?.ToString());
                        // TargetRoot = Expression.Lambda<Func<object>>(getValue);
                        // getValue = null;
                        // break;
                }
            }

            TargetPath = fullValuePath;
        }
    }

    public class ValueBinder<TInput, TValue>
    {
        public ValueBinder(Expression<Func<TInput, TValue>> exp)
        {
            ValueExpression = exp;
            ParseBindingExpression();
        }

        public Expression<Func<TInput, TValue>> ValueExpression { get; private set; }
        public Expression<Func<object>> TargetRoot { get; private set; }
        public IEnumerable<ValuePathSegment<TInput>> TargetPath { get; private set; }

        public Type TargetType { get; private set; }

        public MemberInfo ValueMember { get; private set; }

        public ValueGetter<TInput, TValue> Getter { get; private set; }
        public ValueSetter<TInput, TValue> Setter { get; private set; }

        public string ValueLabel { get; private set; }

        public bool TryGetValue(TInput input, out TValue value)
        {
            bool canGet = false;

            if (ResolveTarget(input, out var target) && target != null)
            {
                if (Getter == null)
                {
                    value = (TValue)target;
                    canGet = true;
                }
                else if (target != null || Getter.IsStatic)
                {
                    value = Getter.Getter(target, input);
                    canGet = true;
                }
                else
                {
                    value = default;
                }
            }
            else
            {
                value = default;
            }

            return canGet;
        }

        public bool TrySetValue(TInput input, TValue value)
        {
            bool canSet = false;

            if (ResolveTarget(input, out var target))
            {
                if (Setter != null && (target != null || Setter.IsStatic))
                {
                    Setter.Setter(target, input, value);
                    canSet = true;
                }
            }

            return canSet;
        }

        public bool CanSetValue => Setter != null;

        private bool ResolveTarget(TInput input, out object target)
        {
            var targetResolved = true;
            var root = TargetRoot?.Compile().Invoke();
            target = root;

            foreach (var vps in TargetPath)
            {
                if (target != null || vps.IsStatic)
                {
                    target = vps.Getter(target, input);
                }
                else
                {
                    targetResolved = false;
                    break;
                }
            }

            return targetResolved;
        }

        private object Evaluate(Expression x)
        {
            if (x is ConstantExpression cx)
                return cx.Value;

            return Expression.Lambda(x).Compile().DynamicInvoke();
        }

        private void ParseBindingExpression()
        {
            var leafValue = ValueExpression.Body;

            // First resolve the leaf node Getter/Setter
            while (leafValue is UnaryExpression unaryEx)
            {
                leafValue = unaryEx.Operand;
            }

            if (leafValue is MemberExpression membEx)
            {
                ValueMember = membEx.Member;
                if (membEx.Member is PropertyInfo pi)
                {
                    ValueLabel = pi.Name;
                    if (pi.CanRead)
                    {
                        Getter = new ValueGetter<TInput, TValue>
                        {
                            Label = pi.Name,
                            TypedLabel = $"property[{pi.Name}]",
                            IsStatic = pi.GetMethod.IsStatic,
                            Getter = (target, input) => target != null || pi.GetMethod.IsStatic
                                ? (TValue)pi.GetValue(target) : default(TValue),
                        };
                    }
                    if (pi.CanWrite)
                    {
                        Setter = new ValueSetter<TInput, TValue>
                        {
                            Label = pi.Name,
                            TypedLabel = $"property[{pi.Name}]",
                            IsStatic = pi.SetMethod.IsStatic,
                            Setter = (target, input, value) =>
                            {
                                if (target != null || pi.SetMethod.IsStatic)
                                    pi.SetValue(target, value);
                            },
                        };
                    }

                    leafValue = membEx.Expression;
                }
                else if (membEx.Member is FieldInfo fi)
                {
                    ValueLabel = fi.Name;
                    Getter = new ValueGetter<TInput, TValue>
                    {
                        Label = fi.Name,
                        TypedLabel = $"field[{fi.Name}]",
                        IsStatic = fi.IsStatic,
                        Getter = (target, input) => (TValue)fi.GetValue(target),
                    };
                    Setter = new ValueSetter<TInput, TValue>
                    {
                        Label = fi.Name,
                        TypedLabel = $"field[{fi.Name}]",
                        IsStatic = fi.IsStatic,
                        Setter = (target, input, value) =>
                        {
                            if (target != null || fi.IsStatic)
                                fi.SetValue(target, value);
                        },
                    };

                    leafValue = membEx.Expression;
                }
            }
            else if (leafValue is MethodCallExpression cx)
            {
                ValueLabel = cx.Method.Name;
            }

            // Then resolve the full path of the expression to the value
            var nextValue = leafValue;
            var fullValuePath = new List<ValuePathSegment<TInput>>();
            TargetType = leafValue?.Type;
            while (nextValue != null)
            {
                switch (nextValue)
                {
                    case ConstantExpression kx:
                        fullValuePath.Insert(0, new ValuePathSegment<TInput>
                        {
                            Label = kx.Value?.GetType().Name ?? "Object",
                            TypedLabel = $"constant[{kx.Value}]",
                            IsStatic = false,
                            Getter = (target, input) => kx.Value,
                        });
                        if (kx.Type.IsValueType)
                        {
                            // Have to box it up
                            var convExp = Expression.Convert(nextValue, typeof(object));
                            TargetRoot = Expression.Lambda<Func<object>>(convExp);
                        }
                        else
                        {
                            TargetRoot = Expression.Lambda<Func<object>>(nextValue);
                        }
                        nextValue = null;
                        break;

                    case UnaryExpression ux when ux.NodeType == ExpressionType.Convert:
                        // Skip insert in path
                        nextValue = ux.Operand;
                        break;

                    case ParameterExpression px:
                        fullValuePath.Insert(0, new ValuePathSegment<TInput>
                        {
                            Label = px.Name,
                            TypedLabel = $"param[{px.Name}]",
                            Getter = (target, input) => input,
                        });
                        nextValue = null;
                        break;

                    case MemberExpression mx:
                        // Properties
                        if (mx.Member is PropertyInfo pi)
                        {
                            fullValuePath.Insert(0, new ValuePathSegment<TInput>
                            {
                                Label = pi.Name,
                                TypedLabel = $"property[{pi.Name}]",
                                IsStatic = pi.GetMethod.IsStatic,
                                Getter = (target, input) => target != null || pi.GetMethod.IsStatic
                                    ? pi.GetValue(target)
                                    : null,
                            });
                            nextValue = mx.Expression;
                        }
                        // Fields
                        else if (mx.Member is FieldInfo fi)
                        {
                            fullValuePath.Insert(0, new ValuePathSegment<TInput>
                            {
                                Label = fi.Name,
                                TypedLabel = $"field[{fi.Name}]",
                                IsStatic = fi.IsStatic,
                                Getter = (target, input) => fi.IsStatic || target != null
                                    ? fi.GetValue(target)
                                    : null,
                            });
                            nextValue = mx.Expression;
                        }
                        // Is there anything else?
                        else
                        {
                            throw new Exception("Don't know how to handle MEMBER expression of type "
                                + nextValue.NodeType + " rooted at " + nextValue?.ToString());
                        }
                        break;

                    case MethodCallExpression cx:
                        // Static
                        if (cx.Object == null)
                        {
                            // For extension methods, the first arg is effectively the receiver
                            nextValue = cx.Arguments.First();
                            fullValuePath.Insert(0, new ValuePathSegment<TInput>
                            {
                                Label = cx.Method.Name,
                                TypedLabel = $"staticCall[{cx.Method.Name}]",
                                IsStatic = true,
                                Getter = (target, input) => target != null
                                    ? cx.Method.Invoke(null, cx.Arguments.Select(x => Evaluate(x)).ToArray())
                                    : null,
                            });
                        }
                        // Instance
                        else
                        {
                            nextValue = cx.Object;
                            fullValuePath.Insert(0, new ValuePathSegment<TInput>
                            {
                                Label = cx.Method.Name,
                                TypedLabel = $"call[{cx.Method.Name}]",
                                IsStatic = false,
                                Getter = (target, input) => target != null
                                    ? cx.Method.Invoke(target, cx.Arguments.Select(x => Evaluate(x)).ToArray())
                                    : null,
                            });
                        }
                        // else
                        // {
                        //     throw new Exception("Don't know how to handle CALLER expression of type "
                        //         + getValue.NodeType + " rooted at " + getValue?.ToString());
                        // }
                        break;

                    default:
                        throw new Exception("Don't know how to handle expression of type "
                            + nextValue.NodeType + " (" + nextValue.GetType().FullName + ") rooted at " + nextValue?.ToString());
                        // TargetRoot = Expression.Lambda<Func<object>>(getValue);
                        // getValue = null;
                        // break;
                }
            }

            TargetPath = fullValuePath;
        }
    }
}
