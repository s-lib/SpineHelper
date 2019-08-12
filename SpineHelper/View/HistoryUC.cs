using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SpineHelper.History;
using SpineHelper.Device;
using SpineHelper.Export;

namespace SpineHelper.View
{
    public partial class HistoryUC : UserControl
    {
        private SaveFileDialog save = new SaveFileDialog();
        private OpenFileDialog load = new OpenFileDialog();
        private ArrowSet currentSet = new ArrowSet();

        private DataGridViewColumnSelector columnSelector;

        public HistoryUC()
        {
            InitializeComponent();


            TranslateDataGridView();
            Spinetester.instance.ArrowTaken += OnArrowTaken;

            columnSelector = new DataGridViewColumnSelector(historyView);

            GlobalEventManager.instance.AddToHistory += AddArrow;
            GlobalEventManager.instance.RemoveFromHistory += OnRemoveFromHistory;
            GlobalEventManager.instance.ClearHistory += OnClearHistory;
            GlobalEventManager.instance.ExportHistory += OnExportHistory;

            GlobalEventManager.instance.SaveHistory += OnSaveHistory;
            GlobalEventManager.instance.LoadHistory += OnLoadHistory;

            SetHistoryViewColumnVisibility();

            //var r = new System.Random(System.DateTime.Now.Millisecond);

            //while (CurrentSet.Index < 50)
            //{
            //    ArrowData newArrow = new ArrowData();
            //    newArrow.Spine.Value1 = r.Next(30, 40);
            //    newArrow.Spine.Value2 = r.Next(30, 40);
            //    newArrow.Weight.Left = r.Next(100, 200);
            //    newArrow.Weight.Right = r.Next(100, 200);
            //    newArrow.Straightness.Set(new double[] { 0.01 });

            //    AddArrow(newArrow);
            //}
        }



        public void OnSaveHistory()
        {
            if (currentSet.ArrowCount < 1)
            {
                MessageBox.Show(GlobalStrings.NoDataToExport);
                return;
            }

            save.InitialDirectory = DataSerializer.SaveDirectory;
            save.Title = GlobalStrings.SerializerSaveToFile;
            save.FileName = "";
            save.Filter = DataSerializer.SaveFormat;
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                var serializer = new DataSerializer();
                serializer.SaveFailed += OnFailed;
                serializer.SaveSuccessful += OnSaveSuccessful;
                serializer.SaveToFile(currentSet, save.FileName);
            }
        }

        public void OnLoadHistory()
        {
            var dr = DialogResult.Yes;
            if (currentSet.ArrowCount > 0)
            {
                dr = MessageBox.Show(
                GlobalStrings.SerializerLoadWarning,
                GlobalStrings.SerializerLoadWarningHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            }

            if (dr == DialogResult.Yes)
            {
                load.InitialDirectory = DataSerializer.SaveDirectory;
                load.Title = GlobalStrings.SerializerOpenFile;
                load.FileName = "";
                load.Filter = DataSerializer.SaveFormat;
                if (load.ShowDialog() != DialogResult.Cancel)
                {
                    ClearHistory();
                    var serializer = new DataSerializer();
                    serializer.LoadFailed += OnFailed;
                    serializer.LoadSuccessful  += OnLoadSuccessful;
                    serializer.LoadFromFile(ref currentSet, load.FileName);

                    foreach (var arrow in currentSet.Arrows)
                    {
                        AddArrowToView(arrow);
                    }
                }
            }
        }


        private void ClearHistoryView()
        {
            historyView.Rows.Clear();
            historyView.Refresh();
        }

        private void ReloadHistoryView()
        {
            ClearHistoryView();
            foreach (var arrow in currentSet.Arrows)
            {
                AddArrowToView(arrow);
            }
        }

        private void AddArrowToView(ArrowData arrow)
        {
            if (historyView.InvokeRequired)
            {
                var d = new Action<ArrowData>(AddArrowToView);
                Invoke(d, new object[] { arrow });
            }
            else
            {
                historyView.Rows.Add(arrow.ToArray());
            }
        }



        private void historyView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && historyView.Columns[e.ColumnIndex].Name == "Comment")
            {
                // TODO: clean unused debug messages
                //Debug.WriteLine("Cell value changed for row " + e.RowIndex + ", column " + e.ColumnIndex);
                //Debug.WriteLine("New value= " + historyView[e.ColumnIndex, e.RowIndex].Value.ToString());
                //var arrow = HistoryManager.instance.CurrentSet.GetArrow((int)historyView["ID", e.RowIndex].Value - 1);
                var arrow = currentSet.GetArrow((int)historyView["ID", e.RowIndex].Value - 1);
                var value = historyView[e.ColumnIndex, e.RowIndex].Value;

                if (arrow != null)
                {
                    string data = value != null ? value.ToString() : string.Empty;
                    arrow.SetDataByName(historyView.Columns[e.ColumnIndex].Name, data);
                    //arrow.Comment = historyView[e.ColumnIndex, e.RowIndex].Value.ToString();
                    //System.Diagnostics.Debug.WriteLine("ARROW " + arrow.Index + " UPDATED COMMENT=== " + arrow.Comment);
                }
            }
        }


        private void OnArrowTaken(ArrowData arrow)
        {
            if (Properties.Settings.Default.AutoAddToHistory)
            {
                AddArrow(arrow);
            }
        }

        public void AddArrow(ArrowData arrow)
        {
            if (arrow.BasicTestDone && currentSet.Contains(arrow) == false)
            {
                currentSet.AddArrow(arrow);
                AddArrowToView(arrow);
            }
        }


        public void OnRemoveFromHistory()
        {
            if (historyView.Rows.Count > 0)
            {
                var dr = DialogResult.Yes;
                if (Settings.HistoryRemoveConfirmation)
                {
                    dr = MessageBox.Show(
                    GlobalStrings.HistoryRemoveEntry,
                    GlobalStrings.HistoryRemoveEntryHeader,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                }

                if (dr == DialogResult.Yes)
                {
                    int id = currentSet.RemoveLast();
                    if (id > 0)
                    {
                        for (int i = 0; i < historyView.Rows.Count; i++)
                        {
                            if ((int)historyView.Rows[i].Cells["ID"].Value == id)
                            {
                                historyView.Rows.RemoveAt(i);
                                break;
                            }
                        }
                        historyView.Refresh();
                    }
                }
            }
        }

        public void OnClearHistory()
        {
            var dr = DialogResult.Yes;
            if (Settings.HistoryClearConfirmation && currentSet.ArrowCount > 0)
            {
                dr = MessageBox.Show(
                GlobalStrings.HistoryClear,
                GlobalStrings.HistoryClearHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            }

            if (dr == DialogResult.Yes)
                ClearHistory();
        }

        private void ClearHistory()
        {
            ClearHistoryView();
            currentSet.Clear();
        }

        public void OnExportHistory()
        {
            if (currentSet.ArrowCount < 1)
            {
                MessageBox.Show(GlobalStrings.NoDataToExport);
                return;
            }
            save.InitialDirectory = DataExporter.ExportDirectory;
            save.Title = GlobalStrings.SerializerExportToFile;
            save.FileName = "";
            save.Filter = DataExporter.AvailableExportFormats;
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                var dataConverter = new DataConverter(currentSet, historyView);
                var dataExporter = new DataExporter(save.FilterIndex);
                dataExporter.ExportFailed += OnFailed;
                dataExporter.ExportSuccessful += OnExportSuccessful;
                dataExporter.ExportToFile(dataConverter.ConvertToArray(true), save.FileName);
            }
        }

        private void OnExportSuccessful()
        {
            if (Settings.SaveLoadConfirmation)
                MessageBox.Show(GlobalStrings.SerializerExportSuccessful,
                    GlobalStrings.SerializerExportSuccessfulHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnSaveSuccessful()
        {
            if (Settings.SaveLoadConfirmation)
                MessageBox.Show(GlobalStrings.SerializerSaveSuccessful,
                    GlobalStrings.SerializerSaveSuccessfulHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnLoadSuccessful()
        {
            if (Settings.SaveLoadConfirmation)
                MessageBox.Show(GlobalStrings.SerializerLoadSuccessful,
                    GlobalStrings.SerializerLoadSuccessfulHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnFailed(string message)
        {
            MessageBox.Show(message, GlobalStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }






        private void TranslateDataGridView()
        {
            historyView.Columns["Grams"].HeaderText = GlobalStrings.HistoryViewColumnGrams;
            historyView.Columns["Grains"].HeaderText = GlobalStrings.HistoryViewColumnGrains;
            historyView.Columns["Straightness"].HeaderText = GlobalStrings.HistoryViewColumnStraightness;
            historyView.Columns["Comment"].HeaderText = GlobalStrings.HistoryViewColumnComment;
            historyView.Columns["AMO1"].HeaderText = GlobalStrings.HistoryViewColumnAMO1;
            historyView.Columns["AMO2"].HeaderText = GlobalStrings.HistoryViewColumnAMO2;
            historyView.Columns["ASTM1"].HeaderText = GlobalStrings.HistoryViewColumnASTM1;
            historyView.Columns["ASTM2"].HeaderText = GlobalStrings.HistoryViewColumnASTM2;
        }

        private void SetHistoryViewColumnVisibility()
        {
            int index = 0;
            var flags = Settings.HistoryHiddenColumns;
            var columns = Enum.GetValues(typeof(History.Data.Column));

            foreach (History.Data.Column c in columns)
            {
                int i = index - 1;

                if (i > 0 && i < historyView.ColumnCount)
                {
                    if (flags.HasFlag(c))
                        historyView.Columns[i].Visible = false;
                }
                index++;
            }
        }

        private void removeArrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyView.SelectedRows.Count > 0)
            {
                var rows = new List<int>();
                foreach (DataGridViewRow row in historyView.SelectedRows)
                {
                    rows.Add(row.Index);
                }
                rows.Sort();

                var dr = MessageBox.Show(
                GlobalStrings.HistoryViewRemoveArrowsConfirmation,
                GlobalStrings.HistoryRemoveEntryHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    for (int i = rows.Count - 1; i >= 0; i--)
                    {
                        int id = (int)historyView.Rows[rows[i]].Cells["ID"].Value;
                        currentSet.RemoveByID(id);
                        historyView.Rows.RemoveAt(rows[i]);
                        //Console.WriteLine("Removing arrow with ID: " + id + " from column no." + rows[i]);
                    }
                    historyView.Refresh();
                }


            }
        }

        private void historyView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex == -1)
            {
                if (historyView.SelectedRows.Count > 0)
                {
                    removeArrowToolStripMenuItem.Text = historyView.SelectedRows.Count > 1 ?
                        GlobalStrings.HistoryViewRemoveArrows : GlobalStrings.HistoryViewRemoveArrow;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
