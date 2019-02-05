using System;
namespace Domain.Model
{
    public class Recommendation : Post
    {
        public string Location { get; set; }

        public Recommendation(User user) : base (user)
        {
        }
    }
}
