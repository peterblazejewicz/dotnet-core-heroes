using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreHeroes.Web.Bootstrap
{
    [HtmlTargetElement("alert")]
    public class AlertTagHelper : TagHelper
    {

        [HtmlAttributeName("message")]
        public string message { get; set; }

        [HtmlAttributeName("header")]
        public string header { get; set; }

        [HtmlAttributeName("icon")]
        public string icon { get; set; }

        [HtmlAttributeName("class")]
        public string cssClass { get; set; }

        [HtmlAttributeName("alert-class")]
        public string alertClass { get; set; }

        [HtmlAttributeName("message-as-html")]
        public bool messageAsHtml { get; set; }

        [HtmlAttributeName("header-as-html")]
        public bool headerAsHtml { get; set; }

        [HtmlAttributeName("dismissible")]
        public bool dismissible { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrEmpty(message) && string.IsNullOrEmpty(header))
                return;

            if (string.IsNullOrEmpty(icon))
                icon = "warning";
            else
                icon = icon.Trim();
            if (icon == "none")
                icon = "";

            // assume alertclass to match icon  by default
            // override it when icon and alert class are diff (ie. info, info-circle)
            if (string.IsNullOrEmpty(alertClass))
                alertClass = icon;

            if (icon == "info")
                icon = "info-circle";
            if (icon == "danger")
            {
                icon = "warning";
                if (string.IsNullOrEmpty(alertClass))
                    alertClass = "alert-danger";
            }
            if (icon == "success")
            {
                icon = "check";
                if (string.IsNullOrEmpty(alertClass))
                    alertClass = "success";
            }

            if (icon == "warning" || icon == "error" || icon == "danger")
                icon = icon + " text-danger"; // force to error color

            if (dismissible && !alertClass.Contains("alert-dismissible"))
                alertClass += " alert-dismissible";

            string messageText = !messageAsHtml ? System.Net.WebUtility.HtmlEncode(message) : message;
            string headerText = !headerAsHtml ? System.Net.WebUtility.HtmlEncode(header) : header;

            output.TagName = "div";

            // fix up CSS class            
            if (cssClass != null)
                cssClass = cssClass + " alert alert-" + alertClass;
            else
                cssClass = "alert alert-" + alertClass;
            output.Attributes.Add("class", cssClass);
            output.Attributes.Add("role", "alert");

            StringBuilder sb = new StringBuilder();

            if (dismissible)
                sb.Append(
@"<button type=""ton"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
    <span aria-hidden=""true"">&times;</span>
</button>");

            if (string.IsNullOrEmpty(header))
                sb.AppendLine($@"<i class=""fa fa-{icon}""></i> {messageText}");
            else
            {
                sb.Append(
$@"<h3><i class=""fa fa-{icon}""></i> {headerText}</h3>
<hr/>
{messageText}");
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
