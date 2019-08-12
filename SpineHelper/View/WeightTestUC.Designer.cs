namespace SpineHelper.View
{
    partial class WeightTestUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightTestUC));
            this.labelSecondaryValue = new System.Windows.Forms.Label();
            this.labelSecondary = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMainValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSecondaryValue
            // 
            resources.ApplyResources(this.labelSecondaryValue, "labelSecondaryValue");
            this.labelSecondaryValue.Name = "labelSecondaryValue";
            // 
            // labelSecondary
            // 
            resources.ApplyResources(this.labelSecondary, "labelSecondary");
            this.labelSecondary.Name = "labelSecondary";
            // 
            // labelMain
            // 
            resources.ApplyResources(this.labelMain, "labelMain");
            this.labelMain.Name = "labelMain";
            // 
            // labelWeight
            // 
            resources.ApplyResources(this.labelWeight, "labelWeight");
            this.labelWeight.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelWeight.Name = "labelWeight";
            // 
            // labelMainValue
            // 
            resources.ApplyResources(this.labelMainValue, "labelMainValue");
            this.labelMainValue.Name = "labelMainValue";
            // 
            // WeightTestUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.labelSecondaryValue);
            this.Controls.Add(this.labelSecondary);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelMainValue);
            this.Controls.Add(this.labelMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "WeightTestUC";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSecondaryValue;
        private System.Windows.Forms.Label labelSecondary;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMainValue;
    }
}
