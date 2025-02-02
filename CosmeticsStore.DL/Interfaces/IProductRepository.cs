using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.DL.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product? GetProductById(string id);
        void UpdateProduct(Product product);
        void DeleteProduct(string id);
    }
}

