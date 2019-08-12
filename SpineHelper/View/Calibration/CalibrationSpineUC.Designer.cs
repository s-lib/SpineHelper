namespace SpineHelper.View.Calibration
{
    partial class CalibrationSpineUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationSpineUC));
            this.groupTestedWeight = new System.Windows.Forms.GroupBox();
            this.radioInput1 = new System.Windows.Forms.RadioButton();
            this.radioInput2 = new System.Windows.Forms.RadioButton();
            this.numericInput1 = new System.Windows.Forms.NumericUpDown();
            this.numericInput2 = new System.Windows.Forms.NumericUpDown();
            this.labelFactoryL = new System.Windows.Forms.Label();
            this.labelCurrentL = new System.Windows.Forms.Label();
            this.labelFactory = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelCalibrateWeight = new System.Windows.Forms.Label();
            this.labelMilimeterSymbol = new System.Windows.Forms.Label();
            this.labelFixedDeflection = new System.Windows.Forms.Label();
            this.numericCalibration = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericLastTension = new System.Windows.Forms.NumericUpDown();
            this.labelLastTension = new System.Windows.Forms.Label();
            this.labelLastAMO = new System.Windows.Forms.Label();
            this.labelLastASTM = new System.Windows.Forms.Label();
            this.numericLastASTM = new System.Windows.Forms.NumericUpDown();
            this.numericLastAMO = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupTestedWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCalibration)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastTension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastASTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastAMO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTestedWeight
            // 
            resources.ApplyResources(this.groupTestedWeight, "groupTestedWeight");
            this.groupTestedWeight.Controls.Add(this.radioInput1);
            this.groupTestedWeight.Controls.Add(this.radioInput2);
            this.groupTestedWeight.Controls.Add(this.numericInput1);
            this.groupTestedWeight.Controls.Add(this.numericInput2);
            this.groupTestedWeight.Name = "groupTestedWeight";
            this.groupTestedWeight.TabStop = false;
            // 
            // radioInput1
            // 
            resources.ApplyResources(this.radioInput1, "radioInput1");
            this.radioInput1.Name = "radioInput1";
            this.radioInput1.TabStop = true;
            this.radioInput1.UseVisualStyleBackColor = true;
            this.radioInput1.CheckedChanged += new System.EventHandler(this.radioInput1_CheckedChanged);
            // 
            // radioInput2
            // 
            resources.ApplyResources(this.radioInput2, "radioInput2");
            this.radioInput2.Name = "radioInput2";
            this.radioInput2.TabStop = true;
            this.radioInput2.UseVisualStyleBackColor = true;
            this.radioInput2.CheckedChanged += new System.EventHandler(this.radioInput2_CheckedChanged);
            // 
            // numericInput1
            // 
            resources.ApplyResources(this.numericInput1, "numericInput1");
            this.numericInput1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericInput1.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericInput1.Name = "numericInput1";
            this.numericInput1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericInput2
            // 
            resources.ApplyResources(this.numericInput2, "numericInput2");
            this.numericInput2.DecimalPlaces = 1;
            this.numericInput2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericInput2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericInput2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericInput2.Name = "numericInput2";
            this.numericInput2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelFactoryL
            // 
            resources.ApplyResources(this.labelFactoryL, "labelFactoryL");
            this.labelFactoryL.Name = "labelFactoryL";
            // 
            // labelCurrentL
            // 
            resources.ApplyResources(this.labelCurrentL, "labelCurrentL");
            this.labelCurrentL.Name = "labelCurrentL";
            // 
            // labelFactory
            // 
            resources.ApplyResources(this.labelFactory, "labelFactory");
            this.labelFactory.Name = "labelFactory";
            // 
            // labelCurrent
            // 
            resources.ApplyResources(this.labelCurrent, "labelCurrent");
            this.labelCurrent.Name = "labelCurrent";
            // 
            // labelCalibrateWeight
            // 
            resources.ApplyResources(this.labelCalibrateWeight, "labelCalibrateWeight");
            this.labelCalibrateWeight.Name = "labelCalibrateWeight";
            // 
            // labelMilimeterSymbol
            // 
            resources.ApplyResources(this.labelMilimeterSymbol, "labelMilimeterSymbol");
            this.labelMilimeterSymbol.Name = "labelMilimeterSymbol";
            // 
            // labelFixedDeflection
            // 
            resources.ApplyResources(this.labelFixedDeflection, "labelFixedDeflection");
            this.labelFixedDeflection.Name = "labelFixedDeflection";
            // 
            // numericCalibration
            // 
            resources.ApplyResources(this.numericCalibration, "numericCalibration");
            this.numericCalibration.DecimalPlaces = 2;
            this.numericCalibration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCalibration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCalibration.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericCalibration.Name = "numericCalibration";
            this.numericCalibration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCalibrate
            // 
            resources.ApplyResources(this.buttonCalibrate, "buttonCalibrate");
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.numericLastTension);
            this.groupBox1.Controls.Add(this.labelLastTension);
            this.groupBox1.Controls.Add(this.labelLastAMO);
            this.groupBox1.Controls.Add(this.labelLastASTM);
            this.groupBox1.Controls.Add(this.numericLastASTM);
            this.groupBox1.Controls.Add(this.numericLastAMO);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // numericLastTension
            // 
            resources.ApplyResources(this.numericLastTension, "numericLastTension");
            this.numericLastTension.DecimalPlaces = 2;
            this.numericLastTension.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericLastTension.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericLastTension.Name = "numericLastTension";
            this.numericLastTension.ReadOnly = true;
            // 
            // labelLastTension
            // 
            resources.ApplyResources(this.labelLastTension, "labelLastTension");
            this.labelLastTension.Name = "labelLastTension";
            // 
            // labelLastAMO
            // 
            resources.ApplyResources(this.labelLastAMO, "labelLastAMO");
            this.labelLastAMO.Name = "labelLastAMO";
            // 
            // labelLastASTM
            // 
            resources.ApplyResources(this.labelLastASTM, "labelLastASTM");
            this.labelLastASTM.Name = "labelLastASTM";
            // 
            // numericLastASTM
            // 
            resources.ApplyResources(this.numericLastASTM, "numericLastASTM");
            this.numericLastASTM.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericLastASTM.Name = "numericLastASTM";
            this.numericLastASTM.ReadOnly = true;
            // 
            // numericLastAMO
            // 
            resources.ApplyResources(this.numericLastAMO, "numericLastAMO");
            this.numericLastAMO.DecimalPlaces = 1;
            this.numericLastAMO.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericLastAMO.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericLastAMO.Name = "numericLastAMO";
            this.numericLastAMO.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CalibrationSpineUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFixedDeflection);
            this.Controls.Add(this.numericCalibration);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCalibrate);
            this.Controls.Add(this.labelMilimeterSymbol);
            this.Controls.Add(this.groupTestedWeight);
            this.Controls.Add(this.labelFactoryL);
            this.Controls.Add(this.labelCurrentL);
            this.Controls.Add(this.labelFactory);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelCalibrateWeight);
            this.Name = "CalibrationSpineUC";
            this.groupTestedWeight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCalibration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericLastTension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastASTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastAMO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCalibrateWeight;
        private System.Windows.Forms.NumericUpDown numericInput2;
        private System.Windows.Forms.NumericUpDown numericInput1;
        private System.Windows.Forms.RadioButton radioInput2;
        private System.Windows.Forms.RadioButton radioInput1;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelFactory;
        private System.Windows.Forms.Label labelCurrentL;
        private System.Windows.Forms.Label labelFactoryL;
        private System.Windows.Forms.GroupBox groupTestedWeight;
        private System.Windows.Forms.Label labelMilimeterSymbol;
        private System.Windows.Forms.Label labelFixedDeflection;
        private System.Windows.Forms.NumericUpDown numericCalibration;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericLastTension;
        private System.Windows.Forms.Label labelLastTension;
        private System.Windows.Forms.Label labelLastAMO;
        private System.Windows.Forms.Label labelLastASTM;
        private System.Windows.Forms.NumericUpDown numericLastASTM;
        private System.Windows.Forms.NumericUpDown numericLastAMO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
