using System;
using System.Windows.Forms;

namespace SpineHelper.View
{
    public partial class HistoryControlsUC : UserControl
    {
        public HistoryControlsUC()
        {
            InitializeComponent();
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnClearHistory();
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnRemoveFromHistory();
        }

        private void buttonExportHistory_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnExportHistory();
        }
    }
}
