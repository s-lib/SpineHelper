using System;
using System.Windows.Forms;

namespace SpineHelper.View.Options
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeControls();
        }

        private void InitializeControls()
        {
            labelRestart.Visible = false;
            buttonRestart.Enabled = false;

            checkBoxAutoUpdates.Checked = Settings.AutoUpdates;
            comboBoxColorScheme.SelectedIndex = 0;
            comboBoxResultsSize.SelectedIndex = 0;
            checkBoxDebugMode.Checked = Settings.DebugMode;

            foreach (var l in Enum.GetNames(typeof(Settings.Language)))
            {
                comboBoxLanguage.Items.Add(l);
            }
            comboBoxLanguage.SelectedIndex = Settings.UILanguageIndex;

            comboBoxColorScheme.SelectedValueChanged += OnNeedRestart;
            comboBoxResultsSize.SelectedValueChanged += OnNeedRestart;
            comboBoxLanguage.SelectedValueChanged += OnNeedRestart;

            checkBoxNotifySaveLoad.Checked = Settings.SaveLoadConfirmation;
            checkBoxConfirmHistoryClear.Checked = Settings.HistoryClearConfirmation;
            checkBoxConfirmHistoryRemove.Checked = Settings.HistoryRemoveConfirmation;
            checkBoxSimplifiedConnection.Checked = Settings.SimplifiedConnectionInfo;
        }


        private void buttonRestart_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            Application.Restart();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Versioning.CheckForUpdates(true);
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
            buttonRestart.Enabled = true;
        }


        private void SaveAllSettings()
        {
            Settings.AutoUpdates = checkBoxAutoUpdates.Checked;
            Settings.DebugMode = checkBoxDebugMode.Checked;

            Settings.SaveLoadConfirmation = checkBoxNotifySaveLoad.Checked;
            Settings.HistoryClearConfirmation = checkBoxConfirmHistoryClear.Checked;
            Settings.HistoryRemoveConfirmation = checkBoxConfirmHistoryRemove.Checked;
            Settings.SimplifiedConnectionInfo = checkBoxSimplifiedConnection.Checked;


            Settings.Save();
            Settings.SetLanguage(comboBoxLanguage.SelectedIndex);
        }
    }
}
