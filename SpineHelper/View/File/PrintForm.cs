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
        private const int TableCellSpacingY = 25;

        //TODO: max entries on one page
        private const int maxEntriesPerPage = 36;
        private int currentPage = 0;



        public PrintForm()
        {
            InitializeComponent();
            radioButtonMain.Select();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintAppLogo(e);
            PrintArrowSetData(e, HistoryManager.instance.CurrentSet, radioButtonFull.Checked);
        }

        private void PrintArrowSetData(PrintPageEventArgs e, ArrowSet set, bool full)
        {
            int x = 150;
            int xCellSpacing = 70; 
            int y = 150;

            if (full)
            {
                x = 100;
                xCellSpacing = 60;
            }


            var font_bold = new Font("Arial", 9, FontStyle.Bold);
            var font = new Font("Arial", 9, FontStyle.Regular);
            var brush = Brushes.Black;

            PrintDataRow(e, x, y, xCellSpacing, font_bold, brush, GetHeaders(full));
            y += 30;

            int start = currentPage++ * maxEntriesPerPage;

            for (int i = start; i < set.Arrows.Length; i++)
            {
                if (i >= currentPage * maxEntriesPerPage)
                {
                    e.HasMorePages = true;
                    return;
                }

                PrintDataRow(e, x, y, xCellSpacing, font, brush, GetDataString(set.Arrows[i], full));
                y += TableCellSpacingY;
            }
        }



        private string[] GetHeaders(bool full = false)
        {
            var h = new List<string>();
            h.Add("ID");
            h.Add(GlobalStrings.HistoryViewColumnGrams);
            h.Add(GlobalStrings.HistoryViewColumnGrains);
            h.Add("AMO");
            h.Add("ASTM");
            h.Add(GlobalStrings.HistoryViewColumnStraightness);
            
            if (full)
            {
                h[h.Count - 1] = GlobalStrings.HistoryViewColumnStraightnessShort;
                h.Add(GlobalStrings.HistoryViewColumnAMO1);
                h.Add(GlobalStrings.HistoryViewColumnASTM1);
                h.Add(GlobalStrings.HistoryViewColumnAMO2);
                h.Add(GlobalStrings.HistoryViewColumnASTM2);
            }

            return h.ToArray();
        }

        private string[] GetDataString(ArrowData a, bool full = false)
        {
            var s = new List<string>();
            s.Add(a.Index.ToString());
            s.Add(a.Weight.Grams.ToString("0.0"));
            s.Add(a.Weight.Grains.ToString());
            s.Add(a.Spine.AMO.ToString());
            s.Add(a.Spine.ASTM.ToString());
            s.Add(a.Straightness.String);

            if (full)
            {
                s.Add(a.Spine.AMO1.ToString());
                s.Add(a.Spine.ASTM1.ToString());
                s.Add(a.Spine.AMO2.ToString());
                s.Add(a.Spine.ASTM2.ToString());
            }

            return s.ToArray();
        }



        private void PrintDataRow(PrintPageEventArgs e, int x, int y, int xAdd, Font font, Brush brush, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                e.Graphics.DrawString(strings[i], font, brush, new Point(x + (i * xAdd), y));
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
