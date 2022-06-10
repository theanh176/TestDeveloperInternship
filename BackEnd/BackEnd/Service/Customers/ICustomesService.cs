using BackEnd.Models;

namespace BackEnd.Service.Customers
{
    public interface ICustomesService
    {
        List<Customer> GetCustomers();
        Boolean AddCustomer(Customer customer);
        Boolean UpdateCustomer(Customer customer);
        Boolean DeleteCustomer(Customer customer);
    }
}
