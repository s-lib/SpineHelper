namespace SpineHelper.View
{
    partial class HistoryControlsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryControlsUC));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearLast = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonExportHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonExportHistory, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.buttonClearLast, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearHistory, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // buttonClearLast
            // 
            resources.ApplyResources(this.buttonClearLast, "buttonClearLast");
            this.buttonClearLast.Name = "buttonClearLast";
            this.buttonClearLast.UseVisualStyleBackColor = true;
            this.buttonClearLast.Click += new System.EventHandler(this.buttonClearLast_Click);
            // 
            // buttonClearHistory
            // 
            resources.ApplyResources(this.buttonClearHistory, "buttonClearHistory");
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // buttonExportHistory
            // 
            resources.ApplyResources(this.buttonExportHistory, "buttonExportHistory");
            this.buttonExportHistory.Name = "buttonExportHistory";
            this.buttonExportHistory.UseVisualStyleBackColor = true;
            this.buttonExportHistory.Click += new System.EventHandler(this.buttonExportHistory_Click);
            // 
            // HistoryControlsUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryControlsUC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonClearLast;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonExportHistory;
    }
}
