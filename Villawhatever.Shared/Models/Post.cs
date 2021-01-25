using System;
using System.Collections.Generic;

namespace Villawhatever.Shared.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public DateTime DatePosted { get; set; }
        public string Content { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
}
