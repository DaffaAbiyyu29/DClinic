namespace D_Clinic
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTampilPass = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnKeluar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.imgUsername = new System.Windows.Forms.PictureBox();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.txPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnTampilPass);
            this.pnlLogin.Controls.Add(this.btnBatal);
            this.pnlLogin.Controls.Add(this.btnKeluar);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.imgUsername);
            this.pnlLogin.Controls.Add(this.imgPassword);
            this.pnlLogin.Controls.Add(this.txPassword);
            this.pnlLogin.Controls.Add(this.txUsername);
            this.pnlLogin.Controls.Add(this.guna2GroupBox3);
            this.pnlLogin.Controls.Add(this.guna2GroupBox2);
            this.pnlLogin.Location = new System.Drawing.Point(685, 256);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(551, 568);
            this.pnlLogin.TabIndex = 23;
            // 
            // btnTampilPass
            // 
            this.btnTampilPass.Animated = true;
            this.btnTampilPass.BackColor = System.Drawing.Color.Transparent;
            this.btnTampilPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTampilPass.BorderRadius = 20;
            this.btnTampilPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTampilPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampilPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampilPass.FillColor = System.Drawing.Color.Transparent;
            this.btnTampilPass.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.btnTampilPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTampilPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnTampilPass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnTampilPass.Image = global::D_Clinic.Properties.Resources.hide_pass;
            this.btnTampilPass.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTampilPass.Location = new System.Drawing.Point(421, 215);
            this.btnTampilPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilPass.Name = "btnTampilPass";
            this.btnTampilPass.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTampilPass.PressedDepth = 50;
            this.btnTampilPass.Size = new System.Drawing.Size(50, 50);
            this.btnTampilPass.TabIndex = 30;
            this.btnTampilPass.UseTransparentBackground = true;
            this.btnTampilPass.Click += new System.EventHandler(this.btnTampilPass_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Animated = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBatal.BorderRadius = 20;
            this.btnBatal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBatal.BorderThickness = 2;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.Transparent;
            this.btnBatal.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBatal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnBatal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnBatal.Location = new System.Drawing.Point(293, 406);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBatal.PressedDepth = 50;
            this.btnBatal.Size = new System.Drawing.Size(178, 55);
            this.btnBatal.TabIndex = 27;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Animated = true;
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKeluar.BorderRadius = 20;
            this.btnKeluar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnKeluar.BorderThickness = 2;
            this.btnKeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKeluar.FillColor = System.Drawing.Color.Transparent;
            this.btnKeluar.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKeluar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnKeluar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnKeluar.Location = new System.Drawing.Point(80, 406);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnKeluar.PressedDepth = 50;
            this.btnKeluar.Size = new System.Drawing.Size(178, 55);
            this.btnKeluar.TabIndex = 26;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseTransparentBackground = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnLogin.Location = new System.Drawing.Point(80, 344);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnLogin.PressedDepth = 50;
            this.btnLogin.Size = new System.Drawing.Size(391, 55);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgUsername
            // 
            this.imgUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.imgUsername.Image = ((System.Drawing.Image)(resources.GetObject("imgUsername.Image")));
            this.imgUsername.Location = new System.Drawing.Point(91, 146);
            this.imgUsername.Margin = new System.Windows.Forms.Padding(2);
            this.imgUsername.Name = "imgUsername";
            this.imgUsername.Size = new System.Drawing.Size(40, 40);
            this.imgUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsername.TabIndex = 28;
            this.imgUsername.TabStop = false;
            // 
            // imgPassword
            // 
            this.imgPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.imgPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgPassword.Image")));
            this.imgPassword.Location = new System.Drawing.Point(91, 228);
            this.imgPassword.Margin = new System.Windows.Forms.Padding(2);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(40, 40);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassword.TabIndex = 29;
            this.imgPassword.TabStop = false;
            // 
            // txPassword
            // 
            this.txPassword.Animated = true;
            this.txPassword.AutoRoundedCorners = true;
            this.txPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txPassword.BorderColor = System.Drawing.Color.White;
            this.txPassword.BorderRadius = 25;
            this.txPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txPassword.BorderThickness = 2;
            this.txPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txPassword.DefaultText = "";
            this.txPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPassword.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.txPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPassword.Location = new System.Drawing.Point(136, 215);
            this.txPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txPassword.MaxLength = 15;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '\0';
            this.txPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txPassword.PlaceholderText = "Password";
            this.txPassword.SelectedText = "";
            this.txPassword.Size = new System.Drawing.Size(335, 53);
            this.txPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txPassword.TabIndex = 24;
            this.txPassword.TextOffset = new System.Drawing.Point(0, 5);
            this.txPassword.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // txUsername
            // 
            this.txUsername.Animated = true;
            this.txUsername.AutoRoundedCorners = true;
            this.txUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txUsername.BorderColor = System.Drawing.Color.White;
            this.txUsername.BorderRadius = 25;
            this.txUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txUsername.BorderThickness = 2;
            this.txUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txUsername.DefaultText = "";
            this.txUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.txUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txUsername.Font = new System.Drawing.Font("Porsche Next TT", 18F, System.Drawing.FontStyle.Bold);
            this.txUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txUsername.Location = new System.Drawing.Point(136, 133);
            this.txUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txUsername.MaxLength = 15;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txUsername.PlaceholderText = "Username";
            this.txUsername.SelectedText = "";
            this.txUsername.Size = new System.Drawing.Size(335, 53);
            this.txUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txUsername.TabIndex = 23;
            this.txUsername.TextOffset = new System.Drawing.Point(0, 5);
            this.txUsername.TextChanged += new System.EventHandler(this.Gambar_TextChanged);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox3.BorderRadius = 5;
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 522);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(551, 46);
            this.guna2GroupBox3.TabIndex = 2;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.logo);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(551, 93);
            this.guna2GroupBox2.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(146, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.UseTransparentBackground = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.pnlLogin;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2Button btnTampilPass;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnKeluar;
        public Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.PictureBox imgUsername;
        private System.Windows.Forms.PictureBox imgPassword;
        public Guna.UI2.WinForms.Guna2TextBox txPassword;
        public Guna.UI2.WinForms.Guna2TextBox txUsername;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}

