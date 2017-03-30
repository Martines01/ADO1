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
    public partial class FormCreateItem : Form
    {
        OleDbConnection con = null;
        Artikel newArtikel = null;
        public FormCreateItem()
        {
            InitializeComponent();
        }

        public FormCreateItem(OleDbConnection ole)
        {
            this.con = ole;
            InitializeComponent();
        }

        internal Artikel NewArtikel
        {
            get
            {
                return newArtikel;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();
            a.ArtikelNr = textBoxArtikelNr.Text;
            a.ArtikelGruppe = Convert.ToInt32(textBoxArtikelGrp.Text);
            a.Bezeichnung = textBoxBezeichnung.Text;
            a.Verpackung = Convert.ToInt32(textBoxVerpackung.Text);
            insertDB(a);

            newArtikel = a;
            this.Close();
        }
        private void insertDB(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();
            string sql = "Insert Into tArtikel(ArtikelNr,ArtikelGruppe,Bezeichnung,Verpackung) values (ANR,AG,BEZ,VP)";
            cmd.Parameters.Add("ANR", OleDbType.WChar);
            cmd.Parameters.Add("AG", OleDbType.Integer);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);            
            cmd.Parameters.Add("VP", OleDbType.Integer);
            cmd.CommandText = sql;

            // Values
            cmd.Parameters["ANR"].Value = a.ArtikelNr;           
            cmd.Parameters["AG"].Value = a.ArtikelGruppe;
            cmd.Parameters["BEZ"].Value = a.Bezeichnung;
            cmd.Parameters["VP"].Value = a.Verpackung;
            // Ausführen
            try
            {
                int anzahl = cmd.ExecuteNonQuery();

                // Autowert
                cmd.CommandText = "SELECT @@IDENTITY FROM tArtikel";
                Int32 autowert = (Int32)cmd.ExecuteScalar();
                a.ArtikelOid = autowert;
                textBoxArtikelOid.Text = autowert.ToString();
                MessageBox.Show(anzahl.ToString() + " Sätze eingefügt");
            }
            catch (Exception)
            {
                MessageBox.Show("!!Fehler bein Aufnehmen!!");
            }

        }

        private void textBoxArtikelGrp_Validating(object sender, CancelEventArgs e)
        {
            int i;

            try
            {
                i = Convert.ToInt32(textBoxArtikelGrp.Text);
            }
            catch
            {

                MessageBox.Show("muss Integerwert sein");
                e.Cancel = true;
            }

        }

        private void textBoxVerpackung_Validating(object sender, CancelEventArgs e)
        {
            int i;

            try
            {
                i = Convert.ToInt32(textBoxVerpackung.Text);
            }
            catch
            {

                MessageBox.Show("muss Integerwert sein");
                e.Cancel = true;
            }
        }

        private void buttonAbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
