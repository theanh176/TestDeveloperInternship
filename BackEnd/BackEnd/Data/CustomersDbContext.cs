using BackEnd.Configuration;
using BackEnd.Models;
using BackEnd.Seeders;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
