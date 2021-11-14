// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Data;

namespace Conjure.BlazorKit.Controls;

public partial class KitSearchBy<TDataItem> : IDataSearchField<TDataItem>
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [CascadingParameter] public IDataSearcher<TDataItem> DataSearcher { get; set; } = default!;

    /// <summary>
    /// Specifying a binding in the context of the current TDataItem to derive a label and search field
    /// expression, or specify both the <see cref="Label"/> and the <see cref="Expression"/> explicitly.
    /// </summary>
    [Parameter] public Expression<Func<TDataItem, string>>? Binding { get; set; }

    /// <summary>
    /// Specify a descriptive label for the search field, or override the default label derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public string? Label { get; set; }
    /// <summary>
    /// Specify an expression for the sort field, or override the default expression derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public Func<SearchInput, Expression<Func<TDataItem, bool>>>? Predicate { get; set; }

    /// <summary>
    /// Specifies that the derived predicate from the Binding expression should do a case-insensitive
    /// comparison.  If the Predicate expression is not derived, this value has no effect.
    /// </summary>
    [Parameter] public bool CaseInsensitive { get; set; }

    private ValueBinder<TDataItem, string>? _binder;

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
            if (Predicate == null)
            {
                Predicate = (input) => PredicateBuilder.Contains(
                    Binding, input.SearchValue!, CaseInsensitive);
            }
        }
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        DataSearcher?.Add(this);
    }
}
