// This code adapted from the original Checkbox.razor.cs
//    https://github.com/ant-design-blazor/ant-design-blazor/blob/339b05571b15a269170eeb256ebe85b5f443923e/components/checkbox/Checkbox.razor.cs

using System.Linq.Expressions;

namespace AntDesign;

public partial class TriStateCheckbox : AntInputNullableBoolComponentBase
{
    [Parameter] public RenderFragment? ChildContent { get; set; }

    //[Obsolete] attribute does not work with [Parameter] for now. Tracking issue: https://github.com/dotnet/aspnetcore/issues/30967
    [Obsolete("Instead use @bing-Checked or EventCallback<bool> CheckedChanged .")]
    [Parameter]
    public EventCallback<bool?> CheckedChange { get; set; }

    [Parameter] public Expression<Func<bool?>>? CheckedExpression { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public bool TriState { get; set; }

    internal bool IsFromOptions { get; set; }
    private bool _isInitalized;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        SetClass();
        _isInitalized = true;
    }

    protected bool InputChecked => Checked ?? false;

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }

    protected ClassMapper ClassMapperLabel { get; } = new ClassMapper();

    private readonly string _prefixCls = "ant-checkbox";
    protected void SetClass()
    {
        ClassMapperLabel.Clear()
            .Add($"{_prefixCls}-wrapper")
            .If($"{_prefixCls}-wrapper-checked", () => Checked ?? false);

        ClassMapper.Clear()
            .Add(_prefixCls)
            .If($"{_prefixCls}-checked", () => Checked ?? false)
            .If($"{_prefixCls}-disabled", () => Disabled)
            .If($"{_prefixCls}-indeterminate", () => Checked == null)
            .If($"{_prefixCls}-rtl", () => RTL);
    }

    private bool? _lastNullValue;

    protected async Task InputCheckedChange(ChangeEventArgs args)
    {
        if (args != null && args.Value is bool value)
        {
            // A somewhat kludgy attempt at adding a third state with minimal disruption
            // in the original behavior.  It has the inelegant effect of cycling through
            // the third (null/indeterminate) state twice in a full cycle, once after each
            // of the other states (true/false), instead of just once in a sequental series.
            bool? newValue = value;
            if ((_lastNullValue == null && Value.HasValue) || (Value.HasValue && Value.Value == _lastNullValue))
            {
                _lastNullValue = !Value.Value;
                newValue = null;
            }

            await base.ChangeValue(newValue);

#pragma warning disable CS0618 // Type or member is obsolete
            if (CheckedChange.HasDelegate) // kept for compatibility reasons with previous versions
                await CheckedChange.InvokeAsync(newValue);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }

    internal void SetValue(bool value) => Checked = value;
}
