using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Web.Bootstrap.Card
{
    [HtmlTargetElement("card-block", ParentTag = "card")]
    public class CardBlockTagHelper: TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            var cardContext = (CardContext)context.Items[typeof(CardTagHelper)];
            cardContext.Block = childContent;
            output.SuppressOutput();
        }

    }
}