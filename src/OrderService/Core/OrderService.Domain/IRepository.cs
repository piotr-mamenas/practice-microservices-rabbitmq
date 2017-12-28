using System;
using System.Threading.Tasks;

namespace eCorp.WebStore.OrderService.Domain
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(Guid id);
        Task AddAsync(T order);
    }
}