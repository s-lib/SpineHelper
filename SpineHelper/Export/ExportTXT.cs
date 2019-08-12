
namespace SpineHelper.Export
{
    public class ExportTXT : BaseText
    {

        protected override string cellSeparator { get { return "\t"; } }
        protected override string lineSeparator { get { return "\r\n"; } }

        public ExportTXT()
        {
        }
    }



}
