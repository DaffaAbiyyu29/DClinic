namespace D_Clinic.Halaman
{
    partial class Form_Master_Rekam_Medis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tblPasien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            this.txCariPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txDiagnosa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKembali = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_Pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
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
            this.label1.TabIndex = 43;
            this.label1.Text = "Rekam Medis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCari.TabIndex = 58;
            this.btnCari.Text = "Cari";
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.txDiagnosa);
            this.guna2GroupBox1.Controls.Add(this.dtpTanggal);
            this.guna2GroupBox1.Controls.Add(this.tblPasien);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.btnSimpan);
            this.guna2GroupBox1.Controls.Add(this.btnKembali);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.txPasien);
            this.guna2GroupBox1.Controls.Add(this.txID);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 56;
            this.guna2GroupBox1.Text = "Detail Pendafaran";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Animated = true;
            this.dtpTanggal.BackColor = System.Drawing.Color.Transparent;
            this.dtpTanggal.BorderColor = System.Drawing.Color.White;
            this.dtpTanggal.BorderRadius = 10;
            this.dtpTanggal.BorderThickness = 2;
            this.dtpTanggal.Checked = true;
            this.dtpTanggal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggal.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggal.CustomizableEdges.BottomLeft = false;
            this.dtpTanggal.CustomizableEdges.TopRight = false;
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggal.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpTanggal.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.dtpTanggal.ForeColor = System.Drawing.Color.White;
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTanggal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggal.Location = new System.Drawing.Point(100, 177);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(1899, 6, 24, 0, 0, 0, 0);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpTanggal.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpTanggal.Size = new System.Drawing.Size(478, 36);
            this.dtpTanggal.TabIndex = 82;
            this.dtpTanggal.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpTanggal.UseTransparentBackground = true;
            this.dtpTanggal.Value = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            // 
            // tblPasien
            // 
            this.tblPasien.AllowUserToAddRows = false;
            this.tblPasien.AllowUserToDeleteRows = false;
            this.tblPasien.AllowUserToResizeColumns = false;
            this.tblPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblPasien.AutoGenerateColumns = false;
            this.tblPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPasien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tblPasien.ColumnHeadersHeight = 40;
            this.tblPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.id_pasien,
            this.nama_Pasien,
            this.gender,
            this.darah});
            this.tblPasien.DataSource = this.pasienBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Porsche Next TT", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPasien.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.tblPasien.Size = new System.Drawing.Size(721, 637);
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
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSimpan.Location = new System.Drawing.Point(138, 505);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnSimpan.PressedDepth = 50;
            this.btnSimpan.Size = new System.Drawing.Size(412, 37);
            this.btnSimpan.TabIndex = 78;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseTransparentBackground = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
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
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
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
            this.txCariPasien.PlaceholderText = "Search";
            this.txCariPasien.SelectedText = "";
            this.txCariPasien.Size = new System.Drawing.Size(232, 37);
            this.txCariPasien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariPasien.TabIndex = 57;
            this.txCariPasien.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariPasien.TextChanged += new System.EventHandler(this.txCariPasien_TextChanged);
            // 
            // txDiagnosa
            // 
            this.txDiagnosa.Animated = true;
            this.txDiagnosa.AutoRoundedCorners = true;
            this.txDiagnosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.BorderRadius = 69;
            this.txDiagnosa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txDiagnosa.BorderThickness = 2;
            this.txDiagnosa.Cursor = System.Windows.Forms.Cursors.Default;
            this.txDiagnosa.DefaultText = "";
            this.txDiagnosa.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txDiagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txDiagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.Enabled = false;
            this.txDiagnosa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txDiagnosa.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.txDiagnosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txDiagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txDiagnosa.IconLeft = global::D_Clinic.Properties.Resources.white_diagnosa;
            this.txDiagnosa.IconLeftOffset = new System.Drawing.Point(0, -50);
            this.txDiagnosa.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txDiagnosa.Location = new System.Drawing.Point(100, 230);
            this.txDiagnosa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txDiagnosa.MaxLength = 1000;
            this.txDiagnosa.Name = "txDiagnosa";
            this.txDiagnosa.PasswordChar = '\0';
            this.txDiagnosa.PlaceholderForeColor = System.Drawing.Color.White;
            this.txDiagnosa.PlaceholderText = "Diagnosa";
            this.txDiagnosa.SelectedText = "";
            this.txDiagnosa.Size = new System.Drawing.Size(478, 140);
            this.txDiagnosa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txDiagnosa.TabIndex = 83;
            this.txDiagnosa.TextOffset = new System.Drawing.Point(5, -45);
            this.txDiagnosa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gambar_KeyPress);
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
            this.txPasien.Location = new System.Drawing.Point(100, 124);
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
            this.txPasien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gambar_KeyPress);
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
            this.txID.PlaceholderText = "ID Rekam Medis";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(478, 37);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            this.txID.TextOffset = new System.Drawing.Point(5, 0);
            this.txID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gambar_KeyPress);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // id_pasien
            // 
            this.id_pasien.DataPropertyName = "Id_Pasien";
            this.id_pasien.HeaderText = "ID Pasien";
            this.id_pasien.Name = "id_pasien";
            this.id_pasien.ReadOnly = true;
            // 
            // nama_Pasien
            // 
            this.nama_Pasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_Pasien.DataPropertyName = "Nama";
            this.nama_Pasien.HeaderText = "Nama Pasien";
            this.nama_Pasien.Name = "nama_Pasien";
            this.nama_Pasien.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gender.DataPropertyName = "Jenis_Kelamin";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 150;
            // 
            // darah
            // 
            this.darah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.darah.DataPropertyName = "Golongan_Darah";
            this.darah.HeaderText = "Darah";
            this.darah.Name = "darah";
            this.darah.ReadOnly = true;
            this.darah.Width = 80;
            // 
            // Form_Rekam_Medis
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
            this.Name = "Form_Rekam_Medis";
            this.Text = "Form_Rekam_Medis";
            this.Load += new System.EventHandler(this.Form_Rekam_Medis_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txCariPasien;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPasien;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2ImageButton btnKembali;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2TextBox txPasien;
        public Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggal;
        private Guna.UI2.WinForms.Guna2TextBox txDiagnosa;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_Pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn darah;
    }
}