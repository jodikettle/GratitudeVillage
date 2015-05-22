using System.Collections.Generic;
using System.Linq;
using GratitudeVillage.Repository.Models;
using MongoDB.Driver;

namespace GratitudeVillage.Repository
{
    public class GratitudeRepository: IGratitudeRepository
    {
        private MongoDatabase database; 

        public GratitudeRepository()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            database = server.GetDatabase("local");
        }

        public List<Gratitude> GetTop(int count)
        {
            var collection = database.GetCollection<Gratitude>("Gratitude").FindAll().Take(count);
            return collection.ToList();
        }
    }
}
