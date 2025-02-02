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
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _products;
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<ProductRepository> logger)
        {
            _logger = logger;
            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.DatabaseName);
            _products = database.GetCollection<Product>($"{nameof(Product)}s");
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                _logger.LogError("Product is null");
                return;
            }

            try
            {
                product.Id = Guid.NewGuid().ToStrin
