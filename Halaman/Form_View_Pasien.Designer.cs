namespace D_Clinic.Halaman
{
    partial class Form_View_Pasien
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblPasien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golonganDarahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.radiusDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            this.txCariData = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.rbAktif = new Guna.UI2.WinForms.Guna2Button();
            this.rbSemua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
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
            this.guna2GroupBox1.Controls.Add(this.tblPasien);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 43;
            // 
            // tblPasien
            // 
            this.tblPasien.AllowUserToAddRows = false;
            this.tblPasien.AllowUserToDeleteRows = false;
            this.tblPasien.AllowUserToResizeColumns = false;
            this.tblPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPasien.AutoGenerateColumns = false;
            this.tblPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPasien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPasien.ColumnHeadersHeight = 40;
            this.tblPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.idPasienDataGridViewTextBoxColumn,
            this.pasien,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.golonganDarahDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.tblPasien.DataSource = this.pasienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPasien.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblPasien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.Location = new System.Drawing.Point(3, 4);
            this.tblPasien.MultiSelect = false;
            this.tblPasien.Name = "tblPasien";
            this.tblPasien.ReadOnly = true;
            this.tblPasien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPasien.RowHeadersVisible = false;
            this.tblPasien.RowHeadersWidth = 4;
            this.tblPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPasien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Porsche Next TT", 13F);
            this.tblPasien.RowTemplate.Height = 30;
            this.tblPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPasien.Size = new System.Drawing.Size(1578, 673);
            this.tblPasien.TabIndex = 60;
            this.tblPasien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblPasien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPasien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPasien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblPasien.ThemeStyle.HeaderStyle.Height = 40;
            this.tblPasien.ThemeStyle.ReadOnly = true;
            this.tblPasien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPasien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPasien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.ThemeStyle.RowsStyle.Height = 30;
            this.tblPasien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
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
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "ID Pasien";
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasien
            // 
            this.pasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pasien.DataPropertyName = "Nama";
            this.pasien.HeaderText = "Nama Pasien";
            this.pasien.Name = "pasien";
            this.pasien.ReadOnly = true;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 115;
            // 
            // golonganDarahDataGridViewTextBoxColumn
            // 
            this.golonganDarahDataGridViewTextBoxColumn.DataPropertyName = "Golongan_Darah";
            this.golonganDarahDataGridViewTextBoxColumn.HeaderText = "Darah";
            this.golonganDarahDataGridViewTextBoxColumn.Name = "golonganDarahDataGridViewTextBoxColumn";
            this.golonganDarahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpDataGridViewTextBoxColumn
            // 
            this.telpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telpDataGridViewTextBoxColumn.DataPropertyName = "Telp";
            this.telpDataGridViewTextBoxColumn.HeaderText = "No Telelpon";
            this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
            this.telpDataGridViewTextBoxColumn.ReadOnly = true;
            this.telpDataGridViewTextBoxColumn.Width = 180;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
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
            // radiusDGV
            // 
            this.radiusDGV.BorderRadius = 30;
            this.radiusDGV.TargetControl = this.tblPasien;
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
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
            this.txCariData.TabIndex = 42;
            this.txCariData.TabStop = false;
            this.txCariData.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariData.TextChanged += new System.EventHandler(this.txCariData_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1715, 131);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pasien";
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
            this.rbNonAktif.TabIndex = 70;
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
            this.rbAktif.TabIndex = 71;
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
            this.rbSemua.TabIndex = 72;
            this.rbSemua.Text = "Semua Data";
            this.rbSemua.UseTransparentBackground = true;
            this.rbSemua.Click += new System.EventHandler(this.CariData);
            // 
            // Form_View_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.rbNonAktif);
            this.Controls.Add(this.rbAktif);
            this.Controls.Add(this.rbSemua);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txCariData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_View_Pasien";
            this.Text = "Form_View_Pasien";
            this.Load += new System.EventHandler(this.Form_View_Pasien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2TextBox txCariData;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPasien;
        private Guna.UI2.WinForms.Guna2Elipse radiusDGV;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golonganDarahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button rbNonAktif;
        private Guna.UI2.WinForms.Guna2Button rbAktif;
        private Guna.UI2.WinForms.Guna2Button rbSemua;
    }
}