using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Villawhatever.Shared.Models;
using Villawhatever.Shared.Services.Interfaces;

namespace Villawhatever.Pages
{
    public partial class FullPost : DirtiableBase
    {
        [Parameter]
        public string Slug { get; set; }

        [Inject] 
        public IPostDataService PostService { get; set; }

        private Post post;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                post = await PostService.GetPost(Slug);
                await SetDirtyAsync();
            }
        }
    }
}
