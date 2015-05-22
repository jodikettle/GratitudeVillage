using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GratitudeVillage.Repository.Models
{
    public class Gratitude
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string Message { get; set; }
    }
}
