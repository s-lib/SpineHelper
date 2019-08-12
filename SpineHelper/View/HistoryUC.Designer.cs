namespace SpineHelper.View
{
    partial class HistoryUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historyView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Straightness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyView
            // 
            this.historyView.AllowUserToAddRows = false;
            this.historyView.AllowUserToDeleteRows = false;
            this.historyView.AllowUserToOrderColumns = true;
            this.historyView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Grains,
            this.Grams,
            this.ASTM,
            this.AMO,
            this.Straightness,
            this.ASTM1,
            this.AMO1,
            this.ASTM2,
            this.AMO2,
            this.Comment});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyView.DefaultCellStyle = dataGridViewCellStyle5;
            this.historyView.Location = new System.Drawing.Point(0, 0);
            this.historyView.Margin = new System.Windows.Forms.Padding(0);
            this.historyView.Name = "historyView";
            this.historyView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyView.RowTemplate.Height = 20;
            this.historyView.Size = new System.Drawing.Size(970, 300);
            this.historyView.TabIndex = 5;
            this.historyView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.historyView_CellMouseClick);
            this.historyView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyView_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeArrowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 28);
            // 
            // removeArrowToolStripMenuItem
            // 
            this.removeArrowToolStripMenuItem.Name = "removeArrowToolStripMenuItem";
            this.removeArrowToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.removeArrowToolStripMenuItem.Text = "Remove Arrow";
            this.removeArrowToolStripMenuItem.Click += new System.EventHandler(this.removeArrowToolStripMenuItem_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 30;
            // 
            // Grains
            // 
            this.Grains.DataPropertyName = "Grains";
            this.Grains.Frozen = true;
            this.Grains.HeaderText = "Grains";
            this.Grains.Name = "Grains";
            this.Grains.ReadOnly = true;
            this.Grains.Width = 75;
            // 
            // Grams
            // 
            this.Grams.DataPropertyName = "Grams";
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.Grams.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grams.Frozen = true;
            this.Grams.HeaderText = "Grams";
            this.Grams.Name = "Grams";
            this.Grams.ReadOnly = true;
            this.Grams.Width = 75;
            // 
            // ASTM
            // 
            this.ASTM.DataPropertyName = "ASTM";
            this.ASTM.Frozen = true;
            this.ASTM.HeaderText = "ASTM";
            this.ASTM.Name = "ASTM";
            this.ASTM.ReadOnly = true;
            this.ASTM.Width = 75;
            // 
            // AMO
            // 
            this.AMO.DataPropertyName = "AMO";
            this.AMO.Frozen = true;
            this.AMO.HeaderText = "AMO";
            this.AMO.Name = "AMO";
            this.AMO.ReadOnly = true;
            this.AMO.Width = 75;
            // 
            // Straightness
            // 
            this.Straightness.DataPropertyName = "Straightness";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.Straightness.DefaultCellStyle = dataGridViewCellStyle3;
            this.Straightness.Frozen = true;
            this.Straightness.HeaderText = "Straightness";
            this.Straightness.Name = "Straightness";
            this.Straightness.ReadOnly = true;
            this.Straightness.Width = 90;
            // 
            // ASTM1
            // 
            this.ASTM1.DataPropertyName = "ASTM1";
            this.ASTM1.Frozen = true;
            this.ASTM1.HeaderText = "1st ASTM";
            this.ASTM1.Name = "ASTM1";
            this.ASTM1.ReadOnly = true;
            this.ASTM1.Width = 75;
            // 
            // AMO1
            // 
            this.AMO1.DataPropertyName = "AMO1";
            this.AMO1.Frozen = true;
            this.AMO1.HeaderText = "1st AMO";
            this.AMO1.Name = "AMO1";
            this.AMO1.ReadOnly = true;
            this.AMO1.Width = 75;
            // 
            // ASTM2
            // 
            this.ASTM2.DataPropertyName = "ASTM2";
            this.ASTM2.Frozen = true;
            this.ASTM2.HeaderText = "2nd ASTM";
            this.ASTM2.Name = "ASTM2";
            this.ASTM2.ReadOnly = true;
            this.ASTM2.Width = 75;
            // 
            // AMO2
            // 
            this.AMO2.DataPropertyName = "AMO2";
            this.AMO2.Frozen = true;
            this.AMO2.HeaderText = "2nd AMO";
            this.AMO2.Name = "AMO2";
            this.AMO2.ReadOnly = true;
            this.AMO2.Width = 75;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Comment.DefaultCellStyle = dataGridViewCellStyle4;
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // HistoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.historyView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HistoryUC";
            this.Size = new System.Drawing.Size(970, 300);
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView historyView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeArrowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grains;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Straightness;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}
