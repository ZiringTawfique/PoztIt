using System;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.UseCases.Register
{
    public interface IRegisterUser
    {
        void Register(string username, string name, string initialAddress, 
            int initialTeleNumber);

        Task<User> GetUser(string username);

        void DeleteUser(string username);

        void UpdateUser(string username, string name, string address, int teleNumber);
    }
}
