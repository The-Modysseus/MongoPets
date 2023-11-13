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
	public class Pet
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public int Id { get; set; }

		[BsonElement("Name")]
		public string Name { get; set; } = "";
		[BsonElement("Years")]
		public int Years { get; set; } = 0;
		[BsonElement("Race")]
		public string Race { get; set; } = "";
		[BsonElement("Weight")]
		public double Weight { get; set; } = 0.0;
		[BsonElement("Owner")]
		public string Owner { get; set; } = "";
	}
}
