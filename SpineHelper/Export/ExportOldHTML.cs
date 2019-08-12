using System.IO;
using System.Text;

namespace SpineHelper.Export
{
    public class ExportOldHTML : IExportFormat
    {
        private string HeaderName = GlobalStrings.Arrows;
        private const string EndLine = "\r\n";
        private const string Tab = "\t";
        private const string Tab2 = "\t\t";


        public ExportOldHTML()
        {
        }

        public virtual string ExportDataToFile(object[,] dataTable, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                string output = string.Empty;



                if (dataTable.GetLength(1) > 1)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append("<html>" + EndLine);
                    builder.Append("<head>" + EndLine);
                    builder.Append("<title>" + HeaderName + "</title>" + EndLine);
                    builder.Append("<style>" + EndLine);
                    builder.Append(GetStyle());
                    builder.Append("</style>" + EndLine);
                    builder.Append("</head>" + EndLine);
                    builder.Append("<body>" + EndLine);
                    builder.Append("<table id = 'arrows'>");
                    builder.Append(Tab + "<tr align='center' valign='top'>" + EndLine);


                    int numberColumns = dataTable.GetLength(0);
                    builder.Append(Tab2 + "<tr align='center'><td colspan='" + numberColumns + "' bgcolor='#B6DDE8'><b>"
                        + HeaderName + "</b></td></tr>" + EndLine);


                    builder.Append(Tab2 + "<tr align='center'><td colspan='" + numberColumns + "'></td></tr>" + EndLine);


                    int summaryIndex = dataTable.GetLength(1) - 2; //TODO: check if summary exists

                    for (int r = 0; r < dataTable.GetLength(1); r++)
                    {
                        builder.Append(Tab2 + "<tr align='right'>");

                        for (int c = 0; c < dataTable.GetLength(0); c++)
                        {
                            if (r == 0)
                                builder.Append("<th>" + dataTable[c, r] + "</th>");
                            else if (r == summaryIndex)
                                builder.Append("<td bgcolor='#D7E4BC'><b>" + dataTable[c, r] + "</b></td>");
                            else if (r > summaryIndex && dataTable[c, r] != null)
                                builder.Append("<td bgcolor='#D7E4BC'>" + dataTable[c, r] + " </td>");
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


        private string GetStyle()
        {
            string s = "#arrows {font-family: \"Trebuchet MS\", Arial, Helvetica, sans-serif; border-collapse:collapse; }"
             + "#arrows td, #arrows th {border: 0px solid #ddd;  padding: 5px; padding-left: 8px; padding-right: 8px;}"
             + "#arrows tr:hover {background-color: #ddd; }"
             + "#arrows th {padding-top: 12px; padding-bottom: 12px; color:white; background-color: #963737;}";
            
            return s;
        }
    }
}

