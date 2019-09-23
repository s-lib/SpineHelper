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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightTestUC1 = new SpineHelper.View.WeightTestUC();
            this.spineTestUC1 = new SpineHelper.View.SpineTestUC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AMO,
            this.ASTM});
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // AMO
            // 
            this.AMO.Frozen = true;
            this.AMO.HeaderText = "AMO";
            this.AMO.Name = "AMO";
            this.AMO.ReadOnly = true;
            // 
            // ASTM
            // 
            this.ASTM.Frozen = true;
            this.ASTM.HeaderText = "ASTM";
            this.ASTM.Name = "ASTM";
            this.ASTM.ReadOnly = true;
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
            // MultiSpineTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.spineTestUC1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightTestUC1);
            this.Name = "MultiSpineTestForm";
            this.Text = "Multiple Spine Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private WeightTestUC weightTestUC1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTM;
        private SpineTestUC spineTestUC1;
    }
}