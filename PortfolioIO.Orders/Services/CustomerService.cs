using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioIO.Orders.Models;

namespace PortfolioIO.Orders.Services
{
    public class CustomerService : ICustomerService
    {
        private IList<Customer> _customer;

        public CustomerService()
        {
            // for the sake of time 
            _customer = new List<Customer>();
            _customer.Add(new Customer(1, "Customer 1"));
            _customer.Add(new Customer(2, "Customer 2"));
            _customer.Add(new Customer(3, "Customer 3"));
            _customer.Add(new Customer(4, "Customer 4"));
            _customer.Add(new Customer(5, "Customer 5"));
        }

        public Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return Task.FromResult(_customer.AsEnumerable());
        }

        public Customer GetCustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customer.Single(o => Equals(o.Id, id)));
        }
    }

    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustomerAsync();
    }
}
