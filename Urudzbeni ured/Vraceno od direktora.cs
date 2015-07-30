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
    public partial class frmVracenoOdDirektora : Form
    {
        int brojac;
        Upiti veza = new Upiti();

        public frmVracenoOdDirektora()
        {
            InitializeComponent();
        }

        private void frmVracenoOdDirektora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }

        private void glOsoba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glOsoba.EditValue = 0;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glOsoba.Text != "" && dtpPredanoDirektoru.Text != "")
                {
                    string datum = Convert.ToDateTime(dtpPredanoDirektoru.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumPredano = Convert.ToDateTime(datum);

                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    this.vracenoOdDirektoraTableAdapter.VracenoDirektorDatumPredanoOsoba(this.vraceno_od_direktora.VracenoOdDirektora, datumPredano, IDoperatera);
                }
                else if(glOsoba.Text != "" && dtpDO.Text != "" && dtpOD.Text != "")
                {

                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.vracenoOdDirektoraTableAdapter.VracenoOdDirektoraDatumiOsoba(this.vraceno_od_direktora.VracenoOdDirektora, datumOD, datumDO, IDoperatera);
                }
                else if (glOsoba.Text == "" && dtpPredanoDirektoru.Text != "")
                {
                    string datum = Convert.ToDateTime(dtpPredanoDirektoru.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumPredano = Convert.ToDateTime(datum);

                    this.vracenoOdDirektoraTableAdapter.VracenoDirektorDatumPredaja(this.vraceno_od_direktora.VracenoOdDirektora, datumPredano);
                }
                else if (glOsoba.Text == "" && dtpOD.Text != "" && dtpDO.Text != "")
                {
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.vracenoOdDirektoraTableAdapter.VracenoOdDirektoraDatumi(this.vraceno_od_direktora.VracenoOdDirektora, datumOD, datumDO);
                }

                if (btnPredajOznacene.Enabled == false)
                {
                    btnPredajOznacene.Enabled = true;
                }

                if (btnPredajSve.Enabled == false)
                {
                    btnPredajSve.Enabled = true;
                }

                if (dgPodaci.RowCount < 1)
                {
                    MessageBox.Show("Nema pošte koja odgovara odabiru!");
                    dtpPredanoDirektoru.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPredajOznacene_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
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
                                if (row[9].ToString() == "Da")
                                {
                                    string postaID = row[0].ToString();
                                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                    //MessageBox.Show("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                    veza.ExecuteQuery("update posta set posta_datumVracenoDirektor = '" + datum + "' where posta_ID = " + postaID + "");
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

        private void btnPredajSve_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
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
                                veza.ExecuteQuery("update posta set posta_datumVracenoDirektor = '" + datum + "' where posta_ID = " + postaID + "");
                            }
                        }
                        //btnPrikazi.PerformClick();
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                        btnPredajSve.Enabled = false;
                        vraceno_od_direktora.Clear();
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
                    if (row[9].ToString() != "Da")
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[9], "Da");
                    }
                    else
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[9], "");
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
                string oznaka = View.GetRowCellDisplayText(e.RowHandle, View.Columns[9]);

                if (oznaka != "")
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.BackColor = Color.Yellow;
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
                            if (row[9].ToString() != "Da")
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[9], "Da");
                            }
                            else
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[9], "");
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

        private void frmVracenoOdDirektora_KeyDown(object sender, KeyEventArgs e)
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
    }
}
