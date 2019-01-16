using System.Collections.Generic;
using System.Text;
using System.Web.UI.HtmlControls;
using System;
using System.Text.RegularExpressions;

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
        private void _createTableArray(string htmlTableStr)
        {
            int startIndexTr, endIndexTr, lenghtTr;
            HtmlTable table = new HtmlTable();
            //Create 2 Dimensional Array [Row,Cell]
            string[,] tableArray = new string[,] { };
            //Iterate through the table string, delete the converted cells from the string
            while(!String.IsNullOrWhiteSpace(htmlTableStr))
            {
                //Initialisation
                HtmlTableRow row = new HtmlTableRow();
                startIndexTr = htmlTableStr.IndexOf("<tr>");
                endIndexTr = htmlTableStr.IndexOf("</tr>");
                //get the lenght
                lenghtTr = endIndexTr - startIndexTr + 1;
                //create a substring of the tr
                string tempString = htmlTableStr.Substring(startIndexTr, lenghtTr);

                //count how many strings //TODO
                int neededColumns = Regex.Matches(tempString, "<td>").Count;

                for(int i = 0; i < neededColumns; i++)
                {
                    //Initialisation
                    HtmlTableCell cell = new HtmlTableCell();  
                    int startIndexTd = htmlTableStr.IndexOf("<td>");
                    int endIndexTd = htmlTableStr.IndexOf("</td>");
                    //get the lenght
                    lenghtTr = endIndexTd - startIndexTd + 1;

                    //Fill the variable cellContent with the content of the cell
                    string cellContent = htmlTableStr.Substring(startIndexTr, lenghtTr);

                    cell.InnerHtml = $@"{cellContent}";

                    //Add the filled cell to the row
                    row.Cells.Add(cell);
                }
                //add the filled row to the table
                table.Rows.Add(row);
            }
        }
        private HtmlTable _createTableObj()
        {
            HtmlTable table = new HtmlTable();
            //TODO
            return table;
        }

    }
}
