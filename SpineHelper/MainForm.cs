using System;
using System.Windows.Forms;

namespace SpineHelper
{
    public partial class MainForm : Form
    {
        //protected override void OnLoad(EventArgs e)
        //{
        //    this.Font = new Font(this.Font.FontFamily, this.Font.Size * 120 / 96);
        //    base.OnLoad(e);
        //}


        public MainForm()
        {
            InitializeComponent();

            this.Text = Common.MainFormName;

            GlobalEventManager.instance.ExitApplication += () => { this.Close(); };

            Settings.LoadMainFormState(this);
            FormClosing += MainForm_FormClosing;
            Shown += MainForm_Shown;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Settings.CheckInstalledVersion();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SaveFormState(this);
        }
    }


    
}
