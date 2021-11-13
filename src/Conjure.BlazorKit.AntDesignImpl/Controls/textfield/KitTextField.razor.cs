using Conjure.Binding;
using System.Linq.Expressions;

namespace Conjure.BlazorKit.Controls;

public partial class KitTextField<TValue>
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public Expression<Func<TValue>>? Binding { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool ReadOnly { get; set; }
    [Parameter] public int Lines { get; set; }
    [Parameter] public string? Format { get; set; }

    private ValueBinder<TValue>? _binder;

    private TValue? BoundValue

    {
        get => (_binder?.TryGetValue(out var val) ?? false) ? val : default(TValue);
        set
        {
            _binder?.TrySetValue(value);
            Screen.ScreenStateHasChanged();
        }
    }

    private bool IsDisabled => Disabled || _binder?.Getter == null || !_binder.TryGetValue(out _);
    private bool IsReadOnly => ReadOnly || _binder?.Setter == null;

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        if (Binding != null)
        {
            _binder = ValueBinder.Create(Binding);
            if (Label == null)
            {
                Label = _binder.ValueLabel.Titleize();
            }
        }
    }
}
