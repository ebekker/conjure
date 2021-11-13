// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Validation;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;

public class QuerySourceBuilder<TDbContext, TDataItem>
    where TDbContext : DbContextBase
    where TDataItem : class
{
    private readonly TDbContext _db;
    private readonly Func<TDbContext, IQueryable<TDataItem>> _query;

    private Func<IQueryable<TDataItem>, string, IQueryable<TDataItem>>? _filter;

    // This is mutually exclusive with the next two
    private List<SortKey<TDataItem>>? _sortKeys;

    private Func<IQueryable<TDataItem>, IDataSortKey<TDataItem>, SortDirection, IQueryable<TDataItem>>? _sorter;
    private IEnumerable<string?>? _sortLabels;

    private List<ValidationHandler<TDataItem>>? _validators;

    public QuerySourceBuilder(TDbContext db, Func<TDbContext, IQueryable<TDataItem>> query)
    {
        ArgumentNullException.ThrowIfNull(db);
        ArgumentNullException.ThrowIfNull(query);

        _db = db;
        _query = query;
    }

    public QuerySourceBuilder<TDbContext, TDataItem> SetFilter(
        Func<IQueryable<TDataItem>, string, IQueryable<TDataItem>> filter)
    {
        _filter = filter;
        return this;
    }

    public QuerySourceBuilder<TDbContext, TDataItem> AddSortKey<TKey>(
        Expression<Func<TDataItem, TKey>> exp, string? label = null)
    {
        if (_sortLabels != null || _sorter != null)
            throw new InvalidOperationException(
                "cannot add sort keys when sort labels and custom sorter already set");

        if (_sortKeys == null)
            _sortKeys = new();
        _sortKeys.Add(SortKey<TDataItem>.For<TKey>(exp, label));
        return this;
    }

    public QuerySourceBuilder<TDbContext, TDataItem> SetCustomSorter(
        Func<IQueryable<TDataItem>, IDataSortKey<TDataItem>, SortDirection, IQueryable<TDataItem>> customSorter,
        params string[] sortLabels)
    {
        if (_sortKeys != null)
            throw new InvalidOperationException(
                "cannot set sort labels and custom sorter when sort keys already added");
        _sorter = customSorter;
        _sortLabels = sortLabels;
        return this;
    }

    public QuerySourceBuilder<TDbContext, TDataItem> AddValidator(
        ValidationHandler<TDataItem> validator)
    {
        if (_validators == null)
            _validators = new();
        _validators.Add(validator);
        return this;
    }

    public QuerySource<TDbContext, TDataItem> Build()
    {
        if (_sortKeys != null)
        {
            _sorter = (query, label, dir) =>
            {
                if (label != null)
                {
                    var key = _sortKeys.FirstOrDefault(x => string.Equals(x.Label, label));
                    if (key?.Query != null)
                    {
                        return key.Query(query, dir);
                    }
                }
                return query;
            };
            _sortLabels = _sortKeys.Select(x => x.Label);
        }

        return new(_db, _db => _query(_db))
        {
            FilterFactory = _filter,
            SortLabels = _sortLabels,
            SorterFactory = _sorter,
            Validators = _validators,
        };
    }
}
