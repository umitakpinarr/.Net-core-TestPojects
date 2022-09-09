using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mulk.Models.Context
{
    public class DatabaseContext : DbContext
    {


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<tenants> tenants { get; set; }
        public DbSet<rents> rents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
