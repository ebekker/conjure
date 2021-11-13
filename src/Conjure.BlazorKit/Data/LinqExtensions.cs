// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;

namespace Conjure.BlazorKit.Data;

public static class LinqExtensions
{
    // These were *stolen* from MudBlazor for convenience:
    //  https://github.com/MudBlazor/MudBlazor/blob/dev/src/MudBlazor/Extensions/TableExtensions.cs

    public static IOrderedEnumerable<TSource> OrderByDirection<TSource, TKey>(this IEnumerable<TSource> source, SortDirection direction,
        Func<TSource, TKey> keySelector)
    {
        if (direction == SortDirection.Descending)
            return source.OrderByDescending(keySelector);
        return source.OrderBy(keySelector);
    }

    public static IOrderedQueryable<TSource> OrderByDirection<TSource, TKey>(this IQueryable<TSource> source, SortDirection direction,
        Expression<Func<TSource, TKey>> keySelector)
    {
        if (direction == SortDirection.Descending)
            return source.OrderByDescending(keySelector);
        return source.OrderBy(keySelector);
    }
}
