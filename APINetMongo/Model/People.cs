using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APINetMongo
{
    [BsonIgnoreExtraElements]
    public class People
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("graduate")]
        public bool IsGraduate { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;

        [BsonElement("age")]
        public int Age { get; set; }
    }

}