using D_Clinic.Halaman;
using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace D_Clinic
{
    public partial class Form_Login : Form
    {
        Msg_Box mBox = new Msg_Box();

        string loginSession;
        private Timer blinkTimer;
        private bool isTextVisible = true;
        int lastID;
        public int gagal = 0;
        string id_log, id_kry, nama, jabatan;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txUsername.TextLength != 0 && txPassword.TextLength != 0)
            {
                GenerateIDLogin();
                LoginMenu();
            } else
            {
                mBox.Show();
                loginSession = "Login Gagal";
                mBox.text1.Text = "Masukkan Username & Password !";
                mBox.session.Text = loginSession;
                mBox.WarningMessage();
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            mBox.text1.Text = "Terimakasih Sudah Menggunakan Aplikasi Ini";
            mBox.session.Text = "Logout";
            mBox.Show();
            mBox.InformationMessage();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txUsername.Clear();
            txPassword.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isTextVisible = !isTextVisible; // Toggle nilai variabel isTextVisible
            logo.Visible = isTextVisible;
        }
        private void LoginMenu()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT * FROM Karyawan WHERE Username = @username AND Password = @password COLLATE Latin1_General_CS_AS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txUsername.Text);
                command.Parameters.AddWithValue("@password", txPassword.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        id_kry = reader.GetString(0);
                        nama = reader.GetString(1);
                        jabatan = reader.GetString(6);
                        
                        RiwayatLogin();
                        pnlLogin.Visible = false;
                        mBox.Show();
                        loginSession = "Login Berhasil";
                        mBox.text1.Text = "Selamat Datang " +nama;
                        mBox.SuccessMessage();
                        mBox.session.Text = loginSession;
                    }
                }
                else
                {
                    gagal += 1;
                    mBox.Show();
                    loginSession = "Login Gagal";
                    mBox.text1.Text = "Username / Password Salah !";
                    mBox.session.Text = loginSession;
                    mBox.WarningMessage();
                }

                reader.Close();
                if (gagal >= 3)
                {
                    Program.HideAllForms();
                    mBox.Show();
                    loginSession = "Akses Ditolak";
                    mBox.text1.Text = "Akses Ditolak !";
                    mBox.session.Text = loginSession;
                    mBox.ErrorMessage();
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txPassword.UseSystemPasswordChar = true;
            blinkTimer = new Timer();
            blinkTimer.Interval = 800; // Interval dalam milidetik (500ms = 0.5 detik)
            blinkTimer.Tick += timer1_Tick;
            blinkTimer.Start(); // Mulai Timer untuk memulai animasi berkedip
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txUsername.Text))
            {
                imgUsername.Image = Properties.Resources.green_user;
            }
            else
            {
                imgUsername.Image = Properties.Resources.white_user;
            }

            if (!string.IsNullOrEmpty(txPassword.Text))
            {
                imgPassword.Image = Properties.Resources.green_pass;
            }
            else
            {
                imgPassword.Image = Properties.Resources.white_pass;
            }
        }

        private void btnTampilPass_Click(object sender, EventArgs e)
        {
            if (txPassword.UseSystemPasswordChar)
            {
                // Jika karakter password disembunyikan, tampilkan sebagai teks biasa
                txPassword.UseSystemPasswordChar = false;
                btnTampilPass.Image = Properties.Resources.show_pass;

            }
            else
            {
                // Jika karakter password ditampilkan sebagai teks biasa, sembunyikan
                txPassword.UseSystemPasswordChar = true;
                btnTampilPass.Image = Properties.Resources.hide_pass;
            }
        }
        private void RiwayatLogin()
        {
            DateTime sekarang = DateTime.Now;
            string tanggal = sekarang.ToString("dd/MM/yyyy"); // Format: dd/MM/yyyy
            string waktu = sekarang.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("en-US")); // Format: HH:mm:ss

            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Riwayat_Login input = new Riwayat_Login();
                    input.Id_Login = id_log;
                    input.Id_Karyawan = id_kry;
                    input.Nama = nama;
                    input.Tanggal = DateTime.Parse(tanggal);
                    input.Waktu = waktu;

                    context.Riwayat_Logins.InsertOnSubmit(input);
                    context.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GenerateIDLogin()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Login, 3) AS ID FROM Riwayat_Login ORDER BY Id_Login DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                id_log = string.Format("LOG{0:D3}", lastID + 1);
            }
        }
    }
}
