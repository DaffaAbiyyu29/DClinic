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
    public partial class Form_Transaksi_Rujukan_Pasien : Form
    {
        Msg_Box mBox = new Msg_Box();

        DateTime currentDateTime = DateTime.Now;
        string IDPendaftaran, namaDokter, namaPasien;
        public Form_Transaksi_Rujukan_Pasien()
        {
            InitializeComponent();
        }

        private void Form_Transaksi_Rujukan_Pasien_Load(object sender, EventArgs e)
        {
            this.view_TrsRujukanTableAdapter.Fill(this.dClinicDataSet.View_TrsRujukan);
            this.view_TrsPendaftaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPendaftaran);
            RS_Tersedia();
            cariData();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariPendaftaran.Clear();
            txID.Clear();
            txPasien.Clear();
            cbRumahSakit.SelectedIndex = -1;
            txKeterangan.Clear();
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
            if (!string.IsNullOrEmpty(txKeterangan.Text))
            {
                txKeterangan.IconLeft = Properties.Resources.green_keluhan;
            }
            else
            {
                txKeterangan.IconLeft = Properties.Resources.white_keluhan;
            }
            if (!string.IsNullOrEmpty(txDiagnosa.Text))
            {
                txDiagnosa.IconLeft = Properties.Resources.green_diagnosa;
            }
            else
            {
                txDiagnosa.IconLeft = Properties.Resources.white_diagnosa;
            }
        }
        private string IDRujukan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDTrsRujukan()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void RS_Tersedia()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand search = new SqlCommand("sp_Search_RS_Tersedia", connection);
            search.CommandType = CommandType.StoredProcedure;
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
                        string rs = reader.GetString(0);
                        cbRumahSakit.Items.Add(rs);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tblPendaftaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblPendaftaran.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            cbRumahSakit.Enabled = false;
            txKeterangan.Enabled = false;
        }

        private void txCariRS_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariPendaftaran.Text))
            {
                cariData();
                txCariPendaftaran.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariPendaftaran.IconLeft = Properties.Resources.white_magnifier;
            }
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariPendaftaran.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_Search_TrsPendaftaran_Tersedia_Rujukan", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Dokter", txDokter.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblPendaftaran.DataSource = table;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cariData();
            this.view_TrsRujukanTableAdapter.Fill(this.dClinicDataSet.View_TrsRujukan);
        }
        private string GenerateIDRS()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_RumahSakit FROM RumahSakitRekanan WHERE Nama = '" + cbRumahSakit.Text + "'";

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
        private void RujukanPasien()
        {
            string waktu = currentDateTime.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("en-US")); // Format: HH:mm:ss

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertTrsRujukan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_TrsRujukanPasien", txID.Text);
            insert.Parameters.AddWithValue("Id_TrsPendaftaran", IDPendaftaran);
            insert.Parameters.AddWithValue("Id_RumahSakit", GenerateIDRS());
            insert.Parameters.AddWithValue("Keterangan", txKeterangan.Text);
            insert.Parameters.AddWithValue("Tanggal", currentDateTime);
            insert.Parameters.AddWithValue("Waktu", waktu);
            insert.Parameters.AddWithValue("Diagnosa", txDiagnosa.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Rujukan Pasien Terkirim";
                mBox.session.Text = "Rujukan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                cbRumahSakit.Enabled = false;
                txKeterangan.Enabled = false;
            }
            catch (Exception ex)
            {
                mBox.text1.Text = "Rujukan Pasien Gagal";
                mBox.session.Text = "Rujukan";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                this.view_TrsPendaftaranTableAdapter.Fill(this.dClinicDataSet.View_TrsPendaftaran);
                cariData();
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (txDokter.Text.Length != 0 || txPasien.Text.Length != 0 || cbRumahSakit.SelectedIndex != -1 || txKeterangan.Text.Length != 0 || txDiagnosa.Text.Length != 0)
            {
                RujukanPasien();
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Rujukan";
                mBox.Show();
                mBox.WarningMessage();
            }
            this.view_TrsRujukanTableAdapter.Fill(this.dClinicDataSet.View_TrsRujukan);
        }

        private void tblRujukanPasien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblRujukanPasien.Rows[e.RowIndex].Cells["nomor"].Value = (e.RowIndex + 1).ToString();
        }

        private void tblPendaftaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txID.Text = IDRujukan();
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblPendaftaran.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                IDPendaftaran = row.Cells["id_daftar"].Value.ToString();
                namaDokter = row.Cells["nama_dokter"].Value.ToString();
                namaPasien = row.Cells["nama_pasien"].Value.ToString();
                txPasien.Text = namaPasien;
            }
            cbRumahSakit.Enabled = true;
            txKeterangan.Enabled = true;
            btnKirim.Enabled = true;
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void cbRumahSakit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRumahSakit.SelectedIndex != -1)
            {
                imgRS.Image = Properties.Resources.green_rs;
                lblRS.ForeColor = Color.FromArgb(131, 235, 97);
                lblRS.Visible = false;
            }
            else
            {
                imgRS.Image = Properties.Resources.white_rs;
                lblRS.ForeColor = Color.White;
                lblRS.Visible = true;
            }
        }
    }
}
