using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.DL.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer? GetCustomerById(string id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(string id);
    }
}

