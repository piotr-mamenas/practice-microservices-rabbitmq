using System;
using MongoDB.Bson.Serialization.Attributes;

namespace eCorp.WebStore.OrderService.Domain
{
    public abstract class BaseEntity
    {
        [BsonId]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime UpdatedOn { get; set; }

        public string Version { get; set; }
    }
}
