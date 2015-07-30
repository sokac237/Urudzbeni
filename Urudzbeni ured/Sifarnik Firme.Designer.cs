namespace Urudzbeni_ured
{
    partial class frmSifarnikFirme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPregledFirmi = new DevExpress.XtraGrid.GridControl();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firma = new Urudzbeni_ured.Firma();
            this.dgFirme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfi_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfi_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfi_aktivna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfi_oib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfi_adresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfi_telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firmaTableAdapter = new Urudzbeni_ured.FirmaTableAdapters.firmaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPregledFirmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFirme)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAzuriraj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(720, 22);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(1, 1);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delete - obriši";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F7 - dodaj novi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "F4 - ažuriraj ";
            // 
            // dgPregledFirmi
            // 
            this.dgPregledFirmi.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.dgPregledFirmi.DataSource = this.firmaBindingSource;
            this.dgPregledFirmi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPregledFirmi.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgPregledFirmi.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgPregledFirmi.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgPregledFirmi.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dgPregledFirmi.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.dgPregledFirmi.Location = new System.Drawing.Point(0, 61);
            this.dgPregledFirmi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.dgPregledFirmi.MainView = this.dgFirme;
            this.dgPregledFirmi.Name = "dgPregledFirmi";
            this.dgPregledFirmi.Size = new System.Drawing.Size(719, 465);
            this.dgPregledFirmi.TabIndex = 24;
            this.dgPregledFirmi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgFirme});
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "firma";
            this.firmaBindingSource.DataSource = this.firma;
            // 
            // firma
            // 
            this.firma.DataSetName = "Firma";
            this.firma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgFirme
            // 
            this.dgFirme.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgFirme.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgFirme.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgFirme.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgFirme.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgFirme.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgFirme.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgFirme.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgFirme.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgFirme.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgFirme.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.Empty.Options.UseBackColor = true;
            this.dgFirme.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgFirme.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgFirme.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgFirme.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgFirme.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgFirme.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgFirme.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgFirme.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgFirme.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgFirme.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgFirme.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgFirme.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgFirme.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgFirme.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgFirme.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgFirme.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgFirme.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgFirme.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgFirme.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgFirme.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgFirme.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgFirme.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgFirme.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgFirme.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgFirme.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgFirme.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgFirme.Appearance.GroupRow.Options.UseFont = true;
            this.dgFirme.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgFirme.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgFirme.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgFirme.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgFirme.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgFirme.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgFirme.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgFirme.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgFirme.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgFirme.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgFirme.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.OddRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.OddRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgFirme.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgFirme.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.Preview.Options.UseBackColor = true;
            this.dgFirme.Appearance.Preview.Options.UseForeColor = true;
            this.dgFirme.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.Row.Options.UseBackColor = true;
            this.dgFirme.Appearance.Row.Options.UseForeColor = true;
            this.dgFirme.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgFirme.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgFirme.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgFirme.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgFirme.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgFirme.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgFirme.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgFirme.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.VertLine.Options.UseBackColor = true;
            this.dgFirme.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgFirme.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgFirme.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgFirme.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgFirme.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgFirme.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgFirme.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgFirme.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfi_ID,
            this.colfi_naziv,
            this.colfi_aktivna,
            this.colfi_oib,
            this.colfi_adresa,
            this.colfi_telefon});
            this.dgFirme.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgFirme.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.dgFirme.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            this.dgFirme.GridControl = this.dgPregledFirmi;
            this.dgFirme.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.dgFirme.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.dgFirme.Name = "dgFirme";
            this.dgFirme.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgFirme.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgFirme.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgFirme.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgFirme.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.dgFirme.OptionsBehavior.Editable = false;
            this.dgFirme.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.dgFirme.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.dgFirme.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgFirme.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.dgFirme.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.dgFirme.OptionsView.EnableAppearanceEvenRow = true;
            this.dgFirme.OptionsView.EnableAppearanceOddRow = true;
            this.dgFirme.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.dgFirme.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.dgFirme.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.dgFirme.OptionsView.ShowAutoFilterRow = true;
            this.dgFirme.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgFirme.OptionsView.ShowGroupPanel = false;
            this.dgFirme.OptionsView.ShowIndicator = false;
            this.dgFirme.PaintStyleName = "WindowsXP";
            this.dgFirme.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.dgFirme.SynchronizeClones = false;
            this.dgFirme.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colfi_ID
            // 
            this.colfi_ID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_ID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_ID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_ID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_ID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_ID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_ID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_ID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_ID.FieldName = "fi_ID";
            this.colfi_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_ID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_ID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_ID.Name = "colfi_ID";
            this.colfi_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_ID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_ID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colfi_naziv
            // 
            this.colfi_naziv.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_naziv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_naziv.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_naziv.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_naziv.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_naziv.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_naziv.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_naziv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_naziv.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_naziv.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_naziv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_naziv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_naziv.Caption = "Naziv";
            this.colfi_naziv.FieldName = "fi_naziv";
            this.colfi_naziv.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_naziv.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_naziv.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_naziv.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_naziv.Name = "colfi_naziv";
            this.colfi_naziv.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_naziv.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_naziv.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_naziv.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_naziv.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_naziv.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_naziv.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_naziv.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_naziv.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_naziv.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colfi_naziv.Visible = true;
            this.colfi_naziv.VisibleIndex = 0;
            this.colfi_naziv.Width = 358;
            // 
            // colfi_aktivna
            // 
            this.colfi_aktivna.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_aktivna.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_aktivna.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_aktivna.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_aktivna.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_aktivna.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_aktivna.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_aktivna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_aktivna.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_aktivna.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_aktivna.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_aktivna.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_aktivna.Caption = "Aktivna";
            this.colfi_aktivna.FieldName = "fi_aktivna";
            this.colfi_aktivna.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_aktivna.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_aktivna.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_aktivna.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_aktivna.Name = "colfi_aktivna";
            this.colfi_aktivna.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_aktivna.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_aktivna.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_aktivna.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_aktivna.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_aktivna.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_aktivna.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_aktivna.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_aktivna.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_aktivna.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colfi_aktivna.Visible = true;
            this.colfi_aktivna.VisibleIndex = 1;
            this.colfi_aktivna.Width = 90;
            // 
            // colfi_oib
            // 
            this.colfi_oib.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_oib.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_oib.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_oib.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_oib.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_oib.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_oib.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_oib.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_oib.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_oib.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_oib.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_oib.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_oib.Caption = "OIB";
            this.colfi_oib.FieldName = "fi_oib";
            this.colfi_oib.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_oib.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_oib.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_oib.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_oib.Name = "colfi_oib";
            this.colfi_oib.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_oib.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_oib.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_oib.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_oib.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_oib.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_oib.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_oib.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_oib.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_oib.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colfi_oib.Visible = true;
            this.colfi_oib.VisibleIndex = 2;
            this.colfi_oib.Width = 167;
            // 
            // colfi_adresa
            // 
            this.colfi_adresa.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_adresa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_adresa.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_adresa.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_adresa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_adresa.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_adresa.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_adresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_adresa.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_adresa.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_adresa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_adresa.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_adresa.Caption = "Adresa";
            this.colfi_adresa.FieldName = "fi_adresa";
            this.colfi_adresa.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_adresa.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_adresa.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_adresa.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_adresa.Name = "colfi_adresa";
            this.colfi_adresa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_adresa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_adresa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_adresa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_adresa.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_adresa.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_adresa.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_adresa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_adresa.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_adresa.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colfi_adresa.Visible = true;
            this.colfi_adresa.VisibleIndex = 3;
            this.colfi_adresa.Width = 287;
            // 
            // colfi_telefon
            // 
            this.colfi_telefon.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_telefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_telefon.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_telefon.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_telefon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_telefon.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_telefon.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colfi_telefon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colfi_telefon.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colfi_telefon.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colfi_telefon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colfi_telefon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colfi_telefon.Caption = "Telefon";
            this.colfi_telefon.FieldName = "fi_telefon";
            this.colfi_telefon.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colfi_telefon.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colfi_telefon.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colfi_telefon.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colfi_telefon.Name = "colfi_telefon";
            this.colfi_telefon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_telefon.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_telefon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_telefon.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colfi_telefon.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colfi_telefon.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_telefon.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colfi_telefon.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colfi_telefon.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colfi_telefon.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colfi_telefon.Visible = true;
            this.colfi_telefon.VisibleIndex = 4;
            this.colfi_telefon.Width = 183;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSifarnikFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 526);
            this.Controls.Add(this.dgPregledFirmi);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmSifarnikFirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Šifarnik firmi";
            this.Load += new System.EventHandler(this.frmSifarnikFirme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSifarnikFirme_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPregledFirmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFirme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgPregledFirmi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgFirme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Firma firma;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private FirmaTableAdapters.firmaTableAdapter firmaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_aktivna;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_oib;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_adresa;
        private DevExpress.XtraGrid.Columns.GridColumn colfi_telefon;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}