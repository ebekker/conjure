using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
