using System;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.Repository
{
    public interface IUserReadOnlyRepository
    {
        Task<User> GetUser(string username);
    }
}
