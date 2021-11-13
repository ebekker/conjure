// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Data;

public class LoadDataArgs<TDataItem>
{
    public SearchInput? Search { get; init; }

    public int Page { get; init; }
    public int PageSize { get; init; }

    public IDataSortKey<TDataItem>? SortKey { get; init; }
    public SortDirection SortDirection { get; init; }

    /// <summary>
    /// If true, a count of total items in the result page will be used to support paging.
    /// Otherwise, the value will be ignored so no need to compute.
    /// </summary>
    public bool IncludeTotalItems { get; init; }
}
