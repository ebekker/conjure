// Conjure application framework.
// Copyright (C) Conjure.

using Conjure.Validation;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;


public class QuerySource<TDbContext, TDataItem>
    where TDbContext : DbContextBase
    where TDataItem : class
{
    public TDbContext DB { get; }

    public Func<TDbContext, IQueryable<TDataItem>> QueryFactory { get; }

    public Func<IQueryable<TDataItem>, string, IQueryable<TDataItem>>? FilterFactory { get; init; }

    public IEnumerable<string?>? SortLabels { get; init; }

    public Func<IQueryable<TDataItem>, IDataSortKey<TDataItem>, SortDirection, IQueryable<TDataItem>>? SorterFactory { get; init; }

    public IEnumerable<ValidationHandler<TDataItem>>? Validators { get; init; }

    public TDataItem? SelectedItem { get; set; }

    public QuerySource(TDbContext db, Func<TDbContext, IQueryable<TDataItem>> queryFactory)
    {
        ArgumentNullException.ThrowIfNull(db);
        ArgumentNullException.ThrowIfNull(queryFactory);

        DB = db;
        QueryFactory = queryFactory;
    }

    public Task<LoadDataPage<TDataItem>> LoadPage(LoadDataArgs<TDataItem> args)
    {
        IQueryable<TDataItem> query = QueryFactory(DB);

        if (FilterFactory != null && args.Search?.SearchValue is string searchValue)
        {
            query = FilterFactory(query, searchValue);
        }

        if (SorterFactory != null && args.SortKey != null)
        {
            query = SorterFactory(query, args.SortKey, args.SortDirection);
        }

        // First, count the total matching records for paging purposes
        var totalItems = args.IncludeTotalItems ? query.Count() : -1;
        // TODO: ARGH!  Async version here and down below causes re-entrant
        //       call to _db when sorting by column, need to figure why!
        //_totalItems = await _db.Partners.CountAsync();

        // Then, narrow to a single page if needed
        if (args.Page >= 0 && args.PageSize > 0)
        {
            query = query
                .Skip(args.Page * args.PageSize)
                .Take(args.PageSize);
        }

        // Finally, resolve the actual data
        IEnumerable<TDataItem> pagedData = query.ToArray();
        // TODO: ARGH!  Async version here and up above causes re-entrant
        //       call to _db when sorting by column, need to figure why!
        //_pagedData = await query.ToArrayAsync();

        // Add in any newly added entities
        var added = DB.ChangeTracker.Entries<TDataItem>()
            .Where(x => x.State == EntityState.Added)
            .Select(x => x.Entity).ToArray();
        if (added.Length > 0)
        {
            pagedData = pagedData.Concat(added);
        }

        return Task.FromResult(new LoadDataPage<TDataItem>
        {
            TotalItems = totalItems,
            Items = pagedData,
        });
    }

    public bool CanUndoChanges(TDataItem item)
    {
        if (item != null)
        {
            var state = DB.Entry(item).State;
            return state == EntityState.Added
                || state == EntityState.Modified
                || state == EntityState.Deleted;
        }
        return false;
    }

    public Task UndoChanges(TDataItem item)
    {
        if (item != null)
        {
            var ee = DB.Entry(item);
            if (ee.State == EntityState.Added)
            {
                DB.Remove(item);
                if (SelectedItem == item)
                    SelectedItem = null;
            }
            else if (ee.State == EntityState.Modified || ee.State == EntityState.Deleted)
            {
                ee.CurrentValues.SetValues(ee.OriginalValues);
                ee.State = EntityState.Unchanged;
            }
        }
        return Task.CompletedTask;
    }
}
