namespace D_Clinic
{
    partial class DClinic_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DClinic_App));
            this.radiusForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.loadingBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusForm
            // 
            this.radiusForm.BorderRadius = 40;
            this.radiusForm.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.pnlLoading.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlLoading.BorderThickness = 2;
            this.pnlLoading.Controls.Add(this.lblLoading);
            this.pnlLoading.Controls.Add(this.loadingBar);
            this.pnlLoading.Controls.Add(this.logo);
            this.pnlLoading.Controls.Add(this.label1);
            this.pnlLoading.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.pnlLoading.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.pnlLoading.Location = new System.Drawing.Point(725, 413);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(470, 254);
            this.pnlLoading.TabIndex = 5;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoading.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.lblLoading.Location = new System.Drawing.Point(0, 202);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(470, 26);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "100%";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loadingBar
            // 
            this.loadingBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.loadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.loadingBar.Location = new System.Drawing.Point(0, 228);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.loadingBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.loadingBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.loadingBar.Size = new System.Drawing.Size(470, 26);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 5;
            this.loadingBar.Text = "guna2ProgressBar1";
            this.loadingBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::D_Clinic.Properties.Resources.D_Clinic_Green;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(109, 74);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(252, 120);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selamat Datang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusPanel
            // 
            this.radiusPanel.BorderRadius = 40;
            this.radiusPanel.TargetControl = this.pnlLoading;
            // 
            // DClinic_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DClinic_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DClinic_App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DClinic_App_Load);
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse radiusForm;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel pnlLoading;
        private Guna.UI2.WinForms.Guna2Elipse radiusPanel;
        private System.Windows.Forms.Label lblLoading;
        private Guna.UI2.WinForms.Guna2ProgressBar loadingBar;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}