// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Data;

public interface IDataSorter<TDataItem>
{
    void Add(IDataSortKey<TDataItem> sortKey);
}
