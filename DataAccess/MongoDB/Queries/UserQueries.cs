using System;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Model;
using Microsoft.Extensions.Options;


namespace MongoDB.Queries
{
    public class UserQueries : IUserReadOnlyRepository, IUserWriteOnlyRepository
    {
        private readonly Context _context;

        public UserQueries(IOptions<MongoDBSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task AddUser(User user)
        {
            DataEntities.User userEntity = new DataEntities.User
            {
                 Username = user.Username,
                 Name = user.Name,
                 Address = user.Address,
                 TeleNumber = user.TeleNumber
            };

            await _context.UsersCollection.InsertOneAsync(userEntity);
           
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
