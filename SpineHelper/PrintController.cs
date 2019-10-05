using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using SpineHelper.History;
using SpineHelper.Properties;

namespace SpineHelper
{
    public class PrintController
    {
        public string ArrowSetName { get; set; } = string.Empty;
        public bool Details { get; set; }
        public bool Summary { get; set; }
        public bool AddCustomLogo { get; set; }
        public Image CustomLogo { get; set; }
        public bool Grayscale
        {
            get { return !settings.DefaultPageSettings.Color; }
            set { settings.DefaultPageSettings.Color = !value; }
        }


        private const int maxLogoHeight = 100;
        private const int maxLogoWidth = maxLogoHeight * 4;
        private const int logoYPos = 50;
        private const int titleYPos = 180;
        private const int footerYPos = 1060;
        private const int maxEntriesPerPage = 30;
        private const int appLogoSize = 44;
        private const int cellSpacingY = 25;

        private readonly PrintDocument doc = new PrintDocument();
        private readonly PrintPreviewDialog preview = new PrintPreviewDialog();
        private readonly PrintDialog print = new PrintDialog();
        private readonly PrinterSettings settings = new PrinterSettings();

        private readonly Image defaultLogo = Resources.spinetester;
        private readonly Image appLogo = Resources._128;

        private ArrowSet set;
        private int currentPage = 0;


        public PrintController(ArrowSet set)
        {
            NewSet(set);
            doc.PrintPage += printDocument_PrintPage;
            doc.EndPrint += printDocument_EndPrint;
            doc.PrinterSettings = settings;
            preview.Document = doc;
            print.Document = doc;
        }


        public void NewSet(ArrowSet set)
        {
            this.set = set;
        }

        public void Preview()
        {
            currentPage = 0;
            preview.ShowDialog();
        }

        public void Print()
        {
            currentPage = 0;
            if (print.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintLogos(e);
            PrintTitle(e, ArrowSetName);
            if (set.ArrowCount > 0)
                PrintArrowSetData(e, set, Details, Summary);
        }

        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            currentPage = 0;
        }


        private void PrintLogos(PrintPageEventArgs e)
        {
            int centerX = e.PageSettings.PaperSize.Width / 2;

            // Draw top logo
            var logo =  AddCustomLogo ? CustomLogo ?? defaultLogo : defaultLogo;
            var p = GetRescaledImageSize(logo, maxLogoWidth, maxLogoHeight);
            PrintImage(e, logo, centerX - (p.X / 2), logoYPos, p.X, p.Y);

            // Set data for footer logo
            int x = centerX - 69;// 345;
            int xAdd = 50;
            int yAdd = 15;

            var dateString = DateTime.Now.ToString("d", CultureInfo.CurrentCulture);
            var font_bold = new Font("Arial", 7, FontStyle.Bold);
            var font = new Font("Arial", 7, FontStyle.Regular);

            // Draw footer logo with app info
            PrintImage(e, appLogo, x, footerYPos + yAdd, appLogoSize, appLogoSize);
            PrintString(e, GlobalStrings.PrintCreatedDate + dateString, font, x, footerYPos);
            PrintString(e, "SpineHelper",          font_bold, x + xAdd, footerYPos + yAdd);
            PrintString(e, GlobalStrings.PrintLogoInfo, font, x + xAdd, footerYPos + 2 * yAdd);
            PrintString(e, "daedalus.pl@gmail.com",     font, x + xAdd, footerYPos + 3 * yAdd);
        }

        private Point GetRescaledImageSize(Image img, double maxX, double maxY)
        {
            int x = img.Width;
            int y = img.Height;
            double scale = x > 2 * y ? x / maxX : y / maxY;

            x = Convert.ToInt32(x / scale);
            y = Convert.ToInt32(y / scale);

            return new Point(x, y);
        }

        private void PrintTitle(PrintPageEventArgs e, string title)
        {
            var font = new Font("Arial", 14, FontStyle.Bold);
            int fontSize = 11;
            int x = e.PageSettings.PaperSize.Width / 2 - (title.Length / 2 * fontSize);

            PrintString(e, title, font, x, titleYPos);
        }


        private void PrintArrowSetData(PrintPageEventArgs e, ArrowSet set, bool full, bool summary)
        {
            int x = 200;
            int xCellSpacing = 70;
            int y = 215;
            int lineSize = Details ? 590 : 390;

            if (full)
            {
                x = 100;
                xCellSpacing = 60;
            }


            var font_bold = new Font("Arial", 9, FontStyle.Bold);
            var font = new Font("Arial", 9, FontStyle.Regular);

            PrintDataRow(e, x, y, xCellSpacing, font_bold, GetHeaders(full));
            y += 30;
            PrintLine(e, x, y - 9, x + lineSize, y - 9);

            int start = currentPage++ * maxEntriesPerPage;

            for (int i = start; i < set.Arrows.Length; i++)
            {
                if (i >= currentPage * maxEntriesPerPage)
                {
                    e.HasMorePages = true;
                    break;
                }

                PrintDataRow(e, x, y, xCellSpacing, font, GetDataString(set.Arrows[i], full));
                y += cellSpacingY;
            }

            if (Summary)
            {
                PrintLine(e, x, y - 3, x + lineSize, y - 3);
                PrintDataRow(e, x, y + 5, xCellSpacing, font_bold, GetSummaryString(set));
                PrintDataRow(e, x, y + 5 + cellSpacingY, xCellSpacing, font_bold, GetSummaryString(set, true));
            }
        }

        private void PrintDataRow(PrintPageEventArgs e, int x, int y, int xAdd, Font font, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                PrintString(e, strings[i], font, x + (i * xAdd), y);
            }
        }

        private void PrintLine(PrintPageEventArgs e, float x1, float y1, float x2, float y2)
        {
            e.Graphics.DrawLine(new Pen(Brushes.Black, 1), x1, y1, x2, y2);
        }

        private void PrintString(PrintPageEventArgs e, string text, Font font, int x, int y)
        {
            e.Graphics.DrawString(text, font, Brushes.Black, new Point(x, y));
        }

        private void PrintImage(PrintPageEventArgs e, Image image, int x, int y, int width, int height)
        {
            e.Graphics.DrawImage(image, x, y, width, height);
        }

        private string[] GetHeaders(bool full = false)
        {
            var h = new List<string>
            {
                "ID",
                GlobalStrings.HistoryViewColumnGrams,
                GlobalStrings.HistoryViewColumnGrains,
                "AMO",
                "ASTM",
                GlobalStrings.HistoryViewColumnStraightness
            };

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
            var s = new List<string>
            {
                a.Index.ToString(),
                a.Weight.Grams.ToString("0.0"),
                a.Weight.Grains.ToString(),
                a.Spine.AMO.ToString(),
                a.Spine.ASTM.ToString(),
                a.Straightness.String
            };

            if (full)
            {
                s.Add(a.Spine.AMO1.ToString());
                s.Add(a.Spine.ASTM1.ToString());
                s.Add(a.Spine.AMO2.ToString());
                s.Add(a.Spine.ASTM2.ToString());
            }

            return s.ToArray();
        }

        private string[] GetSummaryString(ArrowSet set, bool secondRow = false)
        {
            object s = set.GetSummary("Straightness", secondRow);

            return new string[]
            {
                secondRow ? string.Empty : "###",
                set.GetSummary("Grams", secondRow).ToString(),
                set.GetSummary("Grains", secondRow).ToString(),
                set.GetSummary("AMO", secondRow).ToString(),
                set.GetSummary("ASTM", secondRow).ToString(),
                s != null ? s.ToString() : string.Empty
            };
        }



    }

}
