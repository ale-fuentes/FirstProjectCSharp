using APINetMongo.Models;
using MongoDB.Driver;


namespace APINetMongo.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IMongoCollection<People> _students;

        public PeopleService(IPeopleStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DataBaseName);
            _students = database.GetCollection<People>(settings.LabNetCollection);
        }

        public People Create(People people)
        {
            _students.InsertOne(people);
            return people;
        }

        public List<People> Get()
        {
            return _students.Find(people => true).ToList();
        }

        public People Get(string id)
        {
            return _students.Find(people => people.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _students.DeleteOne(people => people.Id == id);
        }

        public void Update(string id, People people)
        {
            _students.ReplaceOne(people => people.Id == id, people);
        }
    }
}