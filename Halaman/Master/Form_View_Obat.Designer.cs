namespace D_Clinic.Halaman
{
    partial class Form_View_Obat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblObat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaJualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.obatTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.ObatTableAdapter();
            this.txCariData = new Guna.UI2.WinForms.Guna2TextBox();
            this.radiusDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rbNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.rbAktif = new Guna.UI2.WinForms.Guna2Button();
            this.rbSemua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.tblObat);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 40;
            // 
            // tblObat
            // 
            this.tblObat.AllowUserToAddRows = false;
            this.tblObat.AllowUserToDeleteRows = false;
            this.tblObat.AllowUserToResizeColumns = false;
            this.tblObat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblObat.AutoGenerateColumns = false;
            this.tblObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblObat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblObat.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblObat.ColumnHeadersHeight = 40;
            this.tblObat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.idObatDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.hargaJualDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.stokDataGridViewTextBoxColumn});
            this.tblObat.DataSource = this.obatBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblObat.DefaultCellStyle = dataGridViewCellStyle5;
            this.tblObat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.Location = new System.Drawing.Point(3, 4);
            this.tblObat.MultiSelect = false;
            this.tblObat.Name = "tblObat";
            this.tblObat.ReadOnly = true;
            this.tblObat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblObat.RowHeadersVisible = false;
            this.tblObat.RowHeadersWidth = 4;
            this.tblObat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblObat.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Porsche Next TT", 13F);
            this.tblObat.RowTemplate.Height = 30;
            this.tblObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblObat.Size = new System.Drawing.Size(1578, 673);
            this.tblObat.TabIndex = 61;
            this.tblObat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblObat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblObat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblObat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblObat.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblObat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblObat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblObat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblObat.ThemeStyle.HeaderStyle.Height = 40;
            this.tblObat.ThemeStyle.ReadOnly = true;
            this.tblObat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblObat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblObat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblObat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.RowsStyle.Height = 30;
            this.tblObat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblObat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblObat_RowPostPaint);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // idObatDataGridViewTextBoxColumn
            // 
            this.idObatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idObatDataGridViewTextBoxColumn.DataPropertyName = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.HeaderText = "ID Obat";
            this.idObatDataGridViewTextBoxColumn.Name = "idObatDataGridViewTextBoxColumn";
            this.idObatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama Obat";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "Merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "Merk Obat";
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaJualDataGridViewTextBoxColumn
            // 
            this.hargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga_Jual";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.hargaJualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual";
            this.hargaJualDataGridViewTextBoxColumn.Name = "hargaJualDataGridViewTextBoxColumn";
            this.hargaJualDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargaJualDataGridViewTextBoxColumn.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tgl_Kadaluarsa";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tanggal Kadaluarsa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // txCariData
            // 
            this.txCariData.Animated = true;
            this.txCariData.AutoRoundedCorners = true;
            this.txCariData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariData.BorderColor = System.Drawing.Color.White;
            this.txCariData.BorderRadius = 20;
            this.txCariData.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariData.BorderThickness = 2;
            this.txCariData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariData.DefaultText = "";
            this.txCariData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariData.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariData.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariData.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariData.Location = new System.Drawing.Point(1373, 133);
            this.txCariData.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txCariData.MaxLength = 30;
            this.txCariData.Name = "txCariData";
            this.txCariData.PasswordChar = '\0';
            this.txCariData.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariData.PlaceholderText = "Search";
            this.txCariData.SelectedText = "";
            this.txCariData.Size = new System.Drawing.Size(279, 43);
            this.txCariData.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariData.TabIndex = 41;
            this.txCariData.TabStop = false;
            this.txCariData.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariData.TextChanged += new System.EventHandler(this.txCariData_TextChanged);
            // 
            // radiusDGV
            // 
            this.radiusDGV.BorderRadius = 30;
            this.radiusDGV.TargetControl = this.tblObat;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1715, 131);
            this.label1.TabIndex = 42;
            this.label1.Text = "Obat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbNonAktif
            // 
            this.rbNonAktif.Animated = true;
            this.rbNonAktif.AutoRoundedCorners = true;
            this.rbNonAktif.BackColor = System.Drawing.Color.Transparent;
            this.rbNonAktif.BorderColor = System.Drawing.Color.White;
            this.rbNonAktif.BorderRadius = 17;
            this.rbNonAktif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rbNonAktif.BorderThickness = 2;
            this.rbNonAktif.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbNonAktif.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbNonAktif.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbNonAktif.DisabledState.BorderColor = System.Drawing.Color.White;
            this.rbNonAktif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbNonAktif.DisabledState.ForeColor = System.Drawing.Color.White;
            this.rbNonAktif.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.rbNonAktif.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbNonAktif.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.rbNonAktif.ForeColor = System.Drawing.Color.White;
            this.rbNonAktif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbNonAktif.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbNonAktif.Location = new System.Drawing.Point(385, 140);
            this.rbNonAktif.Margin = new System.Windows.Forms.Padding(2);
            this.rbNonAktif.Name = "rbNonAktif";
            this.rbNonAktif.PressedColor = System.Drawing.Color.NavajoWhite;
            this.rbNonAktif.PressedDepth = 50;
            this.rbNonAktif.Size = new System.Drawing.Size(153, 37);
            this.rbNonAktif.TabIndex = 67;
            this.rbNonAktif.Text = "Non-Aktif";
            this.rbNonAktif.UseTransparentBackground = true;
            this.rbNonAktif.Click += new System.EventHandler(this.CariData);
            // 
            // rbAktif
            // 
            this.rbAktif.Animated = true;
            this.rbAktif.AutoRoundedCorners = true;
            this.rbAktif.BackColor = System.Drawing.Color.Transparent;
            this.rbAktif.BorderColor = System.Drawing.Color.White;
            this.rbAktif.BorderRadius = 17;
            this.rbAktif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rbAktif.BorderThickness = 2;
            this.rbAktif.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbAktif.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbAktif.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbAktif.DisabledState.BorderColor = System.Drawing.Color.White;
            this.rbAktif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbAktif.DisabledState.ForeColor = System.Drawing.Color.White;
            this.rbAktif.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.rbAktif.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbAktif.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.rbAktif.ForeColor = System.Drawing.Color.White;
            this.rbAktif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbAktif.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbAktif.Location = new System.Drawing.Point(228, 140);
            this.rbAktif.Margin = new System.Windows.Forms.Padding(2);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.PressedColor = System.Drawing.Color.NavajoWhite;
            this.rbAktif.PressedDepth = 50;
            this.rbAktif.Size = new System.Drawing.Size(153, 37);
            this.rbAktif.TabIndex = 68;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseTransparentBackground = true;
            this.rbAktif.Click += new System.EventHandler(this.CariData);
            // 
            // rbSemua
            // 
            this.rbSemua.Animated = true;
            this.rbSemua.AutoRoundedCorners = true;
            this.rbSemua.BackColor = System.Drawing.Color.Transparent;
            this.rbSemua.BorderColor = System.Drawing.Color.White;
            this.rbSemua.BorderRadius = 17;
            this.rbSemua.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rbSemua.BorderThickness = 2;
            this.rbSemua.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbSemua.Checked = true;
            this.rbSemua.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbSemua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbSemua.DisabledState.BorderColor = System.Drawing.Color.White;
            this.rbSemua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.rbSemua.DisabledState.ForeColor = System.Drawing.Color.White;
            this.rbSemua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.rbSemua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbSemua.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.rbSemua.ForeColor = System.Drawing.Color.White;
            this.rbSemua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbSemua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.rbSemua.Location = new System.Drawing.Point(71, 140);
            this.rbSemua.Margin = new System.Windows.Forms.Padding(2);
            this.rbSemua.Name = "rbSemua";
            this.rbSemua.PressedColor = System.Drawing.Color.NavajoWhite;
            this.rbSemua.PressedDepth = 50;
            this.rbSemua.Size = new System.Drawing.Size(153, 37);
            this.rbSemua.TabIndex = 69;
            this.rbSemua.Text = "Semua Data";
            this.rbSemua.UseTransparentBackground = true;
            this.rbSemua.Click += new System.EventHandler(this.CariData);
            // 
            // Form_View_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.rbNonAktif);
            this.Controls.Add(this.rbAktif);
            this.Controls.Add(this.rbSemua);
            this.Controls.Add(this.txCariData);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_View_Obat";
            this.Text = "Form_View_Obat";
            this.Load += new System.EventHandler(this.Form_View_Obat_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private DClinicDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluarsaDataGridViewTextBoxColumn;
        public Guna.UI2.WinForms.Guna2TextBox txCariData;
        private Guna.UI2.WinForms.Guna2DataGridView tblObat;
        private Guna.UI2.WinForms.Guna2Elipse radiusDGV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button rbNonAktif;
        private Guna.UI2.WinForms.Guna2Button rbAktif;
        private Guna.UI2.WinForms.Guna2Button rbSemua;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}