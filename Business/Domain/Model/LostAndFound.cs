using System;
namespace Domain.Model
{
    public class LostAndFound : Post
    {
        public LostAndFound(User user) : base (user)
        {
        }
    }
}
