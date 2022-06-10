using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("TestCustomers");
            builder.HasKey(t => t.CustomerID);
            builder.Property(t => t.CompanyName).IsRequired();
            builder.Property(t => t.ContactName).IsRequired();
            builder.Property(t => t.ContactTitle).IsRequired();
            builder.Property(t => t.Address).IsRequired();
            builder.Property(t => t.City).IsRequired();
            builder.Property(t => t.Region);
            builder.Property(t => t.PostalCode).IsRequired();
            builder.Property(t => t.Country).IsRequired();
            builder.Property(t => t.Phone).IsRequired();
            builder.Property(t => t.Fax);
        }
    }
}
