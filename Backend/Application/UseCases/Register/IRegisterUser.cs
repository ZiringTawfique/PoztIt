using System;
namespace Application.UseCases.Register
{
    public interface IRegisterUser
    {
        void Register(string username, string name, string initialAddress, 
            int initialTeleNumber);
    }
}
