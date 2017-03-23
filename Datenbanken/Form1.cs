﻿using System;
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
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                throw;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBoxAusgabe.Items.Clear();
            while(reader.Read())
            {
                String zeile = reader["ArtikelNr"] + ": " + reader["Bezeichnung"];
                listBoxAusgabe.Items.Add(zeile);
            }
        }
    }
}
