using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        void AddProduct(Product product);

        Product? GetById(string id);
    }
}
