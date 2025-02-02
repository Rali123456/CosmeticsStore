using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product? GetById(string id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}

