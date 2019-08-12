namespace SpineHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.arrowPanel1 = new SpineHelper.View.ArrowPanelUC();
            this.historyControlsUC1 = new SpineHelper.View.HistoryControlsUC();
            this.menuUC1 = new SpineHelper.View.MenuUC();
            this.historyUC1 = new SpineHelper.View.HistoryUC();
            this.connectionUC1 = new SpineHelper.View.ConnectionUC();
            this.SuspendLayout();
            // 
            // arrowPanel1
            // 
            resources.ApplyResources(this.arrowPanel1, "arrowPanel1");
            this.arrowPanel1.Name = "arrowPanel1";
            // 
            // historyControlsUC1
            // 
            resources.ApplyResources(this.historyControlsUC1, "historyControlsUC1");
            this.historyControlsUC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.historyControlsUC1.Name = "historyControlsUC1";
            // 
            // menuUC1
            // 
            resources.ApplyResources(this.menuUC1, "menuUC1");
            this.menuUC1.Name = "menuUC1";
            // 
            // historyUC1
            // 
            resources.ApplyResources(this.historyUC1, "historyUC1");
            this.historyUC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.historyUC1.Name = "historyUC1";
            // 
            // connectionUC1
            // 
            resources.ApplyResources(this.connectionUC1, "connectionUC1");
            this.connectionUC1.Name = "connectionUC1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.connectionUC1);
            this.Controls.Add(this.historyUC1);
            this.Controls.Add(this.menuUC1);
            this.Controls.Add(this.historyControlsUC1);
            this.Controls.Add(this.arrowPanel1);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private View.ArrowPanelUC arrowPanel1;
        private View.HistoryControlsUC historyControlsUC1;
        private View.MenuUC menuUC1;
        private View.HistoryUC historyUC1;
        private View.ConnectionUC connectionUC1;
    }
}

