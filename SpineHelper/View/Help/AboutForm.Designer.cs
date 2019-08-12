namespace SpineHelper
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelBuilt = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            this.labelRights = new System.Windows.Forms.Label();
            this.linkLabelForum = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.Name = "labelVersion";
            // 
            // labelBuilt
            // 
            resources.ApplyResources(this.labelBuilt, "labelBuilt");
            this.labelBuilt.Name = "labelBuilt";
            // 
            // labelCopyright
            // 
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.labelCopyright.Name = "labelCopyright";
            // 
            // linkLabelWeb
            // 
            resources.ApplyResources(this.linkLabelWeb, "linkLabelWeb");
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // labelRights
            // 
            resources.ApplyResources(this.labelRights, "labelRights");
            this.labelRights.Name = "labelRights";
            // 
            // linkLabelForum
            // 
            resources.ApplyResources(this.linkLabelForum, "linkLabelForum");
            this.linkLabelForum.Name = "linkLabelForum";
            this.linkLabelForum.TabStop = true;
            this.linkLabelForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForum_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpineHelper.Properties.Resources._128;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxMail, "textBoxMail");
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.TabStop = false;
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.linkLabelForum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRights);
            this.Controls.Add(this.linkLabelWeb);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelBuilt);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelBuilt;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.LinkLabel linkLabelWeb;
        private System.Windows.Forms.Label labelRights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelForum;
        private System.Windows.Forms.TextBox textBoxMail;
    }
}