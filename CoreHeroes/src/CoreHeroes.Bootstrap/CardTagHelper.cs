using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Bootstrap
{
    [HtmlTargetElement("card")]
    [RestrictChildren("card-header", "card-block")]
    public class CardTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var cardContext = new CardContext();
            context.Items.Add(typeof(CardTagHelper), cardContext);
            await output.GetChildContentAsync();
            output.TagName = "div";
            output.Attributes.Add("class", "card");
            
            if(cardContext.Header != null) {
                var header = new TagBuilder("h3");
                header.AddCssClass("card-header");
                header.InnerHtml.AppendHtml(cardContext.Header);
                output.Content.AppendHtml(header);
            }
            if (cardContext.Block != null)
            {
                var block = new TagBuilder("div");
                block.AddCssClass("card-block");
                block.InnerHtml.AppendHtml(cardContext.Block);
                output.Content.AppendHtml(block);
            }
        }
    }
}