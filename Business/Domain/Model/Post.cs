using System;
namespace Domain.Model
{
    public class Post
    {
		public int PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public User User { get; set; }

        public bool IsUrgent { get; set; }

    }
}
