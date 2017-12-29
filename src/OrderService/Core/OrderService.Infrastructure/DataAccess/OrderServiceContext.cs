using System;
using eCorp.WebStore.OrderService.Domain.Models;
using MongoDB.Driver;

namespace eCorp.WebStore.OrderService.Infrastructure.DataAccess
{
    public class OrderServiceContext
    {
        private readonly IMongoDatabase _database;

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
        
        public IMongoCollection<ShipmentOrder> ShipmentOrders => 
            _database.GetCollection<ShipmentOrder>("ShipmentOrders");
        
        public IMongoCollection<PurchaseOrder> PurchaseOrders => 
            _database.GetCollection<PurchaseOrder>("PurchaseOrders");

        public IMongoCollection<ServiceParameters> ServiceParameters =>
            _database.GetCollection<ServiceParameters>("ServiceParameters");
    }
}
