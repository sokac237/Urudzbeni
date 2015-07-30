using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Urudzbeni_ured
{
    public partial class frmPredajaPoste : Form
    {
        int flag;
        DataTable table = new DataTable();
        Upiti veza = new Upiti();
        int brojac;
        string _oznaka;
        string idOdabrabnih;

        public frmPredajaPoste()
        {
            InitializeComponent();
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        private void frmPredajaPoste_Load(object sender, EventArgs e)
        {
            if (_oznaka == "D") //predaja prema datumu
            {
                panel1.Visible = false;
            }
            else //predaja prema razdoblju "R"
            {
                panel2.Visible = false;
                btnIspis.Visible = false;
            }

            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }



        private void frmPredajaPoste_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Želite li odabrane dokumente predati na potpis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                if (dgPodaci.RowCount > 0 && glOsobaPotpis.Text != "")
                {
                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.Rows.Count; brojac++)
                        {
                            string postaID = dgPodaci.Rows[brojac].Cells[4].Value.ToString();
                            string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                            //MessageBox.Show("update posta set posta_datumPredaje = '" + datum + "' and  operater_op_ID_predano = " + glOsobaPotpis.EditValue + " where posta_ID = " + postaID + "");
                            veza.ExecuteQuery("update posta set posta_datumPredaje = '" + datum + "' where posta_ID = " + postaID + "");
                        }                       
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                        btnIspis.Visible = true;
                        btnPredaj.Enabled = false;

                        report();
                        //btnPrikazi.PerformClick();
                        predaja_poste.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            report();
        }

        private void report()
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = predaja_poste.predaja.CopyToDataTable();

                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("dd.MM.yyyy");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("dd.MM.yyyy");
                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    artikli.TableName = "Artikli";
                    FDataSet.Tables.Add(artikli);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Predaja3.frx");
                    report.SetParameterValue("datumod", OD);
                    report.SetParameterValue("datumdo", DO);
                    report.SetParameterValue("datumPredaje", DateTime.Now.Date.ToString("dd.MM.yyyy"));

                    // register the dataset
                    report.RegisterData(FDataSet);

                    //dizajn
                    //report.Design();

                    // run the report
                    report.Show();

                    // free resources used by report
                    report.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reportOznaceni()
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    table = new DataTable();

                    napunipotvrdjeneZaPredajuUDataset();

                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("dd.MM.yyyy");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("dd.MM.yyyy");
                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    table.TableName = "Artikli";
                    FDataSet.Tables.Add(table);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Predaja.frx");
                    report.SetParameterValue("datumod", OD);
                    report.SetParameterValue("datumdo", DO);
                    report.SetParameterValue("datumPredaje", DateTime.Now.Date.ToString("dd.MM.yyyy"));

                    // register the dataset
                    report.RegisterData(FDataSet);

                    //dizajn
                    //report.Design();

                    // run the report
                    report.Show();

                    // free resources used by report
                    report.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void brnPrikaz_Click(object sender, EventArgs e)
        {
            if (glOsobaPotpis.Text != "" && dtpOD.Text != "")
            {
                try
                {
                    int IDoperatera = Convert.ToInt32(glOsobaPotpis.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.predajaTableAdapter.Fill(this.predaja_poste.predaja, datumOD, datumDO, IDoperatera);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (btnPredaj.Enabled == false)
            {
                btnPredaj.Enabled = true;
            }

            if (btnOznaceni.Enabled == false)
            {
                btnOznaceni.Enabled = true;
            }

            if (dgPodaci.RowCount < 1)
            {
                MessageBox.Show("Nema pošte koja odgovara odabiru!");
                dtpOD.Focus();
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = predaja_poste.predaja.CopyToDataTable();
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("dd.MM.yyyy");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("dd.MM.yyyy");
                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    artikli.TableName = "Artikli";
                    FDataSet.Tables.Add(artikli);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Predaja2.frx");

                    // register the dataset
                    report.RegisterData(FDataSet);

                    //dizajn
                    //report.Design();

                    // run the report
                    report.Show();

                    // free resources used by report
                    report.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPrikaz2_Click(object sender, EventArgs e)
        {
            if (glOperater.Text != "" && dtpPredaja.Text != "")
            {
                try
                {
                    int IDoperatera = Convert.ToInt32(glOperater.EditValue);
                    string datum = Convert.ToDateTime(dtpPredaja.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumPredaja = Convert.ToDateTime(datum);

                    this.predajaTableAdapter.FillBy2(this.predaja_poste.predaja, datumPredaja, IDoperatera);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dgPodaci.RowCount < 1)
            {
                MessageBox.Show("Nema pošte koja odgovara odabiru!");
                dtpPredaja.Focus();
            }
        }

        private void glOsobaPotpis_EditValueChanged(object sender, EventArgs e)
        {
            btnIspis.Visible = false;
            btnPredaj.Enabled = false;
            btnOznaceni.Enabled = false;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPodaci.Rows.Count > 0)
            {
                if (_oznaka != "D")
                {
                    string ID = dgPodaci.CurrentRow.Cells[4].Value.ToString();
                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                    string idartikl = dgPodaci.CurrentRow.Cells[0].Value.ToString();

                    if (dgPodaci.CurrentRow.Cells["oznaci"].Value == null)
                    {
                        veza.ExecuteQuery("Update posta set posta_datumPredaje = '" + datum + "' where posta_ID = " + ID + "");

                        dgPodaci.CurrentRow.Cells[9].Value = "Da";

                        foreach (DataGridViewRow dgvr in dgPodaci.Rows)
                        {
                            if (dgvr.Cells[9].Value != null)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }
                    }
                    else if (dgPodaci.CurrentRow.Cells[9].Value != null)
                    {
                        veza.ExecuteQuery("Update posta set posta_datumPredaje = null where posta_ID = " + ID + "");

                        dgPodaci.CurrentRow.Cells[9].Value = null;

                        foreach (DataGridViewRow dgvr in dgPodaci.Rows)
                        {
                            if (dgvr.Cells[9].Value == null)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        private void btnOznaceni_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Želite li odabrane dokumente predati na potpis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                if (dgPodaci.RowCount > 0 && glOsobaPotpis.Text != "")
                {
                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.Rows.Count; brojac++)
                        {

                            if (dgPodaci.Rows[brojac].Cells["oznaci"].Value != null)
                            {
                                string postaID = dgPodaci.Rows[brojac].Cells[4].Value.ToString();
                                string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                //MessageBox.Show("update posta set posta_datumPredaje = '" + datum + "' and  operater_op_ID_predano = " + glOsobaPotpis.EditValue + " where posta_ID = " + postaID + "");
                                veza.ExecuteQuery("update posta set posta_datumPredaje = '" + datum + "' where posta_ID = " + postaID + "");
                                flag = 1;
                            }
                        }

                        if (flag == 1) 
                        {
                            napunipotvrdjeneZaPredajuUDataset();
                            MessageBox.Show("Uspješno ste ažurirali poštu!");
                            reportOznaceni();
                            btnPrikazi.PerformClick();
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void napunipotvrdjeneZaPredajuUDataset()
        {

            if (dgPodaci.Rows.Count > 0)
            {
                try
                {
                    idOdabrabnih = "";

                    for (brojac = 0; brojac < dgPodaci.Rows.Count; brojac++)
                    {
                        if (dgPodaci.Rows[brojac].Cells["oznaci"].Value == null)
                        {
                            //
                        }
                        else
                        {
                            if (dgPodaci.Rows[brojac].Cells["oznaci"].Value.ToString() == "Da")
                            {
                                if (idOdabrabnih != "")
                                {
                                    idOdabrabnih = idOdabrabnih + ",";
                                }
                                idOdabrabnih = idOdabrabnih + dgPodaci.Rows[brojac].Cells[4].Value.ToString();
                            }
                        }
                    }

                    if (idOdabrabnih != "")
                    {
                        veza.ExecuteQuery("select posta.posta_ID, posta.posta_evidBroj, partner.PA_NAZIV, posta.posta_brojDokumenta, concat( boso2011.operater.op_ime ,' ',  boso2011.operater.op_prezime), posta.posta_datVraceno, posta.posta_datDokumenta, posta_datumPredaje, vrstaPoste.vp_naziv from vrstaposte,  boso2011.operater , posta left outer join partner on partner.PA_ID = posta.partner_pa_ID where  boso2011.operater.op_ID = posta.operater_op_ID_predano and vrstaPoste.vp_ID = posta.vrstaPoste_vp_ID and posta.posta_datVraceno is null and posta_datPredanoKnjizenje is null and posta.posta_ID in (" + idOdabrabnih + ")", ref table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgPodaci_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    string ID = dgPodaci.CurrentRow.Cells[4].Value.ToString();
                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                    if (dgPodaci.CurrentRow.Cells["oznaci"].Value == null)
                    {
                        //veza.ExecuteQuery("Update posta set posta_datumPredaje = '" + datum + "' where posta_ID = " + ID + "");

                        dgPodaci.CurrentRow.Cells[9].Value = "Da";

                        foreach (DataGridViewRow dgvr in dgPodaci.Rows)
                        {
                            if (dgvr.Cells[9].Value != null)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.Yellow;
                            }
                        }
                    }
                    else if (dgPodaci.CurrentRow.Cells[9].Value != null)
                    {
                        //veza.ExecuteQuery("Update posta set posta_datumPredaje = null where posta_ID = " + ID + "");

                        dgPodaci.CurrentRow.Cells[9].Value = null;

                        foreach (DataGridViewRow dgvr in dgPodaci.Rows)
                        {
                            if (dgvr.Cells[9].Value == null && dgvr.DefaultCellStyle.BackColor == Color.Yellow)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.White;
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
 

