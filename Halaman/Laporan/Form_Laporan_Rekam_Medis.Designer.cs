namespace D_Clinic
{
    partial class Form_Laporan_Rekam_Medis
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
            this.label1 = new System.Windows.Forms.Label();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rpRekamMedis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radiusReport = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtpTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCariData = new Guna.UI2.WinForms.Guna2Button();
            this.dtpTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewRekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan = new D_Clinic.Laporan();
            this.view_RekamMedisTableAdapter = new D_Clinic.LaporanTableAdapters.View_RekamMedisTableAdapter();
            this.View_TrsRestokObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TrsRestokObatBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Text = "Riwayat Rekam Medis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            this.radiusForm.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.rpRekamMedis);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(65, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1584, 680);
            this.guna2GroupBox1.TabIndex = 44;
            // 
            // rpRekamMedis
            // 
            this.rpRekamMedis.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Laporan_Rekam_Medis";
            reportDataSource1.Value = this.viewRekamMedisBindingSource;
            this.rpRekamMedis.LocalReport.DataSources.Add(reportDataSource1);
            this.rpRekamMedis.LocalReport.ReportEmbeddedResource = "D_Clinic.Halaman.Laporan.Laporan_Rekam_Medis.rdlc";
            this.rpRekamMedis.Location = new System.Drawing.Point(3, 3);
            this.rpRekamMedis.Name = "rpRekamMedis";
            this.rpRekamMedis.ServerReport.BearerToken = null;
            this.rpRekamMedis.Size = new System.Drawing.Size(1578, 674);
            this.rpRekamMedis.TabIndex = 0;
            // 
            // radiusReport
            // 
            this.radiusReport.BorderRadius = 30;
            this.radiusReport.TargetControl = this.rpRekamMedis;
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
            this.dtpTanggalAwal.TabIndex = 45;
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
            this.btnCariData.TabIndex = 59;
            this.btnCariData.Text = "Cari Data";
            this.btnCariData.UseTransparentBackground = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
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
            this.dtpTanggalAkhir.TabIndex = 60;
            this.dtpTanggalAkhir.TextOffset = new System.Drawing.Point(18, 0);
            this.dtpTanggalAkhir.UseTransparentBackground = true;
            this.dtpTanggalAkhir.Value = new System.DateTime(2023, 8, 1, 0, 0, 0, 0);
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
            this.label2.TabIndex = 72;
            this.label2.Text = "Dari";
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
            this.label3.TabIndex = 73;
            this.label3.Text = "Sampai";
            // 
            // viewRekamMedisBindingSource
            // 
            this.viewRekamMedisBindingSource.DataMember = "View_RekamMedis";
            this.viewRekamMedisBindingSource.DataSource = this.laporan;
            // 
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.EnforceConstraints = false;
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_RekamMedisTableAdapter
            // 
            this.view_RekamMedisTableAdapter.ClearBeforeFill = true;
            // 
            // View_TrsRestokObatBindingSource
            // 
            this.View_TrsRestokObatBindingSource.DataMember = "View_TrsRestokObat";
            this.View_TrsRestokObatBindingSource.DataSource = this.laporan;
            // 
            // Form_Laporan_Rekam_Medis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.btnCariData);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laporan_Rekam_Medis";
            this.Text = "Form_Laporan_Rekam_Medis";
            this.Load += new System.EventHandler(this.Form_Laporan_Rekam_Medis_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TrsRestokObatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpRekamMedis;
        private Guna.UI2.WinForms.Guna2Elipse radiusReport;
        private Laporan laporan;
        private System.Windows.Forms.BindingSource viewRekamMedisBindingSource;
        private LaporanTableAdapters.View_RekamMedisTableAdapter view_RekamMedisTableAdapter;
        private System.Windows.Forms.BindingSource View_TrsRestokObatBindingSource;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAwal;
        private Guna.UI2.WinForms.Guna2Button btnCariData;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}