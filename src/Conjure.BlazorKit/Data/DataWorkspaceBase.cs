// Conjure application framework.
// Copyright (C) Conjure.

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
        Console.Error.WriteLine("Creating WORKSPACE: " + GetHashCode());
    }

    protected TDbContext CreateContext<TDbContext>()
        where TDbContext : DbContextBase
    {
        return _scope.ServiceProvider.GetRequiredService<TDbContext>();
    }

    protected void AddContext(DbContextBase db, Action? onDispose = null)
    {
        _dbContexts.Add(new()
        {
            _db = db,
            _onDispose = onDispose,
        });
    }

    protected int CountContexts => _dbContexts.Count;

    protected IEnumerable<DbContextBase> AllContexts => _dbContexts.Select(x => x._db!);

    protected void DisposeContexts()
    {
        foreach (var context in _dbContexts)
        {
            context._db?.Dispose();
            context._onDispose?.Invoke();
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
                Console.Error.WriteLine("Disposing WORKSPACE: " + GetHashCode());
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
