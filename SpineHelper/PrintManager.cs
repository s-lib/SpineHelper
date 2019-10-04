using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using SpineHelper.History;

namespace SpineHelper
{
    public class PrintManager
    {
        private readonly PrintDocument doc = new PrintDocument();
        private readonly PrintPreviewDialog preview = new PrintPreviewDialog();
        private readonly PrintDialog print = new PrintDialog();


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
