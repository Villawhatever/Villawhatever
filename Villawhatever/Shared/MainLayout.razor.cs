using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using MudBlazor;
using Villawhatever.Resources;

namespace Villawhatever.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        private IOptions<ColorConfig> ColorOptions { get; set; }
        private readonly MudTheme darkTheme = new MudTheme();

        protected override void OnParametersSet()
        {
            darkTheme.Palette = ColorOptions.Value.GetPalette();
        }
    }
}
