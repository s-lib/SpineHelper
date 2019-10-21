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
                    var allCells = ws.Cells[1, 1, ws.Dimension.End.Row, ws.Dimension.End.Column];
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
                    SetTitleStyle(firstRow.Style);

                    worksheet.Cells[yOffset++, xOffset].Value = WorksheetName;


                    var secondRow = worksheet.Cells[yOffset, xOffset, yOffset, numColumns - 1 + xOffset];
                    secondRow.Merge = true;
                    secondRow.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    yOffset++;


                    // Format Headers
                    for (int column = 0; column < numColumns; column++)
                    {
                        SetHeaderColumn(worksheet.Column(column + xOffset), dataTable[column, 0]);
                        var style = worksheet.Cells[yOffset, column + xOffset].Style;
                        SetHeaderStyle(style);
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
                                var style = worksheet.Cells[row + yOffset, column + xOffset].Style;
                                SetSummaryStyle(style, row < numRows - 1);
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

        private void SetTitleStyle(ExcelStyle style)
        {
            style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            style.Fill.PatternType = ExcelFillStyle.Solid;
            style.Fill.BackgroundColor.SetColor(Color.PowderBlue);  //rgbPowderBlue
            style.Font.Bold = true;
        }

        private void SetHeaderColumn(ExcelColumn column, object columnData)
        {
            column.Style.Numberformat.Format = GetFormattingByColumnName(columnData);
            column.Width = GetColumnWidthByColumnName(columnData);
        }
        private void SetHeaderStyle(ExcelStyle style)
        {
            style.Font.Name = "Arial";
            style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            style.Fill.PatternType = ExcelFillStyle.Solid;
            style.Fill.BackgroundColor.SetColor(Color.FromArgb(154, 34, 34)); //rgbBrown
            style.Font.Color.SetColor(Color.White);
        }

        private void SetSummaryStyle(ExcelStyle style, bool bold)
        {
            style.Fill.PatternType = ExcelFillStyle.Solid;
            style.Fill.BackgroundColor.SetColor(Color.FromArgb(215, 228, 188));
            style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            style.Font.Bold = bold;
        }
    }



}
