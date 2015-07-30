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
    public partial class frmStorno : Form
    {
        Upiti veza = new Upiti();

        public frmStorno()
        {
            InitializeComponent();
        }

        private void brnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Želite stornirati poštu pod ovim evidencijskim brojem?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable posta = new DataTable();

                    if (txtEvidBroj.Text.Trim() != "")
                    {
                        veza.ExecuteQuery("select posta_evidBroj from posta where  posta_evidBroj = " + txtEvidBroj.Text.Trim() + " and posta_storno = 0", ref posta);

                        if (posta.Rows.Count > 0)
                        {
                            veza.ExecuteQuery("update posta set posta_storno = 1 where posta_evidBroj = " + txtEvidBroj.Text.Trim() + "");
                            MessageBox.Show("Uspješno ste stornirali poštu!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ovaj evidencijski broj je već storniran ili ne postoji!");
                            txtEvidBroj.Focus();
                            txtEvidBroj.Text = "";
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmStorno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
