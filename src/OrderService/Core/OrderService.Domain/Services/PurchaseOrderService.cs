using System;
using System.Collections.Generic;
using eCorp.WebStore.OrderService.Domain.Enums;
using eCorp.WebStore.OrderService.Domain.Models;

namespace eCorp.WebStore.OrderService.Domain.Services
{
    public class PurchaseOrderService
    {
        public IDictionary<string,string> PlacePurchase(PurchaseOrder order)
        {
            IDictionary<string,string> errors = new Dictionary<string,string>();

            if (order.CurrencyCode != "CHF")
            {
                errors.Add(new KeyValuePair<string,string>{ });
            }

            if (order.Status != OrderStatus.Initial)
            {
                errors.Add(new KeyValuePair<string, string> { });
            }

            if (order.IsPaid)
            {
                errors.Add(new KeyValuePair<string, string> { });
            }

            if (order.PaymentAmount <= 0)
            {
                errors.Add(new KeyValuePair<string, string> { });
            }
            return errors;
        }

        public decimal CalculateAmount(string fromCurrency, decimal previousAmount, DateTime placedOn)
        {
            return 0;
        }
    }
}
