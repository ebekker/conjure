// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Validation;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;

public class QuerySourceBuilder<TDbContext>
    where TDbContext : DbContextBase
{
    private readonly TDbContext _db;

    public QuerySourceBuilder(TDbContext db)
    {
        ArgumentNullException.ThrowIfNull(db);

        _db = db;
    }

    public QuerySourceBuilder<TDbContext, TDataItem> Select<TDataItem>(
        Func<TDbContext, IQueryable<TDataItem>> query)
        where TDataItem : class
    {
        ArgumentNullException.ThrowIfNull(query);

        return new QuerySourceBuilder<TDbContext, TDataItem>(_db, query);
    }
}
