using System;
using System.Threading.Tasks;
using eCorp.WebStore.OrderService.Domain.Interfaces;
using eCorp.WebStore.OrderService.Domain.Models;
using MongoDB.Driver;

namespace eCorp.WebStore.OrderService.Infrastructure.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderServiceContext _context;

        public OrderRepository(OrderServiceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a single Order from the repository
        /// </summary>
        /// <param name="id">The id of the order to be fetched from the repository</param>
        /// <returns></returns>
        public async Task<Order> GetAsync(Guid id)
        {
            return await _context.Orders.Find(o => o.Id == id).SingleOrDefaultAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order">The order to be inserted</param>
        /// <returns></returns>
        public async Task AddAsync(Order order)
        {
            await _context.Orders.InsertOneAsync(order);
        }
    }
}
