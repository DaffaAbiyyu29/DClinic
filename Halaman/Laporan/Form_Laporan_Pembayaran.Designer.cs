namespace D_Clinic.Halaman.Laporan
{
    partial class Form_Laporan_Pembayaran
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewTrsPembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan = new D_Clinic.Laporan();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.radiusReport = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rpPembayaran = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radiusReportDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCariData = new Guna.UI2.WinForms.Guna2Button();
            this.btnCetakStruk = new Guna.UI2.WinForms.Guna2Button();
            this.cbStruk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.viewTrsPembayaranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_TrsPembayaranTableAdapter = new D_Clinic.LaporanTableAdapters.View_TrsPembayaranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPembayaranBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewTrsPembayaranBindingSource
            // 
            this.viewTrsPembayaranBindingSource.DataMember = "View_TrsPembayaran";
            this.viewTrsPembayaranBindingSource.DataSource = this.laporan;
            // 
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.EnforceConstraints = false;
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            this.radiusForm.TargetControl = this;
            // 
            // radiusReport
            // 
            this.radiusReport.BorderRadius = 30;
            this.radiusReport.TargetControl = this.rpPembayaran;
            // 
            // rpPembayaran
            // 
            this.rpPembayaran.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Laporan_Pembayaran";
            reportDataSource1.Value = this.viewTrsPembayaranBindingSource;
            this.rpPembayaran.LocalReport.DataSources.Add(reportDataSource1);
            this.rpPembayaran.LocalReport.ReportEmbeddedResource = "D_Clinic.Halaman.Laporan.Laporan_Pembayaran.rdlc";
            this.rpPembayaran.Location = new System.Drawing.Point(3, 3);
            this.rpPembayaran.Name = "rpPembayaran";
            this.rpPembayaran.ServerReport.BearerToken = null;
            this.rpPembayaran.Size = new System.Drawing.Size(1578, 674);
            this.rpPembayaran.TabIndex = 0;
            // 
            // radiusReportDetail
            // 
            this.radiusReportDetail.BorderRadius = 30;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.rpPembayaran);
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
            this.label1.TabIndex = 47;
            this.label1.Text = "Riwayat Pembayaran";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(552, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "Sampai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(232, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 76;
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
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(632, 143);
            this.dtpTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalAkhir.MinDate = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpTanggalAkhir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(262, 36);
            this.dtpTanggalAkhir.TabIndex = 75;
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
            this.dtpTanggalAwal.Location = new System.Drawing.Point(284, 143);
            this.dtpTanggalAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalAwal.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.dtpTanggalAwal.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dtpTanggalAwal.Size = new System.Drawing.Size(262, 36);
            this.dtpTanggalAwal.TabIndex = 74;
            this.dtpTanggalAwal.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpTanggalAwal.UseTransparentBackground = true;
            this.dtpTanggalAwal.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // btnCariData
            // 
            this.btnCariData.Animated = true;
            this.btnCariData.BackColor = System.Drawing.Color.Transparent;
            this.btnCariData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariData.BorderRadius = 10;
            this.btnCariData.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCariData.BorderThickness = 2;
            this.btnCariData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariData.FillColor = System.Drawing.Color.Transparent;
            this.btnCariData.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCariData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCariData.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCariData.Location = new System.Drawing.Point(68, 143);
            this.btnCariData.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCariData.PressedDepth = 50;
            this.btnCariData.Size = new System.Drawing.Size(159, 37);
            this.btnCariData.TabIndex = 78;
            this.btnCariData.Text = "Cari Data";
            this.btnCariData.UseTransparentBackground = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // btnCetakStruk
            // 
            this.btnCetakStruk.Animated = true;
            this.btnCetakStruk.BackColor = System.Drawing.Color.Transparent;
            this.btnCetakStruk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCetakStruk.BorderRadius = 10;
            this.btnCetakStruk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCetakStruk.BorderThickness = 2;
            this.btnCetakStruk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakStruk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCetakStruk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetakStruk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCetakStruk.FillColor = System.Drawing.Color.Transparent;
            this.btnCetakStruk.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCetakStruk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCetakStruk.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCetakStruk.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCetakStruk.Location = new System.Drawing.Point(1487, 140);
            this.btnCetakStruk.Margin = new System.Windows.Forms.Padding(2);
            this.btnCetakStruk.Name = "btnCetakStruk";
            this.btnCetakStruk.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCetakStruk.PressedDepth = 50;
            this.btnCetakStruk.Size = new System.Drawing.Size(159, 37);
            this.btnCetakStruk.TabIndex = 88;
            this.btnCetakStruk.Text = "Cetak Struk";
            this.btnCetakStruk.UseTransparentBackground = true;
            this.btnCetakStruk.Click += new System.EventHandler(this.btnCetakStruk_Click);
            // 
            // cbStruk
            // 
            this.cbStruk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbStruk.BorderColor = System.Drawing.Color.White;
            this.cbStruk.BorderThickness = 2;
            this.cbStruk.DataSource = this.viewTrsPembayaranBindingSource;
            this.cbStruk.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbStruk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbStruk.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbStruk.DisplayMember = "Id_TrsPembayaran";
            this.cbStruk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStruk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStruk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbStruk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbStruk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbStruk.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbStruk.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbStruk.ForeColor = System.Drawing.Color.White;
            this.cbStruk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStruk.ItemHeight = 30;
            this.cbStruk.Location = new System.Drawing.Point(1248, 140);
            this.cbStruk.Margin = new System.Windows.Forms.Padding(2);
            this.cbStruk.Name = "cbStruk";
            this.cbStruk.Size = new System.Drawing.Size(235, 36);
            this.cbStruk.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbStruk.TabIndex = 87;
            this.cbStruk.TextOffset = new System.Drawing.Point(40, 0);
            this.cbStruk.ValueMember = "Nama";
            // 
            // viewTrsPembayaranBindingSource1
            // 
            this.viewTrsPembayaranBindingSource1.DataMember = "View_TrsPembayaran";
            this.viewTrsPembayaranBindingSource1.DataSource = this.laporan;
            // 
            // view_TrsPembayaranTableAdapter
            // 
            this.view_TrsPembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Laporan_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.btnCetakStruk);
            this.Controls.Add(this.cbStruk);
            this.Controls.Add(this.btnCariData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laporan_Pembayaran";
            this.Text = "Form_Laporan_Pembayaran";
            this.Load += new System.EventHandler(this.Form_Laporan_Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewTrsPembayaranBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpPembayaran;
        private Guna.UI2.WinForms.Guna2Elipse radiusReport;
        private Guna.UI2.WinForms.Guna2Elipse radiusReportDetail;
        private System.Windows.Forms.Label label1;
        private D_Clinic.Laporan laporan;
        private System.Windows.Forms.BindingSource viewTrsPembayaranBindingSource;
        private LaporanTableAdapters.View_TrsPembayaranTableAdapter view_TrsPembayaranTableAdapter;
        private System.Windows.Forms.BindingSource viewTrsPembayaranBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAkhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAwal;
        private Guna.UI2.WinForms.Guna2Button btnCariData;
        private Guna.UI2.WinForms.Guna2Button btnCetakStruk;
        public Guna.UI2.WinForms.Guna2ComboBox cbStruk;
    }
}