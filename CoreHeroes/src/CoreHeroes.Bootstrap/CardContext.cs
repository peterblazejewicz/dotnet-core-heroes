using Microsoft.AspNetCore.Html;

namespace CoreHeroes.Bootstrap
{
    public class CardContext
    {
        public IHtmlContent Block { get; set; }
        public IHtmlContent Header { get ; set; }
    }
}