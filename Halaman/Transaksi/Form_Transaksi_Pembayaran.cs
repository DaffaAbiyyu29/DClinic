using D_Clinic.Halaman.Laporan;
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
using System.Text.RegularExpressions;
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
            txCariPendaftaran.Clear();
            txID.Clear();
            txResepsionis.Clear();
            txDokter.Clear();
            txPasien.Clear();
            txTotalHarga.Clear();
            txTunai.Clear();
            txKembali.Clear();
            txTunai.Enabled = false;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariPendaftaran.Text))
            {
                txCariPendaftaran.IconLeft = Properties.Resources.green_magnifier;
                cariPendaftaran();
            }
            else
            {
                txCariPendaftaran.IconLeft = Properties.Resources.white_magnifier;
                cariPendaftaran();
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
            if (!string.IsNullOrEmpty(txKembali.Text))
            {
                txKembali.IconLeft = Properties.Resources.green_harga;
            }
            else
            {
                txKembali.IconLeft = Properties.Resources.white_harga;
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
            dClinicDataSet.View_TrsPembayaran.Columns["Id_TrsResep"].AllowDBNull = true;
            this.view_TrsPembayaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPembayaran);
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
            btnBayar.Enabled = false;
        }
        private void cariPendaftaran()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariPendaftaran.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_Search_TrsPendaftaran_TrsPembayaran", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblPendaftaran.DataSource = table;
            }
        }
        private void Bayar()
        {
            string waktu = currentDateTime.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("en-US")); // Format: HH:mm:ss
            string unformatTotalHarga = Regex.Replace(txTotalHarga.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            //EXEC SP INSERT TABLE TRANSAKSI PEMBERIAN RESEP
            SqlCommand insert_trs = new SqlCommand("sp_InsertTrsPembayaran", connection);
            insert_trs.CommandType = CommandType.StoredProcedure;
            insert_trs.Parameters.AddWithValue("Id_TrsPembayaran", txID.Text);
            insert_trs.Parameters.AddWithValue("Id_TrsPendaftaran", idPendaftaran);
            if(idResep.Length == 0)
            {
                insert_trs.Parameters.AddWithValue("Id_TrsResep", DBNull.Value);
            }
            else
            {
                insert_trs.Parameters.AddWithValue("Id_TrsResep", idResep);
            }
            insert_trs.Parameters.AddWithValue("Tanggal", DateTime.Parse(txTanggal.Text));
            insert_trs.Parameters.AddWithValue("Waktu", waktu);
            insert_trs.Parameters.AddWithValue("Total_Bayar", unformatTotalHarga);

            try
            {
                connection.Open();
                insert_trs.ExecuteNonQuery();
                mBox.text1.Text = "Pembayaran Berhasil";
                mBox.session.Text = "Bayar";
                mBox.Show();
                mBox.SuccessMessage();
                string unformatTunai = Regex.Replace(txTunai.Text, "[^0-9]", "");
                int tunai = int.Parse(unformatTunai);
                Struk_Pembayaran struk = new Struk_Pembayaran();
                string id = txID.Text;
                struk.id = id;
                struk.tunai = tunai;
                struk.Show();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Pembayaran Gagal";
                mBox.session.Text = "Bayar";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                this.view_TrsPembayaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPembayaran);
                cariPendaftaran();
            }
        }
        private void btnBayar_Click(object sender, EventArgs e)
        {
            Bayar();
        }

        private void tblPembayaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblPembayaran.Rows[e.RowIndex].Cells["no_bayar"].Value = (e.RowIndex + 1).ToString();
        }
        private decimal HitungKembali()
        {
            string unformatTotalHarga = Regex.Replace(txTotalHarga.Text, "[^0-9]", "");
            string unformatTotalBayar = Regex.Replace(txTunai.Text, "[^0-9]", "");
            decimal totalHarga = decimal.Parse(unformatTotalHarga);
            decimal totalBayar = decimal.Parse(unformatTotalBayar);
            decimal totalKembali = totalBayar - totalHarga;
            return totalKembali;
        }
        private void txBayar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txTunai.Text))
            {
                string unformatTotalHarga = Regex.Replace(txTotalHarga.Text, "[^0-9]", "");
                string unformatTotalBayar = Regex.Replace(txTunai.Text, "[^0-9]", "");
                decimal amount = 0;
                if (Decimal.TryParse(unformatTotalBayar, out amount))
                {
                    string formattedAmount = string.Format(new CultureInfo("id-ID"), "{0:C0}", amount);
                    txTunai.Text = formattedAmount;
                    txTunai.SelectionStart = txTunai.Text.Length;
                }
                txTunai.IconLeft = Properties.Resources.green_harga;
                txKembali.Text = HitungKembali().ToString("C0");
            }
            else
            {
                txTunai.IconLeft = Properties.Resources.white_harga;
                txKembali.Text = 0.ToString("C0");
            }
        }

        private void txBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txTunai.TextLength == 0)
            {
                if(!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }            
            }
        }

        private decimal TotalHarga()
        {
            return tarifJasa + hargaResep;
        }
        private void tblPendaftaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txTunai.Enabled = true;
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
                //hargaResep = decimal.Parse(row.Cells["harga_resep"].Value.ToString());
                decimal? cellHargaResep= row.Cells["harga_resep"].Value as decimal?;
                if (cellHargaResep.HasValue)
                {
                    // Jika nilai sel memiliki nilai atau tidak null, tampilkan nilainya
                    hargaResep = cellHargaResep.Value;
                }
                else
                {
                    // Jika nilai sel adalah null, berikan penanganan khusus
                    hargaResep = 0;
                }
                string id_resep = row.Cells["id_resep"].Value.ToString();
                string status_resep = row.Cells["s_resep"].Value.ToString();
                if(id_resep.Length == 0)
                {
                    txID.Text = IDPembayaran();
                    txResepsionis.Text = namaResepsionis;
                    txDokter.Text = namaDokter;
                    txPasien.Text = namaPasien;
                    txTotalHarga.Text = TotalHarga().ToString("C0");
                    btnBayar.Enabled = true;
                }
                else
                {
                    if (status_resep == "Aktif")
                    {
                        txID.Text = IDPembayaran();
                        txResepsionis.Text = namaResepsionis;
                        txDokter.Text = namaDokter;
                        txPasien.Text = namaPasien;
                        txTotalHarga.Text = TotalHarga().ToString("C0");
                        btnBayar.Enabled = true;
                    }
                    else
                    {
                        mBox.text1.Text = "Resep Belum Diterima Apoteker";
                        mBox.session.Text = "Bayar";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                }
            }
        }
    }
}
