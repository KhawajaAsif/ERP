using BASKET.API.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace BASKET.API.Repositories
{
    public class BaketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BaketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public Task<ShoppingCart> GetBasket(string userName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBasket(string userName)
        {
            throw new NotImplementedException();
        }

       

        public Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            throw new NotImplementedException();
        }
    }
}
