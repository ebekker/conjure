// Conjure application framework.
// Copyright (C) Conjure.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.DependencyInjection;

namespace Conjure.BlazorKit.Data;

public class DataWorkspaceBase : IDisposable
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly IServiceScope _scope;
    private readonly List<DbInfo> _dbContexts = new();
    private bool _disposedValue;

    public DataWorkspaceBase(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
        _scope = _scopeFactory.CreateScope();
    }

    protected TDbContext CreateContext<TDbContext>()
        where TDbContext : DbContextBase
    {
        return _scope.ServiceProvider.GetRequiredService<TDbContext>();
    }

    protected void AddContext(DbContextBase db, Action? onDispose = null)
    {
        db.SavedChanges += Db_SavedChanges;

        _dbContexts.Add(new()
        {
            _db = db,
            _onDispose = onDispose,
        });
    }

    private void Db_SavedChanges(object? sender, SavedChangesEventArgs e)
    {
        SavedChanges?.Invoke(sender, e);
    }

    public event EventHandler<SavedChangesEventArgs>? SavedChanges;

    protected int CountContexts => _dbContexts.Count;

    protected IEnumerable<DbContextBase> AllContexts => _dbContexts.Select(x => x._db!);

    public bool HasChanges()
    {
        return AllContexts.Any(c => c.ChangeTracker.HasChanges());
    }

    public async Task SaveChangesAsync()
    {
        foreach (var context in AllContexts)
        {
            await context.SaveChangesAsync();
        }
    }

    public bool GetEntityEntry(object entity, out EntityEntry? entry)
    {
        foreach (var context in AllContexts)
        {
            var entityEntry = context.Entry(entity);
            if (entityEntry != null && entityEntry.State != EntityState.Detached)
            {
                entry = entityEntry;
                return true;
            }
        }
        entry = null;
        return false;
    }

    //RenderFragment EntityStateIndicator(object entity) => _db.Entry(entity).State switch
    //{
    //    EntityState.Added => EntityAdded,
    //    EntityState.Modified => EntityModified,
    //    EntityState.Deleted => EntityDeleted,
    //    EntityState.Detached => EntityDetached,
    //    _ => EntityDefault,
    //};


    protected void DisposeContexts()
    {
        foreach (var context in _dbContexts)
        {
            if (context._db != null)
            {
                context._db.SavedChanges -= Db_SavedChanges;
                context._db.Dispose();
                context._onDispose?.Invoke();
            }
        }
        _dbContexts.Clear();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                DisposeContexts();
                _scope.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~DataWorkspaceBase()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    private class DbInfo
    {
        public DbContextBase? _db;
        public Action? _onDispose;
    }
}
