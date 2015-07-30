namespace Urudzbeni_ured
{
    partial class frmVrstaPoste
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPosta = new DevExpress.XtraGrid.GridControl();
            this.vrstaposteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaPoste = new Urudzbeni_ured.vrstaPoste();
            this.dgVrstaPoste = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvp_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_vrstaTroška = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_predao_za_slanje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_poslovniPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_naslovljenaNa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_datumDokumenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_brojDokumenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_predanoNaPotpisDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_predanoNaPotpisOsoba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_vracenoDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_predanoNaKnjizenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_mjestoTroska = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_mjesecGodina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vrstaposteTableAdapter = new Urudzbeni_ured.vrstaPosteTableAdapters.vrstaposteTableAdapter();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaposteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVrstaPoste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAzuriraj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 64);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Delete - obriši";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "F4 - ažuriraj ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "F7 - dodaj novi";
            // 
            // dgPosta
            // 
            this.dgPosta.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.dgPosta.DataSource = this.vrstaposteBindingSource;
            this.dgPosta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPosta.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.dgPosta.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgPosta.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgPosta.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgPosta.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgPosta.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgPosta.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgPosta.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgPosta.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dgPosta.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.dgPosta.Location = new System.Drawing.Point(0, 64);
            this.dgPosta.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.dgPosta.MainView = this.dgVrstaPoste;
            this.dgPosta.Name = "dgPosta";
            this.dgPosta.Size = new System.Drawing.Size(1092, 346);
            this.dgPosta.TabIndex = 25;
            this.dgPosta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgVrstaPoste});
            // 
            // vrstaposteBindingSource
            // 
            this.vrstaposteBindingSource.DataMember = "vrstaposte";
            this.vrstaposteBindingSource.DataSource = this.vrstaPoste;
            // 
            // vrstaPoste
            // 
            this.vrstaPoste.DataSetName = "vrstaPoste";
            this.vrstaPoste.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgVrstaPoste
            // 
            this.dgVrstaPoste.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgVrstaPoste.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.Empty.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgVrstaPoste.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgVrstaPoste.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgVrstaPoste.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgVrstaPoste.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgVrstaPoste.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgVrstaPoste.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgVrstaPoste.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgVrstaPoste.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVrstaPoste.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgVrstaPoste.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.GroupRow.Options.UseFont = true;
            this.dgVrstaPoste.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgVrstaPoste.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgVrstaPoste.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgVrstaPoste.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgVrstaPoste.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgVrstaPoste.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgVrstaPoste.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgVrstaPoste.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgVrstaPoste.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgVrstaPoste.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.OddRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.OddRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgVrstaPoste.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgVrstaPoste.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.Preview.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.Preview.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.Row.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.Row.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgVrstaPoste.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgVrstaPoste.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgVrstaPoste.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgVrstaPoste.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgVrstaPoste.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.VertLine.Options.UseBackColor = true;
            this.dgVrstaPoste.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgVrstaPoste.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgVrstaPoste.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgVrstaPoste.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgVrstaPoste.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgVrstaPoste.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgVrstaPoste.ColumnPanelRowHeight = 40;
            this.dgVrstaPoste.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvp_ID,
            this.colvp_naziv,
            this.colvp_vrstaTroška,
            this.colvp_predao_za_slanje,
            this.colvp_poslovniPartner,
            this.colvp_naslovljenaNa,
            this.colvp_datumDokumenta,
            this.colvp_brojDokumenta,
            this.colvp_predanoNaPotpisDatum,
            this.colvp_predanoNaPotpisOsoba,
            this.colvp_vracenoDatum,
            this.colvp_predanoNaKnjizenje,
            this.colvp_napomena,
            this.colvp_mjestoTroska,
            this.colvp_mjesecGodina});
            this.dgVrstaPoste.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgVrstaPoste.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.dgVrstaPoste.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            this.dgVrstaPoste.GridControl = this.dgPosta;
            this.dgVrstaPoste.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.dgVrstaPoste.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.dgVrstaPoste.Name = "dgVrstaPoste";
            this.dgVrstaPoste.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgVrstaPoste.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgVrstaPoste.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgVrstaPoste.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgVrstaPoste.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.dgVrstaPoste.OptionsBehavior.Editable = false;
            this.dgVrstaPoste.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.dgVrstaPoste.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.dgVrstaPoste.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgVrstaPoste.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.dgVrstaPoste.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.dgVrstaPoste.OptionsView.EnableAppearanceEvenRow = true;
            this.dgVrstaPoste.OptionsView.EnableAppearanceOddRow = true;
            this.dgVrstaPoste.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.dgVrstaPoste.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.dgVrstaPoste.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.dgVrstaPoste.OptionsView.ShowAutoFilterRow = true;
            this.dgVrstaPoste.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgVrstaPoste.OptionsView.ShowGroupPanel = false;
            this.dgVrstaPoste.OptionsView.ShowIndicator = false;
            this.dgVrstaPoste.PaintStyleName = "WindowsXP";
            this.dgVrstaPoste.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.dgVrstaPoste.SynchronizeClones = false;
            this.dgVrstaPoste.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colvp_ID
            // 
            this.colvp_ID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_ID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_ID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_ID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_ID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_ID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_ID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_ID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_ID.FieldName = "vp_ID";
            this.colvp_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_ID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_ID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_ID.Name = "colvp_ID";
            this.colvp_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_ID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_ID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colvp_naziv
            // 
            this.colvp_naziv.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_naziv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_naziv.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_naziv.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_naziv.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_naziv.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_naziv.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_naziv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_naziv.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_naziv.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_naziv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_naziv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_naziv.Caption = "Naziv";
            this.colvp_naziv.FieldName = "vp_naziv";
            this.colvp_naziv.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_naziv.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_naziv.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_naziv.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_naziv.Name = "colvp_naziv";
            this.colvp_naziv.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naziv.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naziv.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naziv.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_naziv.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_naziv.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naziv.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naziv.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_naziv.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_naziv.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_naziv.Visible = true;
            this.colvp_naziv.VisibleIndex = 0;
            this.colvp_naziv.Width = 307;
            // 
            // colvp_vrstaTroška
            // 
            this.colvp_vrstaTroška.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_vrstaTroška.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_vrstaTroška.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_vrstaTroška.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_vrstaTroška.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_vrstaTroška.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_vrstaTroška.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_vrstaTroška.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_vrstaTroška.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_vrstaTroška.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_vrstaTroška.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_vrstaTroška.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_vrstaTroška.Caption = "Trošak vrsta";
            this.colvp_vrstaTroška.FieldName = "vp_vrstaTroška";
            this.colvp_vrstaTroška.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_vrstaTroška.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_vrstaTroška.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_vrstaTroška.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_vrstaTroška.Name = "colvp_vrstaTroška";
            this.colvp_vrstaTroška.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vrstaTroška.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vrstaTroška.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vrstaTroška.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_vrstaTroška.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_vrstaTroška.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vrstaTroška.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vrstaTroška.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_vrstaTroška.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_vrstaTroška.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_vrstaTroška.Visible = true;
            this.colvp_vrstaTroška.VisibleIndex = 1;
            this.colvp_vrstaTroška.Width = 57;
            // 
            // colvp_predao_za_slanje
            // 
            this.colvp_predao_za_slanje.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predao_za_slanje.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predao_za_slanje.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predao_za_slanje.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predao_za_slanje.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predao_za_slanje.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predao_za_slanje.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predao_za_slanje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predao_za_slanje.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predao_za_slanje.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predao_za_slanje.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predao_za_slanje.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predao_za_slanje.Caption = "Predao za slanje";
            this.colvp_predao_za_slanje.FieldName = "vp_predao_za_slanje";
            this.colvp_predao_za_slanje.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_predao_za_slanje.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_predao_za_slanje.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_predao_za_slanje.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_predao_za_slanje.Name = "colvp_predao_za_slanje";
            this.colvp_predao_za_slanje.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predao_za_slanje.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predao_za_slanje.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predao_za_slanje.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_predao_za_slanje.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_predao_za_slanje.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predao_za_slanje.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predao_za_slanje.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_predao_za_slanje.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_predao_za_slanje.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_predao_za_slanje.Visible = true;
            this.colvp_predao_za_slanje.VisibleIndex = 2;
            this.colvp_predao_za_slanje.Width = 57;
            // 
            // colvp_poslovniPartner
            // 
            this.colvp_poslovniPartner.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_poslovniPartner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_poslovniPartner.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_poslovniPartner.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_poslovniPartner.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_poslovniPartner.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_poslovniPartner.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_poslovniPartner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_poslovniPartner.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_poslovniPartner.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_poslovniPartner.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_poslovniPartner.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_poslovniPartner.Caption = "Partner";
            this.colvp_poslovniPartner.FieldName = "vp_poslovniPartner";
            this.colvp_poslovniPartner.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_poslovniPartner.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_poslovniPartner.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_poslovniPartner.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_poslovniPartner.Name = "colvp_poslovniPartner";
            this.colvp_poslovniPartner.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_poslovniPartner.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_poslovniPartner.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_poslovniPartner.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_poslovniPartner.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_poslovniPartner.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_poslovniPartner.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_poslovniPartner.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_poslovniPartner.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_poslovniPartner.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_poslovniPartner.Visible = true;
            this.colvp_poslovniPartner.VisibleIndex = 3;
            this.colvp_poslovniPartner.Width = 57;
            // 
            // colvp_naslovljenaNa
            // 
            this.colvp_naslovljenaNa.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_naslovljenaNa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_naslovljenaNa.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_naslovljenaNa.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_naslovljenaNa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_naslovljenaNa.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_naslovljenaNa.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_naslovljenaNa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_naslovljenaNa.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_naslovljenaNa.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_naslovljenaNa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_naslovljenaNa.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_naslovljenaNa.Caption = "Naslovljeno na";
            this.colvp_naslovljenaNa.FieldName = "vp_naslovljenaNa";
            this.colvp_naslovljenaNa.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_naslovljenaNa.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_naslovljenaNa.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_naslovljenaNa.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_naslovljenaNa.Name = "colvp_naslovljenaNa";
            this.colvp_naslovljenaNa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naslovljenaNa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naslovljenaNa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naslovljenaNa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_naslovljenaNa.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_naslovljenaNa.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naslovljenaNa.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_naslovljenaNa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_naslovljenaNa.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_naslovljenaNa.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_naslovljenaNa.Visible = true;
            this.colvp_naslovljenaNa.VisibleIndex = 4;
            this.colvp_naslovljenaNa.Width = 85;
            // 
            // colvp_datumDokumenta
            // 
            this.colvp_datumDokumenta.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_datumDokumenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_datumDokumenta.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_datumDokumenta.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_datumDokumenta.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_datumDokumenta.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_datumDokumenta.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_datumDokumenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_datumDokumenta.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_datumDokumenta.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_datumDokumenta.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_datumDokumenta.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_datumDokumenta.Caption = "Datum";
            this.colvp_datumDokumenta.FieldName = "vp_datumDokumenta";
            this.colvp_datumDokumenta.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_datumDokumenta.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_datumDokumenta.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_datumDokumenta.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_datumDokumenta.Name = "colvp_datumDokumenta";
            this.colvp_datumDokumenta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_datumDokumenta.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_datumDokumenta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_datumDokumenta.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_datumDokumenta.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_datumDokumenta.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_datumDokumenta.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_datumDokumenta.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_datumDokumenta.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_datumDokumenta.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_datumDokumenta.Visible = true;
            this.colvp_datumDokumenta.VisibleIndex = 5;
            this.colvp_datumDokumenta.Width = 64;
            // 
            // colvp_brojDokumenta
            // 
            this.colvp_brojDokumenta.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_brojDokumenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_brojDokumenta.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_brojDokumenta.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_brojDokumenta.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_brojDokumenta.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_brojDokumenta.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_brojDokumenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_brojDokumenta.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_brojDokumenta.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_brojDokumenta.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_brojDokumenta.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_brojDokumenta.Caption = "Broj dok";
            this.colvp_brojDokumenta.FieldName = "vp_brojDokumenta";
            this.colvp_brojDokumenta.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_brojDokumenta.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_brojDokumenta.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_brojDokumenta.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_brojDokumenta.Name = "colvp_brojDokumenta";
            this.colvp_brojDokumenta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_brojDokumenta.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_brojDokumenta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_brojDokumenta.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_brojDokumenta.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_brojDokumenta.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_brojDokumenta.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_brojDokumenta.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_brojDokumenta.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_brojDokumenta.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_brojDokumenta.Visible = true;
            this.colvp_brojDokumenta.VisibleIndex = 6;
            this.colvp_brojDokumenta.Width = 48;
            // 
            // colvp_predanoNaPotpisDatum
            // 
            this.colvp_predanoNaPotpisDatum.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaPotpisDatum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaPotpisDatum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaPotpisDatum.Caption = "Datum potpis";
            this.colvp_predanoNaPotpisDatum.FieldName = "vp_predanoNaPotpisDatum";
            this.colvp_predanoNaPotpisDatum.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_predanoNaPotpisDatum.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_predanoNaPotpisDatum.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_predanoNaPotpisDatum.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_predanoNaPotpisDatum.Name = "colvp_predanoNaPotpisDatum";
            this.colvp_predanoNaPotpisDatum.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisDatum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisDatum.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisDatum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_predanoNaPotpisDatum.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_predanoNaPotpisDatum.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisDatum.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisDatum.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_predanoNaPotpisDatum.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_predanoNaPotpisDatum.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_predanoNaPotpisDatum.Visible = true;
            this.colvp_predanoNaPotpisDatum.VisibleIndex = 7;
            this.colvp_predanoNaPotpisDatum.Width = 49;
            // 
            // colvp_predanoNaPotpisOsoba
            // 
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaPotpisOsoba.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaPotpisOsoba.Caption = "Osoba potpis";
            this.colvp_predanoNaPotpisOsoba.FieldName = "vp_predanoNaPotpisOsoba";
            this.colvp_predanoNaPotpisOsoba.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_predanoNaPotpisOsoba.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_predanoNaPotpisOsoba.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_predanoNaPotpisOsoba.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_predanoNaPotpisOsoba.Name = "colvp_predanoNaPotpisOsoba";
            this.colvp_predanoNaPotpisOsoba.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisOsoba.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaPotpisOsoba.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_predanoNaPotpisOsoba.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_predanoNaPotpisOsoba.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_predanoNaPotpisOsoba.Visible = true;
            this.colvp_predanoNaPotpisOsoba.VisibleIndex = 8;
            this.colvp_predanoNaPotpisOsoba.Width = 53;
            // 
            // colvp_vracenoDatum
            // 
            this.colvp_vracenoDatum.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_vracenoDatum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_vracenoDatum.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_vracenoDatum.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_vracenoDatum.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_vracenoDatum.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_vracenoDatum.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_vracenoDatum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_vracenoDatum.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_vracenoDatum.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_vracenoDatum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_vracenoDatum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_vracenoDatum.Caption = "Vraceno datum";
            this.colvp_vracenoDatum.FieldName = "vp_vracenoDatum";
            this.colvp_vracenoDatum.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_vracenoDatum.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_vracenoDatum.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_vracenoDatum.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_vracenoDatum.Name = "colvp_vracenoDatum";
            this.colvp_vracenoDatum.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vracenoDatum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vracenoDatum.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vracenoDatum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_vracenoDatum.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_vracenoDatum.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vracenoDatum.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_vracenoDatum.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_vracenoDatum.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_vracenoDatum.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_vracenoDatum.Visible = true;
            this.colvp_vracenoDatum.VisibleIndex = 9;
            this.colvp_vracenoDatum.Width = 59;
            // 
            // colvp_predanoNaKnjizenje
            // 
            this.colvp_predanoNaKnjizenje.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaKnjizenje.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaKnjizenje.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaKnjizenje.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaKnjizenje.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaKnjizenje.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_predanoNaKnjizenje.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_predanoNaKnjizenje.Caption = "Knjizenje datum";
            this.colvp_predanoNaKnjizenje.FieldName = "vp_predanoNaKnjizenje";
            this.colvp_predanoNaKnjizenje.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_predanoNaKnjizenje.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_predanoNaKnjizenje.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_predanoNaKnjizenje.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_predanoNaKnjizenje.Name = "colvp_predanoNaKnjizenje";
            this.colvp_predanoNaKnjizenje.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaKnjizenje.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaKnjizenje.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaKnjizenje.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_predanoNaKnjizenje.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_predanoNaKnjizenje.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaKnjizenje.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_predanoNaKnjizenje.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_predanoNaKnjizenje.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_predanoNaKnjizenje.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_predanoNaKnjizenje.Visible = true;
            this.colvp_predanoNaKnjizenje.VisibleIndex = 10;
            this.colvp_predanoNaKnjizenje.Width = 66;
            // 
            // colvp_napomena
            // 
            this.colvp_napomena.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_napomena.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_napomena.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_napomena.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_napomena.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_napomena.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_napomena.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_napomena.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_napomena.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_napomena.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_napomena.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_napomena.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_napomena.Caption = "Napomena";
            this.colvp_napomena.FieldName = "vp_napomena";
            this.colvp_napomena.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_napomena.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_napomena.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_napomena.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_napomena.Name = "colvp_napomena";
            this.colvp_napomena.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_napomena.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_napomena.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_napomena.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_napomena.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_napomena.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_napomena.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_napomena.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_napomena.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_napomena.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_napomena.Visible = true;
            this.colvp_napomena.VisibleIndex = 11;
            this.colvp_napomena.Width = 78;
            // 
            // colvp_mjestoTroska
            // 
            this.colvp_mjestoTroska.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_mjestoTroska.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_mjestoTroska.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_mjestoTroska.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_mjestoTroska.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_mjestoTroska.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_mjestoTroska.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_mjestoTroska.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_mjestoTroska.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_mjestoTroska.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_mjestoTroska.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_mjestoTroska.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_mjestoTroska.Caption = "Mjesto troška";
            this.colvp_mjestoTroska.FieldName = "vp_mjestoTroska";
            this.colvp_mjestoTroska.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_mjestoTroska.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_mjestoTroska.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_mjestoTroska.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_mjestoTroska.Name = "colvp_mjestoTroska";
            this.colvp_mjestoTroska.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjestoTroska.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjestoTroska.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjestoTroska.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_mjestoTroska.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_mjestoTroska.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjestoTroska.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjestoTroska.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_mjestoTroska.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_mjestoTroska.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_mjestoTroska.Visible = true;
            this.colvp_mjestoTroska.VisibleIndex = 12;
            this.colvp_mjestoTroska.Width = 52;
            // 
            // colvp_mjesecGodina
            // 
            this.colvp_mjesecGodina.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_mjesecGodina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_mjesecGodina.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_mjesecGodina.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_mjesecGodina.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_mjesecGodina.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_mjesecGodina.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvp_mjesecGodina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvp_mjesecGodina.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvp_mjesecGodina.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvp_mjesecGodina.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvp_mjesecGodina.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvp_mjesecGodina.Caption = "Mjesec god";
            this.colvp_mjesecGodina.FieldName = "vp_mjesecGodina";
            this.colvp_mjesecGodina.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvp_mjesecGodina.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvp_mjesecGodina.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvp_mjesecGodina.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvp_mjesecGodina.Name = "colvp_mjesecGodina";
            this.colvp_mjesecGodina.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjesecGodina.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjesecGodina.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjesecGodina.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvp_mjesecGodina.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvp_mjesecGodina.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjesecGodina.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvp_mjesecGodina.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvp_mjesecGodina.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvp_mjesecGodina.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvp_mjesecGodina.Visible = true;
            this.colvp_mjesecGodina.VisibleIndex = 13;
            this.colvp_mjesecGodina.Width = 53;
            // 
            // vrstaposteTableAdapter
            // 
            this.vrstaposteTableAdapter.ClearBeforeFill = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(1090, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(1, 1);
            this.btnAzuriraj.TabIndex = 29;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // frmVrstaPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 410);
            this.Controls.Add(this.dgPosta);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmVrstaPoste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrsta pošte";
            this.Load += new System.EventHandler(this.frmVrstaPoste_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVrstaPoste_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaposteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVrstaPoste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgPosta;
        private DevExpress.XtraGrid.Views.Grid.GridView dgVrstaPoste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private vrstaPoste vrstaPoste;
        private System.Windows.Forms.BindingSource vrstaposteBindingSource;
        private vrstaPosteTableAdapters.vrstaposteTableAdapter vrstaposteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_vrstaTroška;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_predao_za_slanje;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_poslovniPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_naslovljenaNa;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_datumDokumenta;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_brojDokumenta;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_predanoNaPotpisDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_predanoNaPotpisOsoba;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_vracenoDatum;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_predanoNaKnjizenje;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_napomena;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_mjestoTroska;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_mjesecGodina;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}