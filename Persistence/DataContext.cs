using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Value>().HasData(
                new { Id = 1, Name = "Value 101" },
                new { Id = 2, Name = "Value 102" },
                new { Id = 3, Name = "Value 103" }
            );
        }
    }
}
