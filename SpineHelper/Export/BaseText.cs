using System.IO;
using System.Text;

namespace SpineHelper.Export
{
    public abstract class BaseText : IExportFormat
    {
        protected abstract string cellSeparator { get; }
        protected abstract string lineSeparator { get; }

        public virtual string ExportDataToFile(object[,] dataTable, string filename)
        {

            using (StreamWriter sw = new StreamWriter(filename))
            {
                string output = string.Empty;

                if (dataTable.GetLength(1) > 1)
                {
                    StringBuilder builder = new StringBuilder();

                    for (int r = 0; r < dataTable.GetLength(1); r++)
                    {
                        for (int c = 0; c < dataTable.GetLength(0); c++)
                        {
                            // Prevents inserting a separator before the first cell
                            if (c > 0)
                                builder.Append(cellSeparator);

                            builder.Append(dataTable[c, r]);
                        }
                        builder.Append(lineSeparator);
                    }
                    output = builder.ToString();
                }

                sw.Write(output);
            }

            return OnExportSuccessfull();
        }

        protected virtual string OnExportSuccessfull()
        {
            return null;
        }
        
    }



}
