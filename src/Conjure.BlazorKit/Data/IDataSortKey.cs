// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Data;

public interface IDataSortKey<TDataItem>
{
    string? Label { get; }

    //Func<IQueryable<TDataItem>, SortDirection, IOrderedQueryable<TDataItem>> Expression { get; set; }
    Func<IQueryable<TDataItem>, SortDirection, IQueryable<TDataItem>>? Expression { get; }
}
