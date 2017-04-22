using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Bootstrap
{
    [HtmlTargetElement("card-block", ParentTag = "card")]
    public class CardBlockTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "card-block");
        }

    }
}