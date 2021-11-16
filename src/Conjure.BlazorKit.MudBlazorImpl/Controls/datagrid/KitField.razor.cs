// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Data;
using MudBlazor;

namespace Conjure.BlazorKit.Controls;

public partial class KitField<TDataItem> : IDataSortKey<TDataItem>, IDataSearchField<TDataItem>
    where TDataItem : class
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [CascadingParameter] public KitDataGrid<TDataItem> DataGrid { get; set; } = default!;

    /// <summary>
    /// Specifying a binding in the context of the current TDataItem to derive a label and sort key
    /// expression, or specify both the <see cref="Label"/> and the <see cref="Expression"/> explicitly.
    /// </summary>
    [Parameter] public Expression<Func<TDataItem, object>>? Binding { get; set; }

    /// <summary>
    /// Specify a descriptive label for the sort key, or override the default label derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Hidden { get; set; }

    [Parameter] public bool SortBy { get; set; }
    [Parameter] public Func<IQueryable<TDataItem>, Data.SortDirection, IQueryable<TDataItem>>? SortByExpression { get; set; }
    Func<IQueryable<TDataItem>, Data.SortDirection, IQueryable<TDataItem>>? IDataSortKey<TDataItem>.Expression => SortByExpression;

    [Parameter] public bool SearchBy { get; set; }
    [Parameter] public bool SearchByCaseInsensitive { get; set; }
    [Parameter] public Func<SearchInput, Expression<Func<TDataItem, bool>>>? SearchByPredicate { get; set; }
    Func<SearchInput, Expression<Func<TDataItem, bool>>>? IDataSearchField<TDataItem>.Predicate => SearchByPredicate;


    /// <summary>
    /// Specify an expression for the sort key, or override the default expression derived from <see cref="Binding"/>.
    /// </summary>
    [Parameter] public RenderFragment<TDataItem>? ChildContent { get; set; }

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
            if (!Hidden && ChildContent == null)
            {
                var func = Binding.Compile();
                ChildContent = item => builder => builder.AddContent(1, func.Invoke(item));
            }
            if (SortBy && SortByExpression == null)
            {
                SortByExpression = (q, d) => q.OrderByDirection(d, Binding);
            }
            if (SearchBy && SearchByPredicate == null)
            {
                SearchByPredicate = (input) => PredicateBuilder.Contains(
                    Binding, input.SearchValue!, SearchByCaseInsensitive);
            }
        }
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        DataGrid?.Add(this);

        if (SortByExpression != null)
        {
            ((IDataSorter<TDataItem>)DataGrid!).Add(this);
        }

        if (SearchByPredicate != null)
        {
            ((IDataSearcher<TDataItem>)DataGrid!).Add(this);
        }
    }
}
