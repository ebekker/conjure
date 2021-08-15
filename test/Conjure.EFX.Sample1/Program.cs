using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tracker.Core.Data;
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
