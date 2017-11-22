namespace eCorp.WebStore.OrderService.Domain.Models
{
    public class DeliveryAddress : BaseEntity
    {
        public string Salutation { get; set; }

        public string FullName { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }
    }
}
