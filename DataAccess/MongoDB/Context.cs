using System;
using MongoDB.DataEntities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MongoDB
{
    public class Context
    {
        private readonly IMongoDatabase _database = null;
        public Context(IOptions<MongoDBSettings> settings)
        {
            try
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                if (client != null)
                    _database = client.GetDatabase(settings.Value.Database);

            }
            catch (Exception exception)
            {
                throw new Exception("Can not access database.", exception);
            }
           
         
        }

        public IMongoCollection<Post> PostCollection
        {
            get
            {
                return _database.GetCollection<Post>("Post");
            }
        }

        public IMongoCollection<Users> UsersCollection
        {
            get
            {
                return _database.GetCollection<Users>("Users");
            }
        }
     }

}
