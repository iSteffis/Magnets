using Magnets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Magnets.DAL
{
    public class MagnetsContext : DbContext
    {
        public DbSet<Community> Communities { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}