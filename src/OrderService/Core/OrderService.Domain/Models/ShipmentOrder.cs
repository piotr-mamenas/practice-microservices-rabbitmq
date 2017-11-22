using System;
using System.Collections.Generic;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    [Serializable]
    public class ShipmentOrder : Order
    {
        public ShippingAddress Address { get; set; }

        public ICollection<ShippableProduct> Products { get; set; }
    }
}
