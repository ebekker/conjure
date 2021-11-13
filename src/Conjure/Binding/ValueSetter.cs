namespace Conjure.Binding;

using System;

public class ValueSetter<TValue>
{
    internal ValueSetter() { }

    public string Label { get; internal set; }
    public string TypedLabel { get; internal set; }
    public bool IsStatic { get; internal set; }
    public Action<object, TValue> Setter { get; internal set; }
}

public class ValueSetter<TInput, TValue>
{
    internal ValueSetter() { }

    public string Label { get; internal set; }
    public string TypedLabel { get; internal set; }
    public bool IsStatic { get; internal set; }
    public Action<object, TInput, TValue> Setter { get; internal set; }
}
