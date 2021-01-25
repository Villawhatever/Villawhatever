using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villawhatever.Shared.Models;
using Villawhatever.Shared.Services.Interfaces;

namespace Villawhatever.Pages
{
    public partial class Blog : DirtiableBase
    {
        [Inject]
        private IPostDataService PostService { get; set; }

        private ICollection<Post> Posts { get; set; }

        private const int MAX_POST_LENGTH = 200;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Posts = await PostService.GetPosts();
                await SetDirtyAsync();
            }
        }
    }
}
