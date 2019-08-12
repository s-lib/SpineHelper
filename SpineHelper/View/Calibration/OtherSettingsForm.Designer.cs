namespace SpineHelper.View.Calibration
{
    partial class OtherSettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherSettingsForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxSpineDiff = new System.Windows.Forms.GroupBox();
            this.labelSpThFactoryVal = new System.Windows.Forms.Label();
            this.labelSpThCurrentVal = new System.Windows.Forms.Label();
            this.labelSpThFactory = new System.Windows.Forms.Label();
            this.labelSpThCurrent = new System.Windows.Forms.Label();
            this.groupBoxAmp = new System.Windows.Forms.GroupBox();
            this.labelAmpFactoryVal = new System.Windows.Forms.Label();
            this.labelAmpCurrentVal = new System.Windows.Forms.Label();
            this.labelAmpFactory = new System.Windows.Forms.Label();
            this.labelAmpCurrent = new System.Windows.Forms.Label();
            this.buttonApplySpine = new System.Windows.Forms.Button();
            this.buttonApplyAmp = new System.Windows.Forms.Button();
            this.numericSpine = new System.Windows.Forms.NumericUpDown();
            this.numericAmp = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSpineDiff.SuspendLayout();
            this.groupBoxAmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.toolTip1.SetToolTip(this.buttonClose, resources.GetString("buttonClose.ToolTip"));
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxSpineDiff
            // 
            resources.ApplyResources(this.groupBoxSpineDiff, "groupBoxSpineDiff");
            this.groupBoxSpineDiff.Controls.Add(this.labelSpThFactoryVal);
            this.groupBoxSpineDiff.Controls.Add(this.labelSpThCurrentVal);
            this.groupBoxSpineDiff.Controls.Add(this.labelSpThFactory);
            this.groupBoxSpineDiff.Controls.Add(this.labelSpThCurrent);
            this.groupBoxSpineDiff.Name = "groupBoxSpineDiff";
            this.groupBoxSpineDiff.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxSpineDiff, resources.GetString("groupBoxSpineDiff.ToolTip"));
            // 
            // labelSpThFactoryVal
            // 
            resources.ApplyResources(this.labelSpThFactoryVal, "labelSpThFactoryVal");
            this.labelSpThFactoryVal.Name = "labelSpThFactoryVal";
            this.toolTip1.SetToolTip(this.labelSpThFactoryVal, resources.GetString("labelSpThFactoryVal.ToolTip"));
            // 
            // labelSpThCurrentVal
            // 
            resources.ApplyResources(this.labelSpThCurrentVal, "labelSpThCurrentVal");
            this.labelSpThCurrentVal.Name = "labelSpThCurrentVal";
            this.toolTip1.SetToolTip(this.labelSpThCurrentVal, resources.GetString("labelSpThCurrentVal.ToolTip"));
            // 
            // labelSpThFactory
            // 
            resources.ApplyResources(this.labelSpThFactory, "labelSpThFactory");
            this.labelSpThFactory.Name = "labelSpThFactory";
            this.toolTip1.SetToolTip(this.labelSpThFactory, resources.GetString("labelSpThFactory.ToolTip"));
            // 
            // labelSpThCurrent
            // 
            resources.ApplyResources(this.labelSpThCurrent, "labelSpThCurrent");
            this.labelSpThCurrent.Name = "labelSpThCurrent";
            this.toolTip1.SetToolTip(this.labelSpThCurrent, resources.GetString("labelSpThCurrent.ToolTip"));
            // 
            // groupBoxAmp
            // 
            resources.ApplyResources(this.groupBoxAmp, "groupBoxAmp");
            this.groupBoxAmp.Controls.Add(this.labelAmpFactoryVal);
            this.groupBoxAmp.Controls.Add(this.labelAmpCurrentVal);
            this.groupBoxAmp.Controls.Add(this.labelAmpFactory);
            this.groupBoxAmp.Controls.Add(this.labelAmpCurrent);
            this.groupBoxAmp.Name = "groupBoxAmp";
            this.groupBoxAmp.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxAmp, resources.GetString("groupBoxAmp.ToolTip"));
            // 
            // labelAmpFactoryVal
            // 
            resources.ApplyResources(this.labelAmpFactoryVal, "labelAmpFactoryVal");
            this.labelAmpFactoryVal.Name = "labelAmpFactoryVal";
            this.toolTip1.SetToolTip(this.labelAmpFactoryVal, resources.GetString("labelAmpFactoryVal.ToolTip"));
            // 
            // labelAmpCurrentVal
            // 
            resources.ApplyResources(this.labelAmpCurrentVal, "labelAmpCurrentVal");
            this.labelAmpCurrentVal.Name = "labelAmpCurrentVal";
            this.toolTip1.SetToolTip(this.labelAmpCurrentVal, resources.GetString("labelAmpCurrentVal.ToolTip"));
            // 
            // labelAmpFactory
            // 
            resources.ApplyResources(this.labelAmpFactory, "labelAmpFactory");
            this.labelAmpFactory.Name = "labelAmpFactory";
            this.toolTip1.SetToolTip(this.labelAmpFactory, resources.GetString("labelAmpFactory.ToolTip"));
            // 
            // labelAmpCurrent
            // 
            resources.ApplyResources(this.labelAmpCurrent, "labelAmpCurrent");
            this.labelAmpCurrent.Name = "labelAmpCurrent";
            this.toolTip1.SetToolTip(this.labelAmpCurrent, resources.GetString("labelAmpCurrent.ToolTip"));
            // 
            // buttonApplySpine
            // 
            resources.ApplyResources(this.buttonApplySpine, "buttonApplySpine");
            this.buttonApplySpine.Name = "buttonApplySpine";
            this.toolTip1.SetToolTip(this.buttonApplySpine, resources.GetString("buttonApplySpine.ToolTip"));
            this.buttonApplySpine.UseVisualStyleBackColor = true;
            this.buttonApplySpine.Click += new System.EventHandler(this.buttonApplySpine_Click);
            // 
            // buttonApplyAmp
            // 
            resources.ApplyResources(this.buttonApplyAmp, "buttonApplyAmp");
            this.buttonApplyAmp.Name = "buttonApplyAmp";
            this.toolTip1.SetToolTip(this.buttonApplyAmp, resources.GetString("buttonApplyAmp.ToolTip"));
            this.buttonApplyAmp.UseVisualStyleBackColor = true;
            this.buttonApplyAmp.Click += new System.EventHandler(this.buttonApplyAmp_Click);
            // 
            // numericSpine
            // 
            resources.ApplyResources(this.numericSpine, "numericSpine");
            this.numericSpine.DecimalPlaces = 1;
            this.numericSpine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericSpine.Name = "numericSpine";
            this.toolTip1.SetToolTip(this.numericSpine, resources.GetString("numericSpine.ToolTip"));
            this.numericSpine.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericAmp
            // 
            resources.ApplyResources(this.numericAmp, "numericAmp");
            this.numericAmp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericAmp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmp.Name = "numericAmp";
            this.toolTip1.SetToolTip(this.numericAmp, resources.GetString("numericAmp.ToolTip"));
            this.numericAmp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 600;
            this.toolTip1.ReshowDelay = 120;
            // 
            // OtherSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.numericAmp);
            this.Controls.Add(this.numericSpine);
            this.Controls.Add(this.buttonApplyAmp);
            this.Controls.Add(this.buttonApplySpine);
            this.Controls.Add(this.groupBoxAmp);
            this.Controls.Add(this.groupBoxSpineDiff);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OtherSettingsForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBoxSpineDiff.ResumeLayout(false);
            this.groupBoxAmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSpine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxSpineDiff;
        private System.Windows.Forms.GroupBox groupBoxAmp;
        private System.Windows.Forms.Button buttonApplySpine;
        private System.Windows.Forms.Button buttonApplyAmp;
        private System.Windows.Forms.Label labelAmpFactoryVal;
        private System.Windows.Forms.Label labelAmpCurrentVal;
        private System.Windows.Forms.Label labelAmpFactory;
        private System.Windows.Forms.Label labelAmpCurrent;
        private System.Windows.Forms.Label labelSpThFactoryVal;
        private System.Windows.Forms.Label labelSpThCurrentVal;
        private System.Windows.Forms.Label labelSpThFactory;
        private System.Windows.Forms.Label labelSpThCurrent;
        private System.Windows.Forms.NumericUpDown numericSpine;
        private System.Windows.Forms.NumericUpDown numericAmp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}