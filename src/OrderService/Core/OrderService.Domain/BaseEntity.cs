using System;

namespace eCorp.WebStore.OrderService.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public string Version { get; set; }
    }
}
