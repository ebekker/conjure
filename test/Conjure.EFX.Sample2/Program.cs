// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tracker.Core.Data;
using Tracker.Core.Data.Entities;

Console.WriteLine("Hello, World!");

var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
    ?? "Development";
Console.WriteLine("Env: " + env);

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{env}.json", optional: true)
    .Build();

TestTracker(config);


static void TestTracker(IConfigurationRoot config)
{
    var conn = config.GetConnectionString("Tracker");
    Console.WriteLine("Connection to: " + conn);

    Console.WriteLine("Querying against Entity: " + User.GetEntityClass());
    Console.WriteLine("                  Table: " + User.GetTableName());

    using var db = new TrackerContext(conn);
    var query = db.Users
        .Include(x => x.AssignedTasks)
        ;
    foreach (var u in query.ToList())
    {
        Console.WriteLine($"User: {u.DisplayName}");
        foreach (var t in u.AssignedTasks)
            Console.WriteLine($"  Task: {t.Title}");
    }
}
