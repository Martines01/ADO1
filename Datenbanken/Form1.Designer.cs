namespace Datenbanken
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
            this.buttonConnection = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.labelArtGrp = new System.Windows.Forms.Label();
            this.textBoxArtikelGruppe = new System.Windows.Forms.TextBox();
            this.buttonCreateItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(43, 32);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(156, 52);
            this.buttonConnection.TabIndex = 0;
            this.buttonConnection.Text = "Connection öffnen";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Enabled = false;
            this.buttonCommand.Location = new System.Drawing.Point(43, 111);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(156, 51);
            this.buttonCommand.TabIndex = 1;
            this.buttonCommand.Text = "SQL - Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(43, 182);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(156, 43);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "auslesen";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(43, 252);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(234, 147);
            this.listBoxAusgabe.TabIndex = 3;
            // 
            // labelArtGrp
            // 
            this.labelArtGrp.AutoSize = true;
            this.labelArtGrp.Location = new System.Drawing.Point(223, 111);
            this.labelArtGrp.Name = "labelArtGrp";
            this.labelArtGrp.Size = new System.Drawing.Size(69, 13);
            this.labelArtGrp.TabIndex = 4;
            this.labelArtGrp.Text = "Artikelgruppe";
            // 
            // textBoxArtikelGruppe
            // 
            this.textBoxArtikelGruppe.Location = new System.Drawing.Point(299, 110);
            this.textBoxArtikelGruppe.Name = "textBoxArtikelGruppe";
            this.textBoxArtikelGruppe.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelGruppe.TabIndex = 5;
            // 
            // buttonCreateItem
            // 
            this.buttonCreateItem.Enabled = false;
            this.buttonCreateItem.Location = new System.Drawing.Point(344, 282);
            this.buttonCreateItem.Name = "buttonCreateItem";
            this.buttonCreateItem.Size = new System.Drawing.Size(110, 50);
            this.buttonCreateItem.TabIndex = 6;
            this.buttonCreateItem.Text = "Neuer Artikel";
            this.buttonCreateItem.UseVisualStyleBackColor = true;
            this.buttonCreateItem.Click += new System.EventHandler(this.buttonCreateItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 439);
            this.Controls.Add(this.buttonCreateItem);
            this.Controls.Add(this.textBoxArtikelGruppe);
            this.Controls.Add(this.labelArtGrp);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.buttonConnection);
            this.Name = "Form1";
            this.Text = "ADO - Connect Beispiel 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Label labelArtGrp;
        private System.Windows.Forms.TextBox textBoxArtikelGruppe;
        private System.Windows.Forms.Button buttonCreateItem;
    }
}

