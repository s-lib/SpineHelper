using SpineHelper.History;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpineHelper.View.File
{
    public partial class PrintForm : Form
    {
        private PrintController pc;

        public PrintForm()
        {
            InitializeComponent();

            pc = new PrintController(HistoryManager.instance.CurrentSet);

            radioButtonMain.Select();
            checkBoxSummary.Checked = true;
            checkBoxLogo.Checked = true;
            checkBoxGrayscale.Checked = pc.Grayscale;
            LoadLogo();
            GetArrowSetName();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            UpdatePrintController();
            pc.Print();

            // Update checkbox to check if printing options didn't change
            checkBoxGrayscale.Checked = pc.Grayscale;
        }


        private void buttonPreview_Click(object sender, EventArgs e)
        {
            UpdatePrintController();
            pc.Preview();
        }

        private void UpdatePrintController()
        {
            pc.ArrowSetName = textBoxTitle.Text;
            pc.Details = radioButtonFull.Checked;
            pc.Summary = checkBoxSummary.Checked;
            pc.AddCustomLogo = checkBoxLogo.Checked;
            pc.Grayscale = checkBoxGrayscale.Checked;
        }


        private void buttonSelectLogo_Click(object sender, EventArgs e)
        {
            var load = new OpenFileDialog
            {
                InitialDirectory = Common.MainDirectory,
                Filter = GlobalStrings.PrintCustomLogoExtensions
            };

            if (load.ShowDialog() == DialogResult.OK)
            {
                LoadLogo(load.FileName, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetLogo();
        }

        private void ResetLogo()
        {
            Settings.CustomLogoFilename = string.Empty;
            pc.CustomLogo = null;
            pictureLogo.Image = null;
            UpdateLogoPreviewVisibility(false);
        }

        private void LoadLogo(string path = null, bool savePath = false)
        {
            if (path == null)
                path = Settings.CustomLogoFilename;


            if (System.IO.File.Exists(path))
            {
                try
                {
                    pc.CustomLogo = Image.FromFile(path);
                    if (savePath)
                        Settings.CustomLogoFilename = path;
                }
                catch
                {
                    if (savePath)
                        MessageBox.Show(GlobalStrings.PrintCustomLogoFail);
                }
            }
            pictureLogo.Image = pc.CustomLogo;
            UpdateLogoPreviewVisibility();
        }


        private void checkBoxLogo_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            buttonSelectLogo.Enabled = checkbox.Checked;
            UpdateLogoPreviewVisibility(checkbox.Checked);
            labelNoLogo.Enabled = checkbox.Checked;
            buttonResetLogo.Enabled = checkbox.Checked;
        }

        private void UpdateLogoPreviewVisibility(bool visible = true)
        {
            pictureLogo.Visible = pictureLogo.Image != null ? visible : false;
        }

        private void buttonTitleReset_Click(object sender, EventArgs e)
        {
            GetArrowSetName();
        }

        private void GetArrowSetName()
        {
            textBoxTitle.Text = GlobalStrings.PrintSetDefaultName;
        }

    }
}
