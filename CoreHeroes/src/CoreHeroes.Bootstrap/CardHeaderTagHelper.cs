using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Bootstrap
{
    [HtmlTargetElement("card-header", ParentTag = "card")]
    public class CardHeaderTagHelper: TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            var cardContext = (CardContext)context.Items[typeof(CardTagHelper)];
            cardContext.Header = childContent;
            output.SuppressOutput();
        }
    }
}