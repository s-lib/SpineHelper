namespace SpineHelper.View.Calibration
{
    partial class CalibrationWeightUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationWeightUC));
            this.groupSensor = new System.Windows.Forms.GroupBox();
            this.radioLeftSensor = new System.Windows.Forms.RadioButton();
            this.radioRightSensor = new System.Windows.Forms.RadioButton();
            this.groupTestedWeight = new System.Windows.Forms.GroupBox();
            this.labelGrainSymbol = new System.Windows.Forms.Label();
            this.labelGramSymbol = new System.Windows.Forms.Label();
            this.radioInput1 = new System.Windows.Forms.RadioButton();
            this.radioInput2 = new System.Windows.Forms.RadioButton();
            this.numericInput1 = new System.Windows.Forms.NumericUpDown();
            this.numericInput2 = new System.Windows.Forms.NumericUpDown();
            this.labelFactoryR = new System.Windows.Forms.Label();
            this.labelFactoryL = new System.Windows.Forms.Label();
            this.labelCurrentR = new System.Windows.Forms.Label();
            this.labelCurrentL = new System.Windows.Forms.Label();
            this.labelFactory = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelCalibrateWeight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNumReadings = new System.Windows.Forms.Label();
            this.labelReadingsValue = new System.Windows.Forms.Label();
            this.labelLastReadings = new System.Windows.Forms.Label();
            this.labelWeightCalibrationFactor = new System.Windows.Forms.Label();
            this.numericCalibration = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.groupSensor.SuspendLayout();
            this.groupTestedWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCalibration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSensor
            // 
            this.groupSensor.Controls.Add(this.radioLeftSensor);
            this.groupSensor.Controls.Add(this.radioRightSensor);
            resources.ApplyResources(this.groupSensor, "groupSensor");
            this.groupSensor.Name = "groupSensor";
            this.groupSensor.TabStop = false;
            // 
            // radioLeftSensor
            // 
            resources.ApplyResources(this.radioLeftSensor, "radioLeftSensor");
            this.radioLeftSensor.Name = "radioLeftSensor";
            this.radioLeftSensor.TabStop = true;
            this.radioLeftSensor.UseVisualStyleBackColor = true;
            this.radioLeftSensor.CheckedChanged += new System.EventHandler(this.radioLeftSensor_CheckedChanged);
            // 
            // radioRightSensor
            // 
            resources.ApplyResources(this.radioRightSensor, "radioRightSensor");
            this.radioRightSensor.Name = "radioRightSensor";
            this.radioRightSensor.TabStop = true;
            this.radioRightSensor.UseVisualStyleBackColor = true;
            this.radioRightSensor.CheckedChanged += new System.EventHandler(this.radioRightSensor_CheckedChanged);
            // 
            // groupTestedWeight
            // 
            resources.ApplyResources(this.groupTestedWeight, "groupTestedWeight");
            this.groupTestedWeight.Controls.Add(this.labelGrainSymbol);
            this.groupTestedWeight.Controls.Add(this.labelGramSymbol);
            this.groupTestedWeight.Controls.Add(this.radioInput1);
            this.groupTestedWeight.Controls.Add(this.radioInput2);
            this.groupTestedWeight.Controls.Add(this.numericInput1);
            this.groupTestedWeight.Controls.Add(this.numericInput2);
            this.groupTestedWeight.Name = "groupTestedWeight";
            this.groupTestedWeight.TabStop = false;
            // 
            // labelGrainSymbol
            // 
            resources.ApplyResources(this.labelGrainSymbol, "labelGrainSymbol");
            this.labelGrainSymbol.Name = "labelGrainSymbol";
            // 
            // labelGramSymbol
            // 
            resources.ApplyResources(this.labelGramSymbol, "labelGramSymbol");
            this.labelGramSymbol.Name = "labelGramSymbol";
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
            this.numericInput1.DecimalPlaces = 2;
            this.numericInput1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericInput1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericInput1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericInput1.Name = "numericInput1";
            this.numericInput1.Value = new decimal(new int[] {
            5921,
            0,
            0,
            131072});
            // 
            // numericInput2
            // 
            resources.ApplyResources(this.numericInput2, "numericInput2");
            this.numericInput2.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericInput2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInput2.Name = "numericInput2";
            this.numericInput2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // labelFactoryR
            // 
            resources.ApplyResources(this.labelFactoryR, "labelFactoryR");
            this.labelFactoryR.Name = "labelFactoryR";
            // 
            // labelFactoryL
            // 
            resources.ApplyResources(this.labelFactoryL, "labelFactoryL");
            this.labelFactoryL.Name = "labelFactoryL";
            // 
            // labelCurrentR
            // 
            resources.ApplyResources(this.labelCurrentR, "labelCurrentR");
            this.labelCurrentR.Name = "labelCurrentR";
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
            // labelRight
            // 
            resources.ApplyResources(this.labelRight, "labelRight");
            this.labelRight.Name = "labelRight";
            // 
            // labelLeft
            // 
            resources.ApplyResources(this.labelLeft, "labelLeft");
            this.labelLeft.Name = "labelLeft";
            // 
            // labelCalibrateWeight
            // 
            resources.ApplyResources(this.labelCalibrateWeight, "labelCalibrateWeight");
            this.labelCalibrateWeight.Name = "labelCalibrateWeight";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.labelNumReadings);
            this.panel1.Controls.Add(this.labelReadingsValue);
            this.panel1.Controls.Add(this.labelLastReadings);
            this.panel1.Controls.Add(this.labelWeightCalibrationFactor);
            this.panel1.Controls.Add(this.numericCalibration);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonCalibrate);
            this.panel1.Name = "panel1";
            // 
            // labelNumReadings
            // 
            resources.ApplyResources(this.labelNumReadings, "labelNumReadings");
            this.labelNumReadings.Name = "labelNumReadings";
            // 
            // labelReadingsValue
            // 
            resources.ApplyResources(this.labelReadingsValue, "labelReadingsValue");
            this.labelReadingsValue.Name = "labelReadingsValue";
            // 
            // labelLastReadings
            // 
            resources.ApplyResources(this.labelLastReadings, "labelLastReadings");
            this.labelLastReadings.Name = "labelLastReadings";
            // 
            // labelWeightCalibrationFactor
            // 
            resources.ApplyResources(this.labelWeightCalibrationFactor, "labelWeightCalibrationFactor");
            this.labelWeightCalibrationFactor.Name = "labelWeightCalibrationFactor";
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
            1,
            0,
            0,
            131072});
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
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalibrate
            // 
            resources.ApplyResources(this.buttonCalibrate, "buttonCalibrate");
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // CalibrationWeightUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupSensor);
            this.Controls.Add(this.groupTestedWeight);
            this.Controls.Add(this.labelFactoryR);
            this.Controls.Add(this.labelFactoryL);
            this.Controls.Add(this.labelCurrentR);
            this.Controls.Add(this.labelCurrentL);
            this.Controls.Add(this.labelFactory);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelCalibrateWeight);
            this.Name = "CalibrationWeightUC";
            this.groupSensor.ResumeLayout(false);
            this.groupTestedWeight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCalibration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCalibrateWeight;
        private System.Windows.Forms.RadioButton radioRightSensor;
        private System.Windows.Forms.RadioButton radioLeftSensor;
        private System.Windows.Forms.NumericUpDown numericInput2;
        private System.Windows.Forms.NumericUpDown numericInput1;
        private System.Windows.Forms.RadioButton radioInput2;
        private System.Windows.Forms.RadioButton radioInput1;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelFactory;
        private System.Windows.Forms.Label labelCurrentL;
        private System.Windows.Forms.Label labelCurrentR;
        private System.Windows.Forms.Label labelFactoryR;
        private System.Windows.Forms.Label labelFactoryL;
        private System.Windows.Forms.GroupBox groupTestedWeight;
        private System.Windows.Forms.GroupBox groupSensor;
        private System.Windows.Forms.Label labelGrainSymbol;
        private System.Windows.Forms.Label labelGramSymbol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumReadings;
        private System.Windows.Forms.Label labelReadingsValue;
        private System.Windows.Forms.Label labelLastReadings;
        private System.Windows.Forms.Label labelWeightCalibrationFactor;
        private System.Windows.Forms.NumericUpDown numericCalibration;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalibrate;
    }
}
