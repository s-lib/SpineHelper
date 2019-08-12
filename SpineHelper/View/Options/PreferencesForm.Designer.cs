namespace SpineHelper.View.Device
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.checkBoxAutoUpdates = new System.Windows.Forms.CheckBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelResultsSize = new System.Windows.Forms.Label();
            this.comboBoxResultsSize = new System.Windows.Forms.ComboBox();
            this.labelColorScheme = new System.Windows.Forms.Label();
            this.comboBoxColorScheme = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.groupBoxDiagnostics = new System.Windows.Forms.GroupBox();
            this.checkBoxDebugMode = new System.Windows.Forms.CheckBox();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.checkBoxConfirmHistoryRemove = new System.Windows.Forms.CheckBox();
            this.checkBoxConfirmHistoryClear = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifySaveLoad = new System.Windows.Forms.CheckBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxSimplifiedConnection = new System.Windows.Forms.CheckBox();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.groupUpdate.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxDiagnostics.SuspendLayout();
            this.groupBoxNotifications.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.toolTips.SetToolTip(this.buttonOK, resources.GetString("buttonOK.ToolTip"));
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.toolTips.SetToolTip(this.buttonCancel, resources.GetString("buttonCancel.ToolTip"));
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupUpdate
            // 
            resources.ApplyResources(this.groupUpdate, "groupUpdate");
            this.groupUpdate.Controls.Add(this.buttonUpdate);
            this.groupUpdate.Controls.Add(this.checkBoxAutoUpdates);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.TabStop = false;
            this.toolTips.SetToolTip(this.groupUpdate, resources.GetString("groupUpdate.ToolTip"));
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.toolTips.SetToolTip(this.buttonUpdate, resources.GetString("buttonUpdate.ToolTip"));
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxAutoUpdates
            // 
            resources.ApplyResources(this.checkBoxAutoUpdates, "checkBoxAutoUpdates");
            this.checkBoxAutoUpdates.Name = "checkBoxAutoUpdates";
            this.toolTips.SetToolTip(this.checkBoxAutoUpdates, resources.GetString("checkBoxAutoUpdates.ToolTip"));
            this.checkBoxAutoUpdates.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneral
            // 
            resources.ApplyResources(this.groupBoxGeneral, "groupBoxGeneral");
            this.groupBoxGeneral.Controls.Add(this.buttonRestart);
            this.groupBoxGeneral.Controls.Add(this.labelRestart);
            this.groupBoxGeneral.Controls.Add(this.labelResultsSize);
            this.groupBoxGeneral.Controls.Add(this.comboBoxResultsSize);
            this.groupBoxGeneral.Controls.Add(this.labelColorScheme);
            this.groupBoxGeneral.Controls.Add(this.comboBoxColorScheme);
            this.groupBoxGeneral.Controls.Add(this.labelLanguage);
            this.groupBoxGeneral.Controls.Add(this.comboBoxLanguage);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.TabStop = false;
            this.toolTips.SetToolTip(this.groupBoxGeneral, resources.GetString("groupBoxGeneral.ToolTip"));
            // 
            // buttonRestart
            // 
            resources.ApplyResources(this.buttonRestart, "buttonRestart");
            this.buttonRestart.Name = "buttonRestart";
            this.toolTips.SetToolTip(this.buttonRestart, resources.GetString("buttonRestart.ToolTip"));
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelRestart
            // 
            resources.ApplyResources(this.labelRestart, "labelRestart");
            this.labelRestart.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRestart.Name = "labelRestart";
            this.toolTips.SetToolTip(this.labelRestart, resources.GetString("labelRestart.ToolTip"));
            // 
            // labelResultsSize
            // 
            resources.ApplyResources(this.labelResultsSize, "labelResultsSize");
            this.labelResultsSize.Name = "labelResultsSize";
            this.toolTips.SetToolTip(this.labelResultsSize, resources.GetString("labelResultsSize.ToolTip"));
            // 
            // comboBoxResultsSize
            // 
            resources.ApplyResources(this.comboBoxResultsSize, "comboBoxResultsSize");
            this.comboBoxResultsSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResultsSize.FormattingEnabled = true;
            this.comboBoxResultsSize.Items.AddRange(new object[] {
            resources.GetString("comboBoxResultsSize.Items")});
            this.comboBoxResultsSize.Name = "comboBoxResultsSize";
            this.toolTips.SetToolTip(this.comboBoxResultsSize, resources.GetString("comboBoxResultsSize.ToolTip"));
            // 
            // labelColorScheme
            // 
            resources.ApplyResources(this.labelColorScheme, "labelColorScheme");
            this.labelColorScheme.Name = "labelColorScheme";
            this.toolTips.SetToolTip(this.labelColorScheme, resources.GetString("labelColorScheme.ToolTip"));
            // 
            // comboBoxColorScheme
            // 
            resources.ApplyResources(this.comboBoxColorScheme, "comboBoxColorScheme");
            this.comboBoxColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorScheme.FormattingEnabled = true;
            this.comboBoxColorScheme.Items.AddRange(new object[] {
            resources.GetString("comboBoxColorScheme.Items")});
            this.comboBoxColorScheme.Name = "comboBoxColorScheme";
            this.toolTips.SetToolTip(this.comboBoxColorScheme, resources.GetString("comboBoxColorScheme.ToolTip"));
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            this.toolTips.SetToolTip(this.labelLanguage, resources.GetString("labelLanguage.ToolTip"));
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.toolTips.SetToolTip(this.comboBoxLanguage, resources.GetString("comboBoxLanguage.ToolTip"));
            // 
            // groupBoxDiagnostics
            // 
            resources.ApplyResources(this.groupBoxDiagnostics, "groupBoxDiagnostics");
            this.groupBoxDiagnostics.Controls.Add(this.checkBoxDebugMode);
            this.groupBoxDiagnostics.Name = "groupBoxDiagnostics";
            this.groupBoxDiagnostics.TabStop = false;
            this.toolTips.SetToolTip(this.groupBoxDiagnostics, resources.GetString("groupBoxDiagnostics.ToolTip"));
            // 
            // checkBoxDebugMode
            // 
            resources.ApplyResources(this.checkBoxDebugMode, "checkBoxDebugMode");
            this.checkBoxDebugMode.Name = "checkBoxDebugMode";
            this.toolTips.SetToolTip(this.checkBoxDebugMode, resources.GetString("checkBoxDebugMode.ToolTip"));
            this.checkBoxDebugMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxNotifications
            // 
            resources.ApplyResources(this.groupBoxNotifications, "groupBoxNotifications");
            this.groupBoxNotifications.Controls.Add(this.checkBoxConfirmHistoryRemove);
            this.groupBoxNotifications.Controls.Add(this.checkBoxConfirmHistoryClear);
            this.groupBoxNotifications.Controls.Add(this.checkBoxNotifySaveLoad);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.TabStop = false;
            this.toolTips.SetToolTip(this.groupBoxNotifications, resources.GetString("groupBoxNotifications.ToolTip"));
            // 
            // checkBoxConfirmHistoryRemove
            // 
            resources.ApplyResources(this.checkBoxConfirmHistoryRemove, "checkBoxConfirmHistoryRemove");
            this.checkBoxConfirmHistoryRemove.Name = "checkBoxConfirmHistoryRemove";
            this.toolTips.SetToolTip(this.checkBoxConfirmHistoryRemove, resources.GetString("checkBoxConfirmHistoryRemove.ToolTip"));
            this.checkBoxConfirmHistoryRemove.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfirmHistoryClear
            // 
            resources.ApplyResources(this.checkBoxConfirmHistoryClear, "checkBoxConfirmHistoryClear");
            this.checkBoxConfirmHistoryClear.Name = "checkBoxConfirmHistoryClear";
            this.toolTips.SetToolTip(this.checkBoxConfirmHistoryClear, resources.GetString("checkBoxConfirmHistoryClear.ToolTip"));
            this.checkBoxConfirmHistoryClear.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifySaveLoad
            // 
            resources.ApplyResources(this.checkBoxNotifySaveLoad, "checkBoxNotifySaveLoad");
            this.checkBoxNotifySaveLoad.Name = "checkBoxNotifySaveLoad";
            this.toolTips.SetToolTip(this.checkBoxNotifySaveLoad, resources.GetString("checkBoxNotifySaveLoad.ToolTip"));
            this.checkBoxNotifySaveLoad.UseVisualStyleBackColor = true;
            // 
            // toolTips
            // 
            this.toolTips.AutomaticDelay = 800;
            // 
            // checkBoxSimplifiedConnection
            // 
            resources.ApplyResources(this.checkBoxSimplifiedConnection, "checkBoxSimplifiedConnection");
            this.checkBoxSimplifiedConnection.Name = "checkBoxSimplifiedConnection";
            this.toolTips.SetToolTip(this.checkBoxSimplifiedConnection, resources.GetString("checkBoxSimplifiedConnection.ToolTip"));
            this.checkBoxSimplifiedConnection.UseVisualStyleBackColor = true;
            // 
            // groupBoxConnection
            // 
            resources.ApplyResources(this.groupBoxConnection, "groupBoxConnection");
            this.groupBoxConnection.Controls.Add(this.checkBoxSimplifiedConnection);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.TabStop = false;
            this.toolTips.SetToolTip(this.groupBoxConnection, resources.GetString("groupBoxConnection.ToolTip"));
            // 
            // PreferencesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxNotifications);
            this.Controls.Add(this.groupBoxDiagnostics);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreferencesForm";
            this.toolTips.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxDiagnostics.ResumeLayout(false);
            this.groupBoxDiagnostics.PerformLayout();
            this.groupBoxNotifications.ResumeLayout(false);
            this.groupBoxNotifications.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdates;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelColorScheme;
        private System.Windows.Forms.ComboBox comboBoxColorScheme;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelResultsSize;
        private System.Windows.Forms.ComboBox comboBoxResultsSize;
        private System.Windows.Forms.GroupBox groupBoxDiagnostics;
        private System.Windows.Forms.CheckBox checkBoxDebugMode;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.GroupBox groupBoxNotifications;
        private System.Windows.Forms.CheckBox checkBoxConfirmHistoryRemove;
        private System.Windows.Forms.CheckBox checkBoxConfirmHistoryClear;
        private System.Windows.Forms.CheckBox checkBoxNotifySaveLoad;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.CheckBox checkBoxSimplifiedConnection;
    }
}