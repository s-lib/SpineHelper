using System;
using System.Drawing;
using Microsoft.Office.Interop.Excel;

namespace SpineHelper.Export
{
    public class ExportExcel : IExportFormat
    {

        private string WorksheetName = GlobalStrings.Arrows;

        public ExportExcel()
        {
        }

        public virtual string ExportDataToFile(object[,] dataTable, string filename)
        {

            _Application excel = new Application();
            excel.StandardFont = "Calibri";
            excel.StandardFontSize = 11;
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = WorksheetName;
                worksheet.Columns.ColumnWidth = 6;


                int xOffset = 2; //Should be at least 1 (excel starts at (1,1)
                int yOffset = 2; //Should be at least 1 (excel starts at (1,1)

                int numColumns = dataTable.GetLength(0);
                int numRows = dataTable.GetLength(1);

                var firstRow = worksheet.Range[worksheet.Cells[yOffset, xOffset], worksheet.Cells[yOffset, numColumns - 1 + xOffset]];
                firstRow.Merge(true);
                firstRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                firstRow.Interior.Color = XlRgbColor.rgbPowderBlue;
                firstRow.Font.Bold = true;
                worksheet.Cells[yOffset++, xOffset] = WorksheetName;

                var secondRow = worksheet.Range[worksheet.Cells[yOffset, xOffset], worksheet.Cells[yOffset, numColumns - 1 + xOffset]];
                secondRow.Merge(true);
                secondRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                yOffset++;

                // Format Headers
                for (int column = 0; column < numColumns; column++)
                {
                    worksheet.Columns[column + xOffset].NumberFormat = GetFormattingByColumnName(dataTable[column, 0]);
                    worksheet.Columns[column + xOffset].ColumnWidth = GetColumnWidthByColumnName(dataTable[column, 0]);

                    worksheet.Cells[yOffset, column + xOffset].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[yOffset, column + xOffset].Interior.Color = XlRgbColor.rgbBrown;
                    worksheet.Cells[yOffset, column + xOffset].Font.Color = XlRgbColor.rgbWhite;

                    worksheet.Cells[yOffset, column + xOffset].Font.Name = "Arial";
                }

                // Copy data
                for (int row = 0; row < numRows; row++)
                {
                    for (int column = 0; column < numColumns; column++)
                    {
                        var obj = dataTable[column, row];
                        //var cell = worksheet.Cells[row + yOffset, column + xOffset];

                        if (obj != null)
                            worksheet.Cells[row + yOffset, column + xOffset] = obj;

                        // Summary rows
                        if (row >= numRows - 2 && obj != null)
                        {
                            worksheet.Cells[row + yOffset, column + xOffset].Interior.Color = Color.FromArgb(215, 228, 188);
                            worksheet.Cells[row + yOffset, column + xOffset].HorizontalAlignment = XlHAlign.xlHAlignRight;
                            if (row < numRows - 1)
                                worksheet.Cells[row + yOffset, column + xOffset].Font.Bold = true;
                        }
                    }
                }

                // Summary rows end

                workbook.SaveAs(filename);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private string GetFormattingByColumnName(object columnData)
        {
            if (columnData == null) return string.Empty;

            if (columnData.ToString() == GlobalStrings.HistoryViewColumnStraightness)
                return "0,000";

            if (columnData.ToString() == GlobalStrings.HistoryViewColumnGrams)
                return "0,0";

            if (columnData.ToString() == GlobalStrings.HistoryViewColumnGPI)
                return "0,0";

            return string.Empty;
        }

        private double GetColumnWidthByColumnName(object columnData)
        {
            if (columnData == null) return 8;

            String name = columnData.ToString();

            if (name == "ID") return 2;
            if (name == "ASTM") return 8.5;
            if (name == "AMO") return 6.8;
            if (name == GlobalStrings.HistoryViewColumnGrains) return 8;
            if (name == GlobalStrings.HistoryViewColumnGrams) return 8.5;
            if (name == GlobalStrings.HistoryViewColumnStraightness) return 11;
            if (name == GlobalStrings.HistoryViewColumnComment) return 25;
            if (name == GlobalStrings.HistoryViewColumnGPI) return 7;

            return 10;
        }


        private void CreateTestColorPalette(_Worksheet worksheet, int startX, int startY)
        {
            // Color test
            int i = 0;
            foreach (var item in Enum.GetNames(typeof(XlRgbColor)))
            {
                worksheet.Cells[i + startY, startX].Interior.Color = (XlRgbColor)Enum.Parse(typeof(XlRgbColor), item);
                worksheet.Cells[i + startY, startX + 1] = item;
                i++;
            }
        }
    }



}
