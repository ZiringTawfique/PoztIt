using System;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

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

            try
            {
                await _context.UsersCollection.InsertOneAsync(userEntity);
            }

            catch(MongoException ex) 
            {
                throw ex;
            }

           
        }

        public async Task DeleteUser(string username)
        {
            try
            {
                var builder = Builders<DataEntities.User>.Filter;
                var filter = builder.Eq(x => x.Username, username);
                var deleteUser = await _context.UsersCollection.DeleteOneAsync(filter);
                var IsDeleted = deleteUser.IsAcknowledged && deleteUser.DeletedCount > 0;
                if (!IsDeleted) { throw new ArgumentException("Invalid user, cannot delete user information"); }
            }
            catch (MongoException ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<User> GetUser(string username)
        {
            var filter = Builders<DataEntities.User>.Filter.Eq(x => x.Username, username);

            try
            {
                var user = await _context.UsersCollection.Find(filter).FirstOrDefaultAsync();
                var ans = (user != null) ? new User(user.Username, user.Name, user.Address, user.TeleNumber) : null;
                return ans;
            }
            catch (MongoException ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task UpdateUser(User user)
        {
            DataEntities.User userEntity = new DataEntities.User
            {
                Username = user.Username,
                Name = user.Name,
                Address = user.Address,
                TeleNumber = user.TeleNumber
            };

            try { 
                var filter = Builders<DataEntities.User>.Filter.Eq(x => x.Username, userEntity.Username);
                var result = await _context.UsersCollection.ReplaceOneAsync(filter, userEntity);

                var IsUpdated = result.IsAcknowledged && result.ModifiedCount > 0;
                if(!IsUpdated) { throw new ArgumentException("Invalid user, cannot update user information"); }
            } 

            catch(Exception ex) {
                throw ex;
            
            }

        }
    }
}
