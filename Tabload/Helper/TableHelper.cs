using System.Collections.Generic;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Tabload.Helper
{
    class TableHelper : Net.NetLoader
    {
        public string _extractTable(string url)
        {
            int firstIndex;
            int lastIndex;
            string doc = _webScraperStr($@"{url}");

            //Get the beginning and end of the table
            firstIndex = doc.IndexOf("<table>");
            lastIndex = doc.IndexOf("</table>");
            doc = doc.Substring(firstIndex);
            return doc;
        }

    }
}
