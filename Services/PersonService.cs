using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoPets.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace MongoPets.Services
{
	public class PersonService
	{
		private IMongoCollection<Person> _people;
		private readonly string connectionString = "mongodb://localhost:27017/;";
		private readonly string DatabaseName = "MongoPets";
		private string collection { get; set; } = "Persons";

		public PersonService()
		{
			var client = new MongoClient(connectionString);
			var database = client.GetDatabase(DatabaseName);
			_people = database.GetCollection<Person>(collection);
		}

		public List<Person> GetAllPeople()
		{
			var query = from p in _people.AsQueryable() 
						select p;
			Console.WriteLine("people found: " + query.ToList().Count);
			return query.ToList();
		}

		public Person GetPerson(string id)
		{
			return _people.Find(p  => p.Id == id).FirstOrDefault();
		}

		public Person CreatePerson(Person person)
		{
			_people.InsertOne(person);
			return person;
		}

		public void UpdatePerson(string id, Person person) 
		{
			_people.ReplaceOne(p => p.Id == id, person);
		}

		public void DeletePerson(string id) 
		{
			_people.DeleteOne(p => p.Id == id);
		}
	}
}
