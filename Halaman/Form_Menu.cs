using D_Clinic.Halaman.Transaksi;
using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_Menu : Form
    {
        string nama;
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            pnlKaryawan.Height = pnlKaryawan.MinimumSize.Height;
            pnlObat.Height = pnlObat.MinimumSize.Height;
            pnlPasien.Height = pnlPasien.MinimumSize.Height;
            pnlLaporan.Height = pnlLaporan.MinimumSize.Height;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard dashboard = new Form_Dashboard();
            dashboard.TopLevel = false;
            pnlContainer.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (pnlKaryawan.Height == pnlKaryawan.MaximumSize.Height)
            {
                pnlKaryawan.Height = pnlKaryawan.MinimumSize.Height;
            }
            else if (pnlKaryawan.Height == pnlKaryawan.MinimumSize.Height)
            {
                pnlKaryawan.Height = pnlKaryawan.MaximumSize.Height;
            }
        }

        private void btnMasterKaryawan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Karyawan kry = new Form_Master_Karyawan();
            kry.TopLevel = false;
            pnlContainer.Controls.Add(kry);
            kry.BringToFront();
            kry.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Login login = new Form_Login();
            login.Show();
            this.Close();
        }
        private void UpdateDateTimeLabel()
        {
            DateTime currentDateTime = DateTime.Now;
            labelDateTime.Text = currentDateTime.ToString("dd MMMM yyyy HH:mm:ss"); // Format tanggal dan waktu sesuai kebutuhan Anda
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }
        private void GenerateNama()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 Nama FROM Riwayat_Login ORDER BY Id_Login DESC";

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
                        nama = reader.GetString(0);
                    }
                }
                reader.Close();
            }
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Form_Dashboard dashboard = new Form_Dashboard();
            dashboard.TopLevel = false;
            pnlContainer.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();

            GenerateNama();
            lblNama.Text = nama;
            UpdateDateTimeLabel(); // Panggil method untuk pertama kali
            Timer timer = new Timer();
            timer.Interval = 1000; // Interval dalam milidetik (1000ms = 1 detik)
            timer.Tick += dateTimer_Tick;
            timer.Start(); // Mulai Timer untuk memperbarui label setiap detik
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (pnlObat.Height == pnlObat.MaximumSize.Height)
            {
                pnlObat.Height = pnlObat.MinimumSize.Height;
            }
            else if (pnlObat.Height == pnlObat.MinimumSize.Height)
            {
                pnlObat.Height = pnlObat.MaximumSize.Height;
            }
        }
        private void btnMasterObat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Obat obt = new Form_Master_Obat();
            obt.TopLevel = false;
            pnlContainer.Controls.Add(obt);
            obt.BringToFront();
            obt.Show();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (pnlPasien.Height == pnlPasien.MaximumSize.Height)
            {
                pnlPasien.Height = pnlPasien.MinimumSize.Height;
            }
            else if (pnlPasien.Height == pnlPasien.MinimumSize.Height)
            {
                pnlPasien.Height = pnlPasien.MaximumSize.Height;
            }
        }

        private void btnMasterPasien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Pasien pas = new Form_Master_Pasien();
            pas.TopLevel = false;
            pnlContainer.Controls.Add(pas);
            pas.BringToFront();
            pas.Show();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Pengaturan_Akun acc = new Form_Pengaturan_Akun();
            acc.TopLevel = false;
            pnlContainer.Controls.Add(acc);
            acc.BringToFront();
            acc.Show();
        }

        private void btnDataObat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_View_Obat obt = new Form_View_Obat();
            obt.TopLevel = false;
            pnlContainer.Controls.Add(obt);
            obt.BringToFront();
            obt.Show();
        }

        private void btnDataKaryawan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_View_Karyawan kry = new Form_View_Karyawan();
            kry.TopLevel = false;
            pnlContainer.Controls.Add(kry);
            kry.BringToFront();
            kry.Show();
        }

        private void btnDataPasien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_View_Pasien pas = new Form_View_Pasien();
            pas.TopLevel = false;
            pnlContainer.Controls.Add(pas);
            pas.BringToFront();
            pas.Show();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (pnlLaporan.Height == pnlLaporan.MaximumSize.Height)
            {
                pnlLaporan.Height = pnlLaporan.MinimumSize.Height;
            }
            else if (pnlPasien.Height == pnlLaporan.MinimumSize.Height)
            {
                pnlLaporan.Height = pnlLaporan.MaximumSize.Height;
            }
        }

        private void btnRSRekanan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_RS_Rekanan rs = new Form_Master_RS_Rekanan();
            rs.TopLevel = false;
            pnlContainer.Controls.Add(rs);
            rs.BringToFront();
            rs.Show();
        }

        private void btnRuangPeriksa_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Ruang_Periksa rp = new Form_Master_Ruang_Periksa();
            rp.TopLevel = false;
            pnlContainer.Controls.Add(rp);
            rp.BringToFront();
            rp.Show();
        }

        private void btnJadwalDokter_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Jadwal_Dokter jd = new Form_Master_Jadwal_Dokter();
            jd.TopLevel = false;
            pnlContainer.Controls.Add(jd);
            jd.BringToFront();
            jd.Show();
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Transaksi_Pendaftaran_Pasien daftar = new Form_Transaksi_Pendaftaran_Pasien();
            daftar.TopLevel = false;
            pnlContainer.Controls.Add(daftar);
            daftar.BringToFront();
            daftar.Show();
            daftar.txResepsionis.Text = lblNama.Text;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Master_Supplier supplier = new Form_Master_Supplier();
            supplier.TopLevel = false;
            pnlContainer.Controls.Add(supplier);
            supplier.BringToFront();
            supplier.Show();
        }

        private void btnResepObat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Transaksi_Pemberian_Resep resep = new Form_Transaksi_Pemberian_Resep();
            resep.TopLevel = false;
            pnlContainer.Controls.Add(resep);
            resep.BringToFront();
            resep.Show();
            resep.txDokter.Text = lblNama.Text;
        }

        private void btnRujukan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Transaksi_Rujukan_Pasien rujukan = new Form_Transaksi_Rujukan_Pasien();
            rujukan.TopLevel = false;
            pnlContainer.Controls.Add(rujukan);
            rujukan.BringToFront();
            rujukan.Show();
            rujukan.txDokter.Text = lblNama.Text;
        }

        private void btnRestok_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Transaksi_Restok_Obat restok = new Form_Transaksi_Restok_Obat();
            restok.TopLevel = false;
            pnlContainer.Controls.Add(restok);
            restok.BringToFront();
            restok.Show();
            restok.txApoteker.Text = lblNama.Text;
        }

        private void btnDaftarObat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Daftar_Resep daftar = new Form_Daftar_Resep();
            daftar.TopLevel = false;
            pnlContainer.Controls.Add(daftar);
            daftar.BringToFront();
            daftar.Show();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Transaksi_Pembayaran bayar = new Form_Transaksi_Pembayaran();
            bayar.TopLevel = false;
            pnlContainer.Controls.Add(bayar);
            bayar.BringToFront();
            bayar.Show();
        }

        private void btnLaporanRekamMedis_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form_Laporan_Rekam_Medis medis = new Form_Laporan_Rekam_Medis();
            medis.TopLevel = false;
            pnlContainer.Controls.Add(medis);
            medis.BringToFront();
            medis.Show();
        }
    }
}
