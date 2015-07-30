namespace Urudzbeni_ured
{
    partial class frmSifarnikPoslovnica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoslovnica = new System.Windows.Forms.TextBox();
            this.dgPoslovnice = new System.Windows.Forms.DataGridView();
            this.poslovnice = new Urudzbeni_ured.Poslovnice();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaTableAdapter = new Urudzbeni_ured.PoslovniceTableAdapters.poslovnicaTableAdapter();
            this.poIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslovnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPoslovnica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 65);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // txtPoslovnica
            // 
            this.txtPoslovnica.Location = new System.Drawing.Point(83, 20);
            this.txtPoslovnica.Name = "txtPoslovnica";
            this.txtPoslovnica.Size = new System.Drawing.Size(144, 20);
            this.txtPoslovnica.TabIndex = 0;
            this.txtPoslovnica.TextChanged += new System.EventHandler(this.txtPoslovnica_TextChanged);
            this.txtPoslovnica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoslovnica_KeyDown);
            // 
            // dgPoslovnice
            // 
            this.dgPoslovnice.AllowUserToAddRows = false;
            this.dgPoslovnice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgPoslovnice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPoslovnice.AutoGenerateColumns = false;
            this.dgPoslovnice.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgPoslovnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoslovnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poIDDataGridViewTextBoxColumn,
            this.posifraDataGridViewTextBoxColumn,
            this.po_naziv});
            this.dgPoslovnice.DataSource = this.poslovnicaBindingSource;
            this.dgPoslovnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPoslovnice.Location = new System.Drawing.Point(0, 65);
            this.dgPoslovnice.Name = "dgPoslovnice";
            this.dgPoslovnice.ReadOnly = true;
            this.dgPoslovnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPoslovnice.Size = new System.Drawing.Size(342, 325);
            this.dgPoslovnice.TabIndex = 6;
            this.dgPoslovnice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoslovnice_CellDoubleClick);
            this.dgPoslovnice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPoslovnice_KeyDown);
            // 
            // poslovnice
            // 
            this.poslovnice.DataSetName = "Poslovnice";
            this.poslovnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.poslovnice;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // poIDDataGridViewTextBoxColumn
            // 
            this.poIDDataGridViewTextBoxColumn.DataPropertyName = "po_ID";
            this.poIDDataGridViewTextBoxColumn.HeaderText = "po_ID";
            this.poIDDataGridViewTextBoxColumn.Name = "poIDDataGridViewTextBoxColumn";
            this.poIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.poIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // posifraDataGridViewTextBoxColumn
            // 
            this.posifraDataGridViewTextBoxColumn.DataPropertyName = "po_sifra";
            this.posifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.posifraDataGridViewTextBoxColumn.Name = "posifraDataGridViewTextBoxColumn";
            this.posifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // po_naziv
            // 
            this.po_naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.po_naziv.DataPropertyName = "po_naziv";
            this.po_naziv.HeaderText = "Naziv";
            this.po_naziv.Name = "po_naziv";
            this.po_naziv.ReadOnly = true;
            // 
            // frmSifarnikPoslovnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 390);
            this.Controls.Add(this.dgPoslovnice);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmSifarnikPoslovnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poslovnice";
            this.Load += new System.EventHandler(this.Sifarnik_poslovnica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSifarnikPoslovnica_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslovnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoslovnica;
        private System.Windows.Forms.DataGridView dgPoslovnice;
        private Poslovnice poslovnice;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovniceTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn poIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_naziv;
    }
}