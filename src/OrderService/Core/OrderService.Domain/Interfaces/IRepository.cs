using System;
using System.Threading.Tasks;
using eCorp.WebStore.OrderService.Domain.Models;

namespace eCorp.WebStore.OrderService.Domain.Interfaces
{
    public interface IRepository<T> 
    {
        Task<Order> GetAsync(Guid id);
        Task AddAsync(T order);
    }
}