using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Reader.Repository
{

    [BsonIgnoreExtraElements]
    public class ObjetDepartment
    {
        [BsonId]        
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Departement")]
        public string Code_Postale { get; set; }
        public string DepartmentsNom { get; set; }
        public int Population { get; set; }
    }

}

// rajouter les coordonnées gps