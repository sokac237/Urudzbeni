using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Urudzbeni_ured
{
    public partial class frmVracenoSPotpisa : Form
    {
        Upiti veza = new Upiti();
        int brojac;

        public frmVracenoSPotpisa()
        {
            InitializeComponent();
        }

        private void frmVracenoSPotpisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpPredaje.Text != "" && glOsoba.Text != "")
                {
                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    string DO = Convert.ToDateTime(dtpPredaje.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumPredaje = Convert.ToDateTime(DO);

                    this.vracenoTableAdapter.VracenoDatumVracenoOsoba(this.vraceno_s_potpisa.vraceno, datumPredaje, IDoperatera);  
                }
                else if (glOsoba.Text != "" && dtpOD.Text != "" && dtpDO.Text != "")
                {
                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.vracenoTableAdapter.VracenoDatumiOsoba(this.vraceno_s_potpisa.vraceno, datumOD, datumDO, IDoperatera);
                }

                if (btnVraceno.Enabled == false)
                {
                    btnVraceno.Enabled = true;
                }

                if (btnOznaceni.Enabled == false)
                {
                    btnOznaceni.Enabled = true;
                }

                if (dgPodaci.RowCount < 1)
                {
                    MessageBox.Show("Nema pošte koja odgovara odabiru!");
                    dtpPredaje.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmVracenoSPotpisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnVraceno_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0 && glOsoba.Text != "")
            {
                DialogResult result;
                result = MessageBox.Show("Želite sve prikazane dokumente ažurirati kao vraćene?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                string postaID = row[0].ToString();
                                string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                //MessageBox.Show("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                veza.ExecuteQuery("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                            }
                        }
                        //btnPrikazi.PerformClick();
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                        btnVraceno.Enabled = false;
                        vraceno_s_potpisa.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgPodaci_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataRow row = dgPodaci.GetDataRow(dgPodaci.FocusedRowHandle);
                if (row != null)
                {
                    if (row[8].ToString() != "Da")
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[7], "Da");
                    }
                    else
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[7], "");
                    }
                
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPodaci_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string oznaka = View.GetRowCellDisplayText(e.RowHandle, View.Columns[7]);

                if (oznaka != "")
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.BackColor = Color.Yellow;
                }
            }
        }
        private void btnOznaceni_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0 && glOsoba.Text != "")
            {
                DialogResult result;
                result = MessageBox.Show("Želite odabrane dokumente ažurirati kao vraćene?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                if(row[8].ToString() == "Da")
                                {
                                    string postaID = row[0].ToString();
                                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                    //MessageBox.Show("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                    veza.ExecuteQuery("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                }                                
                            }
                        }
                        btnPrikazi.PerformClick();
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgPosta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        System.Data.DataRow row = dgPodaci.GetDataRow(dgPodaci.FocusedRowHandle);
                        if (row != null)
                        {
                            if (row[8].ToString() != "Da")
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[7], "Da");
                            }
                            else
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[7], "");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
