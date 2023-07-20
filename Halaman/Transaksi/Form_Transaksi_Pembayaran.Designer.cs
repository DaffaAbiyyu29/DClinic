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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tblPendaftaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnKurang = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnKirim = new Guna.UI2.WinForms.Guna2Button();
            this.tblKeranjang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_keranjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_obat_keranjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat_keranjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_obat_keranjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblResep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblObat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txKeterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txDiagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTotalHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txDokter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTanggal = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCariObat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObat)).BeginInit();
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
            this.guna2GroupBox1.Controls.Add(this.txKeterangan);
            this.guna2GroupBox1.Controls.Add(this.txDiagnosa);
            this.guna2GroupBox1.Controls.Add(this.panel3);
            this.guna2GroupBox1.Controls.Add(this.tblPendaftaran);
            this.guna2GroupBox1.Controls.Add(this.lblTotalHarga);
            this.guna2GroupBox1.Controls.Add(this.txTotalHarga);
            this.guna2GroupBox1.Controls.Add(this.btnKurang);
            this.guna2GroupBox1.Controls.Add(this.btnTambah);
            this.guna2GroupBox1.Controls.Add(this.txDokter);
            this.guna2GroupBox1.Controls.Add(this.txTanggal);
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnKirim);
            this.guna2GroupBox1.Controls.Add(this.tblKeranjang);
            this.guna2GroupBox1.Controls.Add(this.tblResep);
            this.guna2GroupBox1.Controls.Add(this.tblObat);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel3.Location = new System.Drawing.Point(827, 448);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 1);
            this.panel3.TabIndex = 84;
            // 
            // tblPendaftaran
            // 
            this.tblPendaftaran.AllowUserToAddRows = false;
            this.tblPendaftaran.AllowUserToDeleteRows = false;
            this.tblPendaftaran.AllowUserToResizeColumns = false;
            this.tblPendaftaran.AllowUserToResizeRows = false;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.tblPendaftaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPendaftaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPendaftaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPendaftaran.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPendaftaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.tblPendaftaran.ColumnHeadersHeight = 40;
            this.tblPendaftaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_daftar});
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPendaftaran.DefaultCellStyle = dataGridViewCellStyle59;
            this.tblPendaftaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPendaftaran.Location = new System.Drawing.Point(827, 23);
            this.tblPendaftaran.MultiSelect = false;
            this.tblPendaftaran.Name = "tblPendaftaran";
            this.tblPendaftaran.ReadOnly = true;
            this.tblPendaftaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPendaftaran.RowHeadersVisible = false;
            this.tblPendaftaran.RowHeadersWidth = 4;
            this.tblPendaftaran.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPendaftaran.RowTemplate.Height = 30;
            this.tblPendaftaran.Size = new System.Drawing.Size(721, 203);
            this.tblPendaftaran.TabIndex = 88;
            this.tblPendaftaran.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
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
            this.tblPendaftaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPendaftaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            // 
            // no_daftar
            // 
            this.no_daftar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_daftar.HeaderText = "No";
            this.no_daftar.Name = "no_daftar";
            this.no_daftar.ReadOnly = true;
            this.no_daftar.Width = 40;
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHarga.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHarga.ForeColor = System.Drawing.Color.White;
            this.lblTotalHarga.Location = new System.Drawing.Point(464, 563);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(298, 32);
            this.lblTotalHarga.TabIndex = 83;
            this.lblTotalHarga.Text = "Total Harga";
            // 
            // btnKurang
            // 
            this.btnKurang.Animated = true;
            this.btnKurang.BackColor = System.Drawing.Color.Transparent;
            this.btnKurang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.BorderRadius = 10;
            this.btnKurang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnKurang.BorderThickness = 2;
            this.btnKurang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnKurang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.FillColor = System.Drawing.Color.Transparent;
            this.btnKurang.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnKurang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKurang.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnKurang.Location = new System.Drawing.Point(656, 283);
            this.btnKurang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnKurang.PressedDepth = 50;
            this.btnKurang.Size = new System.Drawing.Size(122, 37);
            this.btnKurang.TabIndex = 86;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseTransparentBackground = true;
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
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.FillColor = System.Drawing.Color.Transparent;
            this.btnTambah.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnTambah.Location = new System.Drawing.Point(656, 242);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTambah.PressedDepth = 50;
            this.btnTambah.Size = new System.Drawing.Size(122, 37);
            this.btnTambah.TabIndex = 86;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel2.Location = new System.Drawing.Point(827, 232);
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
            this.btnBatal.Location = new System.Drawing.Point(41, 622);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBatal.PressedDepth = 50;
            this.btnBatal.Size = new System.Drawing.Size(339, 37);
            this.btnBatal.TabIndex = 79;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
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
            this.btnKirim.Location = new System.Drawing.Point(423, 622);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(2);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnKirim.PressedDepth = 50;
            this.btnKirim.Size = new System.Drawing.Size(339, 37);
            this.btnKirim.TabIndex = 78;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseTransparentBackground = true;
            // 
            // tblKeranjang
            // 
            this.tblKeranjang.AllowUserToAddRows = false;
            this.tblKeranjang.AllowUserToDeleteRows = false;
            this.tblKeranjang.AllowUserToResizeColumns = false;
            this.tblKeranjang.AllowUserToResizeRows = false;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKeranjang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle60;
            this.tblKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblKeranjang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKeranjang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblKeranjang.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.tblKeranjang.ColumnHeadersHeight = 40;
            this.tblKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_keranjang,
            this.id_obat_keranjang,
            this.nama_obat_keranjang,
            this.harga_obat_keranjang,
            this.jumlah,
            this.total_satuan});
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblKeranjang.DefaultCellStyle = dataGridViewCellStyle64;
            this.tblKeranjang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblKeranjang.Location = new System.Drawing.Point(41, 330);
            this.tblKeranjang.MultiSelect = false;
            this.tblKeranjang.Name = "tblKeranjang";
            this.tblKeranjang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblKeranjang.RowHeadersVisible = false;
            this.tblKeranjang.RowHeadersWidth = 4;
            this.tblKeranjang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblKeranjang.RowTemplate.Height = 30;
            this.tblKeranjang.Size = new System.Drawing.Size(721, 222);
            this.tblKeranjang.TabIndex = 80;
            this.tblKeranjang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblKeranjang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKeranjang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblKeranjang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKeranjang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKeranjang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKeranjang.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKeranjang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblKeranjang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKeranjang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblKeranjang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblKeranjang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblKeranjang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblKeranjang.ThemeStyle.HeaderStyle.Height = 40;
            this.tblKeranjang.ThemeStyle.ReadOnly = false;
            this.tblKeranjang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblKeranjang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblKeranjang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblKeranjang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKeranjang.ThemeStyle.RowsStyle.Height = 30;
            this.tblKeranjang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKeranjang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            // 
            // no_keranjang
            // 
            this.no_keranjang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_keranjang.HeaderText = "No";
            this.no_keranjang.Name = "no_keranjang";
            this.no_keranjang.Width = 40;
            // 
            // id_obat_keranjang
            // 
            this.id_obat_keranjang.HeaderText = "ID Obat";
            this.id_obat_keranjang.Name = "id_obat_keranjang";
            this.id_obat_keranjang.ReadOnly = true;
            // 
            // nama_obat_keranjang
            // 
            this.nama_obat_keranjang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_obat_keranjang.HeaderText = "Nama  Obat";
            this.nama_obat_keranjang.Name = "nama_obat_keranjang";
            this.nama_obat_keranjang.ReadOnly = true;
            // 
            // harga_obat_keranjang
            // 
            this.harga_obat_keranjang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle62.Format = "C0";
            dataGridViewCellStyle62.NullValue = null;
            this.harga_obat_keranjang.DefaultCellStyle = dataGridViewCellStyle62;
            this.harga_obat_keranjang.HeaderText = "Harga";
            this.harga_obat_keranjang.Name = "harga_obat_keranjang";
            this.harga_obat_keranjang.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            // 
            // total_satuan
            // 
            this.total_satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle63.Format = "C0";
            this.total_satuan.DefaultCellStyle = dataGridViewCellStyle63;
            this.total_satuan.HeaderText = "Total Harga";
            this.total_satuan.Name = "total_satuan";
            this.total_satuan.ReadOnly = true;
            // 
            // tblResep
            // 
            this.tblResep.AllowUserToAddRows = false;
            this.tblResep.AllowUserToDeleteRows = false;
            this.tblResep.AllowUserToResizeColumns = false;
            this.tblResep.AllowUserToResizeRows = false;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblResep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle65;
            this.tblResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblResep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblResep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblResep.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblResep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle66;
            this.tblResep.ColumnHeadersHeight = 40;
            this.tblResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_resep});
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblResep.DefaultCellStyle = dataGridViewCellStyle67;
            this.tblResep.Enabled = false;
            this.tblResep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblResep.Location = new System.Drawing.Point(827, 455);
            this.tblResep.MultiSelect = false;
            this.tblResep.Name = "tblResep";
            this.tblResep.ReadOnly = true;
            this.tblResep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblResep.RowHeadersVisible = false;
            this.tblResep.RowHeadersWidth = 4;
            this.tblResep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblResep.RowTemplate.Height = 30;
            this.tblResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblResep.Size = new System.Drawing.Size(721, 203);
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
            // tblObat
            // 
            this.tblObat.AllowUserToAddRows = false;
            this.tblObat.AllowUserToDeleteRows = false;
            this.tblObat.AllowUserToResizeColumns = false;
            this.tblObat.AllowUserToResizeRows = false;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle68;
            this.tblObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblObat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblObat.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle69;
            this.tblObat.ColumnHeadersHeight = 40;
            this.tblObat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_obat});
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblObat.DefaultCellStyle = dataGridViewCellStyle70;
            this.tblObat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblObat.Location = new System.Drawing.Point(827, 239);
            this.tblObat.MultiSelect = false;
            this.tblObat.Name = "tblObat";
            this.tblObat.ReadOnly = true;
            this.tblObat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblObat.RowHeadersVisible = false;
            this.tblObat.RowHeadersWidth = 4;
            this.tblObat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblObat.RowTemplate.Height = 30;
            this.tblObat.Size = new System.Drawing.Size(721, 203);
            this.tblObat.TabIndex = 80;
            this.tblObat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblObat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblObat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblObat.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblObat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblObat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblObat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblObat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblObat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblObat.ThemeStyle.HeaderStyle.Height = 40;
            this.tblObat.ThemeStyle.ReadOnly = true;
            this.tblObat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblObat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblObat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.tblObat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.RowsStyle.Height = 30;
            this.tblObat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblObat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            // 
            // no_obat
            // 
            this.no_obat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_obat.HeaderText = "No";
            this.no_obat.Name = "no_obat";
            this.no_obat.ReadOnly = true;
            this.no_obat.Width = 40;
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
            this.txKeterangan.Location = new System.Drawing.Point(158, 283);
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
            // 
            // txDiagnosa
            // 
            this.txDiagnosa.Animated = true;
            this.txDiagnosa.AutoRoundedCorners = true;
            this.txDiagnosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.BorderRadius = 17;
            this.txDiagnosa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txDiagnosa.BorderThickness = 2;
            this.txDiagnosa.Cursor = System.Windows.Forms.Cursors.Default;
            this.txDiagnosa.DefaultText = "";
            this.txDiagnosa.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txDiagnosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txDiagnosa.IconLeft = global::D_Clinic.Properties.Resources.white_diagnosa;
            this.txDiagnosa.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txDiagnosa.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txDiagnosa.Location = new System.Drawing.Point(158, 230);
            this.txDiagnosa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txDiagnosa.MaxLength = 1000;
            this.txDiagnosa.Name = "txDiagnosa";
            this.txDiagnosa.PasswordChar = '\0';
            this.txDiagnosa.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.PlaceholderText = "Diagnosa";
            this.txDiagnosa.SelectedText = "";
            this.txDiagnosa.Size = new System.Drawing.Size(478, 37);
            this.txDiagnosa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txDiagnosa.TabIndex = 89;
            this.txDiagnosa.TextOffset = new System.Drawing.Point(5, 0);
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
            this.txTotalHarga.Location = new System.Drawing.Point(423, 560);
            this.txTotalHarga.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTotalHarga.MaxLength = 30;
            this.txTotalHarga.Name = "txTotalHarga";
            this.txTotalHarga.PasswordChar = '\0';
            this.txTotalHarga.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTotalHarga.PlaceholderText = "Total Harga";
            this.txTotalHarga.ReadOnly = true;
            this.txTotalHarga.SelectedText = "";
            this.txTotalHarga.Size = new System.Drawing.Size(339, 37);
            this.txTotalHarga.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTotalHarga.TabIndex = 87;
            this.txTotalHarga.TabStop = false;
            this.txTotalHarga.TextOffset = new System.Drawing.Point(5, 0);
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
            this.txDokter.TabIndex = 85;
            this.txDokter.Tag = "";
            this.txDokter.TextOffset = new System.Drawing.Point(5, 0);
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
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendaftaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2TextBox txKeterangan;
        public Guna.UI2.WinForms.Guna2TextBox txDiagnosa;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView tblPendaftaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_daftar;
        private System.Windows.Forms.Label lblTotalHarga;
        public Guna.UI2.WinForms.Guna2TextBox txTotalHarga;
        private Guna.UI2.WinForms.Guna2Button btnKurang;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        public Guna.UI2.WinForms.Guna2TextBox txDokter;
        public Guna.UI2.WinForms.Guna2TextBox txTanggal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnKirim;
        private Guna.UI2.WinForms.Guna2DataGridView tblKeranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_obat_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_satuan;
        private Guna.UI2.WinForms.Guna2DataGridView tblResep;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_resep;
        private Guna.UI2.WinForms.Guna2DataGridView tblObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_obat;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2TextBox txCariObat;
    }
}