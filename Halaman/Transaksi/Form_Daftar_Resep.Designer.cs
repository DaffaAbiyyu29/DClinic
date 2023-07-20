namespace D_Clinic.Halaman.Transaksi
{
    partial class Form_Daftar_Resep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txKeterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tblDaftarResep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txDokter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnTerima = new Guna.UI2.WinForms.Guna2Button();
            this.tblResepDiterima = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.radiusTabelDaftarResep = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.radiusTabelResepDiterima = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.viewTrsPemberianResepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TrsPemberianResepTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsPemberianResepTableAdapter();
            this.viewTrsPemberianResepDiterimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TrsPemberianResepDiterimaTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsPemberianResepDiterimaTableAdapter();
            this.txCariResep = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.no_daftar2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrsResepDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrsPendaftaranDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrsPendaftaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokter_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ket_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDaftarResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResepDiterima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepDiterimaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            this.radiusForm.TargetControl = this;
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
            this.label1.TabIndex = 62;
            this.label1.Text = "Daftar Obat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.txKeterangan);
            this.guna2GroupBox1.Controls.Add(this.tblDaftarResep);
            this.guna2GroupBox1.Controls.Add(this.txDokter);
            this.guna2GroupBox1.Controls.Add(this.txTanggal);
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnTerima);
            this.guna2GroupBox1.Controls.Add(this.tblResepDiterima);
            this.guna2GroupBox1.Controls.Add(this.btnKembali);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.txID);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 213);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 63;
            // 
            // txKeterangan
            // 
            this.txKeterangan.Animated = true;
            this.txKeterangan.AutoRoundedCorners = true;
            this.txKeterangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.BorderColor = System.Drawing.Color.White;
            this.txKeterangan.BorderRadius = 17;
            this.txKeterangan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txKeterangan.BorderThickness = 2;
            this.txKeterangan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txKeterangan.DefaultText = "";
            this.txKeterangan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txKeterangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeterangan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txKeterangan.IconLeft = global::D_Clinic.Properties.Resources.white_keluhan;
            this.txKeterangan.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txKeterangan.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txKeterangan.Location = new System.Drawing.Point(158, 230);
            this.txKeterangan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txKeterangan.MaxLength = 1000;
            this.txKeterangan.Name = "txKeterangan";
            this.txKeterangan.PasswordChar = '\0';
            this.txKeterangan.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeterangan.PlaceholderText = "Keterangan";
            this.txKeterangan.SelectedText = "";
            this.txKeterangan.Size = new System.Drawing.Size(478, 37);
            this.txKeterangan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txKeterangan.TabIndex = 90;
            this.txKeterangan.TextOffset = new System.Drawing.Point(5, 0);
            this.txKeterangan.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // tblDaftarResep
            // 
            this.tblDaftarResep.AllowUserToAddRows = false;
            this.tblDaftarResep.AllowUserToDeleteRows = false;
            this.tblDaftarResep.AllowUserToResizeColumns = false;
            this.tblDaftarResep.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tblDaftarResep.AutoGenerateColumns = false;
            this.tblDaftarResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblDaftarResep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblDaftarResep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblDaftarResep.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDaftarResep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tblDaftarResep.ColumnHeadersHeight = 40;
            this.tblDaftarResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_daftar,
            this.id_resep,
            this.idTrsPendaftaranDataGridViewTextBoxColumn,
            this.dokter_resep,
            this.tanggal_resep,
            this.waktuDataGridViewTextBoxColumn,
            this.ket_resep,
            this.statusDataGridViewTextBoxColumn});
            this.tblDaftarResep.DataSource = this.viewTrsPemberianResepBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDaftarResep.DefaultCellStyle = dataGridViewCellStyle12;
            this.tblDaftarResep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblDaftarResep.Location = new System.Drawing.Point(827, 23);
            this.tblDaftarResep.MultiSelect = false;
            this.tblDaftarResep.Name = "tblDaftarResep";
            this.tblDaftarResep.ReadOnly = true;
            this.tblDaftarResep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblDaftarResep.RowHeadersVisible = false;
            this.tblDaftarResep.RowHeadersWidth = 4;
            this.tblDaftarResep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblDaftarResep.RowTemplate.Height = 30;
            this.tblDaftarResep.Size = new System.Drawing.Size(721, 298);
            this.tblDaftarResep.TabIndex = 88;
            this.tblDaftarResep.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblDaftarResep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblDaftarResep.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblDaftarResep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblDaftarResep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblDaftarResep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblDaftarResep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblDaftarResep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblDaftarResep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblDaftarResep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblDaftarResep.ThemeStyle.HeaderStyle.Height = 40;
            this.tblDaftarResep.ThemeStyle.ReadOnly = true;
            this.tblDaftarResep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblDaftarResep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblDaftarResep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblDaftarResep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.ThemeStyle.RowsStyle.Height = 30;
            this.tblDaftarResep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblDaftarResep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblDaftarResep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDaftarResep_CellContentClick);
            this.tblDaftarResep.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblDaftarResep_RowPostPaint);
            // 
            // txDokter
            // 
            this.txDokter.AcceptsReturn = true;
            this.txDokter.AcceptsTab = true;
            this.txDokter.Animated = true;
            this.txDokter.AutoRoundedCorners = true;
            this.txDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDokter.BorderColor = System.Drawing.Color.White;
            this.txDokter.BorderRadius = 17;
            this.txDokter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txDokter.BorderThickness = 2;
            this.txDokter.Cursor = System.Windows.Forms.Cursors.Default;
            this.txDokter.DefaultText = "";
            this.txDokter.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txDokter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDokter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDokter.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDokter.Enabled = false;
            this.txDokter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDokter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDokter.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDokter.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txDokter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDokter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txDokter.IconLeft = global::D_Clinic.Properties.Resources.white_dokter;
            this.txDokter.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txDokter.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txDokter.Location = new System.Drawing.Point(158, 124);
            this.txDokter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txDokter.MaxLength = 30;
            this.txDokter.Name = "txDokter";
            this.txDokter.PasswordChar = '\0';
            this.txDokter.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDokter.PlaceholderText = "Dokter";
            this.txDokter.SelectedText = "";
            this.txDokter.Size = new System.Drawing.Size(478, 37);
            this.txDokter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txDokter.TabIndex = 85;
            this.txDokter.Tag = "";
            this.txDokter.TextOffset = new System.Drawing.Point(5, 0);
            this.txDokter.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txTanggal
            // 
            this.txTanggal.Animated = true;
            this.txTanggal.AutoRoundedCorners = true;
            this.txTanggal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTanggal.BorderColor = System.Drawing.Color.White;
            this.txTanggal.BorderRadius = 17;
            this.txTanggal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txTanggal.BorderThickness = 2;
            this.txTanggal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txTanggal.DefaultText = "";
            this.txTanggal.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txTanggal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTanggal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTanggal.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTanggal.Enabled = false;
            this.txTanggal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTanggal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTanggal.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTanggal.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTanggal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTanggal.IconLeft = global::D_Clinic.Properties.Resources.white_cal;
            this.txTanggal.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txTanggal.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txTanggal.Location = new System.Drawing.Point(158, 177);
            this.txTanggal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTanggal.MaxLength = 30;
            this.txTanggal.Name = "txTanggal";
            this.txTanggal.PasswordChar = '\0';
            this.txTanggal.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTanggal.PlaceholderText = "Tanggal";
            this.txTanggal.SelectedText = "";
            this.txTanggal.Size = new System.Drawing.Size(478, 37);
            this.txTanggal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTanggal.TabIndex = 84;
            this.txTanggal.TextOffset = new System.Drawing.Point(5, 0);
            this.txTanggal.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel2.Location = new System.Drawing.Point(827, 340);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 1);
            this.panel2.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Detail Daftar Resep";
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
            this.btnBatal.Location = new System.Drawing.Point(192, 555);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBatal.PressedDepth = 50;
            this.btnBatal.Size = new System.Drawing.Size(412, 37);
            this.btnBatal.TabIndex = 79;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTerima
            // 
            this.btnTerima.Animated = true;
            this.btnTerima.BackColor = System.Drawing.Color.Transparent;
            this.btnTerima.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.BorderRadius = 10;
            this.btnTerima.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTerima.BorderThickness = 2;
            this.btnTerima.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnTerima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.Enabled = false;
            this.btnTerima.FillColor = System.Drawing.Color.Transparent;
            this.btnTerima.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnTerima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTerima.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnTerima.Location = new System.Drawing.Point(192, 505);
            this.btnTerima.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerima.Name = "btnTerima";
            this.btnTerima.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTerima.PressedDepth = 50;
            this.btnTerima.Size = new System.Drawing.Size(412, 37);
            this.btnTerima.TabIndex = 78;
            this.btnTerima.Text = "Terima";
            this.btnTerima.UseTransparentBackground = true;
            // 
            // tblResepDiterima
            // 
            this.tblResepDiterima.AllowUserToAddRows = false;
            this.tblResepDiterima.AllowUserToDeleteRows = false;
            this.tblResepDiterima.AllowUserToResizeColumns = false;
            this.tblResepDiterima.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResepDiterima.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tblResepDiterima.AutoGenerateColumns = false;
            this.tblResepDiterima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblResepDiterima.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblResepDiterima.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblResepDiterima.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblResepDiterima.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tblResepDiterima.ColumnHeadersHeight = 40;
            this.tblResepDiterima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_daftar2,
            this.idTrsResepDataGridViewTextBoxColumn1,
            this.idTrsPendaftaranDataGridViewTextBoxColumn1,
            this.namaDokterDataGridViewTextBoxColumn1,
            this.tanggalDataGridViewTextBoxColumn1,
            this.waktuDataGridViewTextBoxColumn1,
            this.keteranganDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.tblResepDiterima.DataSource = this.viewTrsPemberianResepDiterimaBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblResepDiterima.DefaultCellStyle = dataGridViewCellStyle16;
            this.tblResepDiterima.Enabled = false;
            this.tblResepDiterima.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblResepDiterima.Location = new System.Drawing.Point(827, 361);
            this.tblResepDiterima.MultiSelect = false;
            this.tblResepDiterima.Name = "tblResepDiterima";
            this.tblResepDiterima.ReadOnly = true;
            this.tblResepDiterima.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblResepDiterima.RowHeadersVisible = false;
            this.tblResepDiterima.RowHeadersWidth = 4;
            this.tblResepDiterima.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblResepDiterima.RowTemplate.Height = 30;
            this.tblResepDiterima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblResepDiterima.Size = new System.Drawing.Size(721, 298);
            this.tblResepDiterima.TabIndex = 80;
            this.tblResepDiterima.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblResepDiterima.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblResepDiterima.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblResepDiterima.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResepDiterima.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblResepDiterima.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResepDiterima.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblResepDiterima.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblResepDiterima.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResepDiterima.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblResepDiterima.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblResepDiterima.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblResepDiterima.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblResepDiterima.ThemeStyle.HeaderStyle.Height = 40;
            this.tblResepDiterima.ThemeStyle.ReadOnly = true;
            this.tblResepDiterima.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblResepDiterima.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblResepDiterima.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblResepDiterima.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblResepDiterima.ThemeStyle.RowsStyle.Height = 30;
            this.tblResepDiterima.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblResepDiterima.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResepDiterima.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblResepDiterima_RowPostPaint);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnKembali.HoverState.Image = global::D_Clinic.Properties.Resources.green_next;
            this.btnKembali.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnKembali.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnKembali.Image = global::D_Clinic.Properties.Resources.white_next;
            this.btnKembali.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnKembali.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnKembali.ImageRotate = 0F;
            this.btnKembali.ImageSize = new System.Drawing.Size(35, 35);
            this.btnKembali.Location = new System.Drawing.Point(30, 683);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKembali.ShadowDecoration.BorderRadius = 9;
            this.btnKembali.Size = new System.Drawing.Size(40, 40);
            this.btnKembali.TabIndex = 75;
            this.btnKembali.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel1.Location = new System.Drawing.Point(792, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 637);
            this.panel1.TabIndex = 73;
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
            this.txID.Location = new System.Drawing.Point(158, 71);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Resep Obat";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // radiusTabelDaftarResep
            // 
            this.radiusTabelDaftarResep.BorderRadius = 30;
            this.radiusTabelDaftarResep.TargetControl = this.tblDaftarResep;
            // 
            // radiusTabelResepDiterima
            // 
            this.radiusTabelResepDiterima.BorderRadius = 30;
            this.radiusTabelResepDiterima.TargetControl = this.tblResepDiterima;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTrsPemberianResepBindingSource
            // 
            this.viewTrsPemberianResepBindingSource.DataMember = "View_TrsPemberianResep";
            this.viewTrsPemberianResepBindingSource.DataSource = this.dClinicDataSet;
            // 
            // view_TrsPemberianResepTableAdapter
            // 
            this.view_TrsPemberianResepTableAdapter.ClearBeforeFill = true;
            // 
            // viewTrsPemberianResepDiterimaBindingSource
            // 
            this.viewTrsPemberianResepDiterimaBindingSource.DataMember = "View_TrsPemberianResepDiterima";
            this.viewTrsPemberianResepDiterimaBindingSource.DataSource = this.dClinicDataSet;
            // 
            // view_TrsPemberianResepDiterimaTableAdapter
            // 
            this.view_TrsPemberianResepDiterimaTableAdapter.ClearBeforeFill = true;
            // 
            // txCariResep
            // 
            this.txCariResep.Animated = true;
            this.txCariResep.AutoRoundedCorners = true;
            this.txCariResep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariResep.BorderColor = System.Drawing.Color.White;
            this.txCariResep.BorderRadius = 17;
            this.txCariResep.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariResep.BorderThickness = 2;
            this.txCariResep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariResep.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariResep.DefaultText = "";
            this.txCariResep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariResep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariResep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariResep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariResep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariResep.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariResep.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariResep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariResep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariResep.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariResep.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariResep.Location = new System.Drawing.Point(1271, 172);
            this.txCariResep.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariResep.MaxLength = 30;
            this.txCariResep.Name = "txCariResep";
            this.txCariResep.PasswordChar = '\0';
            this.txCariResep.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariResep.PlaceholderText = "Cari Resep";
            this.txCariResep.SelectedText = "";
            this.txCariResep.Size = new System.Drawing.Size(232, 37);
            this.txCariResep.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariResep.TabIndex = 66;
            this.txCariResep.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariResep.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRefresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRefresh.Location = new System.Drawing.Point(1508, 172);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnRefresh.PressedDepth = 50;
            this.btnRefresh.Size = new System.Drawing.Size(144, 37);
            this.btnRefresh.TabIndex = 67;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseTransparentBackground = true;
            // 
            // no_daftar2
            // 
            this.no_daftar2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_daftar2.HeaderText = "No";
            this.no_daftar2.Name = "no_daftar2";
            this.no_daftar2.ReadOnly = true;
            this.no_daftar2.Width = 40;
            // 
            // idTrsResepDataGridViewTextBoxColumn1
            // 
            this.idTrsResepDataGridViewTextBoxColumn1.DataPropertyName = "Id_TrsResep";
            this.idTrsResepDataGridViewTextBoxColumn1.HeaderText = "ID Resep";
            this.idTrsResepDataGridViewTextBoxColumn1.Name = "idTrsResepDataGridViewTextBoxColumn1";
            this.idTrsResepDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idTrsPendaftaranDataGridViewTextBoxColumn1
            // 
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.DataPropertyName = "Id_TrsPendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.HeaderText = "ID Pendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.Name = "idTrsPendaftaranDataGridViewTextBoxColumn1";
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idTrsPendaftaranDataGridViewTextBoxColumn1.Width = 110;
            // 
            // namaDokterDataGridViewTextBoxColumn1
            // 
            this.namaDokterDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDokterDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Dokter";
            this.namaDokterDataGridViewTextBoxColumn1.HeaderText = "Dokter";
            this.namaDokterDataGridViewTextBoxColumn1.Name = "namaDokterDataGridViewTextBoxColumn1";
            this.namaDokterDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn1
            // 
            this.tanggalDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalDataGridViewTextBoxColumn1.DataPropertyName = "Tanggal";
            dataGridViewCellStyle15.Format = "D";
            this.tanggalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.tanggalDataGridViewTextBoxColumn1.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn1.Name = "tanggalDataGridViewTextBoxColumn1";
            this.tanggalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // waktuDataGridViewTextBoxColumn1
            // 
            this.waktuDataGridViewTextBoxColumn1.DataPropertyName = "Waktu";
            this.waktuDataGridViewTextBoxColumn1.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn1.Name = "waktuDataGridViewTextBoxColumn1";
            this.waktuDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn1
            // 
            this.keteranganDataGridViewTextBoxColumn1.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn1.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn1.Name = "keteranganDataGridViewTextBoxColumn1";
            this.keteranganDataGridViewTextBoxColumn1.ReadOnly = true;
            this.keteranganDataGridViewTextBoxColumn1.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // no_daftar
            // 
            this.no_daftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_daftar.HeaderText = "No";
            this.no_daftar.Name = "no_daftar";
            this.no_daftar.ReadOnly = true;
            this.no_daftar.Width = 40;
            // 
            // id_resep
            // 
            this.id_resep.DataPropertyName = "Id_TrsResep";
            this.id_resep.HeaderText = "ID Resep";
            this.id_resep.Name = "id_resep";
            this.id_resep.ReadOnly = true;
            // 
            // idTrsPendaftaranDataGridViewTextBoxColumn
            // 
            this.idTrsPendaftaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idTrsPendaftaranDataGridViewTextBoxColumn.DataPropertyName = "Id_TrsPendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.HeaderText = "ID Pendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.Name = "idTrsPendaftaranDataGridViewTextBoxColumn";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrsPendaftaranDataGridViewTextBoxColumn.Width = 110;
            // 
            // dokter_resep
            // 
            this.dokter_resep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dokter_resep.DataPropertyName = "Nama_Dokter";
            this.dokter_resep.HeaderText = "Dokter";
            this.dokter_resep.Name = "dokter_resep";
            this.dokter_resep.ReadOnly = true;
            // 
            // tanggal_resep
            // 
            this.tanggal_resep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggal_resep.DataPropertyName = "Tanggal";
            dataGridViewCellStyle11.Format = "D";
            this.tanggal_resep.DefaultCellStyle = dataGridViewCellStyle11;
            this.tanggal_resep.HeaderText = "Tanggal";
            this.tanggal_resep.Name = "tanggal_resep";
            this.tanggal_resep.ReadOnly = true;
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "Waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            this.waktuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ket_resep
            // 
            this.ket_resep.DataPropertyName = "Keterangan";
            this.ket_resep.HeaderText = "Keterangan";
            this.ket_resep.Name = "ket_resep";
            this.ket_resep.ReadOnly = true;
            this.ket_resep.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Daftar_Resep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.txCariResep);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Daftar_Resep";
            this.Text = "Form_Daftar_Resep";
            this.Load += new System.EventHandler(this.Form_Daftar_Resep_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDaftarResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResepDiterima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepDiterimaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2TextBox txKeterangan;
        private Guna.UI2.WinForms.Guna2DataGridView tblDaftarResep;
        public Guna.UI2.WinForms.Guna2TextBox txDokter;
        public Guna.UI2.WinForms.Guna2TextBox txTanggal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnTerima;
        private Guna.UI2.WinForms.Guna2DataGridView tblResepDiterima;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelDaftarResep;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelResepDiterima;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource viewTrsPemberianResepBindingSource;
        private DClinicDataSetTableAdapters.View_TrsPemberianResepTableAdapter view_TrsPemberianResepTableAdapter;
        private System.Windows.Forms.BindingSource viewTrsPemberianResepDiterimaBindingSource;
        private DClinicDataSetTableAdapters.View_TrsPemberianResepDiterimaTableAdapter view_TrsPemberianResepDiterimaTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txCariResep;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_daftar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrsResepDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrsPendaftaranDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrsPendaftaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokter_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ket_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}