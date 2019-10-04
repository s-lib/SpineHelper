using SpineHelper.Device;
using SpineHelper.History;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using SpineHelper.Properties;
using System.Globalization;
using System.IO;

namespace SpineHelper.View.File
{
    public partial class PrintForm : Form
    {
        private const int TableCellSpacingY = 25;

        //TODO: max entries on one page
        private const int maxEntriesPerPage = 30;
        private int currentPage = 0;

        private Image customLogo;
        private const string AvailableLogoFormats = "Image files (*.bmp,*.png,*.jpg,*.gif)|*.bmp;*.png;*.jpg;*.gif";
        private const string LogoName = "customLogo.png";


        public PrintForm()
        {
            InitializeComponent();
            radioButtonMain.Select();
            checkBoxSummary.Checked = true;
            checkBoxLogo.Checked = true;
            LoadLogo();
        }

        //private void PrintForm_Closing(object sender, CancelEventArgs e)
        //{
        //    System.IO.File.Copy(load.FileName, Path.Combine(Common.MainDirectory, LogoName), true);
        //}

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
            PrintLogos(e);
            PrintTitle(e, "Tested Arrows");
            if (HistoryManager.instance.CurrentSet.ArrowCount > 0)
                PrintArrowSetData(e, HistoryManager.instance.CurrentSet, radioButtonFull.Checked, checkBoxSummary.Checked);
        }

        private Image CheckPrintLogo()
        {
            return checkBoxLogo.Checked ? customLogo : null;
        }

        private void PrintTitle(PrintPageEventArgs e, string title)
        {
            var font = new Font("Arial", 14, FontStyle.Bold);
            int fontSize = 12;
            int x = e.PageSettings.PaperSize.Width / 2 - (title.Length / 2 * fontSize);
            int y = 180;

            e.Graphics.DrawString(title, font, Brushes.Black, new Point(x, y));
        }

        private void PrintArrowSetData(PrintPageEventArgs e, ArrowSet set, bool full, bool summary)
        {
            int x = 200;
            int xCellSpacing = 70; 
            int y = 210;

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
                    break;
                }

                PrintDataRow(e, x, y, xCellSpacing, font, brush, GetDataString(set.Arrows[i], full));
                y += TableCellSpacingY;
            }

            PrintDataRow(e, x, y + 5, xCellSpacing, font_bold, brush, GetSummaryString(set));
            PrintDataRow(e, x, y + 5 + TableCellSpacingY, xCellSpacing, font_bold, brush, GetSummaryString(set, true));
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



            private void PrintDataRow(PrintPageEventArgs e, int x, int y, int xAdd, Font font, Brush brush, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                e.Graphics.DrawString(strings[i], font, brush, new Point(x + (i * xAdd), y));
            }
        }



        private void PrintLogos(PrintPageEventArgs e)
        {
            var logo = checkBoxLogo.Checked ? customLogo : null;

            int centerX = e.PageSettings.PaperSize.Width / 2;
            int x = centerX - 69;// 345;
            int y = 40;
            int xAdd = 50;
            int yAdd = 15;

            // Draw custom logo
            if (logo != null)
            {
                int size = 100;
                var p = RescaleLogo(logo, size * 3, size);
                e.Graphics.DrawImage(logo, centerX - (p.X / 2), 50, p.X, p.Y);
                y = 1060;
            }


            var dateString = DateTime.Now.ToString("d", CultureInfo.CurrentCulture);

            var font_bold = new Font("Arial", 7, FontStyle.Bold);
            var font = new Font("Arial", 7, FontStyle.Regular);
            var brush = Brushes.Black;
            var appImage = Resources._128;

            //TODO: add black-white small logo img
            e.Graphics.DrawImage(appImage, x, y + yAdd, 44, 44);
            e.Graphics.DrawString("Created on " + dateString, font, brush, new Point(x, y));
            e.Graphics.DrawString("SpineHelper", font_bold, brush, new Point(x + xAdd, y + yAdd));
            e.Graphics.DrawString("Digital Spinetester PC App", font, brush, new Point(x + xAdd, y + 2 * yAdd));
            e.Graphics.DrawString("daedalus.pl@gmail.com", font, brush, new Point(x + xAdd, y + 3 * yAdd));
        }


        private void buttonSelectLogo_Click(object sender, EventArgs e)
        {
            var load = new OpenFileDialog();

            load.InitialDirectory = Common.MainDirectory;
            load.Filter = AvailableLogoFormats;

            if (load.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    customLogo = Image.FromFile(load.FileName);
                    //TODO: gives exception (protected file)
                    //System.IO.File.Copy(load.FileName, Path.Combine(Common.MainDirectory, LogoName), true);
                }
                catch
                {
                    MessageBox.Show("File could not be loaded. Image too big or not an image file.");
                }

                pictureLogo.Image = customLogo;
            }

        }



        private void LoadLogo()
        {
            try
            {
                customLogo = Image.FromFile(Path.Combine(Common.MainDirectory, LogoName));
                pictureLogo.Image = customLogo;
            }
            catch { }
        }

        private Point RescaleLogo(Image logo, int maxX, int maxY)
        {
            int x = logo.Width;
            int y = logo.Height;
            double scale = x > 2 * y ? x / maxX : y / maxY;

            x = Convert.ToInt32(x / scale);
            y = Convert.ToInt32(y / scale);

            return new Point(x, y);
        }

        private void checkBoxLogo_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            groupBoxLogo.Enabled = checkbox.Checked;
            pictureLogo.Visible = checkbox.Checked;
        }
    }
}
