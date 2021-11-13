// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;

public delegate Task<LoadDataPage<TDataItem>> LoadDataHandler<TDataItem>(LoadDataArgs<TDataItem> args);

public static class DataItemLoader
{
    public static LoadDataHandler<TDataItem> Create<TDataItem>(ValueBinder<IEnumerable<TDataItem>> binder,
        Func<IDataSearchField<TDataItem>[]> searchFieldsProvider = null)
    {
        // Temporarily disabled CS1998 until the async issue below is addressed
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        return async (args) =>
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var searchPredicates = new Expression<Func<TDataItem, SearchInput, bool>>[]
            {
                (item, input) => true,
                (item, input) => true,
                (item, input) => true,
            };


            // TODO: THIS NEEDS FURTHER INVESTIGATION
            // Down below we tried to make use of Async variants of the IQueryable extension methods
            // from EF Core (.CountAsync(), .ToListAsync(), etc...), HOWEVER, as the same DbContext
            // may be used by multiple data-query-aware controls on the same page, they may actually
            // invoke query operations against the same DbContext simulataneously from different
            // async pool threads, a big no-no with DbContext (which is not multi-thread capable).
            // For now we revert back to the sync versions, and we'll need to later investigate
            // if there is some way to synch calls within DbContext itself to force serializing
            // such activity against the same DbContext instance, and still support async calls
            // across different instances and different async I/O calls in general

            IEnumerable<TDataItem> items;
            var totalItems = 0;
            if (binder.TryGetValue(out var enumerable))
            {
                var pageSize = args.PageSize;
                if (enumerable is IQueryable<TDataItem> queryable)
                {
                    //totalItems = await queryable.CountAsync();
                    totalItems = queryable.Count();

                    if (args.Search != null && searchFieldsProvider != null)
                    {
                        var searchFields = searchFieldsProvider();
                        if (searchFields.Length > 0)
                        {
                            var pred = searchFields[0].Predicate!(args.Search)!;
                            for (var i = 1; i < searchFields.Length; i++)
                            {
                                pred = PredicateBuilder.Or(pred, searchFields[i].Predicate!(args.Search));
                            }
                            queryable = queryable.Where(pred);
                        }
                    }

                    if (args.SortKey?.Expression != null)
                    {
                        queryable = args.SortKey.Expression(queryable, args.SortDirection);
                    }

                    queryable = queryable.Skip(pageSize * args.Page).Take(pageSize);
                    //items = await queryable.ToListAsync();
                    items = queryable.ToList();
                }
                else
                {
                    totalItems = enumerable.Count();

                    if (args.Search != null && searchFieldsProvider != null)
                    {
                        var searchFields = searchFieldsProvider();
                        if (searchFields.Length > 0)
                        {
                            var pred = searchFields[0].Predicate!(args.Search)!;
                            for (var i = 1; i < searchFields.Length; i++)
                            {
                                pred = PredicateBuilder.Or(pred, searchFields[i].Predicate!(args.Search));
                            }
                            enumerable = enumerable.AsQueryable().Where(pred);
                        }
                    }

                    if (args.SortKey?.Expression != null)
                    {
                        enumerable = args.SortKey.Expression(enumerable.AsQueryable(), args.SortDirection);
                    }

                    enumerable = enumerable.Skip(pageSize * args.Page).Take(pageSize);
                    items = enumerable.ToList();
                }
            }
            else
            {
                items = Enumerable.Empty<TDataItem>();
            }

            return new()
            {
                Items = items,
                TotalItems = totalItems,
            };
        };
    }
}
