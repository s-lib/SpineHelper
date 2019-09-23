namespace SpineHelper.View.Options
{
    partial class MultiSpineTestForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spineTestUC1 = new SpineHelper.View.SpineTestUC();
            this.weightTestUC1 = new SpineHelper.View.WeightTestUC();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAMO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHighAMO = new System.Windows.Forms.Label();
            this.labelLowAMO = new System.Windows.Forms.Label();
            this.labelHighASTM = new System.Windows.Forms.Label();
            this.labelLowASTM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AMO,
            this.ASTM});
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 405);
            this.dataGridView1.TabIndex = 2;
            // 
            // spineTestUC1
            // 
            this.spineTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.spineTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineTestUC1.Location = new System.Drawing.Point(12, 12);
            this.spineTestUC1.MultiSpineAllowed = true;
            this.spineTestUC1.Name = "spineTestUC1";
            this.spineTestUC1.Size = new System.Drawing.Size(210, 120);
            this.spineTestUC1.TabIndex = 3;
            // 
            // weightTestUC1
            // 
            this.weightTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weightTestUC1.Location = new System.Drawing.Point(228, 12);
            this.weightTestUC1.Name = "weightTestUC1";
            this.weightTestUC1.Size = new System.Drawing.Size(210, 120);
            this.weightTestUC1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 80;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 80;
            // 
            // AMO
            // 
            this.AMO.HeaderText = "AMO";
            this.AMO.MinimumWidth = 150;
            this.AMO.Name = "AMO";
            this.AMO.ReadOnly = true;
            this.AMO.Width = 150;
            // 
            // ASTM
            // 
            this.ASTM.HeaderText = "ASTM";
            this.ASTM.MinimumWidth = 150;
            this.ASTM.Name = "ASTM";
            this.ASTM.ReadOnly = true;
            this.ASTM.Width = 150;
            // 
            // labelAMO
            // 
            this.labelAMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAMO.Location = new System.Drawing.Point(540, 220);
            this.labelAMO.Name = "labelAMO";
            this.labelAMO.Size = new System.Drawing.Size(80, 25);
            this.labelAMO.TabIndex = 4;
            this.labelAMO.Text = "AMO";
            this.labelAMO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(626, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ASTM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHigh
            // 
            this.labelHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHigh.Location = new System.Drawing.Point(444, 255);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(100, 25);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "Highest:";
            this.labelHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLow
            // 
            this.labelLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLow.Location = new System.Drawing.Point(444, 290);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(100, 25);
            this.labelLow.TabIndex = 7;
            this.labelLow.Text = "Lowest:";
            this.labelLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHighAMO
            // 
            this.labelHighAMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHighAMO.Location = new System.Drawing.Point(560, 255);
            this.labelHighAMO.Name = "labelHighAMO";
            this.labelHighAMO.Size = new System.Drawing.Size(40, 25);
            this.labelHighAMO.TabIndex = 8;
            this.labelHighAMO.Text = "--";
            this.labelHighAMO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLowAMO
            // 
            this.labelLowAMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLowAMO.Location = new System.Drawing.Point(560, 290);
            this.labelLowAMO.Name = "labelLowAMO";
            this.labelLowAMO.Size = new System.Drawing.Size(40, 25);
            this.labelLowAMO.TabIndex = 9;
            this.labelLowAMO.Text = "--";
            this.labelLowAMO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHighASTM
            // 
            this.labelHighASTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHighASTM.Location = new System.Drawing.Point(626, 255);
            this.labelHighASTM.Name = "labelHighASTM";
            this.labelHighASTM.Size = new System.Drawing.Size(60, 25);
            this.labelHighASTM.TabIndex = 10;
            this.labelHighASTM.Text = "----";
            this.labelHighASTM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLowASTM
            // 
            this.labelLowASTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLowASTM.Location = new System.Drawing.Point(626, 290);
            this.labelLowASTM.Name = "labelLowASTM";
            this.labelLowASTM.Size = new System.Drawing.Size(60, 25);
            this.labelLowASTM.TabIndex = 11;
            this.labelLowASTM.Text = "----";
            this.labelLowASTM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MultiSpineTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 555);
            this.Controls.Add(this.labelLowASTM);
            this.Controls.Add(this.labelHighASTM);
            this.Controls.Add(this.labelLowAMO);
            this.Controls.Add(this.labelHighAMO);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAMO);
            this.Controls.Add(this.spineTestUC1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightTestUC1);
            this.MinimumSize = new System.Drawing.Size(780, 500);
            this.Name = "MultiSpineTestForm";
            this.Text = "Multiple Spine Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private WeightTestUC weightTestUC1;
        private SpineTestUC spineTestUC1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTM;
        private System.Windows.Forms.Label labelAMO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelHighAMO;
        private System.Windows.Forms.Label labelLowAMO;
        private System.Windows.Forms.Label labelHighASTM;
        private System.Windows.Forms.Label labelLowASTM;
    }
}