using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class CustomerDbContextFactory : IDesignTimeDbContextFactory<CustomersDbContext>
    {
        public CustomersDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("CustomersDatabase");

            var optionBuilder = new DbContextOptionsBuilder<CustomersDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new CustomersDbContext(optionBuilder.Options);
        }
    }
}
