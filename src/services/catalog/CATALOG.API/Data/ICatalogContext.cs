using CATALOG.API.Entities;
using MongoDB.Driver;

namespace CATALOG.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
