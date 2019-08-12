namespace SpineHelper.View.Device
{
    partial class HistoryViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryViewForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.panelVisibleColumns = new System.Windows.Forms.Panel();
            this.labelRestart = new System.Windows.Forms.Label();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxGeneral
            // 
            resources.ApplyResources(this.groupBoxGeneral, "groupBoxGeneral");
            this.groupBoxGeneral.Controls.Add(this.panelVisibleColumns);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.TabStop = false;
            // 
            // panelVisibleColumns
            // 
            resources.ApplyResources(this.panelVisibleColumns, "panelVisibleColumns");
            this.panelVisibleColumns.Name = "panelVisibleColumns";
            // 
            // labelRestart
            // 
            resources.ApplyResources(this.labelRestart, "labelRestart");
            this.labelRestart.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelRestart.Name = "labelRestart";
            // 
            // HistoryViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistoryViewForm";
            this.groupBoxGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Panel panelVisibleColumns;
    }
}