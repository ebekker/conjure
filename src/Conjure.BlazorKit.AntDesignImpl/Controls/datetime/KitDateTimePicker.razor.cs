// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using AntDesign;
using Conjure.Binding;

namespace Conjure.BlazorKit.Controls;

public partial class KitDateTimePicker<TValue>
{
    private static readonly int[] TimeRange = Enumerable.Range(0, 60).ToArray();
    private static readonly DatePickerDisabledTime AllDisabledTime =
        new(TimeRange[0..24], TimeRange[0..60], TimeRange[0..60]);

    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public Expression<Func<TValue>>? Binding { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool ReadOnly { get; set; }

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

    private string? BoundValueFormatted
    {
        get => ((BoundValue as IConvertible)?.ToDateTime(null))?.ToString("yyyy-MM-dd HH:mm:ss") ?? string.Empty;
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
