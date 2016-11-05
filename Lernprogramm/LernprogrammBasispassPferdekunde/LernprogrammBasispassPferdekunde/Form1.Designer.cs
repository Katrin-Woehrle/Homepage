namespace LernprogrammBasispassPferdekunde
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rBAntwort1 = new System.Windows.Forms.RadioButton();
            this.rBAntwort2 = new System.Windows.Forms.RadioButton();
            this.rBAntwort3 = new System.Windows.Forms.RadioButton();
            this.lblFrageNummer = new System.Windows.Forms.Label();
            this.lblFrageID = new System.Windows.Forms.Label();
            this.lblFrage = new System.Windows.Forms.Label();
            this.btnAwPruefen = new System.Windows.Forms.Button();
            this.btnaudio = new System.Windows.Forms.Button();
            this.pBBild = new System.Windows.Forms.PictureBox();
            this.pBEndbild = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEndbild)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.spielToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.beendenToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            this.spielToolStripMenuItem.Click += new System.EventHandler(this.spielToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem1
            // 
            this.beendenToolStripMenuItem1.Name = "beendenToolStripMenuItem1";
            this.beendenToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem1.Text = "Beenden";
            this.beendenToolStripMenuItem1.Click += new System.EventHandler(this.beendenToolStripMenuItem1_Click);
            // 
            // rBAntwort1
            // 
            this.rBAntwort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBAntwort1.Location = new System.Drawing.Point(20, 104);
            this.rBAntwort1.Name = "rBAntwort1";
            this.rBAntwort1.Size = new System.Drawing.Size(682, 66);
            this.rBAntwort1.TabIndex = 2;
            this.rBAntwort1.TabStop = true;
            this.rBAntwort1.Text = "rBAntwort1";
            this.rBAntwort1.UseVisualStyleBackColor = true;
            this.rBAntwort1.Click += new System.EventHandler(this.rBAntwort1_Click);
            // 
            // rBAntwort2
            // 
            this.rBAntwort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBAntwort2.Location = new System.Drawing.Point(20, 185);
            this.rBAntwort2.Name = "rBAntwort2";
            this.rBAntwort2.Size = new System.Drawing.Size(682, 66);
            this.rBAntwort2.TabIndex = 3;
            this.rBAntwort2.TabStop = true;
            this.rBAntwort2.Text = "rBAntwort2";
            this.rBAntwort2.UseVisualStyleBackColor = true;
            this.rBAntwort2.Click += new System.EventHandler(this.rBAntwort2_Click);
            // 
            // rBAntwort3
            // 
            this.rBAntwort3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBAntwort3.Location = new System.Drawing.Point(20, 268);
            this.rBAntwort3.Name = "rBAntwort3";
            this.rBAntwort3.Size = new System.Drawing.Size(682, 66);
            this.rBAntwort3.TabIndex = 4;
            this.rBAntwort3.TabStop = true;
            this.rBAntwort3.Text = "rBAntwort3";
            this.rBAntwort3.UseVisualStyleBackColor = true;
            this.rBAntwort3.Click += new System.EventHandler(this.rBAntwort3_Click);
            // 
            // lblFrageNummer
            // 
            this.lblFrageNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrageNummer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFrageNummer.Location = new System.Drawing.Point(16, 42);
            this.lblFrageNummer.Name = "lblFrageNummer";
            this.lblFrageNummer.Size = new System.Drawing.Size(65, 33);
            this.lblFrageNummer.TabIndex = 5;
            this.lblFrageNummer.Text = "Frage Nr.";
            // 
            // lblFrageID
            // 
            this.lblFrageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrageID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFrageID.Location = new System.Drawing.Point(87, 42);
            this.lblFrageID.Name = "lblFrageID";
            this.lblFrageID.Size = new System.Drawing.Size(34, 33);
            this.lblFrageID.TabIndex = 6;
            this.lblFrageID.Text = "ID";
            // 
            // lblFrage
            // 
            this.lblFrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrage.Location = new System.Drawing.Point(127, 29);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(920, 50);
            this.lblFrage.TabIndex = 7;
            this.lblFrage.Text = "Frage";
            this.lblFrage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAwPruefen
            // 
            this.btnAwPruefen.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAwPruefen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAwPruefen.Location = new System.Drawing.Point(16, 340);
            this.btnAwPruefen.Name = "btnAwPruefen";
            this.btnAwPruefen.Size = new System.Drawing.Size(114, 23);
            this.btnAwPruefen.TabIndex = 9;
            this.btnAwPruefen.Text = "Antwort prüfen";
            this.btnAwPruefen.UseVisualStyleBackColor = false;
            this.btnAwPruefen.Click += new System.EventHandler(this.btnAwPruefen_Click);
            // 
            // btnaudio
            // 
            this.btnaudio.BackColor = System.Drawing.Color.AliceBlue;
            this.btnaudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaudio.Image = ((System.Drawing.Image)(resources.GetObject("btnaudio.Image")));
            this.btnaudio.Location = new System.Drawing.Point(16, 78);
            this.btnaudio.Name = "btnaudio";
            this.btnaudio.Size = new System.Drawing.Size(52, 25);
            this.btnaudio.TabIndex = 8;
            this.btnaudio.UseVisualStyleBackColor = false;
            this.btnaudio.Click += new System.EventHandler(this.btnaudio_Click);
            // 
            // pBBild
            // 
            this.pBBild.Location = new System.Drawing.Point(763, 103);
            this.pBBild.Name = "pBBild";
            this.pBBild.Size = new System.Drawing.Size(284, 230);
            this.pBBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBBild.TabIndex = 1;
            this.pBBild.TabStop = false;
            // 
            // pBEndbild
            // 
            this.pBEndbild.Image = ((System.Drawing.Image)(resources.GetObject("pBEndbild.Image")));
            this.pBEndbild.Location = new System.Drawing.Point(0, 27);
            this.pBEndbild.Name = "pBEndbild";
            this.pBEndbild.Size = new System.Drawing.Size(1059, 352);
            this.pBEndbild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBEndbild.TabIndex = 10;
            this.pBEndbild.TabStop = false;
            this.pBEndbild.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1059, 380);
            this.Controls.Add(this.btnAwPruefen);
            this.Controls.Add(this.btnaudio);
            this.Controls.Add(this.lblFrage);
            this.Controls.Add(this.lblFrageID);
            this.Controls.Add(this.lblFrageNummer);
            this.Controls.Add(this.rBAntwort3);
            this.Controls.Add(this.rBAntwort2);
            this.Controls.Add(this.rBAntwort1);
            this.Controls.Add(this.pBBild);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pBEndbild);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lernprogramm Basispass Pferdekunde";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEndbild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBBild;
        private System.Windows.Forms.RadioButton rBAntwort1;
        private System.Windows.Forms.RadioButton rBAntwort2;
        private System.Windows.Forms.RadioButton rBAntwort3;
        private System.Windows.Forms.Label lblFrageNummer;
        private System.Windows.Forms.Label lblFrageID;
        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Button btnaudio;
        private System.Windows.Forms.Button btnAwPruefen;
        private System.Windows.Forms.PictureBox pBEndbild;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
    }
}

