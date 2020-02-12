using System;
using System.IO;

namespace SpineHelper.Export
{
    public class DataExporter
    {
        public enum ExportType { Undefined, Excel, HTML, OldHTML, CSV, TXT, JPG }

        private const string ExportDirectoryName = "Export";
        private const string FileFormatSeparator = "|";

        public const string AvailableExportFormats =
                                    "Excel Files (2007)|*.xlsx"
            + FileFormatSeparator + "HTML file|*.html"
            + FileFormatSeparator + "Old HTML file (for Excel import)|*.html"
            + FileFormatSeparator + "CSV File|*.csv"
            + FileFormatSeparator + "Plain Text File|*.txt"
            + FileFormatSeparator + "JPEG Image File|*.jpg";


        public event Action<string> ExportFailed;
        public event Action ExportSuccessful;

        private readonly IExportFormat ex;
        private readonly int index;

        public DataExporter(int index)
        {
            this.index = index;

            if (Enum.IsDefined(typeof(ExportType), index))
            {
                switch ((ExportType)index)
                {
                    case ExportType.Excel: ex = new ExportExcel(); break;
                    case ExportType.HTML: ex = new ExportHTML(); break;
                    case ExportType.OldHTML: ex = new ExportOldHTML(); break;
                    case ExportType.CSV: ex = new ExportCSV(); break;
                    case ExportType.TXT: ex = new ExportTXT(); break;
                    case ExportType.JPG: ex = new ExportJPG(); break;
                    default: break;
                }
            }
        }

        private void OnExport(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
                ExportSuccessful?.Invoke();
            else
                ExportFailed?.Invoke(errorMessage);
        }

        public void ExportToFile(object[,] dataTable, string fileName)
        {
            try
            {
                OnExport(ex.ExportDataToFile(dataTable, fileName));
            }
            catch (Exception ex)
            {
                OnExport(string.Format(GlobalStrings.ExportError, index, ex.Message));
            }
        }


        public static string ExportDirectory
        {
            get
            {
                string path = Path.Combine(Common.MainDirectory, ExportDirectoryName);
                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    return path;
                }
                catch (Exception)
                {
                    return Common.InvalidDirectory;
                }
            }
        }



    }



}
