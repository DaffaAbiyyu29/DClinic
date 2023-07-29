namespace D_Clinic.Halaman
{
    partial class Form_Master_Obat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Master_Obat));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txCariObat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTanggalKadaluarsa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpKadaluarsa = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAktif = new Guna.UI2.WinForms.Guna2Button();
            this.lblKemasan = new System.Windows.Forms.Label();
            this.imgKemasan = new System.Windows.Forms.PictureBox();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.cbKemasan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.txNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txHargaBeli = new Guna.UI2.WinForms.Guna2TextBox();
            this.txHargaJual = new Guna.UI2.WinForms.Guna2TextBox();
            this.txMerk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txEfek = new Guna.UI2.WinForms.Guna2TextBox();
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.gbTanggalKadaluarsa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKemasan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.txCariObat);
            this.guna2GroupBox1.Controls.Add(this.btnTambah);
            this.guna2GroupBox1.Controls.Add(this.btnCari);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 140);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 746);
            this.guna2GroupBox1.TabIndex = 36;
            // 
            // txCariObat
            // 
            this.txCariObat.Animated = true;
            this.txCariObat.AutoRoundedCorners = true;
            this.txCariObat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariObat.BorderColor = System.Drawing.Color.White;
            this.txCariObat.BorderRadius = 17;
            this.txCariObat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariObat.BorderThickness = 3;
            this.txCariObat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariObat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariObat.DefaultText = "";
            this.txCariObat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariObat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariObat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariObat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariObat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariObat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txCariObat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariObat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariObat.IconLeft = global::D_Clinic.Properties.Resources.white_magnifier;
            this.txCariObat.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txCariObat.Location = new System.Drawing.Point(1128, 46);
            this.txCariObat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariObat.MaxLength = 30;
            this.txCariObat.Name = "txCariObat";
            this.txCariObat.PasswordChar = '\0';
            this.txCariObat.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariObat.PlaceholderText = "Search";
            this.txCariObat.SelectedText = "";
            this.txCariObat.Size = new System.Drawing.Size(232, 37);
            this.txCariObat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariObat.TabIndex = 48;
            this.txCariObat.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariObat.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
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
            this.btnTambah.Text = "Tambah Obat";
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.guna2GroupBox2.Controls.Add(this.gbTanggalKadaluarsa);
            this.guna2GroupBox2.Controls.Add(this.btnAktif);
            this.guna2GroupBox2.Controls.Add(this.lblKemasan);
            this.guna2GroupBox2.Controls.Add(this.imgKemasan);
            this.guna2GroupBox2.Controls.Add(this.btnBatal);
            this.guna2GroupBox2.Controls.Add(this.cbKemasan);
            this.guna2GroupBox2.Controls.Add(this.panel1);
            this.guna2GroupBox2.Controls.Add(this.btnSimpan);
            this.guna2GroupBox2.Controls.Add(this.btnUpdate);
            this.guna2GroupBox2.Controls.Add(this.txID);
            this.guna2GroupBox2.Controls.Add(this.btnNonAktif);
            this.guna2GroupBox2.Controls.Add(this.txNama);
            this.guna2GroupBox2.Controls.Add(this.txStok);
            this.guna2GroupBox2.Controls.Add(this.txHargaBeli);
            this.guna2GroupBox2.Controls.Add(this.txHargaJual);
            this.guna2GroupBox2.Controls.Add(this.txMerk);
            this.guna2GroupBox2.Controls.Add(this.txEfek);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Detail Obat";
            // 
            // gbTanggalKadaluarsa
            // 
            this.gbTanggalKadaluarsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.gbTanggalKadaluarsa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.gbTanggalKadaluarsa.BorderThickness = 2;
            this.gbTanggalKadaluarsa.Controls.Add(this.dtpKadaluarsa);
            this.gbTanggalKadaluarsa.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.gbTanggalKadaluarsa.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.gbTanggalKadaluarsa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.gbTanggalKadaluarsa.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTanggalKadaluarsa.ForeColor = System.Drawing.Color.White;
            this.gbTanggalKadaluarsa.Location = new System.Drawing.Point(808, 230);
            this.gbTanggalKadaluarsa.Margin = new System.Windows.Forms.Padding(2);
            this.gbTanggalKadaluarsa.Name = "gbTanggalKadaluarsa";
            this.gbTanggalKadaluarsa.Size = new System.Drawing.Size(524, 93);
            this.gbTanggalKadaluarsa.TabIndex = 58;
            this.gbTanggalKadaluarsa.Text = "Tanggal Kadaluarsa";
            // 
            // dtpKadaluarsa
            // 
            this.dtpKadaluarsa.Animated = true;
            this.dtpKadaluarsa.BackColor = System.Drawing.Color.Transparent;
            this.dtpKadaluarsa.BorderColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.BorderRadius = 10;
            this.dtpKadaluarsa.BorderThickness = 2;
            this.dtpKadaluarsa.Checked = true;
            this.dtpKadaluarsa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.CustomizableEdges.BottomLeft = false;
            this.dtpKadaluarsa.CustomizableEdges.TopRight = false;
            this.dtpKadaluarsa.Enabled = false;
            this.dtpKadaluarsa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpKadaluarsa.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.dtpKadaluarsa.ForeColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKadaluarsa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.Location = new System.Drawing.Point(12, 40);
            this.dtpKadaluarsa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKadaluarsa.MinDate = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpKadaluarsa.Name = "dtpKadaluarsa";
            this.dtpKadaluarsa.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpKadaluarsa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpKadaluarsa.Size = new System.Drawing.Size(478, 36);
            this.dtpKadaluarsa.TabIndex = 27;
            this.dtpKadaluarsa.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpKadaluarsa.UseTransparentBackground = true;
            this.dtpKadaluarsa.Value = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpKadaluarsa.TextChanged += new System.EventHandler(this.dtpKadaluarsa_TextChanged);
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
            this.btnAktif.TabIndex = 61;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseTransparentBackground = true;
            this.btnAktif.Visible = false;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // lblKemasan
            // 
            this.lblKemasan.BackColor = System.Drawing.Color.Transparent;
            this.lblKemasan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKemasan.ForeColor = System.Drawing.Color.White;
            this.lblKemasan.Location = new System.Drawing.Point(143, 233);
            this.lblKemasan.Name = "lblKemasan";
            this.lblKemasan.Size = new System.Drawing.Size(91, 31);
            this.lblKemasan.TabIndex = 60;
            this.lblKemasan.Text = "Kemasan";
            // 
            // imgKemasan
            // 
            this.imgKemasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgKemasan.Image = global::D_Clinic.Properties.Resources.white_kemasan;
            this.imgKemasan.Location = new System.Drawing.Point(103, 228);
            this.imgKemasan.Margin = new System.Windows.Forms.Padding(2);
            this.imgKemasan.Name = "imgKemasan";
            this.imgKemasan.Size = new System.Drawing.Size(33, 33);
            this.imgKemasan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgKemasan.TabIndex = 22;
            this.imgKemasan.TabStop = false;
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
            // cbKemasan
            // 
            this.cbKemasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.BorderColor = System.Drawing.Color.White;
            this.cbKemasan.BorderThickness = 2;
            this.cbKemasan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbKemasan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbKemasan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKemasan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKemasan.Enabled = false;
            this.cbKemasan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbKemasan.ForeColor = System.Drawing.Color.White;
            this.cbKemasan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKemasan.ItemHeight = 30;
            this.cbKemasan.Items.AddRange(new object[] {
            "Strip",
            "Botol",
            "Sachet"});
            this.cbKemasan.Location = new System.Drawing.Point(100, 230);
            this.cbKemasan.Margin = new System.Windows.Forms.Padding(2);
            this.cbKemasan.Name = "cbKemasan";
            this.cbKemasan.Size = new System.Drawing.Size(478, 36);
            this.cbKemasan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbKemasan.TabIndex = 22;
            this.cbKemasan.TextOffset = new System.Drawing.Point(40, 0);
            this.cbKemasan.SelectedIndexChanged += new System.EventHandler(this.cbKemasan_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.panel1.Location = new System.Drawing.Point(716, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 580);
            this.panel1.TabIndex = 56;
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
            this.txID.IconLeft = global::D_Clinic.Properties.Resources.white_kode;
            this.txID.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txID.Location = new System.Drawing.Point(100, 71);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Obat";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 36);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 20;
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
            this.txNama.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txNama.Location = new System.Drawing.Point(100, 124);
            this.txNama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txNama.MaxLength = 30;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.PlaceholderText = "Nama Obat";
            this.txNama.SelectedText = "";
            this.txNama.Size = new System.Drawing.Size(478, 36);
            this.txNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txNama.TabIndex = 20;
            this.txNama.TextOffset = new System.Drawing.Point(5, 0);
            this.txNama.TextChanged += new System.EventHandler(this.txNama_TextChanged);
            // 
            // txStok
            // 
            this.txStok.Animated = true;
            this.txStok.AutoRoundedCorners = true;
            this.txStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.BorderColor = System.Drawing.Color.White;
            this.txStok.BorderRadius = 17;
            this.txStok.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txStok.BorderThickness = 2;
            this.txStok.Cursor = System.Windows.Forms.Cursors.Default;
            this.txStok.DefaultText = "";
            this.txStok.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txStok.Enabled = false;
            this.txStok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txStok.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txStok.IconLeft = global::D_Clinic.Properties.Resources.white_stock;
            this.txStok.IconLeftOffset = new System.Drawing.Point(0, -3);
            this.txStok.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txStok.Location = new System.Drawing.Point(819, 177);
            this.txStok.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txStok.MaxLength = 3;
            this.txStok.Name = "txStok";
            this.txStok.PasswordChar = '\0';
            this.txStok.PlaceholderForeColor = System.Drawing.Color.White;
            this.txStok.PlaceholderText = "Stok";
            this.txStok.SelectedText = "";
            this.txStok.Size = new System.Drawing.Size(478, 36);
            this.txStok.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txStok.TabIndex = 26;
            this.txStok.TextOffset = new System.Drawing.Point(5, 0);
            this.txStok.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            this.txStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txHargaBeli
            // 
            this.txHargaBeli.Animated = true;
            this.txHargaBeli.AutoRoundedCorners = true;
            this.txHargaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.BorderColor = System.Drawing.Color.White;
            this.txHargaBeli.BorderRadius = 17;
            this.txHargaBeli.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txHargaBeli.BorderThickness = 2;
            this.txHargaBeli.Cursor = System.Windows.Forms.Cursors.Default;
            this.txHargaBeli.DefaultText = "";
            this.txHargaBeli.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txHargaBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txHargaBeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaBeli.Enabled = false;
            this.txHargaBeli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaBeli.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txHargaBeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaBeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txHargaBeli.IconLeft = ((System.Drawing.Image)(resources.GetObject("txHargaBeli.IconLeft")));
            this.txHargaBeli.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txHargaBeli.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txHargaBeli.Location = new System.Drawing.Point(819, 71);
            this.txHargaBeli.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txHargaBeli.MaxLength = 10;
            this.txHargaBeli.Name = "txHargaBeli";
            this.txHargaBeli.PasswordChar = '\0';
            this.txHargaBeli.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaBeli.PlaceholderText = "Harga Beli";
            this.txHargaBeli.SelectedText = "";
            this.txHargaBeli.Size = new System.Drawing.Size(478, 36);
            this.txHargaBeli.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txHargaBeli.TabIndex = 24;
            this.txHargaBeli.TextOffset = new System.Drawing.Point(5, 0);
            this.txHargaBeli.TextChanged += new System.EventHandler(this.txHargaBeli_TextChanged);
            // 
            // txHargaJual
            // 
            this.txHargaJual.Animated = true;
            this.txHargaJual.AutoRoundedCorners = true;
            this.txHargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.BorderColor = System.Drawing.Color.White;
            this.txHargaJual.BorderRadius = 17;
            this.txHargaJual.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txHargaJual.BorderThickness = 2;
            this.txHargaJual.Cursor = System.Windows.Forms.Cursors.Default;
            this.txHargaJual.DefaultText = "";
            this.txHargaJual.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txHargaJual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaJual.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaJual.Enabled = false;
            this.txHargaJual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaJual.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txHargaJual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaJual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txHargaJual.IconLeft = ((System.Drawing.Image)(resources.GetObject("txHargaJual.IconLeft")));
            this.txHargaJual.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.txHargaJual.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txHargaJual.Location = new System.Drawing.Point(819, 124);
            this.txHargaJual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txHargaJual.MaxLength = 10;
            this.txHargaJual.Name = "txHargaJual";
            this.txHargaJual.PasswordChar = '\0';
            this.txHargaJual.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaJual.PlaceholderText = "Harga Jual";
            this.txHargaJual.SelectedText = "";
            this.txHargaJual.Size = new System.Drawing.Size(478, 36);
            this.txHargaJual.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txHargaJual.TabIndex = 25;
            this.txHargaJual.TextOffset = new System.Drawing.Point(5, 0);
            this.txHargaJual.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txMerk
            // 
            this.txMerk.Animated = true;
            this.txMerk.AutoRoundedCorners = true;
            this.txMerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.BorderColor = System.Drawing.Color.White;
            this.txMerk.BorderRadius = 17;
            this.txMerk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txMerk.BorderThickness = 2;
            this.txMerk.Cursor = System.Windows.Forms.Cursors.Default;
            this.txMerk.DefaultText = "";
            this.txMerk.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txMerk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txMerk.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txMerk.Enabled = false;
            this.txMerk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txMerk.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txMerk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txMerk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMerk.IconLeft = global::D_Clinic.Properties.Resources.white_merk;
            this.txMerk.IconLeftOffset = new System.Drawing.Point(0, -3);
            this.txMerk.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txMerk.Location = new System.Drawing.Point(100, 177);
            this.txMerk.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txMerk.MaxLength = 20;
            this.txMerk.Name = "txMerk";
            this.txMerk.PasswordChar = '\0';
            this.txMerk.PlaceholderForeColor = System.Drawing.Color.White;
            this.txMerk.PlaceholderText = "Merk Obat";
            this.txMerk.SelectedText = "";
            this.txMerk.Size = new System.Drawing.Size(478, 36);
            this.txMerk.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txMerk.TabIndex = 21;
            this.txMerk.TextOffset = new System.Drawing.Point(5, 0);
            this.txMerk.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txEfek
            // 
            this.txEfek.Animated = true;
            this.txEfek.AutoRoundedCorners = true;
            this.txEfek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.BorderColor = System.Drawing.Color.White;
            this.txEfek.BorderRadius = 69;
            this.txEfek.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txEfek.BorderThickness = 2;
            this.txEfek.Cursor = System.Windows.Forms.Cursors.Default;
            this.txEfek.DefaultText = "";
            this.txEfek.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txEfek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txEfek.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEfek.Enabled = false;
            this.txEfek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEfek.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txEfek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEfek.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txEfek.IconLeft = global::D_Clinic.Properties.Resources.white_efek;
            this.txEfek.IconLeftOffset = new System.Drawing.Point(0, -50);
            this.txEfek.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txEfek.Location = new System.Drawing.Point(100, 283);
            this.txEfek.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txEfek.MaxLength = 1000;
            this.txEfek.Name = "txEfek";
            this.txEfek.PasswordChar = '\0';
            this.txEfek.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEfek.PlaceholderText = "Efek Samping";
            this.txEfek.SelectedText = "";
            this.txEfek.Size = new System.Drawing.Size(478, 140);
            this.txEfek.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txEfek.TabIndex = 23;
            this.txEfek.TextOffset = new System.Drawing.Point(-5, -45);
            this.txEfek.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.TabIndex = 42;
            this.label1.Text = "Obat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            // 
            // Form_Master_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Master_Obat";
            this.Text = "Form_Master_Obat";
            this.Load += new System.EventHandler(this.Form_Master_Obat_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.gbTanggalKadaluarsa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgKemasan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbKemasan;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnNonAktif;
        private Guna.UI2.WinForms.Guna2TextBox txNama;
        private Guna.UI2.WinForms.Guna2TextBox txMerk;
        private Guna.UI2.WinForms.Guna2TextBox txEfek;
        private System.Windows.Forms.PictureBox imgKemasan;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKadaluarsa;
        private Guna.UI2.WinForms.Guna2TextBox txHargaJual;
        private Guna.UI2.WinForms.Guna2TextBox txStok;
        private DClinicDataSet dClinicDataSet;
        private Guna.UI2.WinForms.Guna2TextBox txHargaBeli;
        private Guna.UI2.WinForms.Guna2TextBox txCariObat;
        private Guna.UI2.WinForms.Guna2TextBox txID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKemasan;
        private Guna.UI2.WinForms.Guna2Button btnAktif;
        private Guna.UI2.WinForms.Guna2GroupBox gbTanggalKadaluarsa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epWarning;
    }
}