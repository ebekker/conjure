// Conjure application framework.
// Copyright (C) Conjure.

using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Data;

public class DbContextBase : DbContext
{
    //
    // Summary:
    //     Initializes a new instance of the Microsoft.EntityFrameworkCore.DbContext class
    //     using the specified options. The
    //     Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)
    //     method will still be called to allow further configuration of the options.
    //
    // Parameters:
    //   options:
    //     The options for this context.
    public DbContextBase(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        // As per:
        //  https://docs.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies
        optionsBuilder.UseChangeTrackingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // By default UseChangeTrackingProxies() enables the
        // ChangingAndChangeNotifications strategy but we rely
        // on the "Original Values" to support per entity undo
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
    }
}
