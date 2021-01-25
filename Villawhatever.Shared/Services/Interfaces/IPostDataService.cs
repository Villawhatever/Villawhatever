using System.Collections.Generic;
using System.Threading.Tasks;
using Villawhatever.Shared.Models;

namespace Villawhatever.Shared.Services.Interfaces
{
    public interface IPostDataService
    {
        public Task<List<Post>> GetPosts();
        public Task<Post> GetPost(string slug);

        public Task UpdatePost(Post post);
        
    }
}
