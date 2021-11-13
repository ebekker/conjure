// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Data;

public interface IDataSearcher<TDataItem>
{
    void Add(IDataSearchField<TDataItem> searchField);
}
