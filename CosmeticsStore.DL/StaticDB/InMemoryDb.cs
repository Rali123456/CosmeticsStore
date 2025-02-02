using CosmeticsStore.Models.DTO;
using System.Collections.Generic;

namespace CosmeticsStore.DL.StaticDB
{
    internal static class InMemoryDb
    {
        internal static List<Category> Categories = new List<Category>
        {
            new Category { Id = "1", Name = "Skincare" },
            new Category { Id = "2", Name = "Makeup" },
            new Category { Id = "3", Name = "Haircare" },
            new Category { Id = "4", Name = "Fragrance" }
        };

        internal static List<Product> Products = new List<Product>
        {
            new Product { Id = "1", Name = "Moisturizing Cream", Description = "Hydrates and nourishes skin", Price = 25.99m, CategoryId = "1" },
            new Product { Id = "2", Name = "Foundation", Description = "Full coverage, long-lasting foundation", Price = 19.99m, CategoryId = "2" },
            new Product { Id = "3", Name = "Shampoo", Description = "Strengthening shampoo for all hair types", Price = 12.99m, CategoryId = "3" },
            new Product { Id = "4", Name = "Perfume", Description = "Long-lasting floral fragrance", Price = 45.00m, CategoryId = "4" }
        };

        internal static List<Customer> Customers = new List<Customer>
        {
            new Customer { Id = "1", Name = "Alice Johnson", Email = "alice@example.com" },
            new Customer { Id = "2", Name = "Bob Smith", Email = "bob@example.com" },
            new Customer { Id = "3", Name = "Emma Davis", Email = "emma@example.com" }
        };
    }
}
