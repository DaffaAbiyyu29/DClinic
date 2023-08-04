namespace D_Clinic.Halaman.Laporan
{
    partial class Struk_Pembayaran
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
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rpStruk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnOkay = new Guna.UI2.WinForms.Guna2Button();
            this.strukPembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan = new D_Clinic.Laporan();
            this.struk_PembayaranTableAdapter = new D_Clinic.LaporanTableAdapters.Struk_PembayaranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.strukPembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 30;
            this.radiusForm.TargetControl = this;
            // 
            // rpStruk
            // 
            reportDataSource1.Name = "Status_Pembayaran";
            reportDataSource1.Value = this.strukPembayaranBindingSource;
            this.rpStruk.LocalReport.DataSources.Add(reportDataSource1);
            this.rpStruk.LocalReport.ReportEmbeddedResource = "D_Clinic.Halaman.Laporan.Struk_Pembayaran.rdlc";
            this.rpStruk.Location = new System.Drawing.Point(0, 0);
            this.rpStruk.Name = "rpStruk";
            this.rpStruk.ServerReport.BearerToken = null;
            this.rpStruk.ShowBackButton = false;
            this.rpStruk.ShowContextMenu = false;
            this.rpStruk.ShowCredentialPrompts = false;
            this.rpStruk.ShowDocumentMapButton = false;
            this.rpStruk.ShowExportButton = false;
            this.rpStruk.ShowFindControls = false;
            this.rpStruk.ShowPageNavigationControls = false;
            this.rpStruk.ShowParameterPrompts = false;
            this.rpStruk.ShowProgress = false;
            this.rpStruk.ShowPromptAreaButton = false;
            this.rpStruk.ShowRefreshButton = false;
            this.rpStruk.ShowStopButton = false;
            this.rpStruk.ShowZoomControl = false;
            this.rpStruk.Size = new System.Drawing.Size(600, 709);
            this.rpStruk.TabIndex = 0;
            this.rpStruk.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.rpStruk;
            // 
            // btnOkay
            // 
            this.btnOkay.Animated = true;
            this.btnOkay.BackColor = System.Drawing.Color.Transparent;
            this.btnOkay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.BorderRadius = 10;
            this.btnOkay.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnOkay.BorderThickness = 2;
            this.btnOkay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnOkay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.FillColor = System.Drawing.Color.Transparent;
            this.btnOkay.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnOkay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnOkay.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnOkay.Location = new System.Drawing.Point(94, 714);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnOkay.PressedDepth = 50;
            this.btnOkay.Size = new System.Drawing.Size(412, 37);
            this.btnOkay.TabIndex = 79;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseTransparentBackground = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // strukPembayaranBindingSource
            // 
            this.strukPembayaranBindingSource.DataMember = "Struk_Pembayaran";
            this.strukPembayaranBindingSource.DataSource = this.laporan;
            // 
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.EnforceConstraints = false;
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // struk_PembayaranTableAdapter
            // 
            this.struk_PembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // Struk_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(600, 760);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.rpStruk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Struk_Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Struk_Pembayaran";
            this.Load += new System.EventHandler(this.Struk_Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strukPembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private Microsoft.Reporting.WinForms.ReportViewer rpStruk;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private D_Clinic.Laporan laporan;
        private System.Windows.Forms.BindingSource strukPembayaranBindingSource;
        private LaporanTableAdapters.Struk_PembayaranTableAdapter struk_PembayaranTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnOkay;
    }
}