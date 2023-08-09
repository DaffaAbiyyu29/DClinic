namespace D_Clinic.Halaman
{
    partial class Form_Master_Karyawan
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTampilPass = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAktif = new Guna.UI2.WinForms.Guna2Button();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCariGambar = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapusGambar = new Guna.UI2.WinForms.Guna2Button();
            this.imgProfil = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.imgJabatan = new System.Windows.Forms.PictureBox();
            this.cbJabatan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.txNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.txCariKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJabatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
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
            this.guna2GroupBox1.Controls.Add(this.btnCari);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.Controls.Add(this.btnTambah);
            this.guna2GroupBox1.Controls.Add(this.txCariKaryawan);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 140);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 746);
            this.guna2GroupBox1.TabIndex = 34;
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
            this.guna2GroupBox2.Controls.Add(this.btnTampilPass);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.btnAktif);
            this.guna2GroupBox2.Controls.Add(this.lblJabatan);
            this.guna2GroupBox2.Controls.Add(this.panel1);
            this.guna2GroupBox2.Controls.Add(this.btnCariGambar);
            this.guna2GroupBox2.Controls.Add(this.btnHapusGambar);
            this.guna2GroupBox2.Controls.Add(this.imgProfil);
            this.guna2GroupBox2.Controls.Add(this.btnBatal);
            this.guna2GroupBox2.Controls.Add(this.imgJabatan);
            this.guna2GroupBox2.Controls.Add(this.cbJabatan);
            this.guna2GroupBox2.Controls.Add(this.btnSimpan);
            this.guna2GroupBox2.Controls.Add(this.btnUpdate);
            this.guna2GroupBox2.Controls.Add(this.txID);
            this.guna2GroupBox2.Controls.Add(this.btnNonAktif);
            this.guna2GroupBox2.Controls.Add(this.txNama);
            this.guna2GroupBox2.Controls.Add(this.txTelp);
            this.guna2GroupBox2.Controls.Add(this.txEmail);
            this.guna2GroupBox2.Controls.Add(this.txUsername);
            this.guna2GroupBox2.Controls.Add(this.txPassword);
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
            // btnTampilPass
            // 
            this.btnTampilPass.Animated = true;
            this.btnTampilPass.BackColor = System.Drawing.Color.Transparent;
            this.btnTampilPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTampilPass.BorderRadius = 20;
            this.btnTampilPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTampilPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampilPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampilPass.FillColor = System.Drawing.Color.Transparent;
            this.btnTampilPass.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.btnTampilPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTampilPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnTampilPass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnTampilPass.Image = global::D_Clinic.Properties.Resources.hide_pass;
            this.btnTampilPass.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTampilPass.Location = new System.Drawing.Point(548, 336);
            this.btnTampilPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilPass.Name = "btnTampilPass";
            this.btnTampilPass.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTampilPass.PressedDepth = 50;
            this.btnTampilPass.Size = new System.Drawing.Size(30, 30);
            this.btnTampilPass.TabIndex = 72;
            this.btnTampilPass.UseTransparentBackground = true;
            this.btnTampilPass.Click += new System.EventHandler(this.btnTampilPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Detail Karyawan";
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
            this.btnAktif.TabIndex = 60;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseTransparentBackground = true;
            this.btnAktif.Visible = false;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // lblJabatan
            // 
            this.lblJabatan.BackColor = System.Drawing.Color.Transparent;
            this.lblJabatan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.ForeColor = System.Drawing.Color.White;
            this.lblJabatan.Location = new System.Drawing.Point(143, 391);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(83, 31);
            this.lblJabatan.TabIndex = 59;
            this.lblJabatan.Text = "Jabatan";
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
            // btnCariGambar
            // 
            this.btnCariGambar.Animated = true;
            this.btnCariGambar.BackColor = System.Drawing.Color.Transparent;
            this.btnCariGambar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.BorderRadius = 10;
            this.btnCariGambar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCariGambar.BorderThickness = 2;
            this.btnCariGambar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnCariGambar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.Enabled = false;
            this.btnCariGambar.FillColor = System.Drawing.Color.Transparent;
            this.btnCariGambar.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCariGambar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnCariGambar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnCariGambar.Location = new System.Drawing.Point(861, 444);
            this.btnCariGambar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariGambar.Name = "btnCariGambar";
            this.btnCariGambar.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCariGambar.PressedDepth = 50;
            this.btnCariGambar.Size = new System.Drawing.Size(204, 37);
            this.btnCariGambar.TabIndex = 56;
            this.btnCariGambar.Text = "Cari Gambar";
            this.btnCariGambar.UseTransparentBackground = true;
            this.btnCariGambar.Click += new System.EventHandler(this.btnCariGambar_Click);
            // 
            // btnHapusGambar
            // 
            this.btnHapusGambar.Animated = true;
            this.btnHapusGambar.BackColor = System.Drawing.Color.Transparent;
            this.btnHapusGambar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapusGambar.BorderRadius = 10;
            this.btnHapusGambar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnHapusGambar.BorderThickness = 2;
            this.btnHapusGambar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapusGambar.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapusGambar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnHapusGambar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapusGambar.Enabled = false;
            this.btnHapusGambar.FillColor = System.Drawing.Color.Transparent;
            this.btnHapusGambar.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnHapusGambar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapusGambar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapusGambar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapusGambar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnHapusGambar.Location = new System.Drawing.Point(1069, 444);
            this.btnHapusGambar.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapusGambar.Name = "btnHapusGambar";
            this.btnHapusGambar.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnHapusGambar.PressedDepth = 50;
            this.btnHapusGambar.Size = new System.Drawing.Size(204, 37);
            this.btnHapusGambar.TabIndex = 26;
            this.btnHapusGambar.Text = "Hapus Gambar";
            this.btnHapusGambar.UseTransparentBackground = true;
            this.btnHapusGambar.Click += new System.EventHandler(this.btnHapusGambar_Click);
            // 
            // imgProfil
            // 
            this.imgProfil.BackColor = System.Drawing.Color.Transparent;
            this.imgProfil.BorderRadius = 5;
            this.imgProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgProfil.ImageRotate = 0F;
            this.imgProfil.Location = new System.Drawing.Point(937, 83);
            this.imgProfil.Name = "imgProfil";
            this.imgProfil.Size = new System.Drawing.Size(262, 330);
            this.imgProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfil.TabIndex = 57;
            this.imgProfil.TabStop = false;
            this.imgProfil.UseTransparentBackground = true;
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
            this.btnBatal.Location = new System.Drawing.Point(861, 505);
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
            // imgJabatan
            // 
            this.imgJabatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgJabatan.Image = global::D_Clinic.Properties.Resources.white_jabatan;
            this.imgJabatan.Location = new System.Drawing.Point(101, 387);
            this.imgJabatan.Margin = new System.Windows.Forms.Padding(2);
            this.imgJabatan.Name = "imgJabatan";
            this.imgJabatan.Size = new System.Drawing.Size(30, 30);
            this.imgJabatan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJabatan.TabIndex = 29;
            this.imgJabatan.TabStop = false;
            // 
            // cbJabatan
            // 
            this.cbJabatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbJabatan.BorderColor = System.Drawing.Color.White;
            this.cbJabatan.BorderThickness = 2;
            this.cbJabatan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbJabatan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbJabatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJabatan.Enabled = false;
            this.cbJabatan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbJabatan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbJabatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbJabatan.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbJabatan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbJabatan.ForeColor = System.Drawing.Color.White;
            this.cbJabatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbJabatan.ItemHeight = 30;
            this.cbJabatan.Items.AddRange(new object[] {
            "Manager",
            "Resepsionis",
            "Dokter",
            "Apoteker"});
            this.cbJabatan.Location = new System.Drawing.Point(100, 389);
            this.cbJabatan.Margin = new System.Windows.Forms.Padding(2);
            this.cbJabatan.Name = "cbJabatan";
            this.cbJabatan.Size = new System.Drawing.Size(478, 36);
            this.cbJabatan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbJabatan.TabIndex = 28;
            this.cbJabatan.TextOffset = new System.Drawing.Point(40, 0);
            this.cbJabatan.SelectedIndexChanged += new System.EventHandler(this.cbJabatan_SelectedIndexChanged);
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
            this.txID.IconLeft = global::D_Clinic.Properties.Resources.white_id_card;
            this.txID.IconLeftOffset = new System.Drawing.Point(0, 3);
            this.txID.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txID.Location = new System.Drawing.Point(100, 71);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Karyawan";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
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
            this.btnNonAktif.Text = "Non Aktif";
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
            this.txNama.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txNama.Location = new System.Drawing.Point(100, 124);
            this.txNama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txNama.MaxLength = 30;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.PlaceholderText = "Nama Karyawan";
            this.txNama.SelectedText = "";
            this.txNama.Size = new System.Drawing.Size(478, 37);
            this.txNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txNama.TabIndex = 20;
            this.txNama.TextOffset = new System.Drawing.Point(5, 0);
            this.txNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNama_KeyPress);
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
            this.txTelp.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txTelp.Location = new System.Drawing.Point(100, 177);
            this.txTelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTelp.MaxLength = 13;
            this.txTelp.Name = "txTelp";
            this.txTelp.PasswordChar = '\0';
            this.txTelp.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTelp.PlaceholderText = "Telepon";
            this.txTelp.SelectedText = "";
            this.txTelp.Size = new System.Drawing.Size(478, 37);
            this.txTelp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTelp.TabIndex = 20;
            this.txTelp.TextOffset = new System.Drawing.Point(5, 0);
            this.txTelp.TextChanged += new System.EventHandler(this.txTelp_TextChanged_1);
            this.txTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txEmail
            // 
            this.txEmail.Animated = true;
            this.txEmail.AutoRoundedCorners = true;
            this.txEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEmail.BorderColor = System.Drawing.Color.White;
            this.txEmail.BorderRadius = 17;
            this.txEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txEmail.BorderThickness = 2;
            this.txEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txEmail.DefaultText = "";
            this.txEmail.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEmail.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEmail.Enabled = false;
            this.txEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEmail.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEmail.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txEmail.IconLeft = global::D_Clinic.Properties.Resources.white_email;
            this.txEmail.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txEmail.Location = new System.Drawing.Point(100, 230);
            this.txEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txEmail.MaxLength = 30;
            this.txEmail.Name = "txEmail";
            this.txEmail.PasswordChar = '\0';
            this.txEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEmail.PlaceholderText = "Email";
            this.txEmail.SelectedText = "";
            this.txEmail.Size = new System.Drawing.Size(478, 37);
            this.txEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txEmail.TabIndex = 20;
            this.txEmail.TextOffset = new System.Drawing.Point(5, 0);
            this.txEmail.TextChanged += new System.EventHandler(this.txEmail_TextChanged);
            // 
            // txUsername
            // 
            this.txUsername.Animated = true;
            this.txUsername.AutoRoundedCorners = true;
            this.txUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txUsername.BorderColor = System.Drawing.Color.White;
            this.txUsername.BorderRadius = 17;
            this.txUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txUsername.BorderThickness = 2;
            this.txUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txUsername.DefaultText = "";
            this.txUsername.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txUsername.Enabled = false;
            this.txUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txUsername.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txUsername.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txUsername.IconLeft = global::D_Clinic.Properties.Resources.white_user;
            this.txUsername.IconLeftOffset = new System.Drawing.Point(0, -3);
            this.txUsername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txUsername.Location = new System.Drawing.Point(100, 283);
            this.txUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txUsername.MaxLength = 15;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txUsername.PlaceholderText = "Username";
            this.txUsername.SelectedText = "";
            this.txUsername.Size = new System.Drawing.Size(478, 37);
            this.txUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txUsername.TabIndex = 20;
            this.txUsername.TextOffset = new System.Drawing.Point(5, 0);
            this.txUsername.TextChanged += new System.EventHandler(this.txUsername_TextChanged);
            // 
            // txPassword
            // 
            this.txPassword.Animated = true;
            this.txPassword.AutoRoundedCorners = true;
            this.txPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPassword.BorderColor = System.Drawing.Color.White;
            this.txPassword.BorderRadius = 17;
            this.txPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txPassword.BorderThickness = 2;
            this.txPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txPassword.DefaultText = "";
            this.txPassword.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPassword.Enabled = false;
            this.txPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPassword.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txPassword.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPassword.IconLeft = global::D_Clinic.Properties.Resources.white_pass;
            this.txPassword.IconLeftOffset = new System.Drawing.Point(0, -3);
            this.txPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txPassword.Location = new System.Drawing.Point(100, 336);
            this.txPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txPassword.MaxLength = 15;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '\0';
            this.txPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPassword.PlaceholderText = "Password";
            this.txPassword.SelectedText = "";
            this.txPassword.Size = new System.Drawing.Size(478, 37);
            this.txPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txPassword.TabIndex = 20;
            this.txPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.txPassword.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
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
            this.btnTambah.Text = "Tambah Karyawan";
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txCariKaryawan
            // 
            this.txCariKaryawan.Animated = true;
            this.txCariKaryawan.AutoRoundedCorners = true;
            this.txCariKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariKaryawan.BorderColor = System.Drawing.Color.White;
            this.txCariKaryawan.BorderRadius = 17;
            this.txCariKaryawan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariKaryawan.BorderThickness = 2;
            this.txCariKaryawan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariKaryawan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariKaryawan.DefaultText = "";
            this.txCariKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariKaryawan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariKaryawan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariKaryawan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariKaryawan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariKaryawan.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariKaryawan.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariKaryawan.Location = new System.Drawing.Point(1128, 46);
            this.txCariKaryawan.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariKaryawan.MaxLength = 30;
            this.txCariKaryawan.Name = "txCariKaryawan";
            this.txCariKaryawan.PasswordChar = '\0';
            this.txCariKaryawan.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariKaryawan.PlaceholderText = "Cari Karyawan";
            this.txCariKaryawan.SelectedText = "";
            this.txCariKaryawan.Size = new System.Drawing.Size(232, 37);
            this.txCariKaryawan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariKaryawan.TabIndex = 47;
            this.txCariKaryawan.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariKaryawan.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Text = "Karyawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            // 
            // Form_Master_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Master_Karyawan";
            this.Text = "Form_Master_Karyawan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Master_Karyawan_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJabatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txCariKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnCariGambar;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private System.Windows.Forms.PictureBox imgJabatan;
        private Guna.UI2.WinForms.Guna2ComboBox cbJabatan;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2Button btnNonAktif;
        private Guna.UI2.WinForms.Guna2TextBox txNama;
        private Guna.UI2.WinForms.Guna2TextBox txTelp;
        private Guna.UI2.WinForms.Guna2TextBox txEmail;
        private Guna.UI2.WinForms.Guna2TextBox txUsername;
        private Guna.UI2.WinForms.Guna2TextBox txPassword;
        private Guna.UI2.WinForms.Guna2PictureBox imgProfil;
        private Guna.UI2.WinForms.Guna2Button btnHapusGambar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJabatan;
        private Guna.UI2.WinForms.Guna2Button btnAktif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private Guna.UI2.WinForms.Guna2Button btnTampilPass;
    }
}