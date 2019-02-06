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

            catch(Exception ex) 
            {
                throw ex;
            }

           
        }

        public async Task<bool> DeleteUser(string username)
        {
            try
            {
                var builder = Builders<DataEntities.User>.Filter;
                var filter = builder.Eq(x => x.Username, username);
                var deleteUser = await _context.UsersCollection.DeleteOneAsync(filter);

                return deleteUser.IsAcknowledged && deleteUser.DeletedCount > 0;
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
