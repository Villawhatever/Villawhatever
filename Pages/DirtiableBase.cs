using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Villawhatever.Pages
{
    public abstract class DirtiableBase : ComponentBase
    {
        private bool isDirty;

        protected override bool ShouldRender() => isDirty;
        protected override void OnAfterRender(bool firstRender)
        {
            isDirty = false;
        }

        protected void SetDirty()
        {
            isDirty = true;
            StateHasChanged();
        }

        protected async Task SetDirtyAsync()
        {
            isDirty = true;
            await InvokeAsync(StateHasChanged);
        }
    }
}
