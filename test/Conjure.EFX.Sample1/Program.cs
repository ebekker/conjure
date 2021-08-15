using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tracker.Core.Data;
using System.Linq;
using AdvWorks.Data;

namespace Tracker.Core.Data
{
    public partial class TrackerContext
    {
        private string _conn;

        public TrackerContext(string conn)
            : base()
        {
            _conn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (_conn != null)
                optionsBuilder.UseSqlServer(_conn);
        }
    }
}

namespace AdvWorks.Data
{
    public partial class AdventureWorks2017Context
    {
        private string _conn;

        public AdventureWorks2017Context(string conn)
            : base()
        {
            _conn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (_conn != null)
                optionsBuilder.UseSqlServer(_conn);
        }
    }
}

namespace Conjure.EFX.Sample1
{
    public partial class Program
    {
        static IConfigurationRoot _config;

        static void Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                ?? "Development";
            Console.WriteLine("Env: " + env);

            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env}.json", optional: true)
                .Build();

            //TestTracker();
            TestAdvWorks();
        }

        static void TestAdvWorks()
        {
            var conn = _config.GetConnectionString("AdvWorks");

            using var db = new AdventureWorks2017Context(conn);
            var query = db.Customers
                .Include(x => x.Person)
                .Include(x => x.SalesOrderHeaders)
                    .ThenInclude(x => x.SalesOrderDetails)
                .Where(x => x.Person != null)
                .Skip(100)
                .Take(50)
                ;
            foreach (var c in query.ToList())
            {
                Console.WriteLine($"Customer: {c.AccountNumber}");
                Console.WriteLine($"  Person: {c.Person.FirstName} {c.Person.LastName}");
                foreach (var h in c.SalesOrderHeaders)
                {
                    Console.WriteLine($"  Order Status: {h.Status}");
                    Console.WriteLine($"   Order Total: {h.TotalDue}");
                    foreach (var d in h.SalesOrderDetails)
                    {
                        Console.WriteLine($"    Detail: {d.ProductID}");
                    }
                }
            }
        }

        static void TestTracker()
        {
            var conn = _config.GetConnectionString("Tracker");
            Console.WriteLine("Connection to: " + conn);

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
    }
}
