using D_Clinic.Resources;
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
using System.Windows.Interop;
using System.Xml.Linq;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Rekam_Medis : Form
    {
        Msg_Box mBox = new Msg_Box();

        string idRekamMedis, idPasien, namaPasien;
        int lastID;

        public Form_Master_Rekam_Medis()
        {
            InitializeComponent();
        }

        private void Form_Rekam_Medis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.Pasien' table. You can move, or remove it, as needed.
            this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            DateTime currentDateTime = DateTime.Now;
            dtpTanggal.Value = currentDateTime;
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            DateTime currentDateTime = DateTime.Now;
            dtpTanggal.Value = currentDateTime;
            txID.Enabled = true;
            txID.Clear();
            txPasien.Clear();
            txDiagnosa.Clear();
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txPasien.Enabled = false;
            dtpTanggal.Enabled = false;
            txDiagnosa.Enabled = false;
            btnSimpan.Enabled = false;
        }
        private void Gambar()
        {
            if (txID.Text.Length != 0)
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }

            if (txPasien.Text.Length != 0)
            {
                txPasien.IconLeft = Properties.Resources.green_pasien;
            }
            else
            {
                txPasien.IconLeft = Properties.Resources.white_pasien;
            }

            if (txDiagnosa.Text.Length != 0)
            {
                txDiagnosa.IconLeft = Properties.Resources.green_diagnosa;
            }
            else
            {
                txDiagnosa.IconLeft = Properties.Resources.white_diagnosa;
            }
        }

        private void tblPasien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblPasien.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        private void GenerateIDRekamMedis()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_RekamMedis, 3) AS ID FROM RekamMedis ORDER BY Id_RekamMedis DESC";

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

                idRekamMedis = string.Format("RMD{0:D3}", lastID + 1);
                txID.Text = idRekamMedis;
            }
        }

        private void Gambar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gambar();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            Gambar();
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            cariData();
        }
        private string GenerateIDPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_Pasien FROM Pasien WHERE Nama = '" + txPasien.Text + "'";
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
        private void TambahRekamMedis()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertRekamMedis", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_RekamMedis", txID.Text);
            insert.Parameters.AddWithValue("Id_Pasien", GenerateIDPasien());
            insert.Parameters.AddWithValue("Tanggal", dtpTanggal.Value);
            insert.Parameters.AddWithValue("Diagnosa", txDiagnosa.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Rekam Medis";
                mBox.session.Text = "RekamMedis";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Gagal Menambahkan Rekam Medis";
                mBox.session.Text = "RekamMedis";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txDiagnosa.Text.Length != 0)
            {
                DateTime currentDateTime = DateTime.Now;

                if (dtpTanggal.Value >= currentDateTime)
                {
                    TambahRekamMedis();
                    Gambar();
                }
                else
                {
                    mBox.text1.Text = "Tanggal Tidak Boleh Kurang Dari " + currentDateTime.ToString("dd MMMM yyyy");
                    mBox.session.Text = "RekamMedis";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "RekamMedis";
                mBox.Show();
                mBox.WarningMessage();

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
                search.Parameters.AddWithValue("Data", data); SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblPasien.DataSource = table;
            }
        }

        private void tblPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GenerateIDRekamMedis();
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblPasien.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                idPasien = row.Cells["id_pasien"].Value.ToString();
                namaPasien = row.Cells["nama_pasien"].Value.ToString();
                txPasien.Text = namaPasien;
            }
            dtpTanggal.Enabled = true;
            txDiagnosa.Enabled = true;
            btnSimpan.Enabled = true;
            txID.IconLeft = Properties.Resources.green_kode;
            txPasien.IconLeft = Properties.Resources.green_pasien;
        }
    }
}
