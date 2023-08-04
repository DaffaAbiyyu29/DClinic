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
            this.viewRekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan = new D_Clinic.Laporan();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rpRekamMedis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radiusReport = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.view_RekamMedisTableAdapter = new D_Clinic.LaporanTableAdapters.View_RekamMedisTableAdapter();
            this.View_TrsRestokObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCariDetail = new Guna.UI2.WinForms.Guna2Button();
            this.cbPasien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_TrsRestokObatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.btnRefresh.Size = new System.Drawing.Size(159, 37);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnCariDetail.Location = new System.Drawing.Point(1487, 140);
            this.btnCariDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariDetail.Name = "btnCariDetail";
            this.btnCariDetail.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCariDetail.PressedDepth = 50;
            this.btnCariDetail.Size = new System.Drawing.Size(159, 37);
            this.btnCariDetail.TabIndex = 86;
            this.btnCariDetail.Text = "Cari Detail";
            this.btnCariDetail.UseTransparentBackground = true;
            this.btnCariDetail.Click += new System.EventHandler(this.btnCariDetail_Click);
            // 
            // cbPasien
            // 
            this.cbPasien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbPasien.BorderColor = System.Drawing.Color.White;
            this.cbPasien.BorderThickness = 2;
            this.cbPasien.DataSource = this.pasienBindingSource;
            this.cbPasien.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbPasien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbPasien.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbPasien.DisplayMember = "Nama";
            this.cbPasien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.cbPasien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbPasien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbPasien.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbPasien.Font = new System.Drawing.Font("Porsche Next TT", 15F, System.Drawing.FontStyle.Bold);
            this.cbPasien.ForeColor = System.Drawing.Color.White;
            this.cbPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPasien.ItemHeight = 30;
            this.cbPasien.Location = new System.Drawing.Point(1248, 140);
            this.cbPasien.Margin = new System.Windows.Forms.Padding(2);
            this.cbPasien.Name = "cbPasien";
            this.cbPasien.Size = new System.Drawing.Size(235, 36);
            this.cbPasien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbPasien.TabIndex = 85;
            this.cbPasien.TextOffset = new System.Drawing.Point(40, 0);
            this.cbPasien.ValueMember = "Nama";
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
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Laporan_Rekam_Medis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.btnCariDetail);
            this.Controls.Add(this.cbPasien);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laporan_Rekam_Medis";
            this.Text = "Form_Laporan_Rekam_Medis";
            this.Load += new System.EventHandler(this.Form_Laporan_Rekam_Medis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_TrsRestokObatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.ResumeLayout(false);

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
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnCariDetail;
        private Guna.UI2.WinForms.Guna2ComboBox cbPasien;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
    }
}