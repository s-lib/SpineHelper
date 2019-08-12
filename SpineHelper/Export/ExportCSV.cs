
namespace SpineHelper.Export
{
    public class ExportCSV : BaseText
    {
        protected override string cellSeparator { get { return ";"; } }
        protected override string lineSeparator { get { return "\r\n"; } }

        public ExportCSV()
        {
        }
        
    }



}
