using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.History;

namespace SpineHelper.Export
{
    public class DataConverter
    {
        private readonly ArrowSet arrowSet;
        private readonly DataGridView dataGrid;

        public DataConverter(ArrowSet arrowSet, DataGridView dataGrid)
        {
            this.arrowSet = arrowSet;
            this.dataGrid = dataGrid;
        }


        public object[,] ConvertToArray(bool useDisplayOrder = false)
        {
            var columns = GetDataGridVisibleColumns(dataGrid);

            bool addSummary = true; //TODO: export, make into an option when saving

            int rowCount = dataGrid.RowCount + (addSummary ? 3 : 1);

            if (useDisplayOrder)
                columns = columns.OrderBy(c => c.DisplayIndex).ToList();

            object[,] dataTable = new object[columns.Count, rowCount];

            // Copy headers as first row, and summary as last
            int i = 0;
            foreach (var c in columns)
            {
                // Headers
                dataTable[i, 0] = dataGrid.Columns[c.Name].HeaderText;

                // Last row, summary
                if (addSummary)
                {
                    dataTable[i, rowCount - 2] = arrowSet.GetSummary(c.Name);
                    dataTable[i, rowCount - 1] = arrowSet.GetSummary(c.Name, true);
                }
                i++;
            }

            // Copy data
            for (int row = 0; row < dataGrid.RowCount; row++)
            {
                i = 0;
                foreach (var c in columns)
                    dataTable[i++, row + 1] = arrowSet.GetArrow(row).GetDataByName(c.Name); //dataTable[i++, row + 1] = dataGrid[c.Name, row].Value;
            }

            return dataTable;
        }



        private List<DataGridViewColumn> GetDataGridVisibleColumns(DataGridView dataGrid)
        {
            var columns = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn c in dataGrid.Columns)
                if (c.Visible)
                    columns.Add(c);

            return columns;
        }
    }
}
