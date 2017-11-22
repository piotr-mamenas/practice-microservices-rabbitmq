using System;
using System.Collections.Generic;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    [Serializable]
    public class DeliveryOrder : Order
    {
        public DeliveryAddress Address { get; set; }

        public ICollection<ShippableProduct> Products { get; set; }
    }
}
