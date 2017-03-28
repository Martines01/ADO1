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
        public FormCreateItem()
        {
            InitializeComponent();
        }

        public FormCreateItem(OleDbConnection ole)
        {
            this.con = ole;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();
            a.ArtikelNr = Convert.ToInt32(textBoxArtikelNr.Text);
            a.ArtikelGruppe = Convert.ToInt32(textBoxArtikelGrp.Text);
            a.Bezeichnung = textBoxBezeichnung.Text;
            a.Verpackung = Convert.ToInt32(textBoxVerpackung.Text);
            insertDB(a);

        }
        private void insertDB(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();
            String sql = "Insert Into tArtikel(ArtikelNr,ArtikelGruppe,Verpackung) values (ANR,BEZ,AG,VP)";
            cmd.Parameters.Add("ANR", OleDbType.WChar);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);
            cmd.Parameters.Add("AG", OleDbType.Integer);
            cmd.Parameters.Add("VP", OleDbType.Integer);
            cmd.CommandText = sql;
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

        private void textBoxArtikelNr_Validating(object sender, CancelEventArgs e)
        {
            int i;

            try
            {
                i = Convert.ToInt32(textBoxArtikelNr.Text);
            }
            catch
            {

                MessageBox.Show("muss Integerwert sein");
                e.Cancel = true;
            }
        }
    }
}
