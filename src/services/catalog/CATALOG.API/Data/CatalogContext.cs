using CATALOG.API.Entities;
using MongoDB.Driver;
using System.Drawing;

namespace CATALOG.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));


            CatalogConextSeed.SeedData(Products);

        }
        public IMongoCollection<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
