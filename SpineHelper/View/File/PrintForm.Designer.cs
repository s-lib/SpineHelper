namespace SpineHelper.View.File
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.checkBoxLogo = new System.Windows.Forms.CheckBox();
            this.checkBoxSummary = new System.Windows.Forms.CheckBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.radioButtonMain = new System.Windows.Forms.RadioButton();
            this.buttonSelectLogo = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonTitleReset = new System.Windows.Forms.Button();
            this.buttonResetLogo = new System.Windows.Forms.Button();
            this.labelNoLogo = new System.Windows.Forms.Label();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = global::SpineHelper.Properties.Resources.icon_print;
            resources.ApplyResources(this.buttonPrint, "buttonPrint");
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Image = global::SpineHelper.Properties.Resources.icon_print_preview;
            resources.ApplyResources(this.buttonPreview, "buttonPreview");
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // checkBoxLogo
            // 
            resources.ApplyResources(this.checkBoxLogo, "checkBoxLogo");
            this.checkBoxLogo.Name = "checkBoxLogo";
            this.checkBoxLogo.UseVisualStyleBackColor = true;
            this.checkBoxLogo.CheckedChanged += new System.EventHandler(this.checkBoxLogo_CheckedChanged);
            // 
            // checkBoxSummary
            // 
            resources.ApplyResources(this.checkBoxSummary, "checkBoxSummary");
            this.checkBoxSummary.Name = "checkBoxSummary";
            this.checkBoxSummary.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.radioButtonFull);
            this.groupBoxOutput.Controls.Add(this.radioButtonMain);
            resources.ApplyResources(this.groupBoxOutput, "groupBoxOutput");
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.TabStop = false;
            // 
            // radioButtonFull
            // 
            resources.ApplyResources(this.radioButtonFull, "radioButtonFull");
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.TabStop = true;
            this.radioButtonFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonMain
            // 
            resources.ApplyResources(this.radioButtonMain, "radioButtonMain");
            this.radioButtonMain.Name = "radioButtonMain";
            this.radioButtonMain.TabStop = true;
            this.radioButtonMain.UseVisualStyleBackColor = true;
            // 
            // buttonSelectLogo
            // 
            resources.ApplyResources(this.buttonSelectLogo, "buttonSelectLogo");
            this.buttonSelectLogo.Name = "buttonSelectLogo";
            this.buttonSelectLogo.UseVisualStyleBackColor = true;
            this.buttonSelectLogo.Click += new System.EventHandler(this.buttonSelectLogo_Click);
            // 
            // pictureLogo
            // 
            resources.ApplyResources(this.pictureLogo, "pictureLogo");
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.TabStop = false;
            // 
            // textBoxTitle
            // 
            resources.ApplyResources(this.textBoxTitle, "textBoxTitle");
            this.textBoxTitle.Name = "textBoxTitle";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // buttonTitleReset
            // 
            resources.ApplyResources(this.buttonTitleReset, "buttonTitleReset");
            this.buttonTitleReset.Name = "buttonTitleReset";
            this.buttonTitleReset.UseVisualStyleBackColor = true;
            this.buttonTitleReset.Click += new System.EventHandler(this.buttonTitleReset_Click);
            // 
            // buttonResetLogo
            // 
            resources.ApplyResources(this.buttonResetLogo, "buttonResetLogo");
            this.buttonResetLogo.Name = "buttonResetLogo";
            this.buttonResetLogo.UseVisualStyleBackColor = true;
            this.buttonResetLogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNoLogo
            // 
            resources.ApplyResources(this.labelNoLogo, "labelNoLogo");
            this.labelNoLogo.Name = "labelNoLogo";
            // 
            // PrintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.buttonResetLogo);
            this.Controls.Add(this.buttonSelectLogo);
            this.Controls.Add(this.buttonTitleReset);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.checkBoxSummary);
            this.Controls.Add(this.checkBoxLogo);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelNoLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PrintForm";
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.CheckBox checkBoxLogo;
        private System.Windows.Forms.CheckBox checkBoxSummary;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.RadioButton radioButtonFull;
        private System.Windows.Forms.RadioButton radioButtonMain;
        private System.Windows.Forms.Button buttonSelectLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonTitleReset;
        private System.Windows.Forms.Button buttonResetLogo;
        private System.Windows.Forms.Label labelNoLogo;
    }
}