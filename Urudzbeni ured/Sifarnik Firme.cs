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
    public partial class frmSifarnikFirme : Form
    {
        public static Button azuriraj = new Button();
        Upiti veza = new Upiti();
        string firmaID;

        public frmSifarnikFirme()
        {
            InitializeComponent();
        }

        private void frmSifarnikFirme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firma.firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.firma.firma);
            azuriraj = btnAzuriraj;
        }

        private void frmSifarnikFirme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgFirme.RowCount > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabranu firmu?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        System.Data.DataRow row = dgFirme.GetDataRow(dgFirme.FocusedRowHandle);
                        if (row != null)
                        {
                            firmaID = row[0].ToString();
                            veza.ExecuteQuery("Delete from firma where fi_ID = " + firmaID + "");
                            MessageBox.Show("Uspješno ste obrisali firmu");
                            this.firmaTableAdapter.Fill(this.firma.firma);
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
                if (dgFirme.RowCount > 0)
                {
                    System.Data.DataRow row = dgFirme.GetDataRow(dgFirme.FocusedRowHandle);
                    if (row != null)
                    {
                        firmaID = row[0].ToString();           
                        frmAzurirajFirmu UForm = null;
                        if ((UForm = (frmAzurirajFirmu)IsFormAlreadyOpen(typeof(frmAzurirajFirmu))) == null)
                        {
                            frmAzurirajFirmu _frm = new frmAzurirajFirmu();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.oznaka = "F4";
                            _frm.IDFirme = firmaID;
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
                frmAzurirajFirmu UForm = null;
                if ((UForm = (frmAzurirajFirmu)IsFormAlreadyOpen(typeof(frmAzurirajFirmu))) == null)
                {
                    frmAzurirajFirmu _frm = new frmAzurirajFirmu();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.oznaka = "F7";
                    _frm.IDFirme = firmaID;
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

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.firmaTableAdapter.Fill(this.firma.firma);
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
    }
}
