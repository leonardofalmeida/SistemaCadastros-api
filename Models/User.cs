using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace UsersApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nome")]
        public string Nome { get; set; }

        [BsonElement("Cpf")]
        public string Cpf { get; set; }

        [BsonElement("Nascimento")]
        public DateTime Nascimento { get; set; }

        [BsonElement("Peso")]
        public double Peso { get; set; }

        [BsonElement("Uf")]
        public string Uf { get; set; }
    }
}