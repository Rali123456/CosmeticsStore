using Moq;
using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.BL.Services;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.Models.DTO;
using Xunit;

namespace CosmeticsService.Tests
{
    public class CosmeticsBlServiceTests
    {
        private Mock<IProductService> _productServiceMock;
        private Mock<ICategoryRepository> _categoryRepositoryMock;

        public CosmeticsBlServiceTests()
        {
            _productServiceMock = new Mock<IProductService>();
            _categoryRepositoryMock = new Mock<ICategoryRepository>();
        }

        private List<Product> _products = new List<Product>
        {
            new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Moisturizing Cream",
                Description = "Hydrates and nourishes skin",
                Price = 25.99m,
                CategoryId = "1"
            },
            new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Foundation",
                Description = "Full coverage, long-lasting foundation",
                Price = 19.99m,
                CategoryId = "2"
            }
        };

        private List<Category> _categories = new List<Category>
        {
            new Category()
            {
                Id = "1",
                Name = "Skincare"
            },
            new Category()
            {
                Id = "2",
                Name = "Makeup"
            }
        };

        [Fact]
        public void GetDetailedProducts_Ok()
        {
            // Setup
            var expectedCount = 2;

            _productServiceMock
                .Setup(x => x.GetAllProducts())
                .Returns(_products);

            _categoryRepositoryMock.Setup(x =>
                    x.GetById(It.IsAny<string>()))
                .Returns((string id) =>
                    _categories.FirstOrDefault(x => x.Id == id));

            // Inject dependencies
            var cosmeticsBlService = new CosmeticsBlService(
                _productServiceMock.Object,
                _categoryRepositoryMock.Object);

            // Act
            var result = cosmeticsBlService.GetDetailedProducts();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count);
        }
    }
}

