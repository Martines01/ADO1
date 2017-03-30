namespace Datenbanken
{
    partial class FormCreateItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArtikelOid = new System.Windows.Forms.TextBox();
            this.textBoxArtikelNr = new System.Windows.Forms.TextBox();
            this.textBoxArtikelGrp = new System.Windows.Forms.TextBox();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxVerpackung = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArtikelOID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artikel Nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artikel Gruppe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bezeichnung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verpackung";
            // 
            // textBoxArtikelOid
            // 
            this.textBoxArtikelOid.Enabled = false;
            this.textBoxArtikelOid.Location = new System.Drawing.Point(124, 21);
            this.textBoxArtikelOid.Name = "textBoxArtikelOid";
            this.textBoxArtikelOid.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelOid.TabIndex = 5;
            // 
            // textBoxArtikelNr
            // 
            this.textBoxArtikelNr.Location = new System.Drawing.Point(124, 50);
            this.textBoxArtikelNr.Name = "textBoxArtikelNr";
            this.textBoxArtikelNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelNr.TabIndex = 6;
            // 
            // textBoxArtikelGrp
            // 
            this.textBoxArtikelGrp.Location = new System.Drawing.Point(124, 92);
            this.textBoxArtikelGrp.Name = "textBoxArtikelGrp";
            this.textBoxArtikelGrp.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelGrp.TabIndex = 7;
            this.textBoxArtikelGrp.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxArtikelGrp_Validating);
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(124, 127);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxBezeichnung.TabIndex = 8;
            // 
            // textBoxVerpackung
            // 
            this.textBoxVerpackung.Location = new System.Drawing.Point(124, 160);
            this.textBoxVerpackung.Name = "textBoxVerpackung";
            this.textBoxVerpackung.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerpackung.TabIndex = 9;
            this.textBoxVerpackung.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVerpackung_Validating);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(27, 205);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbruch
            // 
            this.buttonAbruch.Location = new System.Drawing.Point(148, 205);
            this.buttonAbruch.Name = "buttonAbruch";
            this.buttonAbruch.Size = new System.Drawing.Size(75, 23);
            this.buttonAbruch.TabIndex = 11;
            this.buttonAbruch.Text = "Abruch";
            this.buttonAbruch.UseVisualStyleBackColor = true;
            this.buttonAbruch.Click += new System.EventHandler(this.buttonAbruch_Click);
            // 
            // FormCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAbruch);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxVerpackung);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.textBoxArtikelGrp);
            this.Controls.Add(this.textBoxArtikelNr);
            this.Controls.Add(this.textBoxArtikelOid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateItem";
            this.Text = "Artikel Aufnehmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArtikelOid;
        private System.Windows.Forms.TextBox textBoxArtikelNr;
        private System.Windows.Forms.TextBox textBoxArtikelGrp;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxVerpackung;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbruch;
    }
}