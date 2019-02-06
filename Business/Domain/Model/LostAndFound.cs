using System;
namespace Domain.Model
{
    public class LostAndFound : Post
    {
        public LostAndFound(SharedModel.User user) : base (user)
        {
        }
    }
}
