using System;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    public abstract class Order 
    {
        public string Number { get; set; }

        public DateTime PlacedTimestamp { get; set; }
    }
}
