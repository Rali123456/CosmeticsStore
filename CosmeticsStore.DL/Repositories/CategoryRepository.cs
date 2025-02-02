using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.Models.Configurations;
using CosmeticsStore.Models.DTO;
using System;
using System.Collections.Generic;

namespace CosmeticsStore.DL.Repositories.MongoRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMongoCollection<Category> _categories;
        private readonly ILogger<CategoryRepository> _logger;

        public CategoryRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<CategoryRepository> logger)
        {
            _logger = logger;
            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.DatabaseName);
            _categories = database.GetCollection<Category>($"{nameof(Category)}s");
        }

        public void AddCategory(Category category)
        {
            category.Id = Guid.NewGuid().ToString();
            _categories.InsertOne(category);
        }

        public Category? GetCategoryById(string id)
        {
            return _categories.Find(c => c.Id == id).FirstOrDefault();
        }

        public List<Category> GetAllCategories()
        {
            return _categories.Find(category => true).ToList();
        }
    }
}
