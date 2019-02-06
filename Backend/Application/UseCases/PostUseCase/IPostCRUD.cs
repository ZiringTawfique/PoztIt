using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.UseCases.PostUseCase
{
    public interface IPostCRUD
    {
        void CreatePost(string title, double price, string location,
                               string freeTextt, Domain.SharedModel.User user);
        Task<Post> GetPost(int postId);
        Task<IReadOnlyCollection<Post>> GetPosts();
        void UpdatePost(Post post);
        void DeletePost(int postId);

    }
}
