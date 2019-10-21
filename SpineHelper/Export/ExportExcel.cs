using System;
using System.Drawing;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

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
            using (var p = new ExcelPackage())
            {
                try
                {
                    var worksheet = p.Workbook.Worksheets.Add(WorksheetName);

                    // Set default font
                    /*
                    var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                    var cellFont = allCells.Style.Font;
                    cellFont.SetFromFont(new Font("Calibri", 11));
                    */

                    // Set default column size
                    for (int i = 1; i <= 20; i++)
                        worksheet.Column(i).Width = 6.6;


                    int xOffset = 2; //Should be at least 1 (excel starts at (1,1)
                    int yOffset = 2; //Should be at least 1 (excel starts at (1,1)

                    int numColumns = dataTable.GetLength(0);
                    int numRows = dataTable.GetLength(1);

                    var firstRow = worksheet.Cells[yOffset, xOffset, yOffset, numColumns - 1 + xOffset];
                    firstRow.Merge = true;
                    firstRow.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    firstRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    firstRow.Style.Fill.BackgroundColor.SetColor(Color.PowderBlue);  //rgbPowderBlue
                    firstRow.Style.Font.Bold = true;


                    worksheet.Cells[yOffset++, xOffset].Value = WorksheetName;


                    var secondRow = worksheet.Cells[yOffset, xOffset, yOffset, numColumns - 1 + xOffset];
                    secondRow.Merge = true;
                    secondRow.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    yOffset++;


                    // Format Headers
                    for (int column = 0; column < numColumns; column++)
                    {
                        worksheet.Column(column + xOffset).Style.Numberformat.Format = GetFormattingByColumnName(dataTable[column, 0]);
                        worksheet.Column(column + xOffset).Width = GetColumnWidthByColumnName(dataTable[column, 0]);

                        worksheet.Cells[yOffset, column + xOffset].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[yOffset, column + xOffset].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[yOffset, column + xOffset].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(154, 34, 34)); //rgbBrown
                        worksheet.Cells[yOffset, column + xOffset].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells[yOffset, column + xOffset].Style.Font.Name = "Arial";
                    }

                    // Copy data
                    for (int row = 0; row < numRows; row++)
                    {
                        for (int column = 0; column < numColumns; column++)
                        {
                            var obj = dataTable[column, row];
                            //var cell = worksheet.Cells[row + yOffset, column + xOffset];

                            if (obj != null)
                                worksheet.Cells[row + yOffset, column + xOffset].Value = obj;

                            // Summary rows
                            if (row >= numRows - 2 && obj != null)
                            {
                                worksheet.Cells[row + yOffset, column + xOffset].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[row + yOffset, column + xOffset].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(215, 228, 188));
                                worksheet.Cells[row + yOffset, column + xOffset].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                                if (row < numRows - 1)
                                    worksheet.Cells[row + yOffset, column + xOffset].Style.Font.Bold = true;
                            }
                        }
                    }

                    p.SaveAs(new FileInfo(filename));
                    return null;

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
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
            if (columnData == null) return 8.6;

            String name = columnData.ToString();

            if (name == "ID") return 2.6;
            if (name == "ASTM") return 9.1;
            if (name == "AMO") return 7.4;
            if (name == GlobalStrings.HistoryViewColumnGrains) return 8.6;
            if (name == GlobalStrings.HistoryViewColumnGrams) return 9.1;
            if (name == GlobalStrings.HistoryViewColumnStraightness) return 11.6;
            if (name == GlobalStrings.HistoryViewColumnComment) return 25.6;
            if (name == GlobalStrings.HistoryViewColumnGPI) return 7.6;

            return 10.6;
        }



    }



}
