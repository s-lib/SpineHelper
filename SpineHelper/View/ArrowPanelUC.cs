using System;
using System.Windows.Forms;
using SpineHelper.Device;

namespace SpineHelper.View
{
    public partial class ArrowPanelUC : UserControl
    {
        public ArrowPanelUC()
        {
            InitializeComponent();
            UpdateAddToHistoryButton();
            GlobalEventManager.instance.AutoAddToHistorySwitched += UpdateAddToHistoryButton;
            checkBoxAutoAddToHistory.Checked = Settings.AutoAddToHistory;
        }


        private void buttonAddToHistory_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnAddToHistory(Spinetester.instance.CurrentArrow);
        }

        private void checkBoxAutoAddToHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked != Settings.AutoAddToHistory)
                GlobalEventManager.instance.OnAutoAddToHistorySwitched();
        }

        private void UpdateAddToHistoryButton()
        {
            buttonAddToHistory.Enabled = Settings.AutoAddToHistory == false;
        }
    }
}
