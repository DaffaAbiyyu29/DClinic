namespace D_Clinic.Halaman.Transaksi
{
    partial class Form_Transaksi_Rujukan_Pasien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnKirim = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.cbRumahSakit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txDiagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txKeterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tblRujukanPasien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rujukan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pendaftaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKaryawanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaResepsionisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJadwalDokterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRumahSakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTrsRujukanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.tblPendaftaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaResepsionisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJadwalDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTrsPendaftaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgRS = new System.Windows.Forms.PictureBox();
            this.txPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txDokter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusTabelDaftar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.radiusTabelRujukan = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.view_TrsPendaftaranTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsPendaftaranTableAdapter();
            this.view_TrsRujukanTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.View_TrsRujukanTableAdapter();
            this.txCariPendaftaran = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRujukanPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsRujukanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRS)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            this.radiusForm.TargetControl = this;
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
            // btnKirim
            // 
            this.btnKirim.Animated = true;
            this.btnKirim.BackColor = System.Drawing.Color.Transparent;
            this.btnKirim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.BorderRadius = 10;
            this.btnKirim.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnKirim.BorderThickness = 2;
            this.btnKirim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnKirim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.Enabled = false;
            this.btnKirim.FillColor = System.Drawing.Color.Transparent;
            this.btnKirim.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnKirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnKirim.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnKirim.Location = new System.Drawing.Point(192, 505);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(2);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnKirim.PressedDepth = 50;
            this.btnKirim.Size = new System.Drawing.Size(412, 37);
            this.btnKirim.TabIndex = 78;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseTransparentBackground = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Detail Rujukan";
            // 
            // lblRS
            // 
            this.lblRS.BackColor = System.Drawing.Color.Transparent;
            this.lblRS.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.ForeColor = System.Drawing.Color.White;
            this.lblRS.Location = new System.Drawing.Point(200, 232);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(131, 31);
            this.lblRS.TabIndex = 77;
            this.lblRS.Text = "Rumah Sakit";
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
            this.btnRefresh.Location = new System.Drawing.Point(1508, 141);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnRefresh.PressedDepth = 50;
            this.btnRefresh.Size = new System.Drawing.Size(144, 37);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbRumahSakit
            // 
            this.cbRumahSakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbRumahSakit.BorderColor = System.Drawing.Color.White;
            this.cbRumahSakit.BorderThickness = 2;
            this.cbRumahSakit.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbRumahSakit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbRumahSakit.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbRumahSakit.DisplayMember = "Nama";
            this.cbRumahSakit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRumahSakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRumahSakit.Enabled = false;
            this.cbRumahSakit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbRumahSakit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbRumahSakit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbRumahSakit.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbRumahSakit.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbRumahSakit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbRumahSakit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRumahSakit.ItemHeight = 30;
            this.cbRumahSakit.Location = new System.Drawing.Point(158, 230);
            this.cbRumahSakit.Margin = new System.Windows.Forms.Padding(2);
            this.cbRumahSakit.Name = "cbRumahSakit";
            this.cbRumahSakit.Size = new System.Drawing.Size(478, 36);
            this.cbRumahSakit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbRumahSakit.TabIndex = 68;
            this.cbRumahSakit.TextOffset = new System.Drawing.Point(40, 0);
            this.cbRumahSakit.ValueMember = "Id_Dokter";
            this.cbRumahSakit.SelectedIndexChanged += new System.EventHandler(this.cbRumahSakit_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.txDiagnosa);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.lblRS);
            this.guna2GroupBox1.Controls.Add(this.txKeterangan);
            this.guna2GroupBox1.Controls.Add(this.tblRujukanPasien);
            this.guna2GroupBox1.Controls.Add(this.tblPendaftaran);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnKirim);
            this.guna2GroupBox1.Controls.Add(this.btnKembali);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.imgRS);
            this.guna2GroupBox1.Controls.Add(this.cbRumahSakit);
            this.guna2GroupBox1.Controls.Add(this.txPasien);
            this.guna2GroupBox1.Controls.Add(this.txDokter);
            this.guna2GroupBox1.Controls.Add(this.txID);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 57;
            // 
            // txDiagnosa
            // 
            this.txDiagnosa.Animated = true;
            this.txDiagnosa.AutoRoundedCorners = true;
            this.txDiagnosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.BorderRadius = 34;
            this.txDiagnosa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txDiagnosa.BorderThickness = 2;
            this.txDiagnosa.Cursor = System.Windows.Forms.Cursors.Default;
            this.txDiagnosa.DefaultText = "";
            this.txDiagnosa.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.Enabled = false;
            this.txDiagnosa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txDiagnosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txDiagnosa.IconLeft = global::D_Clinic.Properties.Resources.white_diagnosa;
            this.txDiagnosa.IconLeftOffset = new System.Drawing.Point(-2, -10);
            this.txDiagnosa.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txDiagnosa.Location = new System.Drawing.Point(158, 369);
            this.txDiagnosa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txDiagnosa.MaxLength = 30;
            this.txDiagnosa.Multiline = true;
            this.txDiagnosa.Name = "txDiagnosa";
            this.txDiagnosa.PasswordChar = '\0';
            this.txDiagnosa.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.PlaceholderText = "Diagnosa";
            this.txDiagnosa.SelectedText = "";
            this.txDiagnosa.Size = new System.Drawing.Size(478, 71);
            this.txDiagnosa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txDiagnosa.TabIndex = 93;
            this.txDiagnosa.TextOffset = new System.Drawing.Point(5, 0);
            this.txDiagnosa.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label4.Location = new System.Drawing.Point(821, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 92;
            this.label4.Text = "Data Rujukan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(821, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 91;
            this.label3.Text = "Data Pendaftaran";
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
            // txKeterangan
            // 
            this.txKeterangan.Animated = true;
            this.txKeterangan.AutoRoundedCorners = true;
            this.txKeterangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.BorderColor = System.Drawing.Color.White;
            this.txKeterangan.BorderRadius = 34;
            this.txKeterangan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txKeterangan.BorderThickness = 2;
            this.txKeterangan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txKeterangan.DefaultText = "";
            this.txKeterangan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txKeterangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeterangan.Enabled = false;
            this.txKeterangan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeterangan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeterangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txKeterangan.IconLeft = global::D_Clinic.Properties.Resources.white_keluhan;
            this.txKeterangan.IconLeftOffset = new System.Drawing.Point(-2, -10);
            this.txKeterangan.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txKeterangan.Location = new System.Drawing.Point(158, 288);
            this.txKeterangan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txKeterangan.MaxLength = 30;
            this.txKeterangan.Multiline = true;
            this.txKeterangan.Name = "txKeterangan";
            this.txKeterangan.PasswordChar = '\0';
            this.txKeterangan.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeterangan.PlaceholderText = "Keterangan";
            this.txKeterangan.SelectedText = "";
            this.txKeterangan.Size = new System.Drawing.Size(478, 71);
            this.txKeterangan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txKeterangan.TabIndex = 81;
            this.txKeterangan.TextOffset = new System.Drawing.Point(5, 0);
            this.txKeterangan.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // tblRujukanPasien
            // 
            this.tblRujukanPasien.AllowUserToAddRows = false;
            this.tblRujukanPasien.AllowUserToDeleteRows = false;
            this.tblRujukanPasien.AllowUserToResizeColumns = false;
            this.tblRujukanPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblRujukanPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRujukanPasien.AutoGenerateColumns = false;
            this.tblRujukanPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblRujukanPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblRujukanPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRujukanPasien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRujukanPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblRujukanPasien.ColumnHeadersHeight = 40;
            this.tblRujukanPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor,
            this.id_rujukan,
            this.id_pendaftaran,
            this.idKaryawanDataGridViewTextBoxColumn1,
            this.namaResepsionisDataGridViewTextBoxColumn1,
            this.idJadwalDokterDataGridViewTextBoxColumn1,
            this.namaDokterDataGridViewTextBoxColumn,
            this.idPasienDataGridViewTextBoxColumn,
            this.namaPasienDataGridViewTextBoxColumn,
            this.idRumahSakitDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn1,
            this.waktuDataGridViewTextBoxColumn1,
            this.keteranganDataGridViewTextBoxColumn});
            this.tblRujukanPasien.DataSource = this.viewTrsRujukanBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRujukanPasien.DefaultCellStyle = dataGridViewCellStyle4;
            this.tblRujukanPasien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblRujukanPasien.Location = new System.Drawing.Point(827, 390);
            this.tblRujukanPasien.MultiSelect = false;
            this.tblRujukanPasien.Name = "tblRujukanPasien";
            this.tblRujukanPasien.ReadOnly = true;
            this.tblRujukanPasien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblRujukanPasien.RowHeadersVisible = false;
            this.tblRujukanPasien.RowHeadersWidth = 4;
            this.tblRujukanPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblRujukanPasien.RowTemplate.Height = 30;
            this.tblRujukanPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblRujukanPasien.Size = new System.Drawing.Size(721, 269);
            this.tblRujukanPasien.TabIndex = 80;
            this.tblRujukanPasien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblRujukanPasien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblRujukanPasien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblRujukanPasien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblRujukanPasien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblRujukanPasien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblRujukanPasien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblRujukanPasien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblRujukanPasien.ThemeStyle.HeaderStyle.Height = 40;
            this.tblRujukanPasien.ThemeStyle.ReadOnly = true;
            this.tblRujukanPasien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblRujukanPasien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRujukanPasien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblRujukanPasien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblRujukanPasien.ThemeStyle.RowsStyle.Height = 30;
            this.tblRujukanPasien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblRujukanPasien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblRujukanPasien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblRujukanPasien_RowPostPaint);
            // 
            // nomor
            // 
            this.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomor.HeaderText = "No";
            this.nomor.Name = "nomor";
            this.nomor.ReadOnly = true;
            this.nomor.Width = 40;
            // 
            // id_rujukan
            // 
            this.id_rujukan.DataPropertyName = "Id_TrsRujukanPasien";
            this.id_rujukan.HeaderText = "ID Rujukan";
            this.id_rujukan.Name = "id_rujukan";
            this.id_rujukan.ReadOnly = true;
            // 
            // id_pendaftaran
            // 
            this.id_pendaftaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_pendaftaran.DataPropertyName = "Id_TrsPendaftaran";
            this.id_pendaftaran.HeaderText = "ID Pendaftaran";
            this.id_pendaftaran.Name = "id_pendaftaran";
            this.id_pendaftaran.ReadOnly = true;
            this.id_pendaftaran.Width = 110;
            // 
            // idKaryawanDataGridViewTextBoxColumn1
            // 
            this.idKaryawanDataGridViewTextBoxColumn1.DataPropertyName = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn1.HeaderText = "ID Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn1.Name = "idKaryawanDataGridViewTextBoxColumn1";
            this.idKaryawanDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idKaryawanDataGridViewTextBoxColumn1.Visible = false;
            // 
            // namaResepsionisDataGridViewTextBoxColumn1
            // 
            this.namaResepsionisDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn1.HeaderText = "Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn1.Name = "namaResepsionisDataGridViewTextBoxColumn1";
            this.namaResepsionisDataGridViewTextBoxColumn1.ReadOnly = true;
            this.namaResepsionisDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idJadwalDokterDataGridViewTextBoxColumn1
            // 
            this.idJadwalDokterDataGridViewTextBoxColumn1.DataPropertyName = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn1.HeaderText = "ID Jadwal";
            this.idJadwalDokterDataGridViewTextBoxColumn1.Name = "idJadwalDokterDataGridViewTextBoxColumn1";
            this.idJadwalDokterDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idJadwalDokterDataGridViewTextBoxColumn1.Visible = false;
            // 
            // namaDokterDataGridViewTextBoxColumn
            // 
            this.namaDokterDataGridViewTextBoxColumn.DataPropertyName = "Nama_Dokter";
            this.namaDokterDataGridViewTextBoxColumn.HeaderText = "Dokter";
            this.namaDokterDataGridViewTextBoxColumn.Name = "namaDokterDataGridViewTextBoxColumn";
            this.namaDokterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "ID Pasien";
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPasienDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaPasienDataGridViewTextBoxColumn
            // 
            this.namaPasienDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pasien";
            this.namaPasienDataGridViewTextBoxColumn.HeaderText = "Pasien";
            this.namaPasienDataGridViewTextBoxColumn.Name = "namaPasienDataGridViewTextBoxColumn";
            this.namaPasienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRumahSakitDataGridViewTextBoxColumn
            // 
            this.idRumahSakitDataGridViewTextBoxColumn.DataPropertyName = "Id_RumahSakit";
            this.idRumahSakitDataGridViewTextBoxColumn.HeaderText = "ID RS";
            this.idRumahSakitDataGridViewTextBoxColumn.Name = "idRumahSakitDataGridViewTextBoxColumn";
            this.idRumahSakitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRumahSakitDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama RS";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn1
            // 
            this.tanggalDataGridViewTextBoxColumn1.DataPropertyName = "Tanggal";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.tanggalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
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
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewTrsRujukanBindingSource
            // 
            this.viewTrsRujukanBindingSource.DataMember = "View_TrsRujukan";
            this.viewTrsRujukanBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPendaftaran
            // 
            this.tblPendaftaran.AllowUserToAddRows = false;
            this.tblPendaftaran.AllowUserToDeleteRows = false;
            this.tblPendaftaran.AllowUserToResizeColumns = false;
            this.tblPendaftaran.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblPendaftaran.AutoGenerateColumns = false;
            this.tblPendaftaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPendaftaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPendaftaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPendaftaran.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPendaftaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tblPendaftaran.ColumnHeadersHeight = 40;
            this.tblPendaftaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id_daftar,
            this.idKaryawanDataGridViewTextBoxColumn,
            this.namaResepsionisDataGridViewTextBoxColumn,
            this.idJadwalDokterDataGridViewTextBoxColumn,
            this.nama_dokter,
            this.id_pasien,
            this.nama_pasien,
            this.tanggalDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn});
            this.tblPendaftaran.DataSource = this.viewTrsPendaftaranBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPendaftaran.DefaultCellStyle = dataGridViewCellStyle8;
            this.tblPendaftaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPendaftaran.Location = new System.Drawing.Point(827, 57);
            this.tblPendaftaran.MultiSelect = false;
            this.tblPendaftaran.Name = "tblPendaftaran";
            this.tblPendaftaran.ReadOnly = true;
            this.tblPendaftaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPendaftaran.RowHeadersVisible = false;
            this.tblPendaftaran.RowHeadersWidth = 4;
            this.tblPendaftaran.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPendaftaran.RowTemplate.Height = 30;
            this.tblPendaftaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPendaftaran.Size = new System.Drawing.Size(721, 269);
            this.tblPendaftaran.TabIndex = 80;
            this.tblPendaftaran.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
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
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
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
            this.idKaryawanDataGridViewTextBoxColumn.HeaderText = "ID Resepsionis";
            this.idKaryawanDataGridViewTextBoxColumn.Name = "idKaryawanDataGridViewTextBoxColumn";
            this.idKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKaryawanDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaResepsionisDataGridViewTextBoxColumn
            // 
            this.namaResepsionisDataGridViewTextBoxColumn.DataPropertyName = "Nama_Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn.HeaderText = "Resepsionis";
            this.namaResepsionisDataGridViewTextBoxColumn.Name = "namaResepsionisDataGridViewTextBoxColumn";
            this.namaResepsionisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idJadwalDokterDataGridViewTextBoxColumn
            // 
            this.idJadwalDokterDataGridViewTextBoxColumn.DataPropertyName = "Id_JadwalDokter";
            this.idJadwalDokterDataGridViewTextBoxColumn.HeaderText = "ID Jadwal";
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
            // id_pasien
            // 
            this.id_pasien.DataPropertyName = "Id_Pasien";
            this.id_pasien.HeaderText = "ID Pasien";
            this.id_pasien.Name = "id_pasien";
            this.id_pasien.ReadOnly = true;
            this.id_pasien.Visible = false;
            // 
            // nama_pasien
            // 
            this.nama_pasien.DataPropertyName = "Nama_Pasien";
            this.nama_pasien.HeaderText = "Pasien";
            this.nama_pasien.Name = "nama_pasien";
            this.nama_pasien.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = null;
            this.tanggalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
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
            // 
            // viewTrsPendaftaranBindingSource
            // 
            this.viewTrsPendaftaranBindingSource.DataMember = "View_TrsPendaftaran";
            this.viewTrsPendaftaranBindingSource.DataSource = this.dClinicDataSet;
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
            // imgRS
            // 
            this.imgRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgRS.Image = global::D_Clinic.Properties.Resources.white_rs;
            this.imgRS.Location = new System.Drawing.Point(161, 229);
            this.imgRS.Margin = new System.Windows.Forms.Padding(2);
            this.imgRS.Name = "imgRS";
            this.imgRS.Size = new System.Drawing.Size(30, 30);
            this.imgRS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRS.TabIndex = 70;
            this.imgRS.TabStop = false;
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
            this.txPasien.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPasien.IconLeft = global::D_Clinic.Properties.Resources.white_pasien;
            this.txPasien.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txPasien.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txPasien.Location = new System.Drawing.Point(158, 177);
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
            this.txDokter.IconLeft = global::D_Clinic.Properties.Resources.green_dokter;
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
            this.txDokter.TabIndex = 22;
            this.txDokter.Tag = "";
            this.txDokter.TextOffset = new System.Drawing.Point(5, 0);
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
            this.txID.PlaceholderText = "ID Rujukan";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
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
            this.label1.TabIndex = 56;
            this.label1.Text = "Rujukan Pasien";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusTabelDaftar
            // 
            this.radiusTabelDaftar.BorderRadius = 30;
            this.radiusTabelDaftar.TargetControl = this.tblPendaftaran;
            // 
            // radiusTabelRujukan
            // 
            this.radiusTabelRujukan.BorderRadius = 30;
            this.radiusTabelRujukan.TargetControl = this;
            // 
            // view_TrsPendaftaranTableAdapter
            // 
            this.view_TrsPendaftaranTableAdapter.ClearBeforeFill = true;
            // 
            // view_TrsRujukanTableAdapter
            // 
            this.view_TrsRujukanTableAdapter.ClearBeforeFill = true;
            // 
            // txCariPendaftaran
            // 
            this.txCariPendaftaran.Animated = true;
            this.txCariPendaftaran.AutoRoundedCorners = true;
            this.txCariPendaftaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariPendaftaran.BorderColor = System.Drawing.Color.White;
            this.txCariPendaftaran.BorderRadius = 17;
            this.txCariPendaftaran.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariPendaftaran.BorderThickness = 2;
            this.txCariPendaftaran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariPendaftaran.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariPendaftaran.DefaultText = "";
            this.txCariPendaftaran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariPendaftaran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariPendaftaran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariPendaftaran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariPendaftaran.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txCariPendaftaran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPendaftaran.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPendaftaran.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariPendaftaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariPendaftaran.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariPendaftaran.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariPendaftaran.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariPendaftaran.Location = new System.Drawing.Point(1271, 141);
            this.txCariPendaftaran.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariPendaftaran.MaxLength = 30;
            this.txCariPendaftaran.Name = "txCariPendaftaran";
            this.txCariPendaftaran.PasswordChar = '\0';
            this.txCariPendaftaran.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariPendaftaran.PlaceholderText = "Cari Pendaftaran";
            this.txCariPendaftaran.SelectedText = "";
            this.txCariPendaftaran.Size = new System.Drawing.Size(232, 37);
            this.txCariPendaftaran.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariPendaftaran.TabIndex = 58;
            this.txCariPendaftaran.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariPendaftaran.TextChanged += new System.EventHandler(this.txCariRS_TextChanged);
            // 
            // Form_Transaksi_Rujukan_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.txCariPendaftaran);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Transaksi_Rujukan_Pasien";
            this.Text = "Form_Transaksi_Rujukan_Pasien";
            this.Load += new System.EventHandler(this.Form_Transaksi_Rujukan_Pasien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRujukanPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsRujukanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPendaftaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Guna.UI2.WinForms.Guna2TextBox txCariPendaftaran;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRS;
        public Guna.UI2.WinForms.Guna2TextBox txKeterangan;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnKirim;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgRS;
        private Guna.UI2.WinForms.Guna2ComboBox cbRumahSakit;
        public Guna.UI2.WinForms.Guna2TextBox txPasien;
        public Guna.UI2.WinForms.Guna2TextBox txDokter;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView tblRujukanPasien;
        private Guna.UI2.WinForms.Guna2DataGridView tblPendaftaran;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelDaftar;
        private Guna.UI2.WinForms.Guna2Elipse radiusTabelRujukan;
        private System.Windows.Forms.Panel panel2;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource viewTrsPendaftaranBindingSource;
        private DClinicDataSetTableAdapters.View_TrsPendaftaranTableAdapter view_TrsPendaftaranTableAdapter;
        private System.Windows.Forms.BindingSource viewTrsRujukanBindingSource;
        private DClinicDataSetTableAdapters.View_TrsRujukanTableAdapter view_TrsRujukanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rujukan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pendaftaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaResepsionisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJadwalDokterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRumahSakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaResepsionisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJadwalDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txDiagnosa;
    }
}