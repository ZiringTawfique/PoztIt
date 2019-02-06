using System;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.Repository
{
    public interface IPostWriteOnlyRepository
    {
        Task CreatePost(Post post);
        Task DeletePost(int postId);
        Task UpdatePost(Post post);
    }
}
