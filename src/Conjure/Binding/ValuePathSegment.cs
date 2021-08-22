namespace Conjure.Binding;

public class ValuePathSegment
{
    internal ValuePathSegment() { }

    public string Label { get; internal set; }
    public string TypedLabel { get; internal set; }
    public bool IsStatic { get; internal set; }
    public Func<object, object> Getter { get; internal set; }
}
