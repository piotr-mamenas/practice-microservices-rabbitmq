using System;
using System.Threading.Tasks;
using eCorp.WebStore.OrderService.Domain.Interfaces;
using eCorp.WebStore.OrderService.Domain.Models;
using MongoDB.Driver;

namespace eCorp.WebStore.OrderService.Infrastructure.DataAccess
{
    public class ShipmentOrderRepository : IShipmentOrderRepository
    {
        private readonly OrderServiceContext _context;

        public ShipmentOrderRepository(OrderServiceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a single Order from the repository
        /// </summary>
        /// <param name="id">The id of the order to be fetched from the repository</param>
        /// <returns></returns>
        public async Task<ShipmentOrder> GetAsync(Guid id)
        {
            return await _context.ShipmentOrders.Find(o => o.Id == id).SingleOrDefaultAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order">The order to be inserted</param>
        /// <returns></returns>
        public async Task AddAsync(ShipmentOrder order)
        {
            await _context.ShipmentOrders.InsertOneAsync(order);
        }
    }
}
