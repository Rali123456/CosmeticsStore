using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);

        List<Customer> GetAllCustomers();

        Customer? GetById(string id);
    }
}

