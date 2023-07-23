namespace D_Clinic.Halaman
{
    partial class Form_View_Karyawan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarif_Jasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet1 = new D_Clinic.DClinicDataSet();
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.radiusDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txCariData = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.karyawanTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.KaryawanTableAdapter();
            this.rbSemua = new Guna.UI2.WinForms.Guna2Button();
            this.rbAktif = new Guna.UI2.WinForms.Guna2Button();
            this.rbNonAktif = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 40;
            this.radiusForm.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.tblKaryawan);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 38;
            // 
            // tblKaryawan
            // 
            this.tblKaryawan.AllowUserToAddRows = false;
            this.tblKaryawan.AllowUserToDeleteRows = false;
            this.tblKaryawan.AllowUserToResizeColumns = false;
            this.tblKaryawan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblKaryawan.AutoGenerateColumns = false;
            this.tblKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblKaryawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKaryawan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblKaryawan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblKaryawan.ColumnHeadersHeight = 40;
            this.tblKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Tarif_Jasa,
            this.idKaryawanDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.Image,
            this.statusDataGridViewTextBoxColumn});
            this.tblKaryawan.DataSource = this.karyawanBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblKaryawan.DefaultCellStyle = dataGridViewCellStyle6;
            this.tblKaryawan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKaryawan.Location = new System.Drawing.Point(3, 4);
            this.tblKaryawan.MultiSelect = false;
            this.tblKaryawan.Name = "tblKaryawan";
            this.tblKaryawan.ReadOnly = true;
            this.tblKaryawan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblKaryawan.RowHeadersVisible = false;
            this.tblKaryawan.RowHeadersWidth = 4;
            this.tblKaryawan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKaryawan.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblKaryawan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold);
            this.tblKaryawan.RowTemplate.Height = 50;
            this.tblKaryawan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tblKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblKaryawan.Size = new System.Drawing.Size(1578, 673);
            this.tblKaryawan.TabIndex = 63;
            this.tblKaryawan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblKaryawan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKaryawan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblKaryawan.ThemeStyle.HeaderStyle.Height = 40;
            this.tblKaryawan.ThemeStyle.ReadOnly = true;
            this.tblKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.Height = 50;
            this.tblKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKaryawan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblKaryawan_RowPostPaint);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 40;
            // 
            // Tarif_Jasa
            // 
            this.Tarif_Jasa.DataPropertyName = "Tarif_Jasa";
            this.Tarif_Jasa.HeaderText = "Tarif";
            this.Tarif_Jasa.Name = "Tarif_Jasa";
            this.Tarif_Jasa.ReadOnly = true;
            this.Tarif_Jasa.Visible = false;
            this.Tarif_Jasa.Width = 69;
            // 
            // idKaryawanDataGridViewTextBoxColumn
            // 
            this.idKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Id_Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.HeaderText = "ID Karyawan";
            this.idKaryawanDataGridViewTextBoxColumn.Name = "idKaryawanDataGridViewTextBoxColumn";
            this.idKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKaryawanDataGridViewTextBoxColumn.Width = 127;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpDataGridViewTextBoxColumn
            // 
            this.telpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telpDataGridViewTextBoxColumn.DataPropertyName = "Telp";
            this.telpDataGridViewTextBoxColumn.HeaderText = "No Telp";
            this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
            this.telpDataGridViewTextBoxColumn.ReadOnly = true;
            this.telpDataGridViewTextBoxColumn.Width = 140;
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            this.jabatanDataGridViewTextBoxColumn.ReadOnly = true;
            this.jabatanDataGridViewTextBoxColumn.Width = 120;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.DataPropertyName = "Foto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "System.Drawing.Bitmap";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.DefaultCellStyle = dataGridViewCellStyle4;
            this.Image.HeaderText = "Foto";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 50;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.dClinicDataSet1;
            // 
            // dClinicDataSet1
            // 
            this.dClinicDataSet1.DataSetName = "DClinicDataSet";
            this.dClinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radiusDGV
            // 
            this.radiusDGV.BorderRadius = 30;
            this.radiusDGV.TargetControl = this.tblKaryawan;
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
            this.txCariData.TabIndex = 39;
            this.txCariData.TabStop = false;
            this.txCariData.TextOffset = new System.Drawing.Point(5, 0);
            this.txCariData.TextChanged += new System.EventHandler(this.txCariData_TextChanged);
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
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
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
            this.rbSemua.TabIndex = 66;
            this.rbSemua.Text = "Semua Data";
            this.rbSemua.UseTransparentBackground = true;
            this.rbSemua.Click += new System.EventHandler(this.CariData);
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
            this.rbAktif.TabIndex = 66;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseTransparentBackground = true;
            this.rbAktif.Click += new System.EventHandler(this.CariData);
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
            this.rbNonAktif.TabIndex = 66;
            this.rbNonAktif.Text = "Non-Aktif";
            this.rbNonAktif.UseTransparentBackground = true;
            this.rbNonAktif.Click += new System.EventHandler(this.CariData);
            // 
            // Form_View_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.rbNonAktif);
            this.Controls.Add(this.rbAktif);
            this.Controls.Add(this.rbSemua);
            this.Controls.Add(this.txCariData);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_View_Karyawan";
            this.Text = "Form_View_Apoteker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_View_Karyawan_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private DClinicDataSet dClinicDataSet;
        private Guna.UI2.WinForms.Guna2Elipse radiusDGV;
        public Guna.UI2.WinForms.Guna2TextBox txCariData;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView tblKaryawan;
        private DClinicDataSet dClinicDataSet1;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private DClinicDataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarif_Jasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button rbSemua;
        private Guna.UI2.WinForms.Guna2Button rbNonAktif;
        private Guna.UI2.WinForms.Guna2Button rbAktif;
    }
}