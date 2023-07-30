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

namespace D_Clinic.Halaman
{
    public partial class Form_Transaksi_Pendaftaran_Pasien : Form
    {
        Msg_Box mBox = new Msg_Box();

        DateTime currentDateTime = DateTime.Now;
        string id_pasien, nama;

        public Form_Transaksi_Pendaftaran_Pasien()
        {
            InitializeComponent();
        }

        private void Form_Pendaftaran_Pasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_TrsPendaftaran' table. You can move, or remove it, as needed.
            this.view_TrsPendaftaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPendaftaran);
            // TODO: This line of code loads data into the 'dClinicDataSet.Pasien' table. You can move, or remove it, as needed.
            this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            Dokter_Tersedia();
            txTanggal.Text = currentDateTime.ToString("dd MMMM yyyy");
            cariData();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariPasien.Clear();
            txID.Clear();
            txPasien.Clear();
            cbDokter.SelectedIndex = -1;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }
            if (!string.IsNullOrEmpty(txPasien.Text))
            {
                txPasien.IconLeft = Properties.Resources.green_pasien;
            }
            else
            {
                txPasien.IconLeft = Properties.Resources.white_pasien;
            }
        }
        private string IDPendaftaran()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDTrsPendaftaran()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form_View_Pasien pasien = new Form_View_Pasien();
            this.Hide();
            pasien.txCariData.Clear();
        }

        private void cbDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDokter.SelectedIndex != -1)
            {
                imgDokter.Image = Properties.Resources.green_dokter;
                lblDokter.ForeColor = Color.FromArgb(131, 235, 97);
                lblDokter.Visible = false;
            }
            else
            {
                imgDokter.Image = Properties.Resources.white_dokter;
                lblDokter.ForeColor = Color.White;
                lblDokter.Visible = true;
            }
        }
        private string GenerateIDResepsionis()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_Karyawan FROM Karyawan WHERE Nama = '" +txResepsionis.Text+ "'";
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
                        return reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return null;
        }
        private string GenerateIDDokter()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_JadwalDokter FROM View_JadwalDokter WHERE Nama = '" + cbDokter.Text + "'";

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
                        return reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return null;
        }
        private void Dokter_Tersedia()
        {
            string hari = currentDateTime.ToString("dddd");
            string jam = currentDateTime.ToString("HH:mm", new CultureInfo("en-US"));
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand search = new SqlCommand("sp_Search_Dokter_Tersedia", connection);
            search.CommandType = CommandType.StoredProcedure;
            search.Parameters.AddWithValue("Hari", hari);
            search.Parameters.AddWithValue("Jam", jam);
            connection.Open();
            search.ExecuteNonQuery();
            SqlDataReader reader = search.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        string dokter = reader.GetString(0);
                        cbDokter.Items.Add(dokter);
                    }
                }
                reader.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariPasien.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchPasien", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data); 
                search.Parameters.AddWithValue("Status", "Aktif"); 
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblPasien.DataSource = table;
            }
        }
        private void PendaftaranPasien()
        {
            string waktu = currentDateTime.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("en-US")); // Format: HH:mm:ss

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertTrsPendaftaran", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_TrsPendaftaran", txID.Text);
            insert.Parameters.AddWithValue("Id_Resepsionis", GenerateIDResepsionis());
            insert.Parameters.AddWithValue("Id_Dokter", GenerateIDDokter());
            insert.Parameters.AddWithValue("Id_Pasien", id_pasien);
            insert.Parameters.AddWithValue("Tanggal", DateTime.Parse(txTanggal.Text));
            insert.Parameters.AddWithValue("Waktu", waktu);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Pendaftaran Berhasil";
                mBox.session.Text = "Daftar";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                cbDokter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Pendaftaran Gagal";
                mBox.session.Text = "Daftar";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                this.view_TrsPendaftaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPendaftaran);
                cariData();
            }
        }
        private void tblPasien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblPasien.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

        }

        private void txCariPasien_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariPasien.Text))
            {
                cariData();
                txCariPasien.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariPasien.IconLeft = Properties.Resources.white_magnifier;
            }
        }

        private void tblPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txID.Text = IDPendaftaran();
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblPasien.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                id_pasien = row.Cells["idPasien"].Value.ToString();
                nama = row.Cells["namaPasien"].Value.ToString();
                txPasien.Text = nama;
            }
            cbDokter.Enabled = true;
            btnDaftar.Enabled = true;
        }

        private void tblTrsPendaftaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblTrsPendaftaran.Rows[e.RowIndex].Cells["nomor"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if(txResepsionis.Text.Length != 0 || txPasien.Text.Length != 0 || cbDokter.SelectedIndex != -1 || txTanggal.Text.Length != 0)
            {
                PendaftaranPasien();
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Daftar";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            cbDokter.Enabled = false;
            btnDaftar.Enabled = false;
        }
    }
}
