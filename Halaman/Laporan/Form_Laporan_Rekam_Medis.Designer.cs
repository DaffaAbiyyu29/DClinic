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
            this.laporan = new D_Clinic.Laporan();
            this.viewRekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_RekamMedisTableAdapter = new D_Clinic.LaporanTableAdapters.View_RekamMedisTableAdapter();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).BeginInit();
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
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.EnforceConstraints = false;
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewRekamMedisBindingSource
            // 
            this.viewRekamMedisBindingSource.DataMember = "View_RekamMedis";
            this.viewRekamMedisBindingSource.DataSource = this.laporan;
            // 
            // view_RekamMedisTableAdapter
            // 
            this.view_RekamMedisTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Laporan_Rekam_Medis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1715, 924);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laporan_Rekam_Medis";
            this.Text = "Form_Laporan_Rekam_Medis";
            this.Load += new System.EventHandler(this.Form_Laporan_Rekam_Medis_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRekamMedisBindingSource)).EndInit();
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
    }
}