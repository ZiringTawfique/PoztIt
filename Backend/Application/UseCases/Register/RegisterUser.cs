using System;
using Application.Repository;
using Domain.Model;

namespace Application.UseCases.Register
{
    public sealed class RegisterUser : IRegisterUser
    {
        IUserWriteOnlyRepository _userWriteOnlyRepository;

        public RegisterUser(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        // The application layer will also contain business rules regarding user registration

        public void Register(string username, string name, string initialAddress, int initialTeleNumber)
        {
            var user = new User(username, name, initialAddress, initialTeleNumber);

            _userWriteOnlyRepository.AddUser(user);


        }
    }
}
