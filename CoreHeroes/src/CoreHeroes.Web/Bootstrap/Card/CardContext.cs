using Microsoft.AspNetCore.Html;

namespace CoreHeroes.Web.Bootstrap.Card
{
    public class CardContext
    {
        public IHtmlContent Block { get; set; }
        public IHtmlContent Header { get ; set; }
        public IHtmlContent ImageBottom { get; set; }
        public IHtmlContent ImageOverlay { get; set; }
        public IHtmlContent ImageTop { get; set; }
    }
}