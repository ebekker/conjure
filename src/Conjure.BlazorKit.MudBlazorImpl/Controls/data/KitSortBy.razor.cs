// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Data;

namespace Conjure.BlazorKit.Controls;

public partial class KitSortBy<TDataItem> : IDataSortKey<TDataItem>
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [CascadingParameter] public IDataSorter<TDataItem> DataSorter { get; set; } = default!;

    /// <summary>
    /// Specifying a binding in the context of the current TDataItem to derive a label and sort key
    /// expression, or specify both the <see cref="Label"/> and the <see cref="Expression"/> explicitly.
    /// </summary>
    [Parameter] public Expression<Func<TDataItem, object>>? Binding { get; set; }

    /// <summary>
    /// Specify a descriptive label for the sort key, or override the default label derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public string? Label { get; set; }
    /// <summary>
    /// Specify an expression for the sort key, or override the default expression derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public Func<IQueryable<TDataItem>, SortDirection, IQueryable<TDataItem>>? Expression { get; set; }

    private ValueBinder<TDataItem, object>? _binder;

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
            if (Expression == null)
            {
                Expression = (q, d) => q.OrderByDirection(d, Binding);
            }
        }
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        DataSorter?.Add(this);
    }
}
