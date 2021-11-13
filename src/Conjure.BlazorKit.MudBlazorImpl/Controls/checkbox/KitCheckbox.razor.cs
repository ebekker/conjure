// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;

namespace Conjure.BlazorKit.Controls;

public partial class KitCheckbox<TDataItem>
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public Expression<Func<TDataItem>>? Binding { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool ReadOnly { get; set; }
    [Parameter] public bool TriState { get; set; }

    private ValueBinder<TDataItem>? _binder;

    private TDataItem? BoundValue

    {
        get => (_binder?.TryGetValue(out var val) ?? false) ? val : default(TDataItem);
        set
        {
            if (_binder?.TrySetValue(value) ?? false)
            {
                Screen.ScreenStateHasChanged();
            }
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
