using eCorp.WebStore.OrderService.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace eCorp.WebStore.OrderService.DAL
{
    public class OrderServiceContext
    {
        private readonly IMongoDatabase _database = null;

        /// <summary>
        /// The constructor of the primary service context
        /// </summary>
        /// <param name="settings">Contains the database connection settings</param>
        public OrderServiceContext(IOptions<ConnectionSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);

            _database = client.GetDatabase(settings.Value.Database);
        }

        /// <summary>
        /// The collection of persisted orders
        /// </summary>
        public IMongoCollection<Order> Orders
        {
            get
            {
                return _database.GetCollection<Order>("Orders");
            }
        }
    }
}
