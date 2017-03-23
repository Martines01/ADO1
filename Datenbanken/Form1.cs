using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Datenbanken
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            //OleDbConnectionStringBuilder strgbild = new OleDbConnectionStringBuilder();
            //strgbild.Provider = "Microsoft.ACE.OLEDB.12.0";
            //strgbild.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            try
            { 
                con.Open();
                buttonCommand.Enabled = true;
            }
            catch (OleDbException ex)
            {  
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonCommand_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.Parameters.Add("belibig", OleDbType.Integer);
            String artgr = textBoxArtikelGruppe.Text;
            cmd.CommandText = "Select * from tArtikel where Artikelgruppe = belibig";
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.Parameters["belibig"].Value = textBoxArtikelGruppe.Text;
                reader = cmd.ExecuteReader();
                buttonRead.Enabled = true;

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBoxAusgabe.Items.Clear();
            while(reader.Read())
            {
                //Artikel a = mkArtikelObject(reader);
                listBoxAusgabe.Items.Add(mkArtikelObject(reader));


                //String zeile = reader["ArtikelNr"] + ": " + reader["Bezeichnung"];
                //listBoxAusgabe.Items.Add(zeile);
            }
            reader.Close();
        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            
            int i = 0;
            if(reader[i] != null)a.ArtikelOid = Convert.ToInt32(reader[i]);
            i++;
            a.ArtikelNr = Convert.ToInt32(reader[i++]);
            a.ArtikelGruppe = Convert.ToInt32(reader[i++]);
            a.Bezeichnung = reader[i++].ToString();
            a.Bestand = Convert.ToInt16(reader[i++]);
            a.Meldebestand = Convert.ToInt16(reader[i++]);
            a.Verpackung = Convert.ToInt16(reader[i++]);
            a.VkPreis = Convert.ToDecimal(reader[i++]);
            a.letzteEntnahme = Convert.ToDateTime(reader[i++]);

            return a;
        }
    }
}
