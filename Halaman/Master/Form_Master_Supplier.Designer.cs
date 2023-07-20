namespace D_Clinic.Halaman
{
    partial class Form_Master_Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.radiusDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tblSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.txCariSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.txNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAktif = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.supplierTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.SupplierTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
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
            this.label1.TabIndex = 44;
            this.label1.Text = "Supplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusDGV
            // 
            this.radiusDGV.BorderRadius = 30;
            this.radiusDGV.TargetControl = this.tblSupplier;
            // 
            // tblSupplier
            // 
            this.tblSupplier.AllowUserToAddRows = false;
            this.tblSupplier.AllowUserToDeleteRows = false;
            this.tblSupplier.AllowUserToResizeColumns = false;
            this.tblSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblSupplier.AutoGenerateColumns = false;
            this.tblSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblSupplier.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblSupplier.ColumnHeadersHeight = 40;
            this.tblSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id_supplier,
            this.nama_supplier,
            this.telp_supplier,
            this.status_supplier});
            this.tblSupplier.DataSource = this.supplierBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblSupplier.Location = new System.Drawing.Point(748, 21);
            this.tblSupplier.MultiSelect = false;
            this.tblSupplier.Name = "tblSupplier";
            this.tblSupplier.ReadOnly = true;
            this.tblSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblSupplier.RowHeadersVisible = false;
            this.tblSupplier.RowHeadersWidth = 4;
            this.tblSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblSupplier.RowTemplate.Height = 30;
            this.tblSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblSupplier.Size = new System.Drawing.Size(657, 571);
            this.tblSupplier.TabIndex = 62;
            this.tblSupplier.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblSupplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblSupplier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblSupplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblSupplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblSupplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblSupplier.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblSupplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblSupplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblSupplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblSupplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblSupplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblSupplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblSupplier.ThemeStyle.HeaderStyle.Height = 40;
            this.tblSupplier.ThemeStyle.ReadOnly = true;
            this.tblSupplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblSupplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblSupplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblSupplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblSupplier.ThemeStyle.RowsStyle.Height = 30;
            this.tblSupplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblSupplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSupplier_CellContentClick);
            this.tblSupplier.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblSupplier_RowPostPaint);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // id_supplier
            // 
            this.id_supplier.DataPropertyName = "Id_Supplier";
            this.id_supplier.HeaderText = "ID Supplier";
            this.id_supplier.Name = "id_supplier";
            this.id_supplier.ReadOnly = true;
            // 
            // nama_supplier
            // 
            this.nama_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_supplier.DataPropertyName = "Nama_Supplier";
            this.nama_supplier.HeaderText = "Nama Supplier";
            this.nama_supplier.Name = "nama_supplier";
            this.nama_supplier.ReadOnly = true;
            // 
            // telp_supplier
            // 
            this.telp_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telp_supplier.DataPropertyName = "Telp";
            this.telp_supplier.HeaderText = "No Telp";
            this.telp_supplier.Name = "telp_supplier";
            this.telp_supplier.ReadOnly = true;
            this.telp_supplier.Width = 150;
            // 
            // status_supplier
            // 
            this.status_supplier.DataPropertyName = "Status";
            this.status_supplier.HeaderText = "Status";
            this.status_supplier.Name = "status_supplier";
            this.status_supplier.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTambah
            // 
            this.btnTambah.Animated = true;
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.BorderRadius = 10;
            this.btnTambah.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTambah.BorderThickness = 2;
            this.btnTambah.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.FillColor = System.Drawing.Color.Transparent;
            this.btnTambah.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTambah.Location = new System.Drawing.Point(76, 46);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTambah.PressedDepth = 50;
            this.btnTambah.Size = new System.Drawing.Size(187, 37);
            this.btnTambah.TabIndex = 54;
            this.btnTambah.Text = "Tambah Supplier";
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txCariSupplier
            // 
            this.txCariSupplier.Animated = true;
            this.txCariSupplier.AutoRoundedCorners = true;
            this.txCariSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariSupplier.BorderColor = System.Drawing.Color.White;
            this.txCariSupplier.BorderRadius = 17;
            this.txCariSupplier.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariSupplier.BorderThickness = 2;
            this.txCariSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariSupplier.DefaultText = "";
            this.txCariSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariSupplier.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariSupplier.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariSupplier.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariSupplier.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariSupplier.Location = new System.Drawing.Point(1128, 46);
            this.txCariSupplier.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariSupplier.MaxLength = 30;
            this.txCariSupplier.Name = "txCariSupplier";
            this.txCariSupplier.PasswordChar = '\0';
            this.txCariSupplier.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariSupplier.PlaceholderText = "Search";
            this.txCariSupplier.SelectedText = "";
            this.txCariSupplier.Size = new System.Drawing.Size(232, 37);
            this.txCariSupplier.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariSupplier.TabIndex = 47;
            this.txCariSupplier.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariSupplier.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel1.Location = new System.Drawing.Point(716, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 580);
            this.panel1.TabIndex = 58;
            // 
            // btnBatal
            // 
            this.btnBatal.Animated = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderColor = System.Drawing.Color.Moccasin;
            this.btnBatal.BorderRadius = 10;
            this.btnBatal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBatal.BorderThickness = 2;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.Transparent;
            this.btnBatal.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.Moccasin;
            this.btnBatal.HoverState.FillColor = System.Drawing.Color.Moccasin;
            this.btnBatal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBatal.Location = new System.Drawing.Point(138, 555);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBatal.PressedDepth = 50;
            this.btnBatal.Size = new System.Drawing.Size(412, 37);
            this.btnBatal.TabIndex = 55;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Animated = true;
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.BorderRadius = 10;
            this.btnSimpan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSimpan.BorderThickness = 2;
            this.btnSimpan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.Enabled = false;
            this.btnSimpan.FillColor = System.Drawing.Color.Transparent;
            this.btnSimpan.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnSimpan.Location = new System.Drawing.Point(420, 505);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnSimpan.PressedDepth = 50;
            this.btnSimpan.Size = new System.Drawing.Size(130, 37);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseTransparentBackground = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnUpdate.Location = new System.Drawing.Point(279, 505);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnUpdate.PressedDepth = 50;
            this.btnUpdate.Size = new System.Drawing.Size(130, 37);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNonAktif
            // 
            this.btnNonAktif.Animated = true;
            this.btnNonAktif.BackColor = System.Drawing.Color.Transparent;
            this.btnNonAktif.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnNonAktif.BorderRadius = 10;
            this.btnNonAktif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnNonAktif.BorderThickness = 2;
            this.btnNonAktif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnNonAktif.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnNonAktif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnNonAktif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnNonAktif.FillColor = System.Drawing.Color.Transparent;
            this.btnNonAktif.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnNonAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnNonAktif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnNonAktif.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnNonAktif.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnNonAktif.Location = new System.Drawing.Point(138, 505);
            this.btnNonAktif.Margin = new System.Windows.Forms.Padding(2);
            this.btnNonAktif.Name = "btnNonAktif";
            this.btnNonAktif.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnNonAktif.PressedDepth = 50;
            this.btnNonAktif.Size = new System.Drawing.Size(130, 37);
            this.btnNonAktif.TabIndex = 26;
            this.btnNonAktif.Text = "Non-Aktif";
            this.btnNonAktif.UseTransparentBackground = true;
            this.btnNonAktif.Visible = false;
            this.btnNonAktif.Click += new System.EventHandler(this.btnNonAktif_Click);
            // 
            // txNama
            // 
            this.txNama.Animated = true;
            this.txNama.AutoRoundedCorners = true;
            this.txNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.BorderColor = System.Drawing.Color.White;
            this.txNama.BorderRadius = 17;
            this.txNama.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txNama.BorderThickness = 2;
            this.txNama.Cursor = System.Windows.Forms.Cursors.Default;
            this.txNama.DefaultText = "";
            this.txNama.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.Enabled = false;
            this.txNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txNama.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNama.IconLeft = global::D_Clinic.Properties.Resources.white_name;
            this.txNama.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txNama.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txNama.Location = new System.Drawing.Point(100, 124);
            this.txNama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txNama.MaxLength = 30;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.PlaceholderText = "Nama Supplier";
            this.txNama.SelectedText = "";
            this.txNama.Size = new System.Drawing.Size(478, 36);
            this.txNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txNama.TabIndex = 20;
            this.txNama.TextOffset = new System.Drawing.Point(5, 0);
            this.txNama.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txTelp
            // 
            this.txTelp.Animated = true;
            this.txTelp.AutoRoundedCorners = true;
            this.txTelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.BorderColor = System.Drawing.Color.White;
            this.txTelp.BorderRadius = 17;
            this.txTelp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txTelp.BorderThickness = 2;
            this.txTelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.txTelp.DefaultText = "";
            this.txTelp.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txTelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txTelp.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTelp.Enabled = false;
            this.txTelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTelp.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txTelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTelp.IconLeft = global::D_Clinic.Properties.Resources.white_telephone;
            this.txTelp.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txTelp.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txTelp.Location = new System.Drawing.Point(100, 177);
            this.txTelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTelp.MaxLength = 13;
            this.txTelp.Name = "txTelp";
            this.txTelp.PasswordChar = '\0';
            this.txTelp.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTelp.PlaceholderText = "Telepon";
            this.txTelp.SelectedText = "";
            this.txTelp.Size = new System.Drawing.Size(478, 36);
            this.txTelp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTelp.TabIndex = 21;
            this.txTelp.TextOffset = new System.Drawing.Point(5, 0);
            this.txTelp.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            this.txTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txID
            // 
            this.txID.Animated = true;
            this.txID.AutoRoundedCorners = true;
            this.txID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.BorderColor = System.Drawing.Color.White;
            this.txID.BorderRadius = 17;
            this.txID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txID.BorderThickness = 2;
            this.txID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txID.DefaultText = "";
            this.txID.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.Enabled = false;
            this.txID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txID.IconLeft = global::D_Clinic.Properties.Resources.white_kode;
            this.txID.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txID.Location = new System.Drawing.Point(100, 71);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Supplier";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 36);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 63;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // btnCari
            // 
            this.btnCari.Animated = true;
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.BorderRadius = 10;
            this.btnCari.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCari.BorderThickness = 2;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.Transparent;
            this.btnCari.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCari.Location = new System.Drawing.Point(1365, 46);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCari.PressedDepth = 50;
            this.btnCari.Size = new System.Drawing.Size(144, 37);
            this.btnCari.TabIndex = 53;
            this.btnCari.Text = "Cari";
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.btnAktif);
            this.guna2GroupBox2.Controls.Add(this.txID);
            this.guna2GroupBox2.Controls.Add(this.tblSupplier);
            this.guna2GroupBox2.Controls.Add(this.panel1);
            this.guna2GroupBox2.Controls.Add(this.btnBatal);
            this.guna2GroupBox2.Controls.Add(this.btnSimpan);
            this.guna2GroupBox2.Controls.Add(this.btnUpdate);
            this.guna2GroupBox2.Controls.Add(this.btnNonAktif);
            this.guna2GroupBox2.Controls.Add(this.txNama);
            this.guna2GroupBox2.Controls.Add(this.txTelp);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(76, 87);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1433, 613);
            this.guna2GroupBox2.TabIndex = 57;
            // 
            // btnAktif
            // 
            this.btnAktif.Animated = true;
            this.btnAktif.BackColor = System.Drawing.Color.Transparent;
            this.btnAktif.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.BorderRadius = 10;
            this.btnAktif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAktif.BorderThickness = 2;
            this.btnAktif.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnAktif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.FillColor = System.Drawing.Color.Transparent;
            this.btnAktif.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnAktif.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnAktif.Location = new System.Drawing.Point(138, 505);
            this.btnAktif.Margin = new System.Windows.Forms.Padding(2);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnAktif.PressedDepth = 50;
            this.btnAktif.Size = new System.Drawing.Size(130, 37);
            this.btnAktif.TabIndex = 66;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseTransparentBackground = true;
            this.btnAktif.Visible = false;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.btnCari);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.Controls.Add(this.btnTambah);
            this.guna2GroupBox1.Controls.Add(this.txCariSupplier);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 140);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 746);
            this.guna2GroupBox1.TabIndex = 43;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Detail Supplier";
            // 
            // Form_Master_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Master_Supplier";
            this.Text = "Form_Master_Supplier";
            this.Load += new System.EventHandler(this.Form_Master_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2DataGridView tblSupplier;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnNonAktif;
        private Guna.UI2.WinForms.Guna2TextBox txNama;
        private Guna.UI2.WinForms.Guna2TextBox txTelp;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2TextBox txCariSupplier;
        private Guna.UI2.WinForms.Guna2Elipse radiusDGV;
        private DClinicDataSet dClinicDataSet;
        private Guna.UI2.WinForms.Guna2Button btnAktif;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DClinicDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_supplier;
        private System.Windows.Forms.Label label2;
    }
}