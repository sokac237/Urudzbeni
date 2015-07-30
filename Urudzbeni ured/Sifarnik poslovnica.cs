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
    public partial class frmSifarnikPoslovnica : Form
    {
        Upiti veza = new Upiti();
        string poslovnica_sifra;

        public frmSifarnikPoslovnica()
        {
            InitializeComponent();
        }

        private void Sifarnik_poslovnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnice.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.poslovnice.poslovnica);
            txtPoslovnica.Focus();
        }

        private void txtPoslovnica_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            veza.ExecuteQuery("select po_ID, po_sifra, po_naziv from poslovnica where po_naziv like '%" + txtPoslovnica.Text + "%'", ref dt);
            poslovnice.Tables.Add(dt);          
        }

        public string sifra_poslovnice
        {
            get { return ((poslovnica_sifra != null)) ? poslovnica_sifra : null; }
        }

        private void frmSifarnikPoslovnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPoslovnice.Rows.Count > 0)
                {
                    poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_naziv"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgPoslovnice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPoslovnice.Rows.Count > 0)
            {
                poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_naziv"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void dgPoslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPoslovnice.Rows.Count > 0)
                {
                    poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_naziv"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void txtPoslovnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
