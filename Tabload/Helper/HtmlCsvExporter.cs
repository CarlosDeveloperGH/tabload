using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Text;
namespace Tabload.Helper
{
    public class HtmlCsvExporter
    {
        private readonly HtmlTable _table;

        public HtmlCsvExporter(HtmlTable table)
        {
            _table = table;
        }
        
        public string[] ConvertHTMLToCSV()
        {
            List<string> rows = new List<string>();
            foreach(HtmlTableRow row in _table.Rows)
            {
                StringBuilder strBuild = new StringBuilder();

                foreach (HtmlTableCell cell in row.Cells)
                {
                    strBuild.Append(cell.TagName.Trim());
                    strBuild.Append(",");
                }
                strBuild.Remove(strBuild.Length - 1, 1);
                rows.Add(strBuild.ToString());
            }
            return rows.ToArray();
        }
    }
}
