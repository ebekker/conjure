// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;

namespace Conjure.BlazorKit.Data;

public interface IDataSearchField<TDataItem>
{
    string? Label { get; }

    Func<SearchInput, Expression<Func<TDataItem, bool>>>? Predicate { get; }
}
