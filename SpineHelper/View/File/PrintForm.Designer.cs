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
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.buttonSelectLogo = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBoxLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(317, 88);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(121, 23);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(317, 131);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(121, 23);
            this.buttonPreview.TabIndex = 1;
            this.buttonPreview.Text = "Print Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // checkBoxLogo
            // 
            this.checkBoxLogo.AutoSize = true;
            this.checkBoxLogo.Location = new System.Drawing.Point(23, 216);
            this.checkBoxLogo.Name = "checkBoxLogo";
            this.checkBoxLogo.Size = new System.Drawing.Size(142, 21);
            this.checkBoxLogo.TabIndex = 2;
            this.checkBoxLogo.Text = "Add Custom Logo";
            this.checkBoxLogo.UseVisualStyleBackColor = true;
            this.checkBoxLogo.CheckedChanged += new System.EventHandler(this.checkBoxLogo_CheckedChanged);
            // 
            // checkBoxSummary
            // 
            this.checkBoxSummary.AutoSize = true;
            this.checkBoxSummary.Location = new System.Drawing.Point(33, 131);
            this.checkBoxSummary.Name = "checkBoxSummary";
            this.checkBoxSummary.Size = new System.Drawing.Size(118, 21);
            this.checkBoxSummary.TabIndex = 3;
            this.checkBoxSummary.Text = "Add Summary";
            this.checkBoxSummary.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.radioButtonFull);
            this.groupBoxOutput.Controls.Add(this.radioButtonMain);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(237, 99);
            this.groupBoxOutput.TabIndex = 5;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Print type";
            // 
            // radioButtonFull
            // 
            this.radioButtonFull.AutoSize = true;
            this.radioButtonFull.Location = new System.Drawing.Point(21, 59);
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.Size = new System.Drawing.Size(96, 21);
            this.radioButtonFull.TabIndex = 1;
            this.radioButtonFull.TabStop = true;
            this.radioButtonFull.Text = "Full details";
            this.radioButtonFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonMain
            // 
            this.radioButtonMain.AutoSize = true;
            this.radioButtonMain.Location = new System.Drawing.Point(21, 32);
            this.radioButtonMain.Name = "radioButtonMain";
            this.radioButtonMain.Size = new System.Drawing.Size(176, 21);
            this.radioButtonMain.TabIndex = 0;
            this.radioButtonMain.TabStop = true;
            this.radioButtonMain.Text = "Only main info (default)";
            this.radioButtonMain.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // buttonSelectLogo
            // 
            this.buttonSelectLogo.Location = new System.Drawing.Point(6, 21);
            this.buttonSelectLogo.Name = "buttonSelectLogo";
            this.buttonSelectLogo.Size = new System.Drawing.Size(121, 23);
            this.buttonSelectLogo.TabIndex = 6;
            this.buttonSelectLogo.Text = "Browse";
            this.buttonSelectLogo.UseVisualStyleBackColor = true;
            this.buttonSelectLogo.Click += new System.EventHandler(this.buttonSelectLogo_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Location = new System.Drawing.Point(10, 52);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(450, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.Controls.Add(this.buttonSelectLogo);
            this.groupBoxLogo.Controls.Add(this.pictureLogo);
            this.groupBoxLogo.Location = new System.Drawing.Point(23, 243);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Size = new System.Drawing.Size(473, 216);
            this.groupBoxLogo.TabIndex = 8;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Text = "Custom Logo";
            // 
            // PrintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(519, 471);
            this.Controls.Add(this.groupBoxLogo);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.checkBoxSummary);
            this.Controls.Add(this.checkBoxLogo);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBoxLogo.ResumeLayout(false);
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
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button buttonSelectLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.GroupBox groupBoxLogo;
    }
}