using System;
using System.Collections.Generic;
using System.Threading;

namespace Villawhatever.Pages
{
    public partial class About : DirtiableBase, IDisposable
    {
        private readonly List<string> stuffToDo = new List<string> { "computer", "Magic", "cool", "API", "nerd" };
        private Timer stuffTimer;
        private string randomThing;
        private string textClass;

        public void Dispose()
        {
            stuffTimer?.Dispose();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                stuffTimer = new Timer(GetNewThing, null, 0, 10000);
            }
        }

        private async void GetNewThing(object _)
        {
            textClass = "fade-out";
            await SetDirtyAsync();
            Thread.Sleep(200);

            GetRandomThing();
            
            textClass = "fade-in";
            await SetDirtyAsync();
        }

        private void GetRandomThing()
        {
            var random = new Random();
            var randomIndex = random.Next(stuffToDo.Count);
            randomThing = stuffToDo[randomIndex];
        }
    }
}
