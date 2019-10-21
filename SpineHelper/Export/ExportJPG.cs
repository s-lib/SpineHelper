using System;
using System.Drawing;

namespace SpineHelper.Export
{
    public class ExportJPG : IExportFormat
    {
        private int ImageCenter { get { return imageWidth / 2; } }

        //TODO: placeholder value
        private string HeaderName = GlobalStrings.Arrows;

        // Default cell size
        private const int CellSpacingY = 25;
        private const int DefaultCellWidth = 85;
        private const int CommentWidthMax = 600;

        private const int DefaultTitleFontSize = 12;
        private const int DefaultFontSize = 9;

        private const string GramsFormat = "0.0";

        // Column width
        private int totalWidth = 0;
        private int[] columnWidth;
        private int commentWidth = 125;

        // Initial size of the image (values are to size obtained from dataTable)
        private int imageWidth = 100;
        private int imageHeight = 100 + (3 * CellSpacingY);

        // Initial Y position
        private int y = 50;

        // Initial X position
        private int x = 0;


        public ExportJPG()
        {
        }

        public string ExportDataToFile(object[,] dataTable, string filename)
        {
            try
            {
                // Set width of each column based on column name
                SetCommentColumnWidth(dataTable);
                columnWidth = new int[dataTable.GetLength(0)];
                for (int i = 0; i < dataTable.GetLength(0); i++)
                {
                    columnWidth[i] = GetWidthByColumnName(dataTable[i, 0]);
                    totalWidth += columnWidth[i];
                }

                // Initialize the bitmap
                imageWidth += totalWidth;
                imageHeight += dataTable.GetLength(1) * CellSpacingY;

                Bitmap bmp = new Bitmap(imageWidth, imageHeight);
                Graphics g = Graphics.FromImage(bmp);

                // Change brush to LightGray in case of adjusting aligment
                g.FillRectangle(Brushes.White, 0, 0, imageWidth, imageHeight);


                // Draw the bitmap
                PrintTitle(g, dataTable, HeaderName);
                PrintData(g, dataTable);

                bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                bmp.Dispose();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return null;
        }

        /// <summary>
        /// Prints the centered image title (name of the arrow set)
        /// </summary>
        private void PrintTitle(Graphics g, object[,] dataTable, string title)
        {
            // Set title font
            var font = new Font("Arial", DefaultTitleFontSize, FontStyle.Bold);

            // Set title x position
            var stringSize = g.MeasureString(title, font);
            int stringWidth = Convert.ToInt32(stringSize.Width);
            int titleX = ImageCenter - (stringWidth / 2);

            // Set some global usefull variables
            x = ImageCenter - (totalWidth / 2);

            // Draw background and the title
            g.FillRectangle(Brushes.PowderBlue, x, y - 2, totalWidth, CellSpacingY);
            PrintString(g, title, font, Brushes.Black, titleX, y);

            // Adjust Y position
            y += 3 * CellSpacingY;
        }

        /// <summary>
        /// Prints the whole data from a two-dimensional array of objects
        /// </summary>
        private void PrintData(Graphics g, object[,] dataTable)
        {
            //TODO: check if summary exists
            int summaryIndex = dataTable.GetLength(1) - 2;

            // Declare basic fonts
            var font_bold = new Font("Arial", DefaultFontSize, FontStyle.Bold);
            var font_normal = new Font("Arial", DefaultFontSize, FontStyle.Regular);

            int currentX = x;

            // Print data by rows
            for (int rows = 0; rows < dataTable.GetLength(1); rows++)
            {
                // Initialize string array to hold row's data values
                string[] row = new string[dataTable.GetLength(0)];

                // Set default font and color
                var font = font_normal;
                var brush = Brushes.Black;

                for (int i = 0; i < row.Length; i++)
                {
                    // Copy row values to string array
                    row[i] = GetStringFromDataValue(dataTable[i, rows], dataTable[i, 0]);

                    // Print background only for last summary line (just for non-empty cells)
                    // Needs to be here, since it's cell-dependant
                    if (rows > summaryIndex)
                    {
                        if (string.IsNullOrEmpty(row[i]) == false)
                            g.FillRectangle(Brushes.DarkSeaGreen, currentX, y - 5, columnWidth[i], CellSpacingY);

                        currentX += columnWidth[i];
                    }
                }

                // Print column header background
                if (rows == 0)
                {
                    g.FillRectangle(Brushes.Brown, x, y - 5, totalWidth, CellSpacingY);
                    font = font_bold;
                    brush = Brushes.White;
                    //y += 5;
                    //PrintLine(g, xMod, y + 15, xMod + lineSize, y + 15);
                }
                // Print first summary row background
                else if (rows == summaryIndex)
                {
                    g.FillRectangle(Brushes.DarkSeaGreen, x, y - 5, totalWidth, CellSpacingY);
                    font = font_bold;
                }

                // Print row values
                PrintDataRow(g, x, y, font, brush, row);

                // Adjust Y
                y += CellSpacingY;
            }

            // Dispose fonts
            font_bold.Dispose();
            font_normal.Dispose();
        }

        /// <summary>
        /// Prints an array of strings (whole row of data)
        /// </summary>
        private void PrintDataRow(Graphics g, int x, int y, Font font, Brush brush, string[] strings)
        {
            int currentX = x;

            for (int i = 0; i < strings.Length; i++)
            {
                currentX += columnWidth[i];
                PrintStringRight(g, strings[i], font, brush, currentX, y);
            }
        }

        /// <summary>
        /// Prints a line from point(x1,y1) to point(x2,y2)
        /// </summary>
        private void PrintLine(Graphics g, float x1, float y1, float x2, float y2)
        {
            g.DrawLine(new Pen(Brushes.Black, 1), x1, y1, x2, y2);
        }

        /// <summary>
        /// Prints left aligned text
        /// </summary>
        private void PrintString(Graphics g, string text, Font font, Brush brush, int x, int y)
        {
            g.DrawString(text, font, brush, new Point(x, y));
        }

        /// <summary>
        /// Prints right aligned text
        /// </summary>
        private void PrintStringRight(Graphics g, string text, Font font, Brush brush, int x, int y)
        {
            // Get real width of the text to shift the X position by this value
            var stringSize = g.MeasureString(text, font);
            int stringWidth = Convert.ToInt32(stringSize.Width);

            g.DrawString(text, font, brush, new Point(x - stringWidth, y));
        }

        /// <summary>
        /// Prints an image
        /// </summary>
        private void PrintImage(Graphics g, Image image, int x, int y, int width, int height)
        {
            g.DrawImage(image, x, y, width, height);
        }


        private int GetWidthByColumnName(object value)
        {
            string name = value == null ? string.Empty : value.ToString();

            if (string.IsNullOrEmpty(name))
                return DefaultCellWidth;

            if (name == "ID") return 40;
            if (name == "ASTM") return 80;
            if (name == "AMO") return 70;
            if (name == GlobalStrings.HistoryViewColumnGrains) return 80;
            if (name == GlobalStrings.HistoryViewColumnGrams) return 85;
            if (name == GlobalStrings.HistoryViewColumnStraightness) return 110;
            if (name == GlobalStrings.HistoryViewColumnComment) return commentWidth;
            if (name == GlobalStrings.HistoryViewColumnGPI) return 70;

            return DefaultCellWidth;
        }

        private void SetCommentColumnWidth(object[,] dataTable)
        {
            for (int i = 0; i < dataTable.GetLength(0); i++)
            {
                if (dataTable[i, 0] != null)
                {
                    string name = dataTable[i, 0].ToString();
                    if (name == GlobalStrings.HistoryViewColumnComment)
                    {
                        for (int r = 0; r < dataTable.GetLength(1); r++)
                        {
                            string comment = dataTable[i, r] == null ? string.Empty : dataTable[i, r].ToString();
                            int width = Math.Max(comment.Length * (DefaultFontSize - 1), commentWidth);
                            commentWidth = Math.Min(width, CommentWidthMax);
                        }
                        return;
                    }
                }
            }
        }

        private string GetStringFromDataValue(object value, object name)
        {
            string result = value == null ? string.Empty : value.ToString();

            // If Grams column, return in proper formatting
            if (name != null && name.ToString() == GlobalStrings.HistoryViewColumnGrams)
            {
                double.TryParse(result.ToString(), out double d);
                result = d == 0 ? result : d.ToString(GramsFormat);
            }

            return result;
        }

    }



}
