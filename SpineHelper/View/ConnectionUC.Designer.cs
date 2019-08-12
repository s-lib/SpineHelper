namespace SpineHelper.View
{
    partial class ConnectionUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionUC));
            this.panelDeviceInfo = new System.Windows.Forms.Panel();
            this.labelCommand = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTension = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonTare = new System.Windows.Forms.Button();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.labelCOMfound = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelDeviceInfo.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDeviceInfo
            // 
            resources.ApplyResources(this.panelDeviceInfo, "panelDeviceInfo");
            this.panelDeviceInfo.Controls.Add(this.labelCommand);
            this.panelDeviceInfo.Controls.Add(this.buttonDisconnect);
            this.panelDeviceInfo.Controls.Add(this.label15);
            this.panelDeviceInfo.Controls.Add(this.labelTension);
            this.panelDeviceInfo.Controls.Add(this.label14);
            this.panelDeviceInfo.Controls.Add(this.buttonTare);
            this.panelDeviceInfo.Name = "panelDeviceInfo";
            // 
            // labelCommand
            // 
            resources.ApplyResources(this.labelCommand, "labelCommand");
            this.labelCommand.Name = "labelCommand";
            // 
            // buttonDisconnect
            // 
            resources.ApplyResources(this.buttonDisconnect, "buttonDisconnect");
            this.buttonDisconnect.Image = global::SpineHelper.Properties.Resources.dot_green;
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // labelTension
            // 
            resources.ApplyResources(this.labelTension, "labelTension");
            this.labelTension.Name = "labelTension";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // buttonTare
            // 
            resources.ApplyResources(this.buttonTare, "buttonTare");
            this.buttonTare.Name = "buttonTare";
            this.buttonTare.UseVisualStyleBackColor = true;
            this.buttonTare.Click += new System.EventHandler(this.buttonTare_Click);
            // 
            // panelConnection
            // 
            resources.ApplyResources(this.panelConnection, "panelConnection");
            this.panelConnection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelConnection.Controls.Add(this.labelCOMfound);
            this.panelConnection.Controls.Add(this.label16);
            this.panelConnection.Controls.Add(this.comboBoxComPort);
            this.panelConnection.Controls.Add(this.buttonConnect);
            this.panelConnection.Name = "panelConnection";
            // 
            // labelCOMfound
            // 
            resources.ApplyResources(this.labelCOMfound, "labelCOMfound");
            this.labelCOMfound.BackColor = System.Drawing.Color.DarkGreen;
            this.labelCOMfound.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelCOMfound.Name = "labelCOMfound";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Name = "label16";
            // 
            // comboBoxComPort
            // 
            resources.ApplyResources(this.comboBoxComPort, "comboBoxComPort");
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Name = "comboBoxComPort";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelConnect
            // 
            resources.ApplyResources(this.labelConnect, "labelConnect");
            this.labelConnect.Name = "labelConnect";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ConnectionUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.panelDeviceInfo);
            resources.ApplyResources(this, "$this");
            this.Name = "ConnectionUC";
            this.panelDeviceInfo.ResumeLayout(false);
            this.panelConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeviceInfo;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTension;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonTare;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Label labelCOMfound;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
