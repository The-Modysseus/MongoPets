using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoPets.Models
{
	[BsonIgnoreExtraElements]
	public class Person
	{
		
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		[BsonElement("Name")]
		public string Name { get; set; } = "";
		[BsonElement("Adress")]
		public string Adress { get; set; } = "";
		[BsonElement("Owns")]
		public List<string> Owns { get; set; } = new List<string>();
	}
}
