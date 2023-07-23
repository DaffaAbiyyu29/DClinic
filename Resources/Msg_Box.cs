using D_Clinic.Halaman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Resources
{
    public partial class Msg_Box : Form
    {
        public Msg_Box()
        {
            InitializeComponent();
        }

        private void Msg_Box_Load(object sender, EventArgs e)
        {

        }
        private void Masuk()
        {
            string nama = lblNama.Text;
            Form_Menu menu = new Form_Menu();

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Jabatan FROM Karyawan WHERE Nama = '" + nama + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    menu.Show();
                    this.Hide();

                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        string jabatan = reader.GetString(0);

                        menu.lblNama.Text = nama;
                        menu.lblJabatan.Text = jabatan;
                        if (jabatan == "Manager")
                        {
                            menu.btnKaryawan.Visible = true;
                            menu.btnJadwalDokter.Visible = true;
                            menu.btnRuangPeriksa.Visible = true;
                            menu.btnRSRekanan.Visible = true;
                            menu.btnSupplier.Visible = true;
                            menu.btnLaporan.Visible = true;
                        }
                        else if (jabatan == "Resepsionis")
                        {
                            menu.btnPasien.Visible = true;
                            menu.btnPendaftaran.Visible = true;
                            menu.btnPembayaran.Visible = true;
                        }
                        else if (jabatan == "Dokter")
                        {
                            menu.btnResepObat.Visible = true;
                            menu.btnRujukan.Visible = true;
                        }
                        else if (jabatan == "Apoteker")
                        {
                            menu.btnObat.Visible = true;
                            menu.btnRestok.Visible = true;
                            menu.btnDaftarObat.Visible = true;
                        }
                    }
                }
                reader.Close();
            }
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (session.Text == "Login Berhasil")
            {
                Program.HideAllForms();
                Masuk();
            }
            else if (session.Text == "Akses Ditolak")
            {
                Program.CloseAllForms();
            }
            else if (session.Text == "Logout")
            {
                Program.CloseAllForms();
            }
            else if (session.Text == "Akun Terhapus")
            {
                Program.HideAllForms();
                Form_Login login = new Form_Login();
                login.Show();
            }
            else
            {
                this.Hide();
            }
        }
        public void SuccessMessage()
        {
            pnlAtas.FillColor = Color.FromArgb(131, 235, 97);
            pnlBawah.FillColor = Color.FromArgb(131, 235, 97);
            pnlContainer.BorderColor = Color.FromArgb(131, 235, 97);
            text1.ForeColor = Color.FromArgb(131, 235, 97);
            btnOkay.ForeColor = Color.FromArgb(131, 235, 97);
            btnOkay.BorderColor = Color.FromArgb(131, 235, 97);
            btnOkay.HoverState.BorderColor = Color.FromArgb(131, 235, 97);
            btnOkay.HoverState.FillColor = Color.FromArgb(131, 235, 97);
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
            session.ForeColor = Color.FromArgb(131, 235, 97);
        }
        public void WarningMessage()
        {
            pnlAtas.FillColor = Color.Gold;
            pnlBawah.FillColor = Color.Gold;
            pnlContainer.BorderColor = Color.Gold;
            text1.ForeColor = Color.Gold;
            btnOkay.ForeColor = Color.Gold;
            btnOkay.BorderColor = Color.Gold;
            btnOkay.HoverState.BorderColor = Color.Gold;
            btnOkay.HoverState.FillColor = Color.Gold;
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
            session.ForeColor = Color.Gold;
        }
        public void ErrorMessage()
        {
            pnlAtas.FillColor = Color.FromArgb(247, 56, 89);
            pnlBawah.FillColor = Color.FromArgb(247, 56, 89);
            pnlContainer.BorderColor = Color.FromArgb(247, 56, 89);
            text1.ForeColor = Color.FromArgb(247, 56, 89);
            btnOkay.ForeColor = Color.FromArgb(247, 56, 89);
            btnOkay.BorderColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.BorderColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.FillColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
            session.ForeColor = Color.FromArgb(247, 56, 89);
        }
        public void InformationMessage()
        {
            pnlAtas.FillColor = Color.DodgerBlue;
            pnlBawah.FillColor = Color.DodgerBlue;
            pnlContainer.BorderColor = Color.DodgerBlue;
            text1.ForeColor = Color.DodgerBlue;
            btnOkay.ForeColor = Color.DodgerBlue;
            btnOkay.BorderColor = Color.DodgerBlue;
            btnOkay.HoverState.BorderColor = Color.DodgerBlue;
            btnOkay.HoverState.FillColor = Color.DodgerBlue;
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
            session.ForeColor = Color.DodgerBlue;
        }
    }
}
