using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileHelpers;
using DevExpress.XtraGrid.Views.Grid;

namespace Urudzbeni_ured
{
    public partial class frmCSV : Form
    {
        Upiti veza = new Upiti();
        int brojac;

        string Naziv;
        string Ziroracun;
        string Mjesto;
        string telefon;
        string oib;

        public frmCSV()
        {
            InitializeComponent();
        }

        private void frmCSV_Load(object sender, EventArgs e)
        {
            btnPrenesi.Enabled = false;
        }

        [DelimitedRecord(";")]

        public class myCSVFile
        {
            [FieldOptional]
            public string Naziv = "";
            [FieldOptional]
            public string ZiroRacun;
            [FieldOptional]
            public string Mjesto;
            [FieldOptional]
            public string Telefon;
            [FieldOptional]
            public string OIB;
        }

        private void prikaziCSVuGrid()
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(myCSVFile));

            myCSVFile[] result = engine.ReadFile(txtPutanja.Text) as myCSVFile[];

            DataTable tablica = new DataTable();
            tablica.Columns.Add("Naziv partnera", typeof(string));
            tablica.Columns.Add("Žiro račun", typeof(string));
            tablica.Columns.Add("Mjesto/grad", typeof(string));
            tablica.Columns.Add("Telefon", typeof(string));
            tablica.Columns.Add("OIB", typeof(string));

            foreach (myCSVFile row in result)
            {
                tablica.Rows.Add(row.Naziv, row.ZiroRacun, row.Mjesto, row.Telefon, row.OIB);
            }
            this.dgCSVPodaci.DataSource = tablica;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // retrieve the name of the selected folder
                string foldername = this.openFileDialog1.FileName;

                // print the folder name on a label
                this.txtPutanja.Text = foldername;
            }
            else
            {
                this.txtPutanja.Text = "";
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPutanja.Text != "")
                {
                    prikaziCSVuGrid();
                    lblStatus.Text = "";
                    btnPrenesi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Želite prijenos podataka u bazu?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (txtPutanja.Text != "")
                    {
                        if (dgPodaci.RowCount > 0)
                        {
                            for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                            {
                                System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                                if (row != null)
                                {
                                    btnPrenesi.Enabled = false;
                                    if (row[4].ToString() != "")
                                    {
                                        if (row[4].ToString().Length > 11)
                                        {
                                            oib = (row[4].ToString()).Substring(0, 11);
                                        }
                                        else
                                        {
                                            oib = row[4].ToString();
                                        }
                                    }
                                    else
                                    {
                                        oib = "";
                                    }

                                    if (row[2].ToString() != "")
                                    {
                                        if (row[2].ToString().Length > 30)
                                        {
                                            Mjesto = (row[2].ToString()).Substring(0, 30);
                                        }
                                        else
                                        {
                                            Mjesto = row[2].ToString();
                                        }
                                    }
                                    else
                                    {
                                        Mjesto = "";
                                    }

                                    if (row[0].ToString() != "")
                                    {
                                        if (row[0].ToString().Length > 50)
                                        {
                                            Naziv = (row[0].ToString()).Substring(0, 50);
                                        }
                                        else
                                        {
                                            Naziv = row[0].ToString();
                                        }
                                    }
                                    else
                                    {
                                        Naziv = "";
                                    }

                                    if (row[3].ToString() != "")
                                    {
                                        if (row[3].ToString().Length > 25)
                                        {
                                            telefon = (row[3].ToString()).Substring(0, 25);
                                        }
                                        else
                                        {
                                            telefon = row[3].ToString();
                                        }
                                    }
                                    else
                                    {
                                        telefon = "";
                                    }

                                    if (row[1].ToString() != "")
                                    {
                                        if (row[1].ToString().Length > 30)
                                        {
                                            Ziroracun = (row[1].ToString()).Substring(0, 30);
                                        }
                                        else
                                        {
                                            Ziroracun = row[1].ToString();
                                        }
                                    }
                                    else
                                    {
                                        Ziroracun = "";
                                    }

                                    if (oib != "" && Naziv != "")
                                    {

                                        DataTable provjera = new DataTable();

                                        veza.ExecuteQuery("select pa_oib from partner where pa_oib = '" + oib + "'", ref provjera);

                                        string insert = "insert into partner (pa_oib, pa_mjesto, pa_naziv, pa_telefon, pa_ziroracun) values ('" + oib + "', '" + Mjesto + "', '" + Naziv + "', '" + telefon + "', '" + Ziroracun + "')";

                                        string update = "update partner set pa_mjesto = '" + Mjesto + "', pa_naziv = '" + Naziv + "', pa_telefon = '" + telefon + "', pa_ziroracun = '" + Ziroracun + "' where pa_oib = '" + oib + "'";

                                        if (provjera.Rows.Count == 1)
                                        {
                                            veza.ExecuteQuery(update);
                                        }
                                        else
                                        {
                                            //MessageBox.Show(iert);ns
                                            veza.ExecuteQuery(insert);
                                        }
                                    }
                                }
                            }
                            btnPrenesi.Enabled = true;
                            MessageBox.Show("Uspješno ste ažurirali podatke");
                        }
                    }
                }
                else
                {
                    return;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPoruka UForm = null;
                if ((UForm = (frmPoruka)IsFormAlreadyOpen(typeof(frmPoruka))) == null)
                {
                    frmPoruka _frm = new frmPoruka();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.Show();
                }
                else
                {
                    UForm.Focus();
                    return;
                }                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
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
    }
}
