using System;

namespace eCorp.WebStore.OrderService.Domain.Models
{
    [Serializable]
    public class ShippableProduct : BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
