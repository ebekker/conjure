// Conjure application framework.
// Copyright (C) Conjure.

using Conjure.Validation;

namespace Conjure.BlazorKit.Data;


public static class QuerySource<TDbContext>
    where TDbContext : DbContextBase
{
    public static QuerySource<TDbContext, TDataItem> For<TDataItem>(TDbContext db,
        Func<TDbContext, IQueryable<TDataItem>> query,
        SortKey<TDataItem>[] sortKeys,
        Func<IQueryable<TDataItem>, string, IQueryable<TDataItem>>? filter = null,
        IEnumerable<ValidationHandler<TDataItem>>? validators = null)
        where TDataItem : class
    {
        Func<IQueryable<TDataItem>, IDataSortKey<TDataItem>, SortDirection, IQueryable<TDataItem>>? sorter = null;
        sorter = (query, label, dir) =>
        {
            if (label != null)
            {
                var key = sortKeys.FirstOrDefault(x => string.Equals(x.Label, label));
                if (key?.Query != null)
                {
                    return key.Query(query, dir);
                }
            }
            return query;
        };

        return new(db, db => query(db))
        {
            FilterFactory = filter,
            SortLabels = sortKeys.Select(x => x.Label),
            SorterFactory = sorter,
            Validators = validators,
        };
    }

    public static QuerySource<TDbContext, TDataItem> For<TDataItem>(TDbContext db,
        Func<TDbContext, IQueryable<TDataItem>> query,
        IEnumerable<string>? sortLabels = null,
        Func<IQueryable<TDataItem>, IDataSortKey<TDataItem>, SortDirection, IQueryable<TDataItem>>? sorter = null,
        Func<IQueryable<TDataItem>, string, IQueryable<TDataItem>>? filter = null,
        IEnumerable<ValidationHandler<TDataItem>>? validators = null)
        where TDataItem : class
    {
        return new(db, db => query(db))
        {
            FilterFactory = filter,
            SortLabels = sortLabels,
            SorterFactory = sorter,
            Validators = validators,
        };
    }
}
