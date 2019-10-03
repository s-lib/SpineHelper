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
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.radioButtonMain = new System.Windows.Forms.RadioButton();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBoxOutput.SuspendLayout();
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
            this.checkBoxLogo.Location = new System.Drawing.Point(33, 171);
            this.checkBoxLogo.Name = "checkBoxLogo";
            this.checkBoxLogo.Size = new System.Drawing.Size(91, 21);
            this.checkBoxLogo.TabIndex = 2;
            this.checkBoxLogo.Text = "Add Logo";
            this.checkBoxLogo.UseVisualStyleBackColor = true;
            // 
            // checkBoxSummary
            // 
            this.checkBoxSummary.AutoSize = true;
            this.checkBoxSummary.Location = new System.Drawing.Point(33, 198);
            this.checkBoxSummary.Name = "checkBoxSummary";
            this.checkBoxSummary.Size = new System.Drawing.Size(118, 21);
            this.checkBoxSummary.TabIndex = 3;
            this.checkBoxSummary.Text = "Add Summary";
            this.checkBoxSummary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(33, 225);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(127, 21);
            this.checkBoxLines.TabIndex = 4;
            this.checkBoxLines.Text = "Draw Cell Lines";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.radioButtonFull);
            this.groupBoxOutput.Controls.Add(this.radioButtonMain);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(237, 142);
            this.groupBoxOutput.TabIndex = 5;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Data";
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
            // PrintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(498, 340);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.checkBoxLines);
            this.Controls.Add(this.checkBoxSummary);
            this.Controls.Add(this.checkBoxLogo);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonPrint);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.CheckBox checkBoxLogo;
        private System.Windows.Forms.CheckBox checkBoxSummary;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.RadioButton radioButtonFull;
        private System.Windows.Forms.RadioButton radioButtonMain;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}