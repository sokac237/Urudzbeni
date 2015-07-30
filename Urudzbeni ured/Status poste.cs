using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using SmartXLS;

namespace Urudzbeni_ured
{
    public partial class frmStatusPoste : Form
    {
        public frmStatusPoste()
        {
            InitializeComponent();
        }

        private void frmStatusPoste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            // TODO: This line of code loads data into the 'vrstaTroska.vrstatroska' table. You can move, or remove it, as needed.
            this.vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
            // TODO: This line of code loads data into the 'status_poste.statusPoste' table. You can move, or remove it, as needed.
            this.WindowState = FormWindowState.Maximized;
            btnIspis.Visible = false;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEvidBroj.Text.Trim() != "")
                {
                    int evidbr = Convert.ToInt32(txtEvidBroj.Text.Trim());
                    this.statusPosteTableAdapter.EvidBroj(this.status_poste.statusPoste, evidbr);
                    btnIspis.Visible = true;
                }
                else if (glOsoba.Text != "")
                {
                    int osoba = Convert.ToInt32(glOsoba.EditValue);
                    this.statusPosteTableAdapter.PremaOsobi(this.status_poste.statusPoste, osoba);
                    btnIspis.Visible = true;
                }
                else if (glPartner.Text == "" && dtpOD.Text == "" && dtpDO.Text == "" && glVrstaTroska.Text == "")
                {

                    this.statusPosteTableAdapter.SvePrazno(this.status_poste.statusPoste);
                    btnIspis.Visible = false;
                }
                else if (glPartner.Text != "" && dtpOD.Text == "" && dtpDO.Text == "" && glVrstaTroska.Text == "")
                {
                    int IDPartner = Convert.ToInt32(glPartner.EditValue);

                    this.statusPosteTableAdapter.Partner(this.status_poste.statusPoste, IDPartner);
                    btnIspis.Visible = true;
                }
                else if (glPartner.Text == "" && dtpOD.Text != "" && dtpDO.Text != "" && glVrstaTroska.Text == "")
                {
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);
                    btnIspis.Visible = true;

                    this.statusPosteTableAdapter.Datum(this.status_poste.statusPoste, datumOD, datumDO);
                }
                else if (glPartner.Text != "" && dtpOD.Text != "" && dtpDO.Text != "" && glVrstaTroska.Text == "")
                {
                    int IDPartner = Convert.ToInt32(glPartner.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.statusPosteTableAdapter.DatumIPartner(this.status_poste.statusPoste, IDPartner, datumOD, datumDO);
                    btnIspis.Visible = true;
                }
                else if (glVrstaTroska.Text != "" && dtpOD.Text != "" && dtpDO.Text != "" && glPartner.Text != "")
                {
                    int IDVrsta = Convert.ToInt32(glVrstaTroska.EditValue);
                    int IDPartner = Convert.ToInt32(glPartner.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);
                    this.statusPosteTableAdapter.SvePopunjeno(this.status_poste.statusPoste, IDVrsta, datumOD, datumDO, IDPartner);
                    btnIspis.Visible = true;
                }
                else if (glVrstaTroska.Text != "" && dtpOD.Text != "" && dtpDO.Text != "")
                {
                    int IDVrsta = Convert.ToInt32(glVrstaTroska.EditValue);
                    string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("yyyy-MM-dd");
                    string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumOD = Convert.ToDateTime(OD);
                    DateTime datumDO = Convert.ToDateTime(DO).AddHours(23).AddMinutes(59).AddSeconds(59);
                    this.statusPosteTableAdapter.VrstaTroskaDatum(this.status_poste.statusPoste, IDVrsta, datumOD, datumDO);
                    btnIspis.Visible = true;
                }
                else if (glVrstaTroska.Text != "" && glPartner.Text != "")
                {
                    int IDPartner = Convert.ToInt32(glPartner.EditValue);
                    int IDVrsta = Convert.ToInt32(glVrstaTroska.EditValue);
                    this.statusPosteTableAdapter.VrstaTroskaPartner(this.status_poste.statusPoste, IDVrsta, IDPartner);
                }
                else if (glVrstaTroska.Text != "")
                {
                    int IDVrsta = Convert.ToInt32(glVrstaTroska.EditValue);
                    this.statusPosteTableAdapter.samoVrstaTroska(this.status_poste.statusPoste, IDVrsta);
                    btnIspis.Visible = true;
                }
                if (dgPodaci.RowCount < 1)
                {
                    MessageBox.Show("Nema pošte za odabrane kriterije");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                this.statusPosteTableAdapter.SvePrazno(this.status_poste.statusPoste);
                btnIspis.Visible = false;
                glVrstaTroska.EditValue = 0;
                glPartner.EditValue = 0;
                dtpDO.Text = "";
                dtpOD.Text = "";
                txtEvidBroj.Text = "";
                glOsoba.EditValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if (dgPodaci.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = status_poste.statusPoste.CopyToDataTable();

                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    artikli.TableName = "Artikli";
                    FDataSet.Tables.Add(artikli);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Sve.frx");

                    if (dtpDO.Text != "" && dtpOD.Text != "")
                    {
                        string OD = Convert.ToDateTime(dtpOD.EditValue).ToString("dd.MM.yyyy");
                        string DO = Convert.ToDateTime(dtpDO.EditValue).ToString("dd.MM.yyyy");

                        report.SetParameterValue("datumod", OD);
                        report.SetParameterValue("datumdo", DO);
                    }

                    if (glPartner.Text != "")
                    {
                        report.SetParameterValue("partner", glPartner.Text);
                    }

                    if (glVrstaTroska.Text != "")
                    {
                        report.SetParameterValue("vrstaTroska", glVrstaTroska.Text);
                    }
                    report.SetParameterValue("evidBroj", txtEvidBroj.Text.Trim());

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

        private void txtEvidBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
                {
                    e.Handled = true;
                    MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
                }
            }
        }

        private void glPartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glPartner.EditValue = 0;
            }
        }

        private void frmStatusPoste_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.F9)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    ExcelExport();
                }
            }
        }

        private void ExcelExport()
        {
            var bindingSource = (BindingSource)this.dgPodaci.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();


            //Export DataTable.
            if (this.dgPodaci != null)
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
            }
            else
            {
                MessageBox.Show("Nema podataka za export u excel!", "Error");
                return;
            }

            //Saving the workbook to disk. 
            m_book.write("C:\\Podaci\\Podaci.xls");


            //gridView1.ExportToXls(@"c:\Podaci\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void glVrstaTroska_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glVrstaTroska.EditValue = 0;
            }
        }

        private void glOsoba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glOsoba.EditValue = 0;
            }
        }
    }
}
