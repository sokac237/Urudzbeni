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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cSVImportPartnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCSV _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmCSV))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmCSV();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ssNazivFirme.Text = "Copyright © Informatika FORTUNO d.o.o. Vukovar";

            frmLogin _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmLogin))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmLogin();
            _frm.ShowDialog();

            string datum = DateTime.Today.Day.ToString() + "." +
                        DateTime.Today.Month.ToString() + "." +
                        DateTime.Today.Year.ToString();
            ssDatum.Text = "Datum: " + datum;
            ssKorisnik.Text = "Korisnik: " + Global.Korisnik;

            if (Global.PravaKorisnika == "1")
            {
                unosPristiglePošteToolStripMenuItem.Enabled = false;
                servisToolStripMenuItem.Enabled = false;
                šifarniciToolStripMenuItem.Enabled = false;
                predajaPošteToolStripMenuItem1.Enabled = false;
                ispisToolStripMenuItem.Enabled = false;
                stornoToolStripMenuItem.Enabled = false;
            }
            else
            {
                return;
            }
            prava();
        }


        private void prava()
        {
            int nivo = Convert.ToInt32(Global.NivoKorisnika);
            if (nivo == 9)
            {
                //OMOGUĆI SVE
                unosPristiglePošteToolStripMenuItem.Enabled = true;
                servisToolStripMenuItem.Enabled = true;
                šifarniciToolStripMenuItem.Enabled = true;
                predajaPošteToolStripMenuItem1.Enabled = true;
                ispisToolStripMenuItem.Enabled = true;
                stornoToolStripMenuItem.Enabled = true;
            }
        }

        private void unosPristiglePošteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosPoste _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmUnosPoste))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmUnosPoste();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void vrstaTroškaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrstaTroska _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmVrstaTroska))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmVrstaTroska();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSifarnikFirme _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSifarnikFirme))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmSifarnikFirme();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void vrstaPošteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrstaPoste _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmVrstaPoste))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmVrstaPoste();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void premaDatumuPredajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredajaPoste _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPredajaPoste))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmPredajaPoste();
            _Form.MdiParent = this;
            _Form.oznaka = "D";
            _Form.Show();
        }

        private void premaRazdobljuUnosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredajaPoste _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPredajaPoste))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmPredajaPoste();
            _Form.MdiParent = this;
            _Form.oznaka = "R";
            _Form.Show();
        }

        private void vraćenoSPotpisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVracenoSPotpisa _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmVracenoSPotpisa))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmVracenoSPotpisa();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void pračenmkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatusPoste _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStatusPoste))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmStatusPoste();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void predajDirektoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredajaDirektoru _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPredajaDirektoru))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmPredajaDirektoru();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void vraćenoOdDirektoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVracenoOdDirektora _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmVracenoOdDirektora))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmVracenoOdDirektora();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void slanjeNaKnjiženjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlanjeNaKnjizenje _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSlanjeNaKnjizenje))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmSlanjeNaKnjizenje();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void ispisPremaDatumuSlanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlanjeNaKnjizenjeIspis _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSlanjeNaKnjizenjeIspis))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmSlanjeNaKnjizenjeIspis();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void ispisšiEvidencijskiBrojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIspisEvidBroj _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmIspisEvidBroj))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmIspisEvidBroj();
            _Form.MdiParent = this;
            _Form.Show();
        }

        private void stornirajPoštuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStorno _Form;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStorno))
                {
                    childForm.Focus();
                    return;
                }
            }
            _Form = new frmStorno();
            _Form.MdiParent = this;
            _Form.Show();
        }
    }
}
