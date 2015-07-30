using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Urudzbeni_ured
{
    public partial class frmAzurirajFirmu : Form
    {
        Upiti veza = new Upiti();

        DataTable firm = new DataTable();

        string _firmaID;

        string _oznaka;

        int aktivna;

        public frmAzurirajFirmu()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string IDFirme
        {
            get { return _firmaID; }
            set { _firmaID = value; }
        }

        private void frmAzurirajFirmu_Load(object sender, EventArgs e)
        {
            try
            {
                if (_oznaka == "F4") //azuriraj
                {
                    veza.ExecuteQuery("select * from firma where fi_ID = "+_firmaID+"", ref firm);
                    if (firm.Rows.Count == 1)
                    {
                        txtNazivFirme.Text = firm.Rows[0][1].ToString();
                        if (firm.Rows[0][2].ToString() == "False")
                        {
                            cmbAktivna.Text = "Ne";
                        }
                        else
                        {
                            cmbAktivna.Text = "Da";
                        }
                        txtOIB.Text = firm.Rows[0][3].ToString();
                        txtAdresa.Text = firm.Rows[0][4].ToString();
                        txtTelefon.Text = firm.Rows[0][5].ToString();
                    }
                }
                else //insert
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNazivFirme.Text != "")
                {
                    if (_oznaka == "F4")//update
                    {
                        if (cmbAktivna.Text == "Da")
                        {
                            aktivna = 1;
                        }
                        else
                        {
                            aktivna = 0;
                        }
                        veza.ExecuteQuery("update firma set fi_naziv = '"+txtNazivFirme.Text.Trim()+"', fi_aktivna = "+aktivna+", fi_oib = '"+txtOIB.Text.Trim()+"', fi_adresa = '"+txtAdresa.Text.Trim()+"', fi_telefon = '"+txtTelefon.Text.Trim()+"' where fi_id = "+_firmaID+"");
                        MessageBox.Show("Uspješno ste ažurirali firmu!");
                        frmSifarnikFirme.azuriraj.PerformClick();
                        this.Close();
                    }
                    else//insert
                    {
                        if (cmbAktivna.Text == "Da")
                        {
                            aktivna = 1;
                        }
                        else
                        {
                            aktivna = 0;
                        }
                        veza.ExecuteQuery("insert into firma (fi_naziv, fi_aktivna, fi_oib, fi_adresa, fi_telefon) values ('" + txtNazivFirme.Text.Trim() + "',  " + aktivna + ",'" + txtOIB.Text.Trim() + "', '"+txtAdresa.Text.Trim()+"', '"+txtTelefon.Text.Trim()+"')");
                        MessageBox.Show("Uspješno ste dodali firmu!");
                        frmSifarnikFirme.azuriraj.PerformClick();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti polje Naziv firme");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmAzurirajFirmu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
