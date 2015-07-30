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
    public partial class frmPredajaDirektoru : Form
    {
        int brojac;
        Upiti veza = new Upiti();

        public frmPredajaDirektoru()
        {
            InitializeComponent();
        }

        private void frmPredajaDirektoru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glOsoba.Text != "" && dtpVracenoSPotpisa.Text != "")
            {
                try
                {
                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    

                    string datum = Convert.ToDateTime(dtpVracenoSPotpisa.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumVraceno = Convert.ToDateTime(datum);

                    this.direktorPredajaTableAdapter.predanoDirektor(this.direktorPotpis.direktorPredaja, datumVraceno, IDoperatera);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (glOsoba.Text != "" && dtpOD.Text != "" && dtpDO.Text != "")
            {
                int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                DateTime datumOD = Convert.ToDateTime(OD);
                DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                this.direktorPredajaTableAdapter.predanoDirektorDatumi(this.direktorPotpis.direktorPredaja, datumOD, datumDO, IDoperatera);
            }
            else if (glOsoba.Text == "" && dtpVracenoSPotpisa.Text != "")
            {
                string datum = Convert.ToDateTime(dtpVracenoSPotpisa.EditValue).ToString("yyyy-MM-dd");
                DateTime datumVraceno = Convert.ToDateTime(datum);

                this.direktorPredajaTableAdapter.predanoDirektorBezOsobe(this.direktorPotpis.direktorPredaja, datumVraceno);
            }
            else if (glOsoba.Text == "" && dtpOD.Text != "" && dtpDO.Text != "")
            {
                string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                DateTime datumOD = Convert.ToDateTime(OD);
                DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                this.direktorPredajaTableAdapter.predanoDirektorDatumiBezOsoba(this.direktorPotpis.direktorPredaja, datumOD, datumDO);
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
                dtpVracenoSPotpisa.Focus();
            }
        }

        private void glOsoba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glOsoba.EditValue = 0;
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
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[8], "Da");
                    }
                    else
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[8], "");
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
                string oznaka = View.GetRowCellDisplayText(e.RowHandle, View.Columns[8]);

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
                            if (row[8].ToString() != "Da")
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[8], "Da");
                            }
                            else
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[8], "");
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

        private void frmPredajaDirektoru_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPredajOznacene_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite odabrane dokumente Predati direktoru na uvid?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                if (row[8].ToString() == "Da")
                                {
                                    string postaID = row[0].ToString();
                                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                    //MessageBox.Show("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                    veza.ExecuteQuery("update posta set posta_datumPredajaDirektor = '" + datum + "' where posta_ID = " + postaID + "");
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
                result = MessageBox.Show("Želite sve prikazane dokumente predati direktoru na uvid?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

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
                                veza.ExecuteQuery("update posta set posta_datumPredajaDirektor = '" + datum + "' where posta_ID = " + postaID + "");
                            }
                        }
                        //btnPrikazi.PerformClick();
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                        btnPredajSve.Enabled = false;
                        direktorPotpis.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
