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
    public partial class frmVrstaPoste : Form
    {
        public static Button azuriraj = new Button();
        Upiti veza = new Upiti();
        string vrstaID;

        public frmVrstaPoste()
        {
            InitializeComponent();
        }

        private void frmVrstaPoste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vrstaPoste.vrstaposte' table. You can move, or remove it, as needed.
            this.vrstaposteTableAdapter.Fill(this.vrstaPoste.vrstaposte);
            azuriraj = btnAzuriraj;
        }

        private void frmVrstaPoste_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (dgVrstaPoste.RowCount > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabranu vrstu pošte?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        System.Data.DataRow row = dgVrstaPoste.GetDataRow(dgVrstaPoste.FocusedRowHandle);
                        if (row != null)
                        {
                            vrstaID = row[0].ToString();
                            veza.ExecuteQuery("Delete from vrstaposte where vp_ID = " + vrstaID + "");
                            MessageBox.Show("Uspješno ste obrisali vrstu pošte");
                            this.vrstaposteTableAdapter.Fill(this.vrstaPoste.vrstaposte);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nemate što obrisati!");
                    return;
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (dgVrstaPoste.RowCount > 0)
                {
                    System.Data.DataRow row = dgVrstaPoste.GetDataRow(dgVrstaPoste.FocusedRowHandle);
                    if (row != null)
                    {
                        vrstaID = row[0].ToString();
                        frmAzurirajVrstuPoste UForm = null;
                        if ((UForm = (frmAzurirajVrstuPoste)IsFormAlreadyOpen(typeof(frmAzurirajVrstuPoste))) == null)
                        {
                            frmAzurirajVrstuPoste _frm = new frmAzurirajVrstuPoste();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.oznaka = "F4";
                            _frm.vrstaPosteID = vrstaID;
                            _frm.Show();
                        }
                        else
                        {
                            UForm.Focus();
                            return;
                        }                       
                    }
                }
                else
                {
                    MessageBox.Show("Nemate što ažurirati!");
                    return;
                }
            }
            else if (e.KeyCode == Keys.F7)
            {
                frmAzurirajVrstuPoste UForm = null;
                if ((UForm = (frmAzurirajVrstuPoste)IsFormAlreadyOpen(typeof(frmAzurirajVrstuPoste))) == null)
                {
                    frmAzurirajVrstuPoste _frm = new frmAzurirajVrstuPoste();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.oznaka = "F7";
                    _frm.Show();
                }
                else
                {
                    UForm.Focus();
                    return;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                }
            }            
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.vrstaposteTableAdapter.Fill(this.vrstaPoste.vrstaposte);
        }
    }
}
