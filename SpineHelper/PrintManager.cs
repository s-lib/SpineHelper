using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using SpineHelper.History;

namespace SpineHelper
{
    public class PrintManager
    {
        public static readonly PrintManager instance = new PrintManager();

        //public event Action<ArrowSet> PreviewPrint;
        //public event Action<ArrowSet> PrintHistory;

        private readonly PrintDocument doc = new PrintDocument();
        private readonly PrintPreviewDialog preview = new PrintPreviewDialog();
        private readonly PrintDialog print = new PrintDialog();


        static PrintManager()
        {
        }

        private PrintManager()
        {
        }

        //public void OnPrintHistory()
        //{
        //    PrintHistory?.Invoke();
        //}

        public void Preview(ArrowSet set)
        {

        }

        public void Print(ArrowSet set)
        {

        }
    }

}
