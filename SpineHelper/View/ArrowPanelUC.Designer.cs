namespace SpineHelper.View
{
    partial class ArrowPanelUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowPanelUC));
            this.panelTesting = new System.Windows.Forms.Panel();
            this.spineDetailsUC1 = new SpineHelper.View.SpineDetailsUC();
            this.weightTestUC1 = new SpineHelper.View.WeightTestUC();
            this.spineTestUC1 = new SpineHelper.View.SpineTestUC();
            this.checkBoxAutoAddToHistory = new System.Windows.Forms.CheckBox();
            this.buttonAddToHistory = new System.Windows.Forms.Button();
            this.toolTipAutoAdd = new System.Windows.Forms.ToolTip(this.components);
            this.panelTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTesting
            // 
            this.panelTesting.Controls.Add(this.spineDetailsUC1);
            this.panelTesting.Controls.Add(this.weightTestUC1);
            this.panelTesting.Controls.Add(this.spineTestUC1);
            this.panelTesting.Controls.Add(this.checkBoxAutoAddToHistory);
            this.panelTesting.Controls.Add(this.buttonAddToHistory);
            resources.ApplyResources(this.panelTesting, "panelTesting");
            this.panelTesting.Name = "panelTesting";
            // 
            // spineDetailsUC1
            // 
            resources.ApplyResources(this.spineDetailsUC1, "spineDetailsUC1");
            this.spineDetailsUC1.Name = "spineDetailsUC1";
            // 
            // weightTestUC1
            // 
            this.weightTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.weightTestUC1, "weightTestUC1");
            this.weightTestUC1.Name = "weightTestUC1";
            // 
            // spineTestUC1
            // 
            this.spineTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.spineTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.spineTestUC1, "spineTestUC1");
            this.spineTestUC1.Name = "spineTestUC1";
            // 
            // checkBoxAutoAddToHistory
            // 
            resources.ApplyResources(this.checkBoxAutoAddToHistory, "checkBoxAutoAddToHistory");
            this.checkBoxAutoAddToHistory.Name = "checkBoxAutoAddToHistory";
            this.toolTipAutoAdd.SetToolTip(this.checkBoxAutoAddToHistory, resources.GetString("checkBoxAutoAddToHistory.ToolTip"));
            this.checkBoxAutoAddToHistory.UseVisualStyleBackColor = true;
            this.checkBoxAutoAddToHistory.CheckedChanged += new System.EventHandler(this.checkBoxAutoAddToHistory_CheckedChanged);
            // 
            // buttonAddToHistory
            // 
            resources.ApplyResources(this.buttonAddToHistory, "buttonAddToHistory");
            this.buttonAddToHistory.Name = "buttonAddToHistory";
            this.buttonAddToHistory.UseVisualStyleBackColor = true;
            this.buttonAddToHistory.Click += new System.EventHandler(this.buttonAddToHistory_Click);
            // 
            // ArrowPanelUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelTesting);
            resources.ApplyResources(this, "$this");
            this.Name = "ArrowPanelUC";
            this.panelTesting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTesting;
        private System.Windows.Forms.CheckBox checkBoxAutoAddToHistory;
        private System.Windows.Forms.Button buttonAddToHistory;
        private WeightTestUC weightTestUC1;
        private SpineTestUC spineTestUC1;
        private SpineDetailsUC spineDetailsUC1;
        private System.Windows.Forms.ToolTip toolTipAutoAdd;
    }
}
