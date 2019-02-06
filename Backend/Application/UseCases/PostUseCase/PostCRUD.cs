using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Model;

namespace Application.UseCases.PostUseCase
{
    public class PostCRUD : IPostCRUD
    {
        private IPostReadOnlyRepository _postReadOnly;
        private IPostWriteOnlyRepository _postWriteOnly;

        public PostCRUD(IPostReadOnlyRepository postReadOnly, IPostWriteOnlyRepository postWriteOnly)
        {
            _postReadOnly = postReadOnly;
            _postWriteOnly = postWriteOnly;
        }

        public void CreatePost(string title, double price, string location,
                               string freeText, Domain.SharedModel.User user )
        {
            var post = new Post(user);
            _postWriteOnly.CreatePost(post);
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
