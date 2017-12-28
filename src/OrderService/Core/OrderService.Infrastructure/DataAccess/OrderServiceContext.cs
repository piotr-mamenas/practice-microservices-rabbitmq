using System;
using eCorp.WebStore.OrderService.Domain.Models;
using MongoDB.Driver;

namespace eCorp.WebStore.OrderService.Infrastructure.DataAccess
{
    public class OrderServiceContext
    {
        private readonly IMongoDatabase _database = null;

        /// <summary>
        /// The constructor of the primary service context
        /// </summary>
        public OrderServiceContext()
        {
            var settings = new ConnectionSettings
            {
                ConnectionString = "mongodb://localhost",
                Database = "OrderService"
            };

            if (string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrWhiteSpace(settings.Database))
            {
                throw new ArgumentNullException();
            }

            MongoDefaults.GuidRepresentation = MongoDB.Bson.GuidRepresentation.Standard;
            var client = new MongoClient(settings.ConnectionString);

            _database = client.GetDatabase(settings.Database);
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
