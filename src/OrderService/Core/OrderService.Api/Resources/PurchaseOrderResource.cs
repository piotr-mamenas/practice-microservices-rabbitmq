using System;
using eCorp.WebStore.OrderService.Domain.Enums;

namespace eCorp.WebStore.OrderService.Api.Resources
{
    [Serializable]
    public class PurchaseOrderResource
    {
        public Guid Id { get; set; }

        public string Number { get; set; }
        
        public DateTime PlacedTimestamp { get; set; }
        
        public OrderStatus Status { get; set; }
        
        public decimal PaymentAmount { get; set; }

        public string CurrencyCode { get; set; }

        public int PaymentDaysTerms { get; set; }

        public bool IsPaid { get; set; }
    }
}
