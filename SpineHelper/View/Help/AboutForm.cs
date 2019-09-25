using System;
using System.Diagnostics;
using System.Windows.Forms;
using SpineHelper.Data;

namespace SpineHelper.View.Help
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            linkLabelWeb.Text = URLs.SpinetesterPageText;
            labelVersion.Text = Versioning.Version;
            labelBuilt.Text = labelBuilt.Text + Common.BuildDate.ToString("dd MMMM yyyy");
            labelCopyright.Text = labelCopyright.Text + Common.BuildDate.ToString("yyyy");
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl(URLs.SpinetesterPage);
        }

        private void linkLabelForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl(GlobalStrings.ForumsURL);
        }


        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(GlobalStrings.ErrorOpeningWebPage + ex.Message, GlobalStrings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
