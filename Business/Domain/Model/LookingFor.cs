using System;
namespace Domain.Model
{
	public class LookingFor : Post
    {
        public LookingFor(SharedModel.User user) : base(user)
        {
        }
    }
}
