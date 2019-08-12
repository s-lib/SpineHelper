
namespace SpineHelper.Export
{
    public interface IExportFormat
    {
        /// <summary>
        /// Returns error message if save failed, null if saved successfully
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>

        string ExportDataToFile(object[,] data, string filename);
    }
}
