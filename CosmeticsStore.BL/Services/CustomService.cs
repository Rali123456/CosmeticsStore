using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customer? GetById(string id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }
}
