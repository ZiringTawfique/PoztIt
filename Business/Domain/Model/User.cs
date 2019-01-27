using System;
namespace Domain.Model
{
    public class User
    {
        public User()
        {
        }

		public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TeleNumber { get; set; }
    }
}
