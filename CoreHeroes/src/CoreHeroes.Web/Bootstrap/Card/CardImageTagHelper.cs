using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Web.Bootstrap.Card
{
    [HtmlTargetElement("card-image", ParentTag = "card")]
    public class CardImageTagHelper : TagHelper
    {
        public CardImageType Type { get; set; }

        // output.Attributes.Add("class", $"panel panel-{Type.ToString().ToLower()}");

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            var cardContext = (CardContext)context.Items[typeof(CardTagHelper)];
            switch(Type) {
                case CardImageType.Bottom:
                    cardContext.ImageBottom = childContent;
                    break;
                case CardImageType.Overlay:
                    cardContext.ImageOverlay = childContent;
                    break;
                case CardImageType.Top:
                default:
                    cardContext.ImageTop = childContent;
                    break;
            }
            output.SuppressOutput();
        }

        public void InternalProcess(TagHelperContext context, TagHelperOutput output)
        {
                var img = new TagBuilder("img");
                img.AddCssClass($"car-image-{Type.ToString().ToLower()}");
                output.Content.AppendHtml(img);
        }
    }
}