namespace LernprogrammBasispassPferdekunde
{
    partial class Form3
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUeberschrift = new System.Windows.Forms.Label();
            this.lblMultiple = new System.Windows.Forms.Label();
            this.lblLernspiel = new System.Windows.Forms.Label();
            this.lblUeM = new System.Windows.Forms.Label();
            this.lblUeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUeberschrift
            // 
            this.lblUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschrift.Location = new System.Drawing.Point(12, 9);
            this.lblUeberschrift.Name = "lblUeberschrift";
            this.lblUeberschrift.Size = new System.Drawing.Size(740, 33);
            this.lblUeberschrift.TabIndex = 1;
            this.lblUeberschrift.Text = "labelUeberschrift";
            // 
            // lblMultiple
            // 
            this.lblMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiple.Location = new System.Drawing.Point(12, 51);
            this.lblMultiple.Name = "lblMultiple";
            this.lblMultiple.Size = new System.Drawing.Size(740, 137);
            this.lblMultiple.TabIndex = 2;
            this.lblMultiple.Text = "LabelM";
            // 
            // lblLernspiel
            // 
            this.lblLernspiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLernspiel.Location = new System.Drawing.Point(12, 208);
            this.lblLernspiel.Name = "lblLernspiel";
            this.lblLernspiel.Size = new System.Drawing.Size(740, 111);
            this.lblLernspiel.TabIndex = 3;
            this.lblLernspiel.Text = "labelL";
            // 
            // lblUeM
            // 
            this.lblUeM.AutoSize = true;
            this.lblUeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeM.Location = new System.Drawing.Point(12, 31);
            this.lblUeM.Name = "lblUeM";
            this.lblUeM.Size = new System.Drawing.Size(84, 20);
            this.lblUeM.TabIndex = 4;
            this.lblUeM.Text = "labelUeM";
            // 
            // lblUeL
            // 
            this.lblUeL.AutoSize = true;
            this.lblUeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeL.Location = new System.Drawing.Point(12, 188);
            this.lblUeL.Name = "lblUeL";
            this.lblUeL.Size = new System.Drawing.Size(80, 20);
            this.lblUeL.TabIndex = 5;
            this.lblUeL.Text = "labelUeL";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 328);
            this.Controls.Add(this.lblUeL);
            this.Controls.Add(this.lblUeM);
            this.Controls.Add(this.lblLernspiel);
            this.Controls.Add(this.lblMultiple);
            this.Controls.Add(this.lblUeberschrift);
            this.Name = "Form3";
            this.Text = "Hilfe zum Lernprogramm Basispass Pferdekunde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUeberschrift;
        private System.Windows.Forms.Label lblMultiple;
        private System.Windows.Forms.Label lblLernspiel;
        private System.Windows.Forms.Label lblUeM;
        private System.Windows.Forms.Label lblUeL;
    }
}