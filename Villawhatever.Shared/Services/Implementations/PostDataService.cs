using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villawhatever.Shared.Models;
using Villawhatever.Shared.Services.Interfaces;

namespace Villawhatever.Shared.Services.Implementations
{
    public class PostDataService : IPostDataService
    {
        private readonly BlogDbContext _context;

        public PostDataService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Post> GetPost(string slug)
        {
            var post = await _context.Posts.SingleOrDefaultAsync(p => p.Slug == slug);
            return post;
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _context.Set<Post>().ToListAsync();
        }

        public async Task UpdatePost(Post post)
        {
            _context.Update(post);
            await _context.SaveChangesAsync();
        }
    }
}
