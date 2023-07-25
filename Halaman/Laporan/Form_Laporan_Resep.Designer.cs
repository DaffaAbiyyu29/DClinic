namespace D_Clinic.Halaman.Laporan
{
    partial class Form_Laporan_Resep
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laporan = new D_Clinic.Laporan();
            this.viewTrsPemberianResepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan1 = new D_Clinic.Laporan();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rpDetailResep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpResep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.radiusReportDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.radiusReport = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCariDetail = new Guna.UI2.WinForms.Guna2Button();
            this.cbResep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.view_TrsPemberianResepTableAdapter = new D_Clinic.LaporanTableAdapters.View_TrsPemberianResepTableAdapter();
            this.viewDetailObatTrsPemberianResepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetailObatTrsPemberianResepTableAdapter = new D_Clinic.LaporanTableAdapters.View_DetailObatTrsPemberianResepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailObatTrsPemberianResepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.EnforceConstraints = false;
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTrsPemberianResepBindingSource
            // 
            this.viewTrsPemberianResepBindingSource.DataMember = "View_TrsPemberianResep";
            this.viewTrsPemberianResepBindingSource.DataSource = this.laporan1;
            // 
            // laporan1
            // 
            this.laporan1.DataSetName = "Laporan";
            this.laporan1.EnforceConstraints = false;
            this.laporan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.TabIndex = 45;
            this.label1.Text = "Riwayat Resep Obat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.rpDetailResep);
            this.guna2GroupBox1.Controls.Add(this.rpResep);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 46;
            // 
            // rpDetailResep
            // 
            this.rpDetailResep.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource5.Name = "Laporan_Detail_Obat_Resep";
            reportDataSource5.Value = this.viewDetailObatTrsPemberianResepBindingSource;
            this.rpDetailResep.LocalReport.DataSources.Add(reportDataSource5);
            this.rpDetailResep.LocalReport.ReportEmbeddedResource = "D_Clinic.Halaman.Laporan.Laporan_Detail_Obat_Resep.rdlc";
            this.rpDetailResep.Location = new System.Drawing.Point(3, 3);
            this.rpDetailResep.Name = "rpDetailResep";
            this.rpDetailResep.ServerReport.BearerToken = null;
            this.rpDetailResep.Size = new System.Drawing.Size(1578, 674);
            this.rpDetailResep.TabIndex = 57;
            this.rpDetailResep.Visible = false;
            // 
            // rpResep
            // 
            this.rpResep.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource6.Name = "Laporan_Resep_Obat";
            reportDataSource6.Value = this.viewTrsPemberianResepBindingSource;
            this.rpResep.LocalReport.DataSources.Add(reportDataSource6);
            this.rpResep.LocalReport.ReportEmbeddedResource = "D_Clinic.Halaman.Laporan.Laporan_Resep_Obat.rdlc";
            this.rpResep.Location = new System.Drawing.Point(3, 3);
            this.rpResep.Name = "rpResep";
            this.rpResep.ServerReport.BearerToken = null;
            this.rpResep.Size = new System.Drawing.Size(1578, 674);
            this.rpResep.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(537, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 82;
            this.label3.Text = "Sampai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(217, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Dari";
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.Animated = true;
            this.dtpTanggalAkhir.BackColor = System.Drawing.Color.Transparent;
            this.dtpTanggalAkhir.BorderColor = System.Drawing.Color.White;
            this.dtpTanggalAkhir.BorderRadius = 10;
            this.dtpTanggalAkhir.BorderThickness = 2;
            this.dtpTanggalAkhir.Checked = true;
            this.dtpTanggalAkhir.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAkhir.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAkhir.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAkhir.CustomizableEdges.BottomLeft = false;
            this.dtpTanggalAkhir.CustomizableEdges.TopRight = false;
            this.dtpTanggalAkhir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAkhir.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpTanggalAkhir.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.dtpTanggalAkhir.ForeColor = System.Drawing.Color.White;
            this.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTanggalAkhir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAkhir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAkhir.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(617, 143);
            this.dtpTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalAkhir.MinDate = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpTanggalAkhir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(262, 36);
            this.dtpTanggalAkhir.TabIndex = 80;
            this.dtpTanggalAkhir.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpTanggalAkhir.UseTransparentBackground = true;
            this.dtpTanggalAkhir.Value = new System.DateTime(2023, 8, 1, 0, 0, 0, 0);
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.Animated = true;
            this.dtpTanggalAwal.BackColor = System.Drawing.Color.Transparent;
            this.dtpTanggalAwal.BorderColor = System.Drawing.Color.White;
            this.dtpTanggalAwal.BorderRadius = 10;
            this.dtpTanggalAwal.BorderThickness = 2;
            this.dtpTanggalAwal.Checked = true;
            this.dtpTanggalAwal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAwal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAwal.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAwal.CustomizableEdges.BottomLeft = false;
            this.dtpTanggalAwal.CustomizableEdges.TopRight = false;
            this.dtpTanggalAwal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAwal.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpTanggalAwal.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.dtpTanggalAwal.ForeColor = System.Drawing.Color.White;
            this.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTanggalAwal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAwal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpTanggalAwal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpTanggalAwal.Location = new System.Drawing.Point(269, 143);
            this.dtpTanggalAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalAwal.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpTanggalAwal.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpTanggalAwal.Size = new System.Drawing.Size(262, 36);
            this.dtpTanggalAwal.TabIndex = 79;
            this.dtpTanggalAwal.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpTanggalAwal.UseTransparentBackground = true;
            this.dtpTanggalAwal.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
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
            this.btnRefresh.Location = new System.Drawing.Point(68, 143);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnRefresh.PressedDepth = 50;
            this.btnRefresh.Size = new System.Drawing.Size(144, 37);
            this.btnRefresh.TabIndex = 78;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            // 
            // radiusReportDetail
            // 
            this.radiusReportDetail.BorderRadius = 30;
            this.radiusReportDetail.TargetControl = this.rpDetailResep;
            // 
            // radiusReport
            // 
            this.radiusReport.BorderRadius = 30;
            this.radiusReport.TargetControl = this.rpResep;
            // 
            // btnCariDetail
            // 
            this.btnCariDetail.Animated = true;
            this.btnCariDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnCariDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariDetail.BorderRadius = 10;
            this.btnCariDetail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCariDetail.BorderThickness = 2;
            this.btnCariDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariDetail.FillColor = System.Drawing.Color.Transparent;
            this.btnCariDetail.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCariDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariDetail.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCariDetail.Location = new System.Drawing.Point(1487, 143);
            this.btnCariDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariDetail.Name = "btnCariDetail";
            this.btnCariDetail.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCariDetail.PressedDepth = 50;
            this.btnCariDetail.Size = new System.Drawing.Size(159, 37);
            this.btnCariDetail.TabIndex = 84;
            this.btnCariDetail.Text = "Cari Detail";
            this.btnCariDetail.UseTransparentBackground = true;
            this.btnCariDetail.Click += new System.EventHandler(this.btnCariDetail_Click);
            // 
            // cbResep
            // 
            this.cbResep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbResep.BorderColor = System.Drawing.Color.White;
            this.cbResep.BorderThickness = 2;
            this.cbResep.DataSource = this.viewTrsPemberianResepBindingSource;
            this.cbResep.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbResep.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbResep.DisplayMember = "Id_TrsResep";
            this.cbResep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbResep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbResep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbResep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbResep.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbResep.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbResep.ForeColor = System.Drawing.Color.White;
            this.cbResep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbResep.ItemHeight = 30;
            this.cbResep.Location = new System.Drawing.Point(1248, 143);
            this.cbResep.Margin = new System.Windows.Forms.Padding(2);
            this.cbResep.Name = "cbResep";
            this.cbResep.Size = new System.Drawing.Size(235, 36);
            this.cbResep.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbResep.TabIndex = 83;
            this.cbResep.TextOffset = new System.Drawing.Point(40, 0);
            this.cbResep.ValueMember = "Id_TrsResep";
            // 
            // view_TrsPemberianResepTableAdapter
            // 
            this.view_TrsPemberianResepTableAdapter.ClearBeforeFill = true;
            // 
            // viewDetailObatTrsPemberianResepBindingSource
            // 
            this.viewDetailObatTrsPemberianResepBindingSource.DataMember = "View_DetailObatTrsPemberianResep";
            this.viewDetailObatTrsPemberianResepBindingSource.DataSource = this.laporan;
            // 
            // view_DetailObatTrsPemberianResepTableAdapter
            // 
            this.view_DetailObatTrsPemberianResepTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Laporan_Resep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.btnCariDetail);
            this.Controls.Add(this.cbResep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laporan_Resep";
            this.Text = "Forrm_Laporan_Resep";
            this.Load += new System.EventHandler(this.Forrm_Laporan_Resep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPemberianResepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailObatTrsPemberianResepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpDetailResep;
        private Microsoft.Reporting.WinForms.ReportViewer rpResep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAkhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAwal;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Guna.UI2.WinForms.Guna2Elipse radiusReportDetail;
        private Guna.UI2.WinForms.Guna2Elipse radiusReport;
        private Guna.UI2.WinForms.Guna2Button btnCariDetail;
        private Guna.UI2.WinForms.Guna2ComboBox cbResep;
        private D_Clinic.Laporan laporan;
        private D_Clinic.Laporan laporan1;
        private System.Windows.Forms.BindingSource viewTrsPemberianResepBindingSource;
        private LaporanTableAdapters.View_TrsPemberianResepTableAdapter view_TrsPemberianResepTableAdapter;
        private System.Windows.Forms.BindingSource viewDetailObatTrsPemberianResepBindingSource;
        private LaporanTableAdapters.View_DetailObatTrsPemberianResepTableAdapter view_DetailObatTrsPemberianResepTableAdapter;
    }
}