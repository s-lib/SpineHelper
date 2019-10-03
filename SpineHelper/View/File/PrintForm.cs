using SpineHelper.Device;
using SpineHelper.History;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using SpineHelper.Properties;
using System.Globalization;

namespace SpineHelper.View.File
{
    public partial class PrintForm : Form
    {
        private const int TableCellSpacingX = 75;
        private const int TableCellSpacingY = 25;

        //TODO: max entries on one page
        private const int maxEntriesPerPage = 36;



        public PrintForm()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintAppLogo(e);
            PrintArrowSetData(e, HistoryManager.instance.CurrentSet);
        }

        private void PrintArrowSetData(PrintPageEventArgs e, ArrowSet set)
        {
            int x = 100;
            int y = 150;

            var font_bold = new Font("Arial", 9, FontStyle.Bold);
            var font = new Font("Arial", 9, FontStyle.Regular);
            var brush = Brushes.Black;

            //TODO: feed with global strings
            string[] strings = new string[] {
                    "ID",
                    "Grams",
                    "Grains",
                    "AMO",
                    "ASTM",
                    "Straightness"
                };
            PrintDataRow(e, x, y, font_bold, brush, strings);
            y += 30;

            int i = 0;
            foreach (var a in set.Arrows)
            {
                if (++i > 36)
                    break;

                strings = new string[] {
                    a.Index.ToString(),
                    a.Weight.Grams.ToString("0.0"),
                    a.Weight.Grains.ToString(),
                    a.Spine.AMO.ToString(),
                    a.Spine.ASTM.ToString(),
                    a.Straightness.String
                };

                PrintDataRow(e, x, y, font, brush, strings);
                y += TableCellSpacingY;
            }
        }

        private void PrintDataRow(PrintPageEventArgs e, int x, int y, Font font, Brush brush, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                e.Graphics.DrawString(strings[i], font, brush, new Point(x + (i * TableCellSpacingX), y));
            }
        }




        private void PrintAppLogo(PrintPageEventArgs e)
        {
            var dateString = DateTime.Now.ToString("d", CultureInfo.CurrentCulture);

            var font_bold = new Font("Arial", 7, FontStyle.Bold);
            var font = new Font("Arial", 7, FontStyle.Regular);
            var brush = Brushes.Black;
            var appImage = Resources._128;

            int x = 325;
            int y = 40;
            int xAdd = 50;
            int yAdd = 15;


            //TODO: add black-white small logo img
            e.Graphics.DrawImage(appImage, x, y + yAdd, 44, 44);
            e.Graphics.DrawString("Created on " + dateString, font, brush, new Point(x, y));
            e.Graphics.DrawString("SpineHelper", font_bold, brush, new Point(x + xAdd, y + yAdd));
            e.Graphics.DrawString("Digital Spinetester PC App", font, brush, new Point(x + xAdd, y + 2 * yAdd));
            e.Graphics.DrawString("daedalus.pl@gmail.com", font, brush, new Point(x + xAdd, y + 3 * yAdd));
        }
    }
}
