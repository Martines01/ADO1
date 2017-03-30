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
        List<Artikel> listArtikel = null;
        public Form1()
        {
            InitializeComponent();
            listArtikel = new List<Artikel>();
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
                buttonCreateItem.Enabled = true;
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
            listBoxAusgabe.DataSource = null;
            listArtikel.Clear();
            while(reader.Read())
            {
                listBoxAusgabe.Items.Add(mkArtikelObject(reader));
                //String zeile = reader["ArtikelNr"] + ": " + reader["Bezeichnung"];
                //listBoxAusgabe.Items.Add(zeile);
                listArtikel.Add(mkArtikelObject(reader));
            }
            reader.Close();
            listBoxAusgabe.DataSource = listArtikel;
            listBoxAusgabe.DisplayMember = "Display";
        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            
            int i = 0;
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelOid = Convert.ToInt32(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelNr = reader[i++].ToString();
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelGruppe = Convert.ToInt32(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.Bezeichnung = reader[i++].ToString();
            if (!DBNull.Value.Equals(reader[i])) a.Bestand = Convert.ToInt16(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.Meldebestand = Convert.ToInt16(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.Verpackung = Convert.ToInt16(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.VkPreis = Convert.ToDecimal(reader[i++]);
            if (!DBNull.Value.Equals(reader[i])) a.letzteEntnahme = Convert.ToDateTime(reader[i]);
          

            return a;
        }

        private void buttonCreateItem_Click(object sender, EventArgs e)
        {
            FormCreateItem frmArt = new FormCreateItem(con);
            frmArt.ShowDialog(); // modal öffnen
            if(frmArt.NewArtikel != null)
            {
                listArtikel.Add(frmArt.NewArtikel);
            }

        }
    }
}
