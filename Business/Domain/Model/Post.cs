using System;
namespace Domain.Model
{
    public class Post
    {
		public int PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; private set; }

        public SharedModel.User User { get; set; }

        public bool IsUrgent { get; set; }

        public double Price { get; set; }


        public Post(SharedModel.User user)
        {
            User = user;
            DateAdded = DateTime.Now;

        }

    }
}
