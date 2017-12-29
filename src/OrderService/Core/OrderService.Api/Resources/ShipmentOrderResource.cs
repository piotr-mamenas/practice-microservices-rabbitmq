using System;
using System.Collections.Generic;
using eCorp.WebStore.OrderService.Domain.Enums;
using eCorp.WebStore.OrderService.Domain.Models;

namespace eCorp.WebStore.OrderService.Api.Resources
{
    public class ShipmentOrderResource
    {
        public Guid Id { get; set; }

        public string Number { get; set; }

        public DateTime PlacedTimestamp { get; set; }

        public OrderStatus Status { get; set; }

        public ShippingAddress Address { get; set; }

        public ICollection<ShippableProduct> Products { get; set; }
    }
}
