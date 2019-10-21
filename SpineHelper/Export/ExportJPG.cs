using System;
using System.Drawing;

namespace SpineHelper.Export
{
    public class ExportJPG : IExportFormat
    {
        //TODO: floating point values aligment (grams)
        //TODO: set cell width by column header name

        private int ImageCenter { get { return imageWidth / 2; } }

        //TODO: placeholder values
        private string HeaderName = GlobalStrings.Arrows;
        private const int CellSpacingX = 100;

        // Default cell height
        private const int CellSpacingY = 25;

        // Initial size of the image (values are to size obtained from dataTable)
        private int imageWidth = 100;
        private int imageHeight = 100 + (3 * CellSpacingY);

        // Initial Y position
        private int y = 50;

        // Initial X position for printing background colors
        private int x = 0;

        // Initial X position for printing data values
        private int cellStartX = 0;


        // Length of the background fill and separator lines
        private int lineSize = 0;

        public ExportJPG()
        {
        }

        public string ExportDataToFile(object[,] dataTable, string filename)
        {
            try
            {
                imageWidth +=  dataTable.GetLength(0) * CellSpacingX;
                imageHeight += dataTable.GetLength(1) * CellSpacingY;

                Bitmap bmp = new Bitmap(imageWidth, imageHeight); 
                Graphics g = Graphics.FromImage(bmp);

                //TODO: change to white when ready adjusting size
                g.FillRectangle(Brushes.LightGray, 0, 0, imageWidth, imageHeight);

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
            var font = new Font("Arial", 14, FontStyle.Bold);

            // Set title x position
            var stringSize = g.MeasureString(title, font);
            int stringWidth = Convert.ToInt32(stringSize.Width);
            int titleX = ImageCenter - (stringWidth / 2);

            // Set some global usefull variables
            x = ImageCenter - ((dataTable.GetLength(0) * CellSpacingX) / 2);
            cellStartX = x + CellSpacingX;
            lineSize = dataTable.GetLength(0) * CellSpacingX;

            // Draw background and the title
            g.FillRectangle(Brushes.PowderBlue, x, y, lineSize, CellSpacingY);
            PrintString(g, title, font, Brushes.Black, titleX, y);

            // Adjust Y position
            y += 3 * CellSpacingY;
        }

        /// <summary>
        /// Prints the whole data from a two-dimensional array of objects
        /// </summary>
        private void PrintData(Graphics g, object[,] dataTable)
        {
            //TODO: get actual cell sizes depending on the header type
            int xCellSpacing = CellSpacingX;

            //TODO: check if summary exists
            int summaryIndex = dataTable.GetLength(1) - 2;

            // Declare basic fonts
            var font_bold = new Font("Arial", 9, FontStyle.Bold);
            var font_normal = new Font("Arial", 9, FontStyle.Regular);


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
                    row[i] = dataTable[i, rows] == null ? string.Empty : dataTable[i, rows].ToString();

                    // Print background only for last summary line (just for non-empty cells)
                    // Needs to be here, since it's cell-dependant
                    if (rows > summaryIndex && string.IsNullOrEmpty(row[i]) == false)
                    {
                        int cellX = x + (i * xCellSpacing);
                        g.FillRectangle(Brushes.DarkSeaGreen, cellX, y - 5, xCellSpacing, CellSpacingY);
                    }
                }

                // Print column header background
                if (rows == 0)
                {
                    g.FillRectangle(Brushes.Brown, x, y - 5, lineSize, CellSpacingY);
                    font = font_bold;
                    brush = Brushes.White;
                    //y += 5;
                    //PrintLine(g, xMod, y + 15, xMod + lineSize, y + 15);
                }
                // Print first summary row background
                else if (rows == summaryIndex)
                {
                    g.FillRectangle(Brushes.DarkSeaGreen, x, y - 5, lineSize, CellSpacingY);
                    font = font_bold;
                }

                // Print row values
                PrintDataRow(g, cellStartX, y, xCellSpacing, font, brush, row);

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
        private void PrintDataRow(Graphics g, int x, int y, int xAdd, Font font, Brush brush, string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                PrintStringRight(g, strings[i], font, brush, x + (i * xAdd), y);
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


    }



}
