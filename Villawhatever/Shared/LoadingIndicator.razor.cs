using Microsoft.AspNetCore.Components;

namespace Villawhatever.Shared
{
    public partial class LoadingIndicator : ComponentBase
    {
        [Parameter]
        public object NullCheckObject { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
