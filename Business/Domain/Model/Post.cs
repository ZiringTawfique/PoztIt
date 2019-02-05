using System;
namespace Domain.Model
{
    public class Post
    {
		public int PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; private set; }

        public User User { get; private set; }

        public bool IsUrgent { get; set; }

        public double Price { get; set; }


        public Post(User user)
        {
            User = user;
            DateAdded = DateTime.Now;

        }

    }
}
