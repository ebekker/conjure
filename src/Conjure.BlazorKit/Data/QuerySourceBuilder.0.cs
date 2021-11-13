// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Validation;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;

public static class QuerySourceBuilder
{
    /// <summary>
    /// Starting point for builder pattern
    /// </summary>
    public static QuerySourceBuilder<TDbContext, TDataItem> Create<TDbContext, TDataItem>(
        TDbContext db, Func<TDbContext, IQueryable<TDataItem>> query)
        where TDbContext : DbContextBase
        where TDataItem : class
    {
        ArgumentNullException.ThrowIfNull(db);
        ArgumentNullException.ThrowIfNull(query);

        return new(db, query);
    }
    public static QuerySourceBuilder<TDbContext> Create<TDbContext>(TDbContext db)
        where TDbContext : DbContextBase
    {
        ArgumentNullException.ThrowIfNull(db);

        return new(db);
    }
}

