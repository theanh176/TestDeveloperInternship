using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { CustomerID="ASJCN",
                    CompanyName = "Data Test1",
                    ContactName = "Data Test2",
                    ContactTitle = "Data Test3",
                    Address = "Data Test4",
                    City = "Data Test5",
                    Region = "",
                    PostalCode = "10000",
                    Country = "VietNam",
                    Phone = "0909123321",
                    Fax = "",
                }    
            );
        }
    }
}
