using DA.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class BaseContext: DbContext
    {
        public BaseContext() : base("baseName")
        {
         Database.SetInitializer(new MigrateDatabaseToLatestVersion<BaseContext, Configuration>(true));

        }
        public DbSet<Client>Clients { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<InputFile> InputFiles { get; set; }

    }
}
