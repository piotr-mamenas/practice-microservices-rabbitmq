using System;
using eCorp.WebStore.OrderService.Domain.Enums;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    /// <summary>
    /// The base order object holding common properties for different order types
    /// </summary>
    public abstract class Order : BaseEntity
    {
        /// <summary>
        /// The computed number of the order
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The time at which the order was placed which can be different 
        /// than the time at which an order was created
        /// </summary>
        public DateTime PlacedTimestamp { get; set; }

        /// <summary>
        /// The processing status of the order
        /// </summary>
        public OrderStatus Status { get; set; }
    }
}
