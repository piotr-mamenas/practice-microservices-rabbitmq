using System;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    public abstract class Order : BaseEntity
    {
        public string Number { get; set; }

        public DateTime PlacedTimestamp { get; set; }
    }
}
