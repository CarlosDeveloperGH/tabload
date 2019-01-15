using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Tabload.Net
{
    abstract class NetLoader 
    {
        private void _WebScraper(string url, string nodeid)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml($@"{url}");

            HtmlNode node = doc.DocumentNode.SelectNodes($@"/div[@id='{nodeid}']").First();
        }
    }
}
