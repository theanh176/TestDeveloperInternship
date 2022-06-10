using BackEnd.Data;
using BackEnd.Models;

namespace BackEnd.Service.Customers
{
    public class CustomersService : ICustomesService
    {
        private readonly CustomersDbContext _customersDbContext;
        public CustomersService(CustomersDbContext customersDbContext)
        {
           _customersDbContext = customersDbContext;
        }

        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return _customersDbContext.Customers.ToList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
