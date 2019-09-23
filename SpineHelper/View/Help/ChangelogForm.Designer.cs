namespace SpineHelper.View.Help
{
    partial class ChangelogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangelogForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxChangelog = new System.Windows.Forms.TextBox();
            this.labelVersionHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // textBoxChangelog
            // 
            resources.ApplyResources(this.textBoxChangelog, "textBoxChangelog");
            this.textBoxChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChangelog.Name = "textBoxChangelog";
            this.textBoxChangelog.ReadOnly = true;
            this.textBoxChangelog.TabStop = false;
            // 
            // labelVersionHistory
            // 
            resources.ApplyResources(this.labelVersionHistory, "labelVersionHistory");
            this.labelVersionHistory.Name = "labelVersionHistory";
            // 
            // ChangelogForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.labelVersionHistory);
            this.Controls.Add(this.textBoxChangelog);
            this.Controls.Add(this.buttonClose);
            this.Name = "ChangelogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxChangelog;
        private System.Windows.Forms.Label labelVersionHistory;
    }
}