using Markdig;
using Microsoft.AspNetCore.Components;

namespace Villawhatever.Shared
{
    public partial class MarkdownView : ComponentBase
    {
        [Parameter]
        public string Content { get; set; }

        private MarkupString MarkedUpContent;

        protected override void OnParametersSet()
        {
            MarkedUpContent = ConvertToMarkup(Content);
        }

        private MarkupString ConvertToMarkup(string value)
        {
            return new MarkupString(Markdown.ToHtml(value, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()));
        }
    }
}