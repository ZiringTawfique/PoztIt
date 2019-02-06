using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.UseCases.PostUseCase
{
    public class PostCRUD : IPostCRUD
    {
        public PostCRUD()
        {
        }

        public void CreatePost()
        {
            throw new NotImplementedException();
        }

        public void DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
