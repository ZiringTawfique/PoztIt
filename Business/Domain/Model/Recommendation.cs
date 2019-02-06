using System;
namespace Domain.Model
{
    public class Recommendation : Post
    {
        public string Location { get; set; }

        public Recommendation(SharedModel.User user) : base (user)
        {
        }
    }
}
