namespace DariaApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("userName")]
        public string UserName { get; set; }

        [BsonElement("entityId")]
        public string EntityId { get; set; }
    }
}