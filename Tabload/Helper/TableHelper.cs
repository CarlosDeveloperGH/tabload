using System.Collections.Generic;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Tabload.Helper
{
    class TableHelper : Net.NetLoader
    {
        private string _extractTable(string url)
        {
            int startIndex, endIndex, lenght;
            string doc = _webScraperStr($@"{url}");

            //Get the beginning and end of the table
            startIndex = doc.IndexOf("<table>");
            endIndex = doc.IndexOf("</table>");
            lenght = endIndex - startIndex + 1;

            //Cut the string
            doc = doc.Substring(startIndex, lenght);
            return doc;
        }
        private void _createTableArray(string htmlTable)
        {
            //Create 2 Dimensional Array [Row,Cell]
            string[,] tableArray = new string[,] { };
            //TODO

        }
        private HtmlTable _createTableObj()
        {
            HtmlTable table = new HtmlTable();
            //TODO
            return table;
        }

    }
}
