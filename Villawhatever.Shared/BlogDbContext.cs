using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Villawhatever.Shared.Models;

namespace Villawhatever.Shared
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(BlogDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var newEntries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added);

            foreach (EntityEntry entry in newEntries)
            {
                (entry.Entity as Post).DatePosted = DateTime.Now;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
