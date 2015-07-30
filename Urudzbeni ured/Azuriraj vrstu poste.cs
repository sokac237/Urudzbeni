using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Urudzbeni_ured
{
    public partial class frmAzurirajVrstuPoste : Form
    {
        Upiti veza = new Upiti();
        DataTable posta = new DataTable();

        string _oznaka;
        string _vrstaPoste;

        int vp_vrstaTroška;
        int vp_predao_za_slanje;
        int vp_poslovniPartner;
        int vp_naslovljenaNa;
        int vp_datumDokumenta;
        int vp_brojDokumenta;
        int vp_predanoNaPotpisDatum;
        int vp_predanoNaPotpisOsoba;
        int vp_vracenoDatum;
        int vp_predanoNaKnjizenje;
        int vp_napomena;
        int vp_mjestoTroska;
        int vp_mjesecGodina;


        public frmAzurirajVrstuPoste()
        {
            InitializeComponent();
        }
        
        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string vrstaPosteID
        {
            get { return _vrstaPoste; }
            set { _vrstaPoste = value; }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAzurirajVrstuPoste_Load(object sender, EventArgs e)
        {
            try
            {
                if (_oznaka == "F4") //azuriraj
                {
                    veza.ExecuteQuery("select * from vrstaposte where vp_ID = " + _vrstaPoste + "", ref posta);
                    if (posta.Rows.Count == 1)
                    {
                        txtVrstaPoste.Text = posta.Rows[0][1].ToString();


                        if (posta.Rows[0][2].ToString() == "False")
                        {
                            rb.Checked = false;
                            br.Checked = true;
                        }
                        else
                        {
                            br.Checked = false;
                            rb.Checked = true;
                        }

                        if (posta.Rows[0][3].ToString() == "False")
                        {
                            rb1.Checked = false;
                            rb2.Checked = true;
                        }
                        else
                        {
                            rb2.Checked = false;
                            rb1.Checked = true;
                        }

                        if (posta.Rows[0][4].ToString() == "False")
                        {
                            rb3.Checked = false;
                            rb4.Checked = true;
                        }
                        else
                        {
                            rb4.Checked = false;
                            rb3.Checked = true;
                        }

                        if (posta.Rows[0][5].ToString() == "False")
                        {
                            rb5.Checked = false;
                            rb6.Checked = true;
                        }
                        else
                        {
                            rb6.Checked = false;
                            rb5.Checked = true;
                        }

                        if (posta.Rows[0][6].ToString() == "False")
                        {
                            rb7.Checked = false;
                            rb8.Checked = true;
                        }
                        else
                        {
                            rb8.Checked = false;
                            rb7.Checked = true;
                        }

                        if (posta.Rows[0][7].ToString() == "False")
                        {
                            rb9.Checked = false;
                            rb10.Checked = true;
                        }
                        else
                        {
                            rb10.Checked = false;
                            rb9.Checked = true;
                        }

                        if (posta.Rows[0][8].ToString() == "False")
                        {
                            rb11.Checked = false;
                            rb12.Checked = true;
                        }
                        else
                        {
                            rb12.Checked = false;
                            rb11.Checked = true;
                        }

                        if (posta.Rows[0][9].ToString() == "False")
                        {
                            rb13.Checked = false;
                            rb14.Checked = true;
                        }
                        else
                        {
                            rb14.Checked = false;
                            rb13.Checked = true;
                        }

                        if (posta.Rows[0][10].ToString() == "False")
                        {
                            rb15.Checked = false;
                            rb16.Checked = true;
                        }
                        else
                        {
                            rb16.Checked = false;
                            rb15.Checked = true;
                        }

                        if (posta.Rows[0][11].ToString() == "False")
                        {
                            rb17.Checked = false;
                            rb18.Checked = true;
                        }
                        else
                        {
                            rb18.Checked = false;
                            rb17.Checked = true;
                        }

                        if (posta.Rows[0][12].ToString() == "False")
                        {
                            rb19.Checked = false;
                            rb20.Checked = true;
                        }
                        else
                        {
                            rb20.Checked = false;
                            rb19.Checked = true;
                        }

                        if (posta.Rows[0][13].ToString() == "False")
                        {
                            rb21.Checked = false;
                            rb22.Checked = true;
                        }
                        else
                        {
                            rb22.Checked = false;
                            rb21.Checked = true;
                        }
                        if (posta.Rows[0][14].ToString() == "False")
                        {
                            rb23.Checked = false;
                            rb24.Checked = true;
                        }
                        else
                        {
                            rb24.Checked = false;
                            rb23.Checked = true;
                        }
                    }
                }
                else //insert
                {
                    return;
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
                if (txtVrstaPoste.Text != "")
                {
                    if (rb.Checked == false)
                    {
                        vp_vrstaTroška = 0;
                    }
                    else
                    {
                        vp_vrstaTroška = 1;
                    }

                    if (rb1.Checked == false)
                    {
                        vp_predao_za_slanje = 0;
                    }
                    else
                    {
                        vp_predao_za_slanje = 1;
                    }

                    if (rb3.Checked == false)
                    {
                        vp_poslovniPartner = 0;
                    }
                    else
                    {
                        vp_poslovniPartner = 1;
                    }

                    if (rb5.Checked == false)
                    {
                        vp_naslovljenaNa = 0;
                    }
                    else
                    {
                        vp_naslovljenaNa = 1;
                    }

                    if (rb7.Checked == false)
                    {
                        vp_datumDokumenta = 0;
                    }
                    else
                    {
                        vp_datumDokumenta = 1;
                    }

                    if (rb9.Checked == false)
                    {
                        vp_brojDokumenta = 0;
                    }
                    else
                    {
                        vp_brojDokumenta = 1;
                    }

                    if (rb11.Checked == false)
                    {
                        vp_predanoNaPotpisDatum = 0;
                    }
                    else
                    {
                        vp_predanoNaPotpisDatum = 1;
                    }

                    if (rb13.Checked == false)
                    {
                        vp_predanoNaPotpisOsoba = 0;
                    }
                    else
                    {
                        vp_predanoNaPotpisOsoba = 1;
                    }

                    if ( rb15.Checked == false)
                    {
                        vp_vracenoDatum = 0;
                    }
                    else
                    {
                        vp_vracenoDatum = 1;
                    }

                    if (rb17.Checked == false)
                    {
                        vp_predanoNaKnjizenje = 0;
                    }
                    else
                    {
                        vp_predanoNaKnjizenje = 1;
                    }

                    if (rb19.Checked == false)
                    {
                        vp_napomena = 0;
                    }
                    else
                    {
                        vp_napomena = 1;
                    }

                    if (rb21.Checked == false)
                    {
                        vp_mjestoTroska = 0;
                    }
                    else
                    {
                        vp_mjestoTroska = 1;
                    }
                    if (rb23.Checked == false)
                    {
                        vp_mjesecGodina = 0;
                    }
                    else
                    {
                        vp_mjesecGodina = 1;
                    }

                    if (_oznaka == "F4")//update
                    {
                        veza.ExecuteQuery("update vrstaposte set vp_naziv= '" + txtVrstaPoste.Text.Trim() + "', vp_vrstaTroška = " + vp_vrstaTroška + ",  vp_predao_za_slanje= " + vp_predao_za_slanje + ", vp_poslovniPartner =" + vp_poslovniPartner + ", vp_naslovljenaNa = " + vp_naslovljenaNa + ",vp_datumDokumenta= " + vp_datumDokumenta + ",vp_brojDokumenta= " + vp_brojDokumenta + ", vp_predanoNaPotpisDatum = " + vp_predanoNaPotpisDatum + " , vp_predanoNaPotpisOsoba =" + vp_predanoNaPotpisOsoba + ", vp_vracenoDatum= " + vp_vracenoDatum + ", vp_predanoNaKnjizenje = " + vp_predanoNaKnjizenje + " ,vp_napomena = " + vp_napomena + ",vp_mjestoTroska = " + vp_mjestoTroska + ", vp_mjesecGodina = "+vp_mjesecGodina+" where  vp_ID = "+_vrstaPoste+" ");
                        MessageBox.Show("Uspješno ste ažurirali vrstu pošte!");
                        frmVrstaPoste.azuriraj.PerformClick();
                        this.Close();
                    }
                    else//insert
                    {
                        veza.ExecuteQuery("insert into vrstaposte (vp_naziv, vp_vrstaTroška, vp_predao_za_slanje, vp_poslovniPartner, vp_naslovljenaNa, vp_datumDokumenta,vp_brojDokumenta,vp_predanoNaPotpisDatum,vp_predanoNaPotpisOsoba,vp_vracenoDatum,vp_predanoNaKnjizenje,vp_napomena,vp_mjestoTroska,vp_mjesecGodina) values ('" + txtVrstaPoste.Text.Trim() + "', " + vp_vrstaTroška + ", " + vp_predao_za_slanje + ", " + vp_poslovniPartner + ", " + vp_naslovljenaNa + ", " + vp_datumDokumenta + ", " + vp_brojDokumenta + ", " + vp_predanoNaPotpisDatum + ", " + vp_predanoNaPotpisOsoba + ", " + vp_vracenoDatum + ", " + vp_predanoNaKnjizenje + "," + vp_napomena + ", " + vp_mjestoTroska + ", " + vp_mjesecGodina + ")");
                        MessageBox.Show("Uspješno ste dodali vrstu pošte!");
                        frmVrstaPoste.azuriraj.PerformClick();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti polje Naziv pošte!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAzurirajVrstuPoste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }

}
