using System;
using System.Data.Entity;

namespace Magnets.Models
{
    public class HomeDB
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Place { get; set; }
    }

    public class HomeDBContext : DbContext
    {
        public DbSet<HomeDB> Homes { get; set; }
    }
}