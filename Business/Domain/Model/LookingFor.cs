using System;
namespace Domain.Model
{
	public class LookingFor : Post
    {
        public LookingFor(User user) : base(user)
        {
        }
    }
}
