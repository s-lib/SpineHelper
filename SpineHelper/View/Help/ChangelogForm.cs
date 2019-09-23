using SpineHelper.Properties;
using System;
using System.Windows.Forms;

namespace SpineHelper.View.Help
{
    public partial class ChangelogForm : Form
    {
        public ChangelogForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            switch (Settings.UILanguage)
            {
                case Settings.Language.Polski:
                    textBoxChangelog.Text = Resources.ChangelogPL;
                    break;
                default:
                    textBoxChangelog.Text = Resources.Changelog;
                    break;
            }
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
