using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Urudzbeni_ured
{
    public partial class frmVrstaTroska : DevExpress.XtraEditors.XtraForm
    {
        Upiti veza = new Upiti();
        string oznaka;
        string vrstaID;

        public frmVrstaTroska()
        {
            InitializeComponent();
        }

        private void frmVrstaTroska_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vrstaTroska.vrstatroska' table. You can move, or remove it, as needed.
            this.vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
        }

        private void frmVrstaTroska_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        oznaka = "F4";
                        System.Data.DataRow row = dgPodaci.GetDataRow(dgPodaci.FocusedRowHandle);
                         if (row != null)
                         { 
                             vrstaID = row[0].ToString();
                             txtVrstaTroska.Text = row[1].ToString();
                             txtVrstaTroska.Focus();
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
                    oznaka = "F7";
                    txtVrstaTroska.Focus();
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite obrisati odabranu vrstu troška?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes) 
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(dgPodaci.FocusedRowHandle);
                            if (row != null)
                            {
                                vrstaID = row[0].ToString();
                                veza.ExecuteQuery("Delete from vrstatroska where vt_ID = " + vrstaID + "");
                                MessageBox.Show("Uspješno ste obrisali vrstu troška");
                                vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
                            }
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Nemate što obrisati!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (oznaka == "F4") //azuriraj
                {
                    if (txtVrstaTroska.Text.Trim() != "")
                    {
                        veza.ExecuteQuery("Update vrstatroska set vt_naziv = '"+txtVrstaTroska.Text.Trim()+"' where vt_ID = "+vrstaID+"");
                        MessageBox.Show("Uspješno ste ažurirali vrstu troška");
                        vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
                    }
                }
                else // insert
                {
                    if (txtVrstaTroska.Text.Trim() != "")
                    {
                        veza.ExecuteQuery("insert into vrstatroska (vt_naziv) values ('"+txtVrstaTroska.Text.Trim()+"')");
                        MessageBox.Show("Uspješno ste dodali vrstu troška");
                        vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vrstatroskaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            txtVrstaTroska.Text = "";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}