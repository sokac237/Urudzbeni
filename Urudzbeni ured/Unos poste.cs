using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.IO;


namespace Urudzbeni_ured
{
    public partial class frmUnosPoste : Form
    {
        private const string PRINTER_NAME = "EPSON TM-U590 Slip";
        int EvidencijskiBroj;
        string vrstaPosteID;
        string postaID;
        string oznaka; // I - insert, U - update
        public DataTable podaci = new DataTable();
        Upiti veza = new Upiti();

        string upit_insert_polja = "insert into posta (";
        string upit_insert_values = "values (";
        string upit_update = "update posta set";
        string ukupniInsert;

        public frmUnosPoste()
        {
            InitializeComponent();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0 || txtEvidencijskiBroj.Text != "")
            {
                if (txtEvidencijskiBroj.Text != "")
                {
                    veza.ExecuteQuery("select posta.*, vrstaposte.vp_naziv from posta left outer join vrstaposte on vrstaposte.vp_ID = posta.vrstaPoste_vp_ID where posta_evidBroj = '" + txtEvidencijskiBroj.Text.Trim() + "'", ref podaci);

                    if (podaci.Rows.Count == 1) //update
                    {
                        if (podaci.Rows[0][13].ToString() == "" && podaci.Rows[0][14].ToString() == "")
                        {
                            pnlUnos.Visible = true;
                            PopuniFormu();
                            glVrstaTroska.Focus();
                            lblBrojDokumenta.Text = "" + podaci.Rows[0][19].ToString() + " broj:  " + podaci.Rows[0][3].ToString() + " ";
                            postaID = podaci.Rows[0][0].ToString();
                            oznaka = "U";
                            prikaziPotrebno();
                        }
                        else
                        {
                            MessageBox.Show("Pošta je već potpisana i poslana na knjiženje!");
                            txtEvidencijskiBroj.Text = "";
                            txtEvidencijskiBroj.Focus();
                            return;
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Nema pošte pod tim evidencijskim brojem !!");
                        txtEvidencijskiBroj.Text = "";
                        txtEvidencijskiBroj.Focus();
                        return;
                    }
                }
                else // insert
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if (row != null)
                    {
                        vrstaPosteID = row[0].ToString();
                    }
                    pnlUnos.Visible = true;
                    glVrstaTroska.Focus();
                    lblBrojDokumenta.Text = "Unos: " +row[1].ToString()+ "";

                    oznaka = "I";
                    panel1.Enabled = false;
                    prikaziPotrebno();
                }
            }
            else
            {
                MessageBox.Show("Odaberite vrstu pošte ili upišite evidencijski broj!");
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            isprazniFormuZaUnos();
            glVrstaTroska.Enabled = true;
            glOsobaPredalaIzlazni.Enabled = true;
            glOsobaPredalaIzlazni.Text = "";
            glPartner.Enabled = true;
            glNaslovljenoNaFirma.Enabled = true;
            dtpDokumenta.Enabled = true;
            txtDokBroj.Enabled = true;
            dtpPotpis.Enabled = true;
            glOsobaPotpis.Enabled = true;
            dtpVracenoSPotpisa.Enabled = true;
            dtpPredanoNaKnjizenje.Enabled = true;
            txtNapomena.Enabled = true;
            txtMjestoTroska.Enabled = true;
            txtMjesecGodina.Enabled = true;
            panel1.Enabled = true;
            pnlUnos.Visible = false;
            lblPoruka.Text = "";
        }

        private void isprazniFormuZaUnos()
        {
            glVrstaTroska.Text = "";
            glOsobaPredalaIzlazni.Text = "";
            glPartner.Text = "";
            glNaslovljenoNaFirma.Text = "";
            dtpDokumenta.Text = "";
            txtDokBroj.Text = "";
            dtpPotpis.Text = "";
            glOsobaPotpis.Text = "";
            dtpVracenoSPotpisa.Text = "";
            dtpPredanoNaKnjizenje.Text = "";
            txtNapomena.Text = "";
            txtMjestoTroska.Text = "";
            txtMjesecGodina.Text = "";
            upit_insert_polja = "insert into posta (";
            upit_insert_values = "values (";
            upit_update = "update posta set";
            lblPoruka.Text = "";
        }

        private void PopuniFormu()
        {
            try
            {
                if (podaci.Rows[0][6].ToString() != "")
                {
                    glVrstaTroska.EditValue = podaci.Rows[0][6];
                }
                if (podaci.Rows[0][8].ToString() != "")
                {
                    glPartner.EditValue = podaci.Rows[0][8];
                }
                if (podaci.Rows[0][17].ToString() != "")
                {
                    glOsobaPredalaIzlazni.EditValue = podaci.Rows[0][17];
                }
                if (podaci.Rows[0][9].ToString() != "")
                {
                    dtpDokumenta.Text = Convert.ToDateTime(podaci.Rows[0][9]).ToString("dd.MM.yyyy");
                }
                if (podaci.Rows[0][10].ToString() != "")
                {
                    txtDokBroj.Text = podaci.Rows[0][10].ToString();
                }
                if (podaci.Rows[0][1].ToString() != "")
                {
                    glNaslovljenoNaFirma.EditValue = podaci.Rows[0][1];
                }
                if (podaci.Rows[0][11].ToString() != "")
                {
                    dtpPotpis.Text = Convert.ToDateTime(podaci.Rows[0][11]).ToString("dd.MM.yyyy");
                }
                else
                {
                    //dtpPotpis.Enabled = false;
                    dtpPotpis.EditValue = "";
                }
                if (podaci.Rows[0][12].ToString() != "")
                {
                    glOsobaPotpis.EditValue = podaci.Rows[0][12];
                }
                if (podaci.Rows[0][13].ToString() != "")
                {
                    dtpVracenoSPotpisa.Text = Convert.ToDateTime(podaci.Rows[0][13]).ToString("dd.MM.yyyy");
                }
                else
                {
                    //dtpVracenoSPotpisa.Enabled = false;
                    dtpVracenoSPotpisa.EditValue = "";
                }
                if (podaci.Rows[0][14].ToString() != "")
                {
                    dtpPredanoNaKnjizenje.Text = Convert.ToDateTime(podaci.Rows[0][14]).ToString("dd.MM.yyyy");
                }
                else
                {
                    //dtpPredanoNaKnjizenje.Enabled = false;
                    dtpPredanoNaKnjizenje.EditValue = "";
                }
                if (podaci.Rows[0][15].ToString() != "")
                {
                    txtNapomena.Text = podaci.Rows[0][15].ToString();
                }
                if (podaci.Rows[0][16].ToString() != "")
                {
                    txtMjestoTroska.Text = podaci.Rows[0][16].ToString();
                }
                if (podaci.Rows[0][18].ToString() != "")
                {
                    txtMjesecGodina.Text = podaci.Rows[0][18].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUnosPoste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firma.firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.firma.firma);
            // TODO: This line of code loads data into the 'operater._operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.operater._operater);
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
            // TODO: This line of code loads data into the 'vrstaTroska.vrstatroska' table. You can move, or remove it, as needed.
            this.vrstatroskaTableAdapter.Fill(this.vrstaTroska.vrstatroska);
            // TODO: This line of code loads data into the 'vrstaPoste.vrstaposte' table. You can move, or remove it, as needed.
            this.vrstaposteTableAdapter.Fill(this.vrstaPoste.vrstaposte);
            gridView2.Focus();
            pnlUnos.Visible = false;
        }

        private void frmUnosPoste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                dgCjenici.Focus();
                txtEvidencijskiBroj.Text = "";
            }
            else if (e.KeyCode == Keys.F2)
            {
                txtEvidencijskiBroj.Focus();
            }
        }

        private void txtBrojDokumenta_Enter(object sender, EventArgs e)
        {
            txtEvidencijskiBroj = sender as TextBox;
            if (txtEvidencijskiBroj != null)
                txtEvidencijskiBroj.SelectAll();
        }

        private void izracunajEvidBroj()
        {
            DataTable broj = new DataTable();
            try
            {
                veza.ExecuteQuery("select se_trenutnibr from serija", ref broj);
                if (broj.Rows.Count == 1)
                {
                    EvidencijskiBroj = Convert.ToInt32(broj.Rows[0][0]);
                    EvidencijskiBroj = EvidencijskiBroj + 1;
                }
                else
                { 
                    //insert u serije
                    veza.ExecuteQuery("insert into serija (se_pocetnibr,se_zavrsnibr, se_trenutnibr) values (0,default,0)");
                    EvidencijskiBroj = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtEvidencijskiBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (oznaka == "U") //update
                {
                    pokupiPodatke();
                    //MessageBox.Show(upit_update);
                    veza.ExecuteQuery(upit_update);
                    MessageBox.Show("Uspješno ste ažurirali podatke!");
                    isprazniFormuZaUnos();
                    pnlUnos.Visible = false;
                    glVrstaTroska.Focus();
                }
                else //insert
                {
                    izracunajEvidBroj();
                    pokupiPodatke();
                    //MessageBox.Show(ukupniInsert);
                    veza.ExecuteQuery(ukupniInsert);
                    MessageBox.Show("Uspješno ste spremili podatke!");
                    veza.ExecuteQuery("update serija set se_trenutnibr = " + EvidencijskiBroj + " , se_datumzadnji = now()");
                    MessageBox.Show("Evidencijski broj unesene pošte Vam je: " + EvidencijskiBroj + " ");
                    isprazniFormuZaUnos();
                    print();
                    pnlUnos.Visible = false;
                    glVrstaTroska.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pdPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x, y, lineOffset;

            // Instantiate font objects used in printing.
            Font printFont = new Font("Verdana", (float)11, FontStyle.Regular, GraphicsUnit.Point); // Substituted to FontA Font

            e.Graphics.PageUnit = GraphicsUnit.Point;

            // Print the receipt text
            lineOffset = printFont.GetHeight(e.Graphics) -2;

            x = 200;
            y = -10 + lineOffset;

            e.Graphics.DrawString("Evid. broj: " + EvidencijskiBroj + "", printFont, Brushes.Black, x, y);
            y += lineOffset;
            e.Graphics.DrawString("" + DateTime.Now + "", printFont, Brushes.Black, x, y);

            // Indicate that no more data to print, and the Print Document can now send the print data to the spooler.
            e.HasMorePages = false;
        }

        private void print()
        {
            try
            {
                PrintDocument pdPrint = new PrintDocument();

                pdPrint.PrinterSettings.PrinterName = PRINTER_NAME;
                pdPrint.PrintPage += new PrintPageEventHandler(pdPrint_PrintPage);
                pdPrint.PrinterSettings.PrinterName = PRINTER_NAME;


                // Open a printer status monitor for the selected printer.

                if (pdPrint.PrinterSettings.IsValid)
                {
                    pdPrint.DocumentName = "Print";

                    // Start printing.
                    pdPrint.Print();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void prikaziPotrebno()
        {
            DataTable prikaz = new DataTable();
            try
            {
                if (txtEvidencijskiBroj.Text != "")
                {
                    DataTable postaID = new DataTable();
                    veza.ExecuteQuery("select vrstaposte.* from vrstaposte, posta where vrstaposte.vp_ID = posta.vrstaPoste_vp_ID and posta.posta_evidBroj = "+txtEvidencijskiBroj.Text.Trim()+" ", ref postaID);
                    if (postaID.Rows.Count == 1)
                    {

                        if (postaID.Rows[0][2].ToString() == "False") // vrsta troška
                        {
                            glVrstaTroska.Enabled = false;
                        }

                        if (postaID.Rows[0][3].ToString() == "False") //predao za slanje
                        {
                            glOsobaPredalaIzlazni.Enabled = false;
                        }
                        else
                        {
                            glOsobaPredalaIzlazni.EditValue = Global.KorisnikID;
                        }
                        
                        if (postaID.Rows[0][4].ToString() == "False") //poslovni partner
                        {
                            glPartner.Enabled = false;
                        }

                        if (postaID.Rows[0][5].ToString() == "False") //naslovljeno na
                        {
                            glNaslovljenoNaFirma.Enabled = false;
                        }

                        if (postaID.Rows[0][6].ToString() == "False") //datum dokumenta
                        {
                            dtpDokumenta.Enabled = false;
                        }

                        if (postaID.Rows[0][7].ToString() == "False") //broj dokumenta
                        {
                            txtDokBroj.Enabled = false;
                        }

                        if (postaID.Rows[0][8].ToString() == "False") //predano na potpis
                        {
                            dtpPotpis.Enabled = false;
                        }

                        if (postaID.Rows[0][9].ToString() == "False") //predano na potpis osobi
                        {
                            glOsobaPotpis.Enabled = false;
                        }

                        //if (postaID.Rows[0][10].ToString() == "False") //datum vraćanja s potpisa
                        //{
                        //    dtpVracenoSPotpisa.Enabled = false;
                        //}

                        //if (postaID.Rows[0][11].ToString() == "False") //predano na knjiženje datum
                        //{
                        //    dtpPredanoNaKnjizenje.Enabled = false;
                        //}

                        if (postaID.Rows[0][12].ToString() == "False") //napomena
                        {
                            txtNapomena.Enabled = false;
                        }

                        if (postaID.Rows[0][13].ToString() == "False") //mjestoTroska
                        {
                            txtMjestoTroska.Enabled = false;
                        }

                        if (postaID.Rows[0][14].ToString() == "False") //mjesecGodina
                        {
                            txtMjesecGodina.Enabled = false;
                        }
                    }
                }
                else
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if (row != null)
                    {
                        vrstaPosteID = row[0].ToString();
                    }

                    veza.ExecuteQuery("Select * from vrstaposte where vp_ID = " + vrstaPosteID + "", ref prikaz);

                    if (prikaz.Rows.Count == 1)
                    {
                        if (prikaz.Rows[0][2].ToString() == "False") // vrsta troška
                        {
                            glVrstaTroska.Enabled = false;
                        }

                        if (prikaz.Rows[0][3].ToString() == "False") //predao za slanje
                        {
                            glOsobaPredalaIzlazni.Enabled = false;
                        }
                        else
                        {
                            glOsobaPredalaIzlazni.EditValue = Global.KorisnikID;
                        }

                        if (prikaz.Rows[0][4].ToString() == "False") //poslovni partner
                        {
                            glPartner.Enabled = false;
                        }

                        if (prikaz.Rows[0][5].ToString() == "False") //naslovljeno na
                        {
                            glNaslovljenoNaFirma.Enabled = false;
                        }

                        if (prikaz.Rows[0][6].ToString() == "False") //datum dokumenta
                        {
                            dtpDokumenta.Enabled = false;
                        }

                        if (prikaz.Rows[0][7].ToString() == "False") //broj dokumenta
                        {
                            txtDokBroj.Enabled = false;
                        }

                        if (prikaz.Rows[0][8].ToString() == "False") //predano na potpis
                        {
                            dtpPotpis.Enabled = false;
                        }

                        if (prikaz.Rows[0][9].ToString() == "False") //predano na potpis osobi
                        {
                            glOsobaPotpis.Enabled = false;
                        }

                        //if (prikaz.Rows[0][10].ToString() == "False") //datum vraćanja s potpisa
                        //{
                        //    dtpVracenoSPotpisa.Enabled = false;
                        //}

                        //if (prikaz.Rows[0][11].ToString() == "False") //predano na knjiženje datum
                        //{
                        //    dtpPredanoNaKnjizenje.Enabled = false;
                        //}

                        if (prikaz.Rows[0][12].ToString() == "False") //napomena
                        {
                            txtNapomena.Enabled = false;
                        }

                        if (prikaz.Rows[0][13].ToString() == "False") //mjestoTroska
                        {
                            txtMjestoTroska.Enabled = false;
                        }

                        if (prikaz.Rows[0][14].ToString() == "False") //mjesecGodina
                        {
                            txtMjesecGodina.Enabled = false;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatke()
        {
            try
            {
                if (oznaka == "U") //pokupi podatke za update
                {
                    if (glVrstaTroska.Enabled != false) // vrsta troška
                    {
                        if (glVrstaTroska.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " vrstaTroska_vt_ID = " + glVrstaTroska.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_update = upit_update + ",vrstaTroska_vt_ID = " + glVrstaTroska.EditValue.ToString() + "";
                            }
                        }
                    }

                    if (glOsobaPredalaIzlazni.Enabled != false) //predao za slanje
                    {
                        if (glOsobaPredalaIzlazni.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " operater_op_ID_tko_je_predao = " + glOsobaPredalaIzlazni.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_update = upit_update + ",operater_op_ID_tko_je_predao = " + glOsobaPredalaIzlazni.EditValue.ToString() + "";
                            }
                        }
                    }

                    if (glPartner.Enabled != false) //poslovni partner
                    {
                        if (glPartner.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " partner_pa_ID = " + glPartner.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_update = upit_update + ",partner_pa_ID = " + glPartner.EditValue.ToString() + "";
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje 'Partner' !!";
                            glPartner.Focus();
                            upit_update = "update posta set";

                            return;
                        }
                    }


                    if (glNaslovljenoNaFirma.Enabled != false) //naslovljeno na
                    {
                        if (glNaslovljenoNaFirma.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " firma_fi_ID = " + glNaslovljenoNaFirma.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_update = upit_update + ",firma_fi_ID = " + glNaslovljenoNaFirma.EditValue.ToString() + "";
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje 'Naslovljeno na' !!";
                            glNaslovljenoNaFirma.Focus();
                            upit_update = "update posta set";

                            return;
                        }
                    }

                    if (dtpDokumenta.Enabled != false) //datum dokumenta
                    {
                        if (dtpDokumenta.Text != "")
                        {
                            string datumDok = Convert.ToDateTime(dtpDokumenta.Text).ToString("yyyy-MM-dd");
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_datDokumenta= '" + datumDok + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_datDokumenta= '" + datumDok + "'";
                            }
                        }
                    }

                    if (txtDokBroj.Enabled != false) //broj dokumenta
                    {
                        if (txtDokBroj.Text.Trim() != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_brojDokumenta = '" + txtDokBroj.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_brojDokumenta = '" + txtDokBroj.Text.Trim() + "'";
                            }
                        }
                    }

                    if (dtpPotpis.Enabled != false) //predano na potpis
                    {
                        if (dtpPotpis.Text != "")
                        {
                            string datPotpis = Convert.ToDateTime(dtpPotpis.Text).ToString("yyyy-MM-dd");
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_datumPredaje = '" + datPotpis + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_datumPredaje = '" + datPotpis + "'";
                            }
                        }
                    }

                    if (glOsobaPotpis.Enabled != false) //predano na potpis osobi
                    {
                        if (glOsobaPotpis.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " operater_op_ID_predano = " + glOsobaPotpis.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_update = upit_update + ",operater_op_ID_predano = " + glOsobaPotpis.EditValue.ToString() + "";
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje Osoba / odjel !!";
                            glOsobaPotpis.Focus();
                            upit_update = "update posta set";

                            return;
                        }
                    }

                    if (dtpVracenoSPotpisa.Enabled != false) //datum vraćanja s potpisa
                    {
                        if (dtpVracenoSPotpisa.Text != "")
                        {
                            string datVraceno = Convert.ToDateTime(dtpVracenoSPotpisa.Text).ToString("yyyy-MM-dd");
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_datVraceno = '" + datVraceno + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_datVraceno = '" + datVraceno + "'";
                            }
                        }
                    }

                    if (dtpPredanoNaKnjizenje.Enabled != false) //predano na knjiženje datum
                    {
                        if (dtpPredanoNaKnjizenje.Text != "")
                        {
                            string datKnjizenje = Convert.ToDateTime(dtpPredanoNaKnjizenje.Text).ToString("yyyy-MM-dd");
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_datPredanoKnjizenje = '" + datKnjizenje + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_datPredanoKnjizenje = '" + datKnjizenje + "'";
                            }
                        }
                    }

                    if (txtNapomena.Enabled != false) //napomena
                    {
                        if (txtNapomena.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_napomena = '" + txtNapomena.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_napomena = '" + txtNapomena.Text.Trim() + "'";
                            }
                        }
                    }

                    if (txtMjestoTroska.Enabled != false) //mjestoTroska
                    {
                        if (txtMjestoTroska.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_mjestoTroska = '" + txtMjestoTroska.Text + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_mjestoTroska = '" + txtMjestoTroska.Text + "'";
                            }
                        }
                    }

                    if (txtMjesecGodina.Enabled != false) //mjesecGodina
                    {
                        if (txtMjesecGodina.Text != "")
                        {
                            if (OdreziDesno(upit_update, 3) == "set")
                            {
                                upit_update = upit_update + " posta_mjesecGodina = '" + txtMjesecGodina.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_update = upit_update + ",posta_mjesecGodina = '" + txtMjesecGodina.Text.Trim() + "'";
                            }
                        }
                    }

                    upit_update = upit_update + " where posta_ID = " + postaID + "";
                }
                else //pokupi podatke insert
                {
                    if (glVrstaTroska.Enabled != false) // vrsta troška
                    {
                        if (glVrstaTroska.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "vrstaTroska_vt_ID";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",vrstaTroska_vt_ID";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + glVrstaTroska.EditValue.ToString();
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + glVrstaTroska.EditValue.ToString();
                            }
                        }
                    }

                    if (glOsobaPredalaIzlazni.Enabled != false) //predao za slanje
                    {
                        if (glOsobaPredalaIzlazni.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "operater_op_ID_tko_je_predao";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",operater_op_ID_tko_je_predao";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + glOsobaPredalaIzlazni.EditValue.ToString();
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + glOsobaPredalaIzlazni.EditValue.ToString();
                            }
                        }
                    }

                    if (glPartner.Enabled != false) //poslovni partner
                    {
                        if (glPartner.Text != "")
                        {

                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "partner_pa_ID";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",partner_pa_ID";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + glPartner.EditValue.ToString();
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + glPartner.EditValue.ToString();
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje 'Partner'!!!";
                            upit_insert_polja = "insert into posta (";
                            upit_insert_values = "values (";
                            return;
                        }
                    }


                    if (glNaslovljenoNaFirma.Enabled != false) //naslovljeno na
                    {
                        if (glNaslovljenoNaFirma.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "firma_fi_ID";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",firma_fi_ID";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + glNaslovljenoNaFirma.EditValue.ToString() + "";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + glNaslovljenoNaFirma.EditValue.ToString(); ;
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje 'Naslovljeno na'!!!";
                            upit_insert_polja = "insert into posta (";
                            upit_insert_values = "values (";
                            return;
                        }
                    }

                    if (dtpDokumenta.Enabled != false) //datum dokumenta
                    {
                        if (dtpDokumenta.Text != "")
                        {
                            string datumDok = Convert.ToDateTime(dtpDokumenta.Text).ToString("yyyy-MM-dd");

                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_datDokumenta";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_datDokumenta";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + datumDok + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + datumDok + "'";
                            }
                        }
                    }

                    if (txtDokBroj.Enabled != false) //broj dokumenta
                    {
                        if (txtDokBroj.Text.Trim() != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_brojDokumenta";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_brojDokumenta";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + txtDokBroj.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + txtDokBroj.Text.Trim() + "'";
                            }
                        }
                    }

                    if (dtpPotpis.Enabled != false) //predano na potpis
                    {
                        if (dtpPotpis.Text != "")
                        {
                            string datPotpis = Convert.ToDateTime(dtpPotpis.Text).ToString("yyyy-MM-dd");

                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_datumPredaje";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_datumPredaje";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + datPotpis + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + datPotpis + "'";
                            }
                        }
                    }

                    if (glOsobaPotpis.Enabled != false) //predano na potpis osobi
                    {
                        if (glOsobaPotpis.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "operater_op_ID_predano";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",operater_op_ID_predano";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + glOsobaPotpis.EditValue.ToString();
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + glOsobaPotpis.EditValue.ToString();
                            }
                        }
                        else
                        {
                            lblPoruka.Text = "Popunite polje 'Osoba / odjel'!!!";
                            upit_insert_polja = "insert into posta (";
                            upit_insert_values = "values (";
                            return;
                        }
                    }

                    if (dtpVracenoSPotpisa.Enabled != false) //datum vraćanja s potpisa
                    {
                        if (dtpVracenoSPotpisa.Text != "")
                        {
                            string datVraceno = Convert.ToDateTime(dtpVracenoSPotpisa.Text).ToString("yyyy-MM-dd");

                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_datVraceno";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_datVraceno";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + datVraceno + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + datVraceno + "'";
                            }
                        }
                    }

                    if (dtpPredanoNaKnjizenje.Enabled != false) //predano na knjiženje datum
                    {
                        if (dtpPredanoNaKnjizenje.Text != "")
                        {
                            string datKnjizenje = Convert.ToDateTime(dtpPredanoNaKnjizenje.Text).ToString("yyyy-MM-dd");

                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_datPredanoKnjizenje";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_datPredanoKnjizenje";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + datKnjizenje + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + datKnjizenje + "'";
                            }
                        }
                    }

                    if (txtNapomena.Enabled != false) //napomena
                    {
                        if (txtNapomena.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_napomena";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_napomena";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + txtNapomena.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + txtNapomena.Text.Trim() + "'";
                            }
                        }
                    }

                    if (txtMjestoTroska.Enabled != false) //mjestoTroska
                    {
                        if (txtMjestoTroska.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_mjestoTroska";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_mjestoTroska";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + txtMjestoTroska.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + txtMjestoTroska.Text.Trim() + "'";
                            }
                        }
                    }

                    if (txtMjesecGodina.Enabled != false) //mjesecGodina
                    {
                        if (txtMjesecGodina.Text != "")
                        {
                            if (OdreziDesno(upit_insert_polja, 1) == "(")
                            {
                                upit_insert_polja = upit_insert_polja + "posta_mjesecGodina";
                            }
                            else
                            {
                                upit_insert_polja = upit_insert_polja + ",posta_mjesecGodina";
                            }

                            if (OdreziDesno(upit_insert_values, 1) == "(")
                            {
                                upit_insert_values = upit_insert_values + "'" + txtMjesecGodina.Text.Trim() + "'";
                            }
                            else
                            {
                                upit_insert_values = upit_insert_values + "," + "'" + txtMjesecGodina.Text.Trim() + "'";
                            }
                        }
                    }

                    upit_insert_polja = "" + upit_insert_polja + ",operater_op_ID , vrstaPoste_vp_ID, posta_evidBroj" + ")";
                    upit_insert_values = upit_insert_values + "," + Global.KorisnikID + "," + vrstaPosteID + "," + EvidencijskiBroj + ")";
                    ukupniInsert = upit_insert_polja + upit_insert_values;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string OdreziDesno(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);

            return result;
        }

        private void txtMjestoTroska_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmSifarnikPoslovnica _frm = new frmSifarnikPoslovnica();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtMjestoTroska.Text = _frm.sifra_poslovnice;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            } 
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void dgCjenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnNaprijed.Focus();
                }
            }
        }

        private void txtEvidencijskiBroj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void glVrstaTroska_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void glPartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void glOsobaPredalaIzlazni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void dtpDokumenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void txtDokBroj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void glNaslovljenoNaFirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void dtpPotpis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void glOsobaPotpis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void dtpVracenoSPotpisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void dtpPredanoNaKnjizenje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void txtNapomena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void txtMjesecGodina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }  
        }

        private void txtDokBroj_Leave(object sender, EventArgs e)
        {
            try
            {
                if (glPartner.Text != "")
                {
                    DataTable provjera = new DataTable();
                    veza.ExecuteQuery("select posta_ID from posta where posta_brojDokumenta = '" + txtDokBroj.Text.Trim() + "' and partner_pa_ID = " + glPartner.EditValue + " and posta_storno = 0", ref podaci);

                    if (podaci.Rows.Count > 0)
                    {
                        lblPorukaBrojDok.Text = "Već postoji dokument pod tim brojem !!";
                    }
                    else
                    {
                        lblPorukaBrojDok.Text = "";
                    }
                }
                else
                {
                    lblPorukaBrojDok.Text = "Odaberite partnera!";
                    glPartner.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
