using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.IO;

namespace Urudzbeni_ured
{
    public partial class frmIspisEvidBroj : Form
    {
        private const string PRINTER_NAME = "EPSON TM-U590 Slip";

        public frmIspisEvidBroj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if (txtBroj.Text != "")
            {
                print();
            }
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



        private void pdPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x, y, lineOffset;

            // Instantiate font objects used in printing.
            Font printFont = new Font("Verdana", (float)11, FontStyle.Regular, GraphicsUnit.Point); // Substituted to FontA Font

            e.Graphics.PageUnit = GraphicsUnit.Point;

            // Print the receipt text
            lineOffset = printFont.GetHeight(e.Graphics) - 2;

            x = 200;
            y = -10 + lineOffset;

            e.Graphics.DrawString("Evid. broj: " + txtBroj.Text.Trim() + "", printFont, Brushes.Black, x, y);
            y += lineOffset;
            e.Graphics.DrawString("" + DateTime.Now + "", printFont, Brushes.Black, x, y);

            // Indicate that no more data to print, and the Print Document can now send the print data to the spooler.
            e.HasMorePages = false;
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmIspisEvidBroj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
