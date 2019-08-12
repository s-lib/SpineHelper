namespace SpineHelper.View
{
    partial class SpineTestUC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpineTestUC));
            this.labelSecondary = new System.Windows.Forms.Label();
            this.labelSecondaryValue = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelSpine = new System.Windows.Forms.Label();
            this.labelMainValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSecondary
            // 
            resources.ApplyResources(this.labelSecondary, "labelSecondary");
            this.labelSecondary.Name = "labelSecondary";
            // 
            // labelSecondaryValue
            // 
            resources.ApplyResources(this.labelSecondaryValue, "labelSecondaryValue");
            this.labelSecondaryValue.Name = "labelSecondaryValue";
            // 
            // labelMain
            // 
            resources.ApplyResources(this.labelMain, "labelMain");
            this.labelMain.Name = "labelMain";
            // 
            // labelSpine
            // 
            resources.ApplyResources(this.labelSpine, "labelSpine");
            this.labelSpine.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelSpine.Name = "labelSpine";
            // 
            // labelMainValue
            // 
            resources.ApplyResources(this.labelMainValue, "labelMainValue");
            this.labelMainValue.Name = "labelMainValue";
            // 
            // SpineTestUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.labelSecondaryValue);
            this.Controls.Add(this.labelSecondary);
            this.Controls.Add(this.labelMainValue);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelSpine);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SpineTestUC";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSecondary;
        private System.Windows.Forms.Label labelSecondaryValue;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelSpine;
        private System.Windows.Forms.Label labelMainValue;
    }
}
