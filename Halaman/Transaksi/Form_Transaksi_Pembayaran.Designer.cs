namespace D_Clinic.Halaman.Transaksi
{
    partial class Form_Transaksi_Pembayaran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblPendaftaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_resepsionis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJadwalDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif_jasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusRujukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusResepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTrsPendaftaranTrsPembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.txTotalHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txResepsionis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txDokter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.tblResep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCariObat = new Guna.UI2.WinForms.Guna2TextBox();
            this.view_TrsPendaftaran_TrsPembayaranTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsPendaftaran_TrsPembayaranTableAdapter();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranTrsPembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResep)).BeginInit();
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
            this.label1.Text = "Pembayaran";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.tblPendaftaran);
            this.guna2GroupBox1.Controls.Add(this.txTotalHarga);
            this.guna2GroupBox1.Controls.Add(this.txResepsionis);
            this.guna2GroupBox1.Controls.Add(this.txPasien);
            this.guna2GroupBox1.Controls.Add(this.txDokter);
            this.guna2GroupBox1.Controls.Add(this.txTanggal);
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnBayar);
            this.guna2GroupBox1.Controls.Add(this.tblResep);
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
            // tblPendaftaran
            // 
            this.tblPendaftaran.AllowUserToAddRows = false;
            this.tblPendaftaran.AllowUserToDeleteRows = false;
            this.tblPendaftaran.AllowUserToResizeColumns = false;
            this.tblPendaftaran.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPendaftaran.AutoGenerateColumns = false;
            this.tblPendaftaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPendaftaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPendaftaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPendaftaran.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPendaftaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPendaftaran.ColumnHeadersHeight = 40;
            this.tblPendaftaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_daftar,
            this.id_daftar,
            this.idKaryawanDataGridViewTextBoxColumn,
            this.nama_resepsionis,
            this.idJadwalDokterDataGridViewTextBoxColumn,
            this.nama_dokter,
            this.tarif_jasa,
            this.idPasienDataGridViewTextBoxColumn,
            this.nama_pasien,
            this.id_resep,
            this.harga_resep,
            this.tanggalDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn,
            this.statusRujukanDataGridViewTextBoxColumn,
            this.statusResepDataGridViewTextBoxColumn,
            this.statusPembayaranDataGridViewTextBoxColumn});
            this.tblPendaftaran.DataSource = this.viewTrsPendaftaranTrsPembayaranBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPendaftaran.DefaultCellStyle = dataGridViewCellStyle6;
            this.tblPendaftaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPendaftaran.Location = new System.Drawing.Point(827, 22);
            this.tblPendaftaran.MultiSelect = false;
            this.tblPendaftaran.Name = "tblPendaftaran";
            this.tblPendaftaran.ReadOnly = true;
            this.tblPendaftaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPendaftaran.RowHeadersVisible = false;
            this.tblPendaftaran.RowHeadersWidth = 4;
            this.tblPendaftaran.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPendaftaran.RowTemplate.Height = 30;
            this.tblPendaftaran.Size = new System.Drawing.Size(721, 298);
            this.tblPendaftaran.TabIndex = 88;
            this.tblPendaftaran.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPendaftaran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPendaftaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblPendaftaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblPendaftaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPendaftaran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblPendaftaran.ThemeStyle.HeaderStyle.Height = 40;
            this.tblPendaftaran.ThemeStyle.ReadOnly = true;
            this.tblPendaftaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPendaftaran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPendaftaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblPendaftaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.RowsStyle.Height = 30;
            this.tblPendaftaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPendaftaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPendaftaran_CellContentClick);
            this.tblPendaftaran.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblPendaftaran_RowPostPaint);
            // 
            // no_daftar
            // 
            this.no_daftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_daftar.HeaderText = "No";
            this.no_daftar.Name = "no_daftar";
            this.no_daftar.ReadOnly = true;
            this.no_daftar.Width = 40;
            // 
            // id_daftar
            // 
            this.id_daftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_daftar.DataPropertyName = "Id_TrsPendaftaran";
            this.id_daftar.HeaderText = "ID Pendaftaran";
            this.id_daftar.Name = "id_daftar";
            this.id_daftar.ReadOnly = true;
            this.id_daftar.Width = 110;
            // 
            // idKaryawanDataGridViewTextBoxColumn
            // 
            this.idKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.HeaderText = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.Name = "idKaryawanDataGridViewTextBoxColumn";
            this.idKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKaryawanDataGridViewTextBoxColumn.Visible = false;
            // 
            // nama_resepsionis
            // 
            this.nama_resepsionis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_resepsionis.DataPropertyName = "Nama_Resepsionis";
            this.nama_resepsionis.HeaderText = "Resepsionis";
            this.nama_resepsionis.Name = "nama_resepsionis";
            this.nama_resepsionis.ReadOnly = true;
            // 
            // idJadwalDokterDataGridViewTextBoxColumn
            // 
            this.idJadwalDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn.HeaderText = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn.Name = "idJadwalDokterDataGridViewTextBoxColumn";
            this.idJadwalDokterDataGridViewTextBoxColumn.ReadOnly = true;
            this.idJadwalDokterDataGridViewTextBoxColumn.Visible = false;
            // 
            // nama_dokter
            // 
            this.nama_dokter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_dokter.DataPropertyName = "Nama_Dokter";
            this.nama_dokter.HeaderText = "Dokter";
            this.nama_dokter.Name = "nama_dokter";
            this.nama_dokter.ReadOnly = true;
            // 
            // tarif_jasa
            // 
            this.tarif_jasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarif_jasa.DataPropertyName = "Tarif_Jasa";
            dataGridViewCellStyle3.Format = "C0";
            this.tarif_jasa.DefaultCellStyle = dataGridViewCellStyle3;
            this.tarif_jasa.HeaderText = "Tarif Jasa";
            this.tarif_jasa.Name = "tarif_jasa";
            this.tarif_jasa.ReadOnly = true;
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPasienDataGridViewTextBoxColumn.Visible = false;
            // 
            // nama_pasien
            // 
            this.nama_pasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_pasien.DataPropertyName = "Nama_Pasien";
            this.nama_pasien.HeaderText = "Pasien";
            this.nama_pasien.Name = "nama_pasien";
            this.nama_pasien.ReadOnly = true;
            // 
            // id_resep
            // 
            this.id_resep.DataPropertyName = "Id_TrsResep";
            this.id_resep.HeaderText = "ID Resep";
            this.id_resep.Name = "id_resep";
            this.id_resep.ReadOnly = true;
            this.id_resep.Visible = false;
            // 
            // harga_resep
            // 
            this.harga_resep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga_resep.DataPropertyName = "Harga_Resep";
            dataGridViewCellStyle4.Format = "C0";
            this.harga_resep.DefaultCellStyle = dataGridViewCellStyle4;
            this.harga_resep.HeaderText = "Harga Resep";
            this.harga_resep.Name = "harga_resep";
            this.harga_resep.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            dataGridViewCellStyle5.Format = "D";
            this.tanggalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            // statusRujukanDataGridViewTextBoxColumn
            // 
            this.statusRujukanDataGridViewTextBoxColumn.DataPropertyName = "Status_Rujukan";
            this.statusRujukanDataGridViewTextBoxColumn.HeaderText = "Status_Rujukan";
            this.statusRujukanDataGridViewTextBoxColumn.Name = "statusRujukanDataGridViewTextBoxColumn";
            this.statusRujukanDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusRujukanDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusResepDataGridViewTextBoxColumn
            // 
            this.statusResepDataGridViewTextBoxColumn.DataPropertyName = "Status_Resep";
            this.statusResepDataGridViewTextBoxColumn.HeaderText = "Status_Resep";
            this.statusResepDataGridViewTextBoxColumn.Name = "statusResepDataGridViewTextBoxColumn";
            this.statusResepDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusResepDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusPembayaranDataGridViewTextBoxColumn
            // 
            this.statusPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Status_Pembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.HeaderText = "Status_Pembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.Name = "statusPembayaranDataGridViewTextBoxColumn";
            this.statusPembayaranDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusPembayaranDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewTrsPendaftaranTrsPembayaranBindingSource
            // 
            this.viewTrsPendaftaranTrsPembayaranBindingSource.DataMember = "View_TrsPendaftaran_TrsPembayaran";
            this.viewTrsPendaftaranTrsPembayaranBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txTotalHarga
            // 
            this.txTotalHarga.Animated = true;
            this.txTotalHarga.AutoRoundedCorners = true;
            this.txTotalHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTotalHarga.BorderColor = System.Drawing.Color.White;
            this.txTotalHarga.BorderRadius = 17;
            this.txTotalHarga.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txTotalHarga.BorderThickness = 2;
            this.txTotalHarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.txTotalHarga.DefaultText = "";
            this.txTotalHarga.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txTotalHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTotalHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTotalHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTotalHarga.Enabled = false;
            this.txTotalHarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTotalHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTotalHarga.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTotalHarga.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txTotalHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTotalHarga.HideSelection = false;
            this.txTotalHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTotalHarga.IconLeft = global::D_Clinic.Properties.Resources.white_harga;
            this.txTotalHarga.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txTotalHarga.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txTotalHarga.Location = new System.Drawing.Point(158, 336);
            this.txTotalHarga.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTotalHarga.MaxLength = 30;
            this.txTotalHarga.Name = "txTotalHarga";
            this.txTotalHarga.PasswordChar = '\0';
            this.txTotalHarga.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTotalHarga.PlaceholderText = "Total Harga";
            this.txTotalHarga.ReadOnly = true;
            this.txTotalHarga.SelectedText = "";
            this.txTotalHarga.Size = new System.Drawing.Size(478, 37);
            this.txTotalHarga.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTotalHarga.TabIndex = 87;
            this.txTotalHarga.TabStop = false;
            this.txTotalHarga.TextOffset = new System.Drawing.Point(5, 0);
            this.txTotalHarga.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txResepsionis
            // 
            this.txResepsionis.AcceptsReturn = true;
            this.txResepsionis.AcceptsTab = true;
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
            this.txResepsionis.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txResepsionis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txResepsionis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResepsionis.IconLeft = global::D_Clinic.Properties.Resources.white_resepsionis;
            this.txResepsionis.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txResepsionis.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txResepsionis.Location = new System.Drawing.Point(158, 124);
            this.txResepsionis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txResepsionis.MaxLength = 30;
            this.txResepsionis.Name = "txResepsionis";
            this.txResepsionis.PasswordChar = '\0';
            this.txResepsionis.PlaceholderForeColor = System.Drawing.Color.White;
            this.txResepsionis.PlaceholderText = "Resepsionis";
            this.txResepsionis.SelectedText = "";
            this.txResepsionis.Size = new System.Drawing.Size(478, 37);
            this.txResepsionis.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txResepsionis.TabIndex = 85;
            this.txResepsionis.Tag = "";
            this.txResepsionis.TextOffset = new System.Drawing.Point(5, 0);
            this.txResepsionis.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txPasien
            // 
            this.txPasien.AcceptsReturn = true;
            this.txPasien.AcceptsTab = true;
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
            this.txPasien.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPasien.IconLeft = global::D_Clinic.Properties.Resources.white_pasien;
            this.txPasien.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txPasien.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txPasien.Location = new System.Drawing.Point(158, 283);
            this.txPasien.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txPasien.MaxLength = 30;
            this.txPasien.Name = "txPasien";
            this.txPasien.PasswordChar = '\0';
            this.txPasien.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPasien.PlaceholderText = "Pasien";
            this.txPasien.SelectedText = "";
            this.txPasien.Size = new System.Drawing.Size(478, 37);
            this.txPasien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txPasien.TabIndex = 85;
            this.txPasien.Tag = "";
            this.txPasien.TextOffset = new System.Drawing.Point(5, 0);
            this.txPasien.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
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
            this.txDokter.Location = new System.Drawing.Point(158, 177);
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
            this.txTanggal.Location = new System.Drawing.Point(158, 230);
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
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Detail Pembayaran";
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
            // btnBayar
            // 
            this.btnBayar.Animated = true;
            this.btnBayar.BackColor = System.Drawing.Color.Transparent;
            this.btnBayar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.BorderRadius = 10;
            this.btnBayar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBayar.BorderThickness = 2;
            this.btnBayar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.Enabled = false;
            this.btnBayar.FillColor = System.Drawing.Color.Transparent;
            this.btnBayar.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnBayar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnBayar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnBayar.Location = new System.Drawing.Point(192, 505);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBayar.PressedDepth = 50;
            this.btnBayar.Size = new System.Drawing.Size(412, 37);
            this.btnBayar.TabIndex = 78;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseTransparentBackground = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // tblResep
            // 
            this.tblResep.AllowUserToAddRows = false;
            this.tblResep.AllowUserToDeleteRows = false;
            this.tblResep.AllowUserToResizeColumns = false;
            this.tblResep.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblResep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblResep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblResep.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblResep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tblResep.ColumnHeadersHeight = 40;
            this.tblResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_resep});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblResep.DefaultCellStyle = dataGridViewCellStyle9;
            this.tblResep.Enabled = false;
            this.tblResep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblResep.Location = new System.Drawing.Point(827, 361);
            this.tblResep.MultiSelect = false;
            this.tblResep.Name = "tblResep";
            this.tblResep.ReadOnly = true;
            this.tblResep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblResep.RowHeadersVisible = false;
            this.tblResep.RowHeadersWidth = 4;
            this.tblResep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblResep.RowTemplate.Height = 30;
            this.tblResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblResep.Size = new System.Drawing.Size(721, 298);
            this.tblResep.TabIndex = 80;
            this.tblResep.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblResep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblResep.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblResep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblResep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblResep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblResep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblResep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblResep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblResep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblResep.ThemeStyle.HeaderStyle.Height = 40;
            this.tblResep.ThemeStyle.ReadOnly = true;
            this.tblResep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblResep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblResep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblResep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.ThemeStyle.RowsStyle.Height = 30;
            this.tblResep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblResep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            // 
            // no_resep
            // 
            this.no_resep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_resep.HeaderText = "No";
            this.no_resep.Name = "no_resep";
            this.no_resep.ReadOnly = true;
            this.no_resep.Width = 40;
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
            this.txID.PlaceholderText = "ID Pendaftaran";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txCariObat
            // 
            this.txCariObat.Animated = true;
            this.txCariObat.AutoRoundedCorners = true;
            this.txCariObat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariObat.BorderColor = System.Drawing.Color.White;
            this.txCariObat.BorderRadius = 17;
            this.txCariObat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariObat.BorderThickness = 2;
            this.txCariObat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariObat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariObat.DefaultText = "";
            this.txCariObat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariObat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariObat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariObat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariObat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariObat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariObat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariObat.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariObat.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariObat.Location = new System.Drawing.Point(1271, 172);
            this.txCariObat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariObat.MaxLength = 30;
            this.txCariObat.Name = "txCariObat";
            this.txCariObat.PasswordChar = '\0';
            this.txCariObat.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariObat.PlaceholderText = "Cari Obat";
            this.txCariObat.SelectedText = "";
            this.txCariObat.Size = new System.Drawing.Size(381, 37);
            this.txCariObat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariObat.TabIndex = 65;
            this.txCariObat.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariObat.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // view_TrsPendaftaran_TrsPembayaranTableAdapter
            // 
            this.view_TrsPendaftaran_TrsPembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Transaksi_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.txCariObat);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Transaksi_Pembayaran";
            this.Text = "Form_Transaksi_Pembayaran";
            this.Load += new System.EventHandler(this.Form_Transaksi_Pembayaran_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranTrsPembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPendaftaran;
        public Guna.UI2.WinForms.Guna2TextBox txTotalHarga;
        public Guna.UI2.WinForms.Guna2TextBox txDokter;
        public Guna.UI2.WinForms.Guna2TextBox txTanggal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2DataGridView tblResep;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_resep;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2TextBox txCariObat;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource viewTrsPendaftaranTrsPembayaranBindingSource;
        private DClinicDataSetTableAdapters.View_TrsPendaftaran_TrsPembayaranTableAdapter view_TrsPendaftaran_TrsPembayaranTableAdapter;
        public Guna.UI2.WinForms.Guna2TextBox txResepsionis;
        public Guna.UI2.WinForms.Guna2TextBox txPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_resepsionis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJadwalDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarif_jasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusRujukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusResepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPembayaranDataGridViewTextBoxColumn;
    }
}