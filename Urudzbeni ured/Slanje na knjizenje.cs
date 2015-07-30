using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;

namespace Urudzbeni_ured
{
    public partial class frmSlanjeNaKnjizenje : Form
    {
        Upiti veza = new Upiti();
        int brojac;
        string idOdabrabnih;
        DataTable table = new DataTable();
        int flag;

        public frmSlanjeNaKnjizenje()
        {
            InitializeComponent();
        }

        private void Slanje_na_knjizenje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpVraceno.Text != "" && glOsoba.Text != "")
                {
                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    string vracenoDat = Convert.ToDateTime(dtpVraceno.EditValue).ToString("yyyy-MM-dd");
                    DateTime NaKnjizenje = Convert.ToDateTime(vracenoDat);

                    this.slanjeNaKnjizenjeTableAdapter.VracenoOdDirektoraDatumVracanjaOsoba(this.slanje_na_knjizenje.SlanjeNaKnjizenje, NaKnjizenje, IDoperatera);
                }
                else if (glOsoba.Text != "" && dtpDO.Text != "" && dtpOD.Text != "")
                {
                    int IDoperatera = Convert.ToInt32(glOsoba.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.slanjeNaKnjizenjeTableAdapter.VracenoOdDirektoraDatumiOsoba(this.slanje_na_knjizenje.SlanjeNaKnjizenje, datumOD, datumDO, IDoperatera);
                }
                else if (glOsoba.Text == "" && dtpVraceno.Text != "")
                {
                    string vracenoDat = Convert.ToDateTime(dtpVraceno.EditValue).ToString("yyyy-MM-dd");
                    DateTime NaKnjizenje = Convert.ToDateTime(vracenoDat);

                    this.slanjeNaKnjizenjeTableAdapter.VracenoOdDirektoraDatumVracanja(this.slanje_na_knjizenje.SlanjeNaKnjizenje, NaKnjizenje);
                }
                else if (glOsoba.Text == "" && dtpOD.Text != "" && dtpDO.Text != "")
                {
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.slanjeNaKnjizenjeTableAdapter.VracenoOdDirektoraDatumi(this.slanje_na_knjizenje.SlanjeNaKnjizenje, datumOD, datumDO);
                }

                if (btnPredajKnjizenje.Enabled == false)
                {
                    btnPredajKnjizenje.Enabled = true;
                }

                if (dgPodaci.RowCount < 1)
                {
                    MessageBox.Show("Nema pošte koja odgovara odabiru!");
                    dtpVraceno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Slanje_na_knjizenje_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPredajKnjizenje_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite sve dokumente poslati na knjiženje?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

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
                                veza.ExecuteQuery("update posta set posta_datPredanoKnjizenje = '" + datum + "' where posta_ID = " + postaID + "");

                                dgPodaci.SetRowCellValue(brojac, dgPodaci.Columns[10], DateTime.Now.Date.ToShortDateString());
                            }
                        }
                        report();
                        //btnPrikazi.PerformClick();
                        MessageBox.Show("Uspješno ste ažurirali poštu!");
                        btnPredajKnjizenje.Enabled = false;
                        slanje_na_knjizenje.Clear();
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
                    if (row[11].ToString() != "Da")
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[11], "Da");
                    }
                    else
                    {
                        dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[11], "");
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
                string oznaka = View.GetRowCellDisplayText(e.RowHandle, View.Columns[11]);

                if (oznaka != "")
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.BackColor = Color.Yellow;
                }
            }
        }

        private void btnNaKnjizenje_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite odabrane dokumente poslati na knjiženje?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                //string a = row[10].ToString();
                                if (row[10].ToString() == "Da")
                                {
                                    string postaID = row[0].ToString();
                                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                                    //MessageBox.Show("update posta set posta_datVraceno = '" + datum + "' where posta_ID = " + postaID + "");
                                    veza.ExecuteQuery("update posta set posta_datPredanoKnjizenje = '" + datum + "' where posta_ID = " + postaID + "");
                                    flag = 1;
                                }
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
                            if (row[11].ToString() != "Da")
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[11], "Da");
                            }
                            else
                            {
                                dgPodaci.SetRowCellValue(dgPodaci.FocusedRowHandle, dgPodaci.Columns[11], "");
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

        private void report()
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = slanje_na_knjizenje.SlanjeNaKnjizenje.CopyToDataTable();

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

                    report.Load(baseDir + "/report/Knjizenje2.frx");
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

        private void napunipotvrdjeneZaPredajuUDataset()
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    idOdabrabnih = "";

                    for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                    {
                        System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                        if (row != null)
                        {
                            //string a = row[10].ToString();
                            if (row[10].ToString() == "Da")
                            {
                                if (idOdabrabnih != "")
                                {
                                    idOdabrabnih = idOdabrabnih + ",";
                                }
                                idOdabrabnih = idOdabrabnih + row[0].ToString();
                            }
                        }
                    }

                    if (idOdabrabnih != "")
                    {
                        veza.ExecuteQuery("select posta.posta_ID, posta.posta_evidBroj, partner.PA_NAZIV, posta.posta_brojDokumenta, concat( boso2011.operater.op_ime ,' ',  boso2011.operater.op_prezime), posta.posta_datVraceno, posta.posta_datDokumenta, posta_datumPredaje, vrstaPoste.vp_naziv, posta.posta_datumPredajaDirektor, posta.posta_datumVracenoDirektor, posta.posta_datPredanoKnjizenje from vrstaposte,  boso2011.operater , posta left outer join partner on partner.PA_ID = posta.partner_pa_ID where  boso2011.operater.op_ID = posta.operater_op_ID_predano and vrstaPoste.vp_ID = posta.vrstaPoste_vp_ID and posta.posta_datVraceno is not null and posta_datPredanoKnjizenje is not null and posta.posta_ID  in (" + idOdabrabnih + ")", ref table);
                    }
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

                    report.Load(baseDir + "/report/Knjizenje.frx");
                    report.SetParameterValue("datumod", OD);
                    report.SetParameterValue("datumdo", DO);
                    report.SetParameterValue("datumPredaje", DateTime.Now.Date.ToString("dd.MM.yyyy"));

                    // register the dataset
                    report.RegisterData(FDataSet);

                    //dizajn
                    report.Design();

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
    }
}
