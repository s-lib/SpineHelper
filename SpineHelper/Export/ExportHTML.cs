using System.IO;
using System.Text;

namespace SpineHelper.Export
{
    public class ExportHTML : IExportFormat
    {
        private const string HeaderName = "Arrows";
        private const string EndLine = "\r\n";
        private const string Tab = "\t";
        private const string Tab2 = "\t\t";


        public ExportHTML()
        {
        }

        public virtual string ExportDataToFile(object[,] dataTable, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                string output = string.Empty;

                int summaryIndex = dataTable.GetLength(1) + 2; //TODO: check if summary exists


                if (dataTable.GetLength(1) > 1)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append("<html>" + EndLine);
                    builder.Append("<head>" + EndLine);
                    builder.Append("<title>" + HeaderName + "</title>" + EndLine);
                    builder.Append("<style>" + EndLine);
                    builder.Append(GetStyle(summaryIndex));
                    builder.Append("</style>" + EndLine);
                    builder.Append("</head>" + EndLine);
                    builder.Append("<body>" + EndLine);
                    builder.Append("<table id = 'arrows'>");
                    builder.Append(Tab + "<tr align='center' valign='top'>" + EndLine);


                    int numberColumns = dataTable.GetLength(0);
                    builder.Append(Tab2 + "<tr><td colspan='" + numberColumns + "' data='Name'>" + HeaderName + "</td></tr>" + EndLine);
                    builder.Append(Tab2 + "<tr><td colspan='" + numberColumns + "' data='More'></td></tr>" + EndLine);

                    for (int r = 0; r < dataTable.GetLength(1); r++)
                    {
                        builder.Append(Tab2 + "<tr>");
                        for (int c = 0; c < dataTable.GetLength(0); c++)
                        {
                            if (r == 0)
                                builder.Append("<th>" + dataTable[c, r] + "</th>");
                            else
                                builder.Append("<td>" + dataTable[c, r] + "</td>");
                        }
                        builder.Append("</tr>" + EndLine);
                    }
                    builder.Append(Tab + "</tr>" + EndLine);
                    builder.Append("</table>" + EndLine);
                    builder.Append("</body>" + EndLine);
                    builder.Append("</html>");
                    output = builder.ToString();
                }

                sw.Write(output);
            }
            return null;
        }


        private string GetStyle(int summaryIndex)
        {
            string s = "#arrows {font-family: \"Trebuchet MS\", Arial, Helvetica, sans-serif; border-collapse:collapse; }" //width:80%; 
             //+ "#arrows tr:first-child {background-color: #B6DDE8; font-weight:bold; text-align:center}"
             + "#arrows tr td[data='Name'] {background-color: #B6DDE8; font-weight:bold; text-align:center}"
             + "#arrows tr td[data='More'] {background-color: white; text-align:center; }"
             + "#arrows td, #arrows th {  border: 0px solid #ddd;  padding: 5px; padding-left: 8px; padding-right: 8px; text-align:right;}"
             //+ "#arrows tr:nth-child(even){background-color: #f2f2f2;}"
             + "#arrows tr:hover {background-color: #ddd; }"
             + "#arrows th {padding-top: 12px; padding-bottom: 12px;  background-color: #963737; color:white; text-align:right;}";

            if (summaryIndex > 0)
            {
                s += "#arrows tr:nth-child(" + summaryIndex + ") {background-color: #D7E4BC; font-weight:bold;}"
                    + "#arrows tr:nth-child(" + (summaryIndex + 1) + ") {background-color: #D7E4BC}";
            }

            return s;
        }
    }
}

