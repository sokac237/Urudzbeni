namespace Urudzbeni_ured
{
    partial class frmStorno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvidBroj = new System.Windows.Forms.TextBox();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.brnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidencijski broj pošte:";
            // 
            // txtEvidBroj
            // 
            this.txtEvidBroj.Location = new System.Drawing.Point(153, 42);
            this.txtEvidBroj.Name = "txtEvidBroj";
            this.txtEvidBroj.Size = new System.Drawing.Size(100, 20);
            this.txtEvidBroj.TabIndex = 1;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(130, 93);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(75, 23);
            this.btnStorniraj.TabIndex = 2;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // brnOdustani
            // 
            this.brnOdustani.Location = new System.Drawing.Point(211, 93);
            this.brnOdustani.Name = "brnOdustani";
            this.brnOdustani.Size = new System.Drawing.Size(75, 23);
            this.brnOdustani.TabIndex = 3;
            this.brnOdustani.Text = "Odustani";
            this.brnOdustani.UseVisualStyleBackColor = true;
            this.brnOdustani.Click += new System.EventHandler(this.brnOdustani_Click);
            // 
            // frmStorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 128);
            this.Controls.Add(this.brnOdustani);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.txtEvidBroj);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmStorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storno";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStorno_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvidBroj;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button brnOdustani;
    }
}