namespace Conjure.Binding;

public class ValueGetter<TValue>
{
    internal ValueGetter() { }

    public string Label { get; internal set; }
    public string TypedLabel { get; internal set; }
    public bool IsStatic { get; internal set; }
    public Func<object, TValue> Getter { get; internal set; }
}
