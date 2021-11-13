using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Util;

namespace Conjure.BlazorKit.Controls;

public partial class KitCheckbox<TValue>
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public Expression<Func<TValue>>? Binding { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool ReadOnly { get; set; }
    [Parameter] public bool TriState { get; set; }
    [Parameter] public EventCallback AfterValueChanged { get; set; }
    [Parameter] public IConverter<TValue?, bool?>? Converter { get; set; }

    private bool _valueIsNullable = false;
    private IConverter<TValue?, bool?> _converter = BoolConverter<TValue?>.Instance;
    private ValueBinder<TValue>? _binder;

    private TValue? BoundValue
    {
        get => (_binder?.TryGetValue(out var val) ?? false) ? val : default(TValue);
        set
        {
            _binder?.TrySetValue(value);
            _ = AfterValueChanged.InvokeAsync();
            Screen.ScreenStateHasChanged();
        }
    }

    private bool BoundValueAsBool
    {
        get => _converter.Get(BoundValue) ?? false;
        set => BoundValue = _converter.Set(value);
    }

    private bool? BoundValueAsNullableBool
    {
        get => _converter.Get(BoundValue);
        set => BoundValue = _converter.Set(value);
    }

    private bool IsDisabled => Disabled || _binder?.Getter == null || !_binder.TryGetValue(out _);
    private bool IsReadOnly => ReadOnly || _binder?.Setter == null;

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        _valueIsNullable = !typeof(TValue).IsValueType
            || Nullable.GetUnderlyingType(typeof(TValue)) != null;

        TriState = _valueIsNullable;

        await base.SetParametersAsync(parameters);

        if (Converter != null)
        {
            _converter = Converter;
        }

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
