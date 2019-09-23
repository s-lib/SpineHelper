using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpineHelper.View.Options
{
    public partial class HistoryViewForm : Form
    {
        private Dictionary<CheckBox, History.Data.Column> visibleColumns;



        public HistoryViewForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            visibleColumns = new Dictionary<CheckBox, History.Data.Column>();
            InitializeControls();
        }



        private void InitializeControls()
        {
            History.Data.Column hiddenColumns = Settings.HistoryHiddenColumns;

            int y = 0;
            foreach (History.Data.Column column in Enum.GetValues(typeof(History.Data.Column)))
            {
                var cb = new CheckBox();
                cb.Text = column.ToString();
                // If has flag == hide
                cb.Checked = !hiddenColumns.HasFlag(column);
                panelVisibleColumns.Controls.Add(cb);
                visibleColumns.Add(cb, column);

                if (column == History.Data.Column.None || column == History.Data.Column.GPI)
                {
                    cb.Visible = false;
                    continue;
                }
                cb.Location = new Point(10, y);
                y += 25;
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnNeedRestart(object sender, EventArgs e)
        {
            labelRestart.Visible = true;
        }


        private void SaveAllSettings()
        {
            History.Data.Column columns = History.Data.Column.None;

            foreach(var cb in visibleColumns.Keys)
            {
                // If unchecked == hidden
                if (cb.Checked == false)
                {
                    columns |= visibleColumns[cb];
                }
            }
            Settings.HistoryHiddenColumns = columns;
            Settings.Save();
        }

    }
}
