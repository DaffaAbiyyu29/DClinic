namespace D_Clinic.Halaman
{
    partial class Form_Transaksi_Pendaftaran_Pasien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDokter = new System.Windows.Forms.Label();
            this.txTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.tblTrsPendaftaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrsPendaftaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaResepsionisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJadwalDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTrsPendaftaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.tblPasien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golonganDarahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnDaftar = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgDokter = new System.Windows.Forms.PictureBox();
            this.cbDokter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txResepsionis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.radiusTabelPasien = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            this.view_TrsPendaftaranTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsPendaftaranTableAdapter();
            this.radiusTabelViewTrs = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txCariPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrsPendaftaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDokter)).BeginInit();
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
            this.label1.TabIndex = 42;
            this.label1.Text = "Pendaftaran Pasien";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.lblDokter);
            this.guna2GroupBox1.Controls.Add(this.txTanggal);
            this.guna2GroupBox1.Controls.Add(this.tblTrsPendaftaran);
            this.guna2GroupBox1.Controls.Add(this.tblPasien);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnDaftar);
            this.guna2GroupBox1.Controls.Add(this.btnKembali);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.imgDokter);
            this.guna2GroupBox1.Controls.Add(this.cbDokter);
            this.guna2GroupBox1.Controls.Add(this.txPasien);
            this.guna2GroupBox1.Controls.Add(this.txResepsionis);
            this.guna2GroupBox1.Controls.Add(this.txID);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel2.Location = new System.Drawing.Point(827, 340);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 1);
            this.panel2.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Detail Pendaftaran";
            // 
            // lblDokter
            // 
            this.lblDokter.BackColor = System.Drawing.Color.Transparent;
            this.lblDokter.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDokter.ForeColor = System.Drawing.Color.White;
            this.lblDokter.Location = new System.Drawing.Point(142, 232);
            this.lblDokter.Name = "lblDokter";
            this.lblDokter.Size = new System.Drawing.Size(83, 31);
            this.lblDokter.TabIndex = 77;
            this.lblDokter.Text = "Dokter";
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
            this.txTanggal.IconLeft = global::D_Clinic.Properties.Resources.green_cal;
            this.txTanggal.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txTanggal.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txTanggal.Location = new System.Drawing.Point(100, 283);
            this.txTanggal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTanggal.MaxLength = 30;
            this.txTanggal.Name = "txTanggal";
            this.txTanggal.PasswordChar = '\0';
            this.txTanggal.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTanggal.PlaceholderText = "Tanggal";
            this.txTanggal.SelectedText = "";
            this.txTanggal.Size = new System.Drawing.Size(478, 37);
            this.txTanggal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTanggal.TabIndex = 81;
            this.txTanggal.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // tblTrsPendaftaran
            // 
            this.tblTrsPendaftaran.AllowUserToAddRows = false;
            this.tblTrsPendaftaran.AllowUserToDeleteRows = false;
            this.tblTrsPendaftaran.AllowUserToResizeColumns = false;
            this.tblTrsPendaftaran.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblTrsPendaftaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tblTrsPendaftaran.AutoGenerateColumns = false;
            this.tblTrsPendaftaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblTrsPendaftaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblTrsPendaftaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblTrsPendaftaran.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTrsPendaftaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tblTrsPendaftaran.ColumnHeadersHeight = 40;
            this.tblTrsPendaftaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor,
            this.idTrsPendaftaranDataGridViewTextBoxColumn,
            this.idKaryawanDataGridViewTextBoxColumn,
            this.namaResepsionisDataGridViewTextBoxColumn,
            this.idJadwalDokterDataGridViewTextBoxColumn,
            this.namaDokterDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn,
            this.namaPasienDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn});
            this.tblTrsPendaftaran.DataSource = this.viewTrsPendaftaranBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblTrsPendaftaran.DefaultCellStyle = dataGridViewCellStyle11;
            this.tblTrsPendaftaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblTrsPendaftaran.Location = new System.Drawing.Point(827, 361);
            this.tblTrsPendaftaran.MultiSelect = false;
            this.tblTrsPendaftaran.Name = "tblTrsPendaftaran";
            this.tblTrsPendaftaran.ReadOnly = true;
            this.tblTrsPendaftaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblTrsPendaftaran.RowHeadersVisible = false;
            this.tblTrsPendaftaran.RowHeadersWidth = 4;
            this.tblTrsPendaftaran.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblTrsPendaftaran.RowTemplate.Height = 30;
            this.tblTrsPendaftaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblTrsPendaftaran.Size = new System.Drawing.Size(721, 298);
            this.tblTrsPendaftaran.TabIndex = 80;
            this.tblTrsPendaftaran.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblTrsPendaftaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblTrsPendaftaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblTrsPendaftaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblTrsPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblTrsPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblTrsPendaftaran.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblTrsPendaftaran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblTrsPendaftaran.ThemeStyle.HeaderStyle.Height = 40;
            this.tblTrsPendaftaran.ThemeStyle.ReadOnly = true;
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.Height = 30;
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblTrsPendaftaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblTrsPendaftaran.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblTrsPendaftaran_RowPostPaint);
            // 
            // nomor
            // 
            this.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomor.HeaderText = "No";
            this.nomor.Name = "nomor";
            this.nomor.ReadOnly = true;
            this.nomor.Width = 40;
            // 
            // idTrsPendaftaranDataGridViewTextBoxColumn
            // 
            this.idTrsPendaftaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idTrsPendaftaranDataGridViewTextBoxColumn.DataPropertyName = "Id_TrsPendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.HeaderText = "ID Pendaftaran";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.Name = "idTrsPendaftaranDataGridViewTextBoxColumn";
            this.idTrsPendaftaranDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrsPendaftaranDataGridViewTextBoxColumn.Width = 120;
            // 
            // idKaryawanDataGridViewTextBoxColumn
            // 
            this.idKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.HeaderText = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.Name = "idKaryawanDataGridViewTextBoxColumn";
            this.idKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKaryawanDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaResepsionisDataGridViewTextBoxColumn
            // 
            this.namaResepsionisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaResepsionisDataGridViewTextBoxColumn.DataPropertyName = "Nama_Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn.HeaderText = "Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn.Name = "namaResepsionisDataGridViewTextBoxColumn";
            this.namaResepsionisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idJadwalDokterDataGridViewTextBoxColumn
            // 
            this.idJadwalDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn.HeaderText = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn.Name = "idJadwalDokterDataGridViewTextBoxColumn";
            this.idJadwalDokterDataGridViewTextBoxColumn.ReadOnly = true;
            this.idJadwalDokterDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaDokterDataGridViewTextBoxColumn
            // 
            this.namaDokterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDokterDataGridViewTextBoxColumn.DataPropertyName = "Nama_Dokter";
            this.namaDokterDataGridViewTextBoxColumn.HeaderText = "Dokter";
            this.namaDokterDataGridViewTextBoxColumn.Name = "namaDokterDataGridViewTextBoxColumn";
            this.namaDokterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPasienDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaPasienDataGridViewTextBoxColumn
            // 
            this.namaPasienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaPasienDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pasien";
            this.namaPasienDataGridViewTextBoxColumn.HeaderText = "Pasien";
            this.namaPasienDataGridViewTextBoxColumn.Name = "namaPasienDataGridViewTextBoxColumn";
            this.namaPasienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            dataGridViewCellStyle10.Format = "D";
            dataGridViewCellStyle10.NullValue = null;
            this.tanggalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "Waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            this.waktuDataGridViewTextBoxColumn.ReadOnly = true;
            this.waktuDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewTrsPendaftaranBindingSource
            // 
            this.viewTrsPendaftaranBindingSource.DataMember = "View_TrsPendaftaran";
            this.viewTrsPendaftaranBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPasien
            // 
            this.tblPasien.AllowUserToAddRows = false;
            this.tblPasien.AllowUserToDeleteRows = false;
            this.tblPasien.AllowUserToResizeColumns = false;
            this.tblPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tblPasien.AutoGenerateColumns = false;
            this.tblPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPasien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tblPasien.ColumnHeadersHeight = 40;
            this.tblPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.idPasien,
            this.namaPasien,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.golonganDarahDataGridViewTextBoxColumn});
            this.tblPasien.DataSource = this.pasienBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPasien.DefaultCellStyle = dataGridViewCellStyle14;
            this.tblPasien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPasien.Location = new System.Drawing.Point(827, 22);
            this.tblPasien.MultiSelect = false;
            this.tblPasien.Name = "tblPasien";
            this.tblPasien.ReadOnly = true;
            this.tblPasien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPasien.RowHeadersVisible = false;
            this.tblPasien.RowHeadersWidth = 4;
            this.tblPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPasien.RowTemplate.Height = 30;
            this.tblPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPasien.Size = new System.Drawing.Size(721, 298);
            this.tblPasien.TabIndex = 80;
            this.tblPasien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblPasien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblPasien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPasien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblPasien.ThemeStyle.HeaderStyle.Height = 40;
            this.tblPasien.ThemeStyle.ReadOnly = true;
            this.tblPasien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPasien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblPasien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.ThemeStyle.RowsStyle.Height = 30;
            this.tblPasien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPasien_CellContentClick);
            this.tblPasien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblPasien_RowPostPaint);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // idPasien
            // 
            this.idPasien.DataPropertyName = "Id_Pasien";
            this.idPasien.HeaderText = "ID Pasien";
            this.idPasien.Name = "idPasien";
            this.idPasien.ReadOnly = true;
            // 
            // namaPasien
            // 
            this.namaPasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaPasien.DataPropertyName = "Nama";
            this.namaPasien.HeaderText = "Nama Pasien";
            this.namaPasien.Name = "namaPasien";
            this.namaPasien.ReadOnly = true;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 165;
            // 
            // golonganDarahDataGridViewTextBoxColumn
            // 
            this.golonganDarahDataGridViewTextBoxColumn.DataPropertyName = "Golongan_Darah";
            this.golonganDarahDataGridViewTextBoxColumn.HeaderText = "Darah";
            this.golonganDarahDataGridViewTextBoxColumn.Name = "golonganDarahDataGridViewTextBoxColumn";
            this.golonganDarahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.dClinicDataSet;
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
            this.btnBatal.TabIndex = 79;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnDaftar
            // 
            this.btnDaftar.Animated = true;
            this.btnDaftar.BackColor = System.Drawing.Color.Transparent;
            this.btnDaftar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.BorderRadius = 10;
            this.btnDaftar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDaftar.BorderThickness = 2;
            this.btnDaftar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnDaftar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.Enabled = false;
            this.btnDaftar.FillColor = System.Drawing.Color.Transparent;
            this.btnDaftar.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnDaftar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnDaftar.Location = new System.Drawing.Point(138, 505);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnDaftar.PressedDepth = 50;
            this.btnDaftar.Size = new System.Drawing.Size(412, 37);
            this.btnDaftar.TabIndex = 78;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseTransparentBackground = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
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
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
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
            // imgDokter
            // 
            this.imgDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgDokter.Image = global::D_Clinic.Properties.Resources.white_dokter;
            this.imgDokter.Location = new System.Drawing.Point(103, 229);
            this.imgDokter.Margin = new System.Windows.Forms.Padding(2);
            this.imgDokter.Name = "imgDokter";
            this.imgDokter.Size = new System.Drawing.Size(30, 30);
            this.imgDokter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDokter.TabIndex = 70;
            this.imgDokter.TabStop = false;
            // 
            // cbDokter
            // 
            this.cbDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbDokter.BorderColor = System.Drawing.Color.White;
            this.cbDokter.BorderThickness = 2;
            this.cbDokter.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbDokter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbDokter.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbDokter.DisplayMember = "Nama";
            this.cbDokter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDokter.Enabled = false;
            this.cbDokter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbDokter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbDokter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbDokter.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbDokter.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbDokter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbDokter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDokter.ItemHeight = 30;
            this.cbDokter.Location = new System.Drawing.Point(100, 230);
            this.cbDokter.Margin = new System.Windows.Forms.Padding(2);
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(478, 36);
            this.cbDokter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDokter.TabIndex = 68;
            this.cbDokter.TextOffset = new System.Drawing.Point(40, 0);
            this.cbDokter.ValueMember = "Id_Dokter";
            this.cbDokter.SelectedIndexChanged += new System.EventHandler(this.cbDokter_SelectedIndexChanged);
            // 
            // txPasien
            // 
            this.txPasien.Animated = true;
            this.txPasien.AutoRoundedCorners = true;
            this.txPasien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPasien.BorderColor = System.Drawing.Color.White;
            this.txPasien.BorderRadius = 17;
            this.txPasien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txPasien.BorderThickness = 2;
            this.txPasien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txPasien.DefaultText = "";
            this.txPasien.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txPasien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPasien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPasien.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPasien.Enabled = false;
            this.txPasien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPasien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPasien.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPasien.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPasien.IconLeft = global::D_Clinic.Properties.Resources.white_pasien;
            this.txPasien.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txPasien.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txPasien.Location = new System.Drawing.Point(100, 177);
            this.txPasien.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txPasien.MaxLength = 30;
            this.txPasien.Name = "txPasien";
            this.txPasien.PasswordChar = '\0';
            this.txPasien.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPasien.PlaceholderText = "Pasien";
            this.txPasien.SelectedText = "";
            this.txPasien.Size = new System.Drawing.Size(478, 37);
            this.txPasien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txPasien.TabIndex = 22;
            this.txPasien.TextOffset = new System.Drawing.Point(5, 0);
            this.txPasien.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txResepsionis
            // 
            this.txResepsionis.Animated = true;
            this.txResepsionis.AutoRoundedCorners = true;
            this.txResepsionis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txResepsionis.BorderColor = System.Drawing.Color.White;
            this.txResepsionis.BorderRadius = 17;
            this.txResepsionis.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txResepsionis.BorderThickness = 2;
            this.txResepsionis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txResepsionis.DefaultText = "";
            this.txResepsionis.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txResepsionis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txResepsionis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txResepsionis.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txResepsionis.Enabled = false;
            this.txResepsionis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txResepsionis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txResepsionis.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txResepsionis.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txResepsionis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txResepsionis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResepsionis.IconLeft = global::D_Clinic.Properties.Resources.green_resepsionis;
            this.txResepsionis.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txResepsionis.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txResepsionis.Location = new System.Drawing.Point(100, 124);
            this.txResepsionis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txResepsionis.MaxLength = 30;
            this.txResepsionis.Name = "txResepsionis";
            this.txResepsionis.PasswordChar = '\0';
            this.txResepsionis.PlaceholderForeColor = System.Drawing.Color.White;
            this.txResepsionis.PlaceholderText = "Resepsionis";
            this.txResepsionis.SelectedText = "";
            this.txResepsionis.Size = new System.Drawing.Size(478, 37);
            this.txResepsionis.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txResepsionis.TabIndex = 22;
            this.txResepsionis.TextOffset = new System.Drawing.Point(5, 0);
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
            this.txID.PlaceholderText = "ID Pendaftaran";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // radiusTabelPasien
            // 
            this.radiusTabelPasien.BorderRadius = 30;
            this.radiusTabelPasien.TargetControl = this.tblPasien;
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
            this.btnCari.Location = new System.Drawing.Point(1508, 141);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCari.PressedDepth = 50;
            this.btnCari.Size = new System.Drawing.Size(144, 37);
            this.btnCari.TabIndex = 55;
            this.btnCari.Text = "Cari";
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // view_TrsPendaftaranTableAdapter
            // 
            this.view_TrsPendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // radiusTabelViewTrs
            // 
            this.radiusTabelViewTrs.BorderRadius = 30;
            this.radiusTabelViewTrs.TargetControl = this.tblTrsPendaftaran;
            // 
            // txCariPasien
            // 
            this.txCariPasien.Animated = true;
            this.txCariPasien.AutoRoundedCorners = true;
            this.txCariPasien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariPasien.BorderColor = System.Drawing.Color.White;
            this.txCariPasien.BorderRadius = 17;
            this.txCariPasien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariPasien.BorderThickness = 2;
            this.txCariPasien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariPasien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariPasien.DefaultText = "";
            this.txCariPasien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariPasien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariPasien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariPasien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariPasien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariPasien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPasien.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPasien.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariPasien.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariPasien.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariPasien.Location = new System.Drawing.Point(1271, 141);
            this.txCariPasien.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariPasien.MaxLength = 30;
            this.txCariPasien.Name = "txCariPasien";
            this.txCariPasien.PasswordChar = '\0';
            this.txCariPasien.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariPasien.PlaceholderText = "Cari Pasien";
            this.txCariPasien.SelectedText = "";
            this.txCariPasien.Size = new System.Drawing.Size(232, 37);
            this.txCariPasien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariPasien.TabIndex = 54;
            this.txCariPasien.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariPasien.TextChanged += new System.EventHandler(this.txCariPasien_TextChanged);
            // 
            // Form_Transaksi_Pendaftaran_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txCariPasien);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Transaksi_Pendaftaran_Pasien";
            this.Text = "Form_Registrasi_Pasien";
            this.Load += new System.EventHandler(this.Form_Pendaftaran_Pasien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrsPendaftaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDokter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.PictureBox imgDokter;
        private Guna.UI2.WinForms.Guna2ComboBox cbDokter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelPasien;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        public Guna.UI2.WinForms.Guna2TextBox txResepsionis;
        public Guna.UI2.WinForms.Guna2TextBox txPasien;
        private System.Windows.Forms.Label lblDokter;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnDaftar;
        private Guna.UI2.WinForms.Guna2DataGridView tblPasien;
        private DClinicDataSet dClinicDataSet;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txCariPasien;
        public Guna.UI2.WinForms.Guna2TextBox txTanggal;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView tblTrsPendaftaran;
        private System.Windows.Forms.BindingSource viewTrsPendaftaranBindingSource;
        private DClinicDataSetTableAdapters.View_TrsPendaftaranTableAdapter view_TrsPendaftaranTableAdapter;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelViewTrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrsPendaftaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaResepsionisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJadwalDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golonganDarahDataGridViewTextBoxColumn;
    }
}