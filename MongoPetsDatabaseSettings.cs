using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoPets
{
	public class MongoPetsDatabaseSettings
	{
		public string ConnectionString { get; set; } = "mongodb://localhost:27017/;";

		public string DatabaseName { get; set; } = "MongoPets";

		public string PersonsCollectionName { get; set; } = "Persons";
		public string PetsCollectionName { get; set; } = "Pets";
	}
}
