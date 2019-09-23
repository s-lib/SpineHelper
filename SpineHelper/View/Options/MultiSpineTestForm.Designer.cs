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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiSpineTestForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spineTestUC1 = new SpineHelper.View.SpineTestUC();
            this.weightTestUC1 = new SpineHelper.View.WeightTestUC();
            this.labelAMO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHighAMO = new System.Windows.Forms.Label();
            this.labelLowAMO = new System.Windows.Forms.Label();
            this.labelHighASTM = new System.Windows.Forms.Label();
            this.labelLowASTM = new System.Windows.Forms.Label();
            this.connectionUC1 = new SpineHelper.View.ConnectionUC();
            this.labelLowID = new System.Windows.Forms.Label();
            this.labelHighID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AMO,
            this.ASTM});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AMO
            // 
            resources.ApplyResources(this.AMO, "AMO");
            this.AMO.Name = "AMO";
            this.AMO.ReadOnly = true;
            // 
            // ASTM
            // 
            resources.ApplyResources(this.ASTM, "ASTM");
            this.ASTM.Name = "ASTM";
            this.ASTM.ReadOnly = true;
            // 
            // spineTestUC1
            // 
            resources.ApplyResources(this.spineTestUC1, "spineTestUC1");
            this.spineTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.spineTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spineTestUC1.MultiSpineAllowed = true;
            this.spineTestUC1.Name = "spineTestUC1";
            // 
            // weightTestUC1
            // 
            resources.ApplyResources(this.weightTestUC1, "weightTestUC1");
            this.weightTestUC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightTestUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weightTestUC1.Name = "weightTestUC1";
            // 
            // labelAMO
            // 
            resources.ApplyResources(this.labelAMO, "labelAMO");
            this.labelAMO.Name = "labelAMO";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelHigh
            // 
            resources.ApplyResources(this.labelHigh, "labelHigh");
            this.labelHigh.Name = "labelHigh";
            // 
            // labelLow
            // 
            resources.ApplyResources(this.labelLow, "labelLow");
            this.labelLow.Name = "labelLow";
            // 
            // labelHighAMO
            // 
            resources.ApplyResources(this.labelHighAMO, "labelHighAMO");
            this.labelHighAMO.Name = "labelHighAMO";
            // 
            // labelLowAMO
            // 
            resources.ApplyResources(this.labelLowAMO, "labelLowAMO");
            this.labelLowAMO.Name = "labelLowAMO";
            // 
            // labelHighASTM
            // 
            resources.ApplyResources(this.labelHighASTM, "labelHighASTM");
            this.labelHighASTM.Name = "labelHighASTM";
            // 
            // labelLowASTM
            // 
            resources.ApplyResources(this.labelLowASTM, "labelLowASTM");
            this.labelLowASTM.Name = "labelLowASTM";
            // 
            // connectionUC1
            // 
            resources.ApplyResources(this.connectionUC1, "connectionUC1");
            this.connectionUC1.MultiSpineAllowed = true;
            this.connectionUC1.Name = "connectionUC1";
            // 
            // labelLowID
            // 
            resources.ApplyResources(this.labelLowID, "labelLowID");
            this.labelLowID.Name = "labelLowID";
            // 
            // labelHighID
            // 
            resources.ApplyResources(this.labelHighID, "labelHighID");
            this.labelHighID.Name = "labelHighID";
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // MultiSpineTestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLowID);
            this.Controls.Add(this.labelHighID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.connectionUC1);
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
            this.Name = "MultiSpineTestForm";
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
        private ConnectionUC connectionUC1;
        private System.Windows.Forms.Label labelLowID;
        private System.Windows.Forms.Label labelHighID;
        private System.Windows.Forms.Label labelID;
    }
}