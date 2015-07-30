using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;

namespace Urudzbeni_ured
{
    public partial class frmSlanjeNaKnjizenjeIspis : Form
    {
        Upiti veza = new Upiti();

        public frmSlanjeNaKnjizenjeIspis()
        {
            InitializeComponent();
        }

        private void frmSlanjeNaKnjizenjeIspis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dtpPredaja.Text != "" && glOperater.Text != "")
                {
                    int IDoperatera = Convert.ToInt32(glOperater.EditValue);
                    string datum = Convert.ToDateTime(dtpPredaja.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumSlanja = Convert.ToDateTime(datum);
                    this.slanjeNaKnjizenjeTableAdapter.NaKnjizenjeIspisOsobaDatumKnjizenja(this.slanje_na_knjizenje.SlanjeNaKnjizenje, datumSlanja, IDoperatera);
                }
                else if (glOperater.Text != "" && dtpPredaja.Text == "")
                {
                    int IDoperatera = Convert.ToInt32(glOperater.EditValue);
                    this.slanjeNaKnjizenjeTableAdapter.NaKnjizenjeOsoba(this.slanje_na_knjizenje.SlanjeNaKnjizenje, IDoperatera);
                }
                if (dtpPredaja.Text != "" && glOperater.Text == "")
                {
                    string datum = Convert.ToDateTime(dtpPredaja.EditValue).ToString("yyyy-MM-dd");
                    DateTime datumSlanja = Convert.ToDateTime(datum);
                    this.slanjeNaKnjizenjeTableAdapter.NaKnjizenjeDatumKnjizenja(this.slanje_na_knjizenje.SlanjeNaKnjizenje, datumSlanja);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSlanjeNaKnjizenjeIspis_KeyDown(object sender, KeyEventArgs e)
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

        private void glOperater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glOperater.EditValue = 0;
            }            
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPodaci.RowCount > 0)
                {
                    try
                    {
                        DataTable artikli = new DataTable();
                        artikli = slanje_na_knjizenje.SlanjeNaKnjizenje.CopyToDataTable();
                        string datumSlanja = Convert.ToDateTime(dtpPredaja.EditValue).ToString("dd.MM.yyyy");

                        //create dataset 
                        DataSet FDataSet = new DataSet();
                        artikli.TableName = "Artikli";
                        FDataSet.Tables.Add(artikli);

                        // create report instance
                        Report report = new Report();

                        // load the existing report
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/Knjizenje3.frx");
                        report.SetParameterValue("datumSlanja", datumSlanja);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
