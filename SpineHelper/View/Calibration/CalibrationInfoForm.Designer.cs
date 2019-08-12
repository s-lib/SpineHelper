namespace SpineHelper.View.Calibration
{
    partial class CalibrationInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationInfoForm));
            this.buttonResetFactory = new System.Windows.Forms.Button();
            this.buttonCalibrateWeight = new System.Windows.Forms.Button();
            this.buttonCalibrateSpine = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.calibrationInfoUC1 = new SpineHelper.View.Calibration.CalibrationInfoUC();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonResetFactory
            // 
            resources.ApplyResources(this.buttonResetFactory, "buttonResetFactory");
            this.buttonResetFactory.Name = "buttonResetFactory";
            this.buttonResetFactory.UseVisualStyleBackColor = true;
            this.buttonResetFactory.Click += new System.EventHandler(this.buttonResetFactory_Click);
            // 
            // buttonCalibrateWeight
            // 
            resources.ApplyResources(this.buttonCalibrateWeight, "buttonCalibrateWeight");
            this.buttonCalibrateWeight.Name = "buttonCalibrateWeight";
            this.buttonCalibrateWeight.UseVisualStyleBackColor = true;
            this.buttonCalibrateWeight.Click += new System.EventHandler(this.buttonCalibrateWeight_Click);
            // 
            // buttonCalibrateSpine
            // 
            resources.ApplyResources(this.buttonCalibrateSpine, "buttonCalibrateSpine");
            this.buttonCalibrateSpine.Name = "buttonCalibrateSpine";
            this.buttonCalibrateSpine.UseVisualStyleBackColor = true;
            this.buttonCalibrateSpine.Click += new System.EventHandler(this.buttonCalibrateSpine_Click);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // calibrationInfoUC1
            // 
            resources.ApplyResources(this.calibrationInfoUC1, "calibrationInfoUC1");
            this.calibrationInfoUC1.Name = "calibrationInfoUC1";
            // 
            // buttonSettings
            // 
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // CalibrationInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.calibrationInfoUC1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCalibrateSpine);
            this.Controls.Add(this.buttonCalibrateWeight);
            this.Controls.Add(this.buttonResetFactory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalibrationInfoForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonResetFactory;
        private System.Windows.Forms.Button buttonCalibrateWeight;
        private System.Windows.Forms.Button buttonCalibrateSpine;
        private System.Windows.Forms.Button buttonClose;
        private CalibrationInfoUC calibrationInfoUC1;
        private System.Windows.Forms.Button buttonSettings;
    }
}