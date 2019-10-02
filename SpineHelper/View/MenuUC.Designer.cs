namespace SpineHelper.View
{
    partial class MenuUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUC));
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.contextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.historyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleSpineTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuHelp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDevice = new System.Windows.Forms.Button();
            this.contextMenuDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.installDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFile.SuspendLayout();
            this.contextMenuOptions.SuspendLayout();
            this.contextMenuHelp.SuspendLayout();
            this.contextMenuDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            resources.ApplyResources(this.buttonFile, "buttonFile");
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.UseVisualStyleBackColor = true;
            // 
            // buttonOptions
            // 
            resources.ApplyResources(this.buttonOptions, "buttonOptions");
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // contextMenuFile
            // 
            this.contextMenuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exportHistoryToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuFile.Name = "contextMenuFile";
            resources.ApplyResources(this.contextMenuFile, "contextMenuFile");
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exportHistoryToolStripMenuItem
            // 
            this.exportHistoryToolStripMenuItem.Name = "exportHistoryToolStripMenuItem";
            resources.ApplyResources(this.exportHistoryToolStripMenuItem, "exportHistoryToolStripMenuItem");
            this.exportHistoryToolStripMenuItem.Click += new System.EventHandler(this.exportHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuOptions
            // 
            this.contextMenuOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyViewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.preferencesToolStripMenuItem});
            this.contextMenuOptions.Name = "contextMenuOptions";
            resources.ApplyResources(this.contextMenuOptions, "contextMenuOptions");
            // 
            // historyViewToolStripMenuItem
            // 
            this.historyViewToolStripMenuItem.Name = "historyViewToolStripMenuItem";
            resources.ApplyResources(this.historyViewToolStripMenuItem, "historyViewToolStripMenuItem");
            this.historyViewToolStripMenuItem.Click += new System.EventHandler(this.historyViewStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // multipleSpineTestToolStripMenuItem
            // 
            this.multipleSpineTestToolStripMenuItem.Name = "multipleSpineTestToolStripMenuItem";
            resources.ApplyResources(this.multipleSpineTestToolStripMenuItem, "multipleSpineTestToolStripMenuItem");
            this.multipleSpineTestToolStripMenuItem.Click += new System.EventHandler(this.multipleSpineTestToolStripMenuItem_Click);
            // 
            // contextMenuHelp
            // 
            this.contextMenuHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpdatesToolStripMenuItem,
            this.viewManualToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem});
            this.contextMenuHelp.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuHelp, "contextMenuHelp");
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkUpdatesToolStripMenuItem, "checkUpdatesToolStripMenuItem");
            this.checkUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkUpdatesToolStripMenuItem_Click);
            // 
            // viewManualToolStripMenuItem
            // 
            this.viewManualToolStripMenuItem.Name = "viewManualToolStripMenuItem";
            resources.ApplyResources(this.viewManualToolStripMenuItem, "viewManualToolStripMenuItem");
            this.viewManualToolStripMenuItem.Click += new System.EventHandler(this.viewManualToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            resources.ApplyResources(this.changelogToolStripMenuItem, "changelogToolStripMenuItem");
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonDevice
            // 
            resources.ApplyResources(this.buttonDevice, "buttonDevice");
            this.buttonDevice.Name = "buttonDevice";
            this.buttonDevice.UseVisualStyleBackColor = true;
            // 
            // contextMenuDevice
            // 
            this.contextMenuDevice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.deviceInfoToolStripMenuItem,
            this.calibrationToolStripMenuItem,
            this.multipleSpineTestToolStripMenuItem,
            this.toolStripMenuItem3,
            this.installDriversToolStripMenuItem});
            this.contextMenuDevice.Name = "contextMenuDevice";
            resources.ApplyResources(this.contextMenuDevice, "contextMenuDevice");
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.tareToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            resources.ApplyResources(this.connectionToolStripMenuItem, "connectionToolStripMenuItem");
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            // 
            // connectToolStripMenuItem
            // 
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // tareToolStripMenuItem
            // 
            resources.ApplyResources(this.tareToolStripMenuItem, "tareToolStripMenuItem");
            this.tareToolStripMenuItem.Name = "tareToolStripMenuItem";
            this.tareToolStripMenuItem.Click += new System.EventHandler(this.tareToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // deviceInfoToolStripMenuItem
            // 
            this.deviceInfoToolStripMenuItem.Name = "deviceInfoToolStripMenuItem";
            resources.ApplyResources(this.deviceInfoToolStripMenuItem, "deviceInfoToolStripMenuItem");
            this.deviceInfoToolStripMenuItem.Click += new System.EventHandler(this.deviceInfoToolStripMenuItem_Click);
            // 
            // calibrationToolStripMenuItem
            // 
            this.calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            resources.ApplyResources(this.calibrationToolStripMenuItem, "calibrationToolStripMenuItem");
            this.calibrationToolStripMenuItem.Click += new System.EventHandler(this.calibrationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // installDriversToolStripMenuItem
            // 
            this.installDriversToolStripMenuItem.Name = "installDriversToolStripMenuItem";
            resources.ApplyResources(this.installDriversToolStripMenuItem, "installDriversToolStripMenuItem");
            this.installDriversToolStripMenuItem.Click += new System.EventHandler(this.installDriversToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MenuUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonDevice);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonFile);
            this.Name = "MenuUC";
            this.contextMenuFile.ResumeLayout(false);
            this.contextMenuOptions.ResumeLayout(false);
            this.contextMenuHelp.ResumeLayout(false);
            this.contextMenuDevice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonDevice;
        private System.Windows.Forms.ContextMenuStrip contextMenuDevice;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem installDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleSpineTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}
