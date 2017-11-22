using System;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    [Serializable]
    public class PurchaseOrder : Order
    {
        public decimal PaymentAmount { get; set; }

        public int PaymentDaysTerms { get; set; }

        public bool IsPaid { get; set; }
    }
}
