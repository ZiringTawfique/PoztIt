using System;
namespace Domain.Model
{
    public class User
    {
        public string Username { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public int TeleNumber { get; private set; }

        public User(string username, string name, string address, int teleNumber)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new DomainException("Username of user must be specified");
            }

            Username = username;
            Name = name;
            Address = address;
            TeleNumber = teleNumber;
        }

    }
}
