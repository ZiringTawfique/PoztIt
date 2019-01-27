using System;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoDB.DataEntities
{
    public class User
    {
        [BsonId]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TeleNumber { get; set; }
    }
}
