using System;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Model;

namespace Application.UseCases.Register
{
    public sealed class RegisterUser : IRegisterUser
    {
        IUserWriteOnlyRepository _userWriteOnlyRepository;
        readonly IUserReadOnlyRepository _userReadOnlyRepository;

        public RegisterUser(IUserWriteOnlyRepository userWriteOnlyRepository,
                            IUserReadOnlyRepository userReadOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
            _userReadOnlyRepository = userReadOnlyRepository;
        }

        public Task<User> GetUser(string username) => _userReadOnlyRepository.GetUser(username);
        public void DeleteUser(string username) => _userWriteOnlyRepository.DeleteUser(username);

        public void Register(string username, string name, string initialAddress, int initialTeleNumber)
        {
            var user = new User(username, name, initialAddress, initialTeleNumber);
            _userWriteOnlyRepository.AddUser(user);
        }

        public void UpdateUser(string username, string name, string address, int teleNumber)
        {
            var user = new User(username, name, address, teleNumber);
            _userWriteOnlyRepository.UpdateUser(user);
        }
    }
}
