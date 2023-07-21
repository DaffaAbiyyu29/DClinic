using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman.Transaksi
{
    public partial class Form_Transaksi_Pembayaran : Form
    {
        Msg_Box mBox = new Msg_Box();

        DateTime currentDateTime = DateTime.Now;

        string idPendaftaran, idResep;
        decimal tarifJasa, hargaResep;
        public Form_Transaksi_Pembayaran()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariObat.Clear();
            txID.Clear();
            txResepsionis.Clear();
            txDokter.Clear();
            txPasien.Clear();
            txTotalHarga.Clear();
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariObat.Text))
            {
                txCariObat.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                txCariObat.IconLeft = Properties.Resources.white_magnifier;
            }
            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }
            if (!string.IsNullOrEmpty(txResepsionis.Text))
            {
                txResepsionis.IconLeft = Properties.Resources.green_resepsionis;
            }
            else
            {
                txResepsionis.IconLeft = Properties.Resources.white_resepsionis;
            }
            if (!string.IsNullOrEmpty(txDokter.Text))
            {
                txDokter.IconLeft = Properties.Resources.green_dokter;
            }
            else
            {
                txDokter.IconLeft = Properties.Resources.white_dokter;
            }
            if (!string.IsNullOrEmpty(txTanggal.Text))
            {
                txTanggal.IconLeft = Properties.Resources.green_cal;
            }
            else
            {
                txTanggal.IconLeft = Properties.Resources.white_cal;
            }
            if (!string.IsNullOrEmpty(txPasien.Text))
            {
                txPasien.IconLeft = Properties.Resources.green_pasien;
            }
            else
            {
                txPasien.IconLeft = Properties.Resources.white_pasien;
            }
            if (!string.IsNullOrEmpty(txTotalHarga.Text))
            {
                txTotalHarga.IconLeft = Properties.Resources.green_harga;
            }
            else
            {
                txTotalHarga.IconLeft = Properties.Resources.white_harga;
            }
        }
        private string IDPembayaran()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDTrsPembayaran()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void Form_Transaksi_Pembayaran_Load(object sender, EventArgs e)
        {
            this.view_TrsPendaftaran_TrsPembayaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPendaftaran_TrsPembayaran);
            txTanggal.Text = currentDateTime.ToString("dd MMMM yyyy");
        }

        private void tblPendaftaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblPendaftaran.Rows[e.RowIndex].Cells["no_daftar"].Value = (e.RowIndex + 1).ToString();
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
        }
        private void Bayar()
        {
            string waktu = currentDateTime.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("en-US")); // Format: HH:mm:ss
        }
        private void btnBayar_Click(object sender, EventArgs e)
        {
            Bayar();
        }

        private decimal TotalHarga()
        {
            return tarifJasa + hargaResep;
        }
        private void tblPendaftaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblPendaftaran.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                idPendaftaran = row.Cells["id_daftar"].Value.ToString();
                idResep = row.Cells["id_resep"].Value.ToString();
                string namaResepsionis = row.Cells["nama_resepsionis"].Value.ToString();
                string namaDokter = row.Cells["nama_dokter"].Value.ToString();
                string namaPasien = row.Cells["nama_pasien"].Value.ToString();
                tarifJasa = decimal.Parse(row.Cells["tarif_jasa"].Value.ToString());
                hargaResep = decimal.Parse(row.Cells["harga_resep"].Value.ToString());

                txID.Text = IDPembayaran();
                txResepsionis.Text = namaResepsionis;
                txDokter.Text = namaDokter;
                txPasien.Text = namaPasien;
                txTotalHarga.Text = TotalHarga().ToString("C0");
            }
            btnBayar.Enabled = true;
        }
    }
}
