using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Villawhatever.Shared.Models;

namespace Villawhatever.Shared.ModelConfiguration
{
    class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(postTag => new { postTag.PostId, postTag.TagId });

            builder.HasOne(x => x.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            builder.HasOne(x => x.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(PostTag => PostTag.TagId);
        }
    }
}
