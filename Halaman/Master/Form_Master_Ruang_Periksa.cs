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

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Ruang_Periksa : Form
    {
        Msg_Box mBox = new Msg_Box();

        bool ditemukan = false;
        string id, nama, status;
        public Form_Master_Ruang_Periksa()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariRuangPeriksa.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            status = "";
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariRuangPeriksa.Text))
            {
                txCariRuangPeriksa.IconLeft = Properties.Resources.green_magnifier;
                cariData();
            }
            else
            {
                txCariRuangPeriksa.IconLeft = Properties.Resources.white_magnifier;
                cariData();
            }

            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }

            if (!string.IsNullOrEmpty(txNama.Text))
            {
                txNama.IconLeft = Properties.Resources.green_name;
            }
            else
            {
                txNama.IconLeft = Properties.Resources.white_name;
            }
        }
        private void tblRuangPeriksa_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblRuangPeriksa.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariRuangPeriksa.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchRuangPeriksa", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data); 
                search.Parameters.AddWithValue("Status", ""); 
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblRuangPeriksa.DataSource = table;

                SqlDataReader reader = search.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ditemukan = true;
                        // Ambil nilai-nilai kolom dari reader
                        id = reader.GetString(0);
                        nama = reader.GetString(1);
                        status = reader.GetString(2);
                    }
                }
                reader.Close();
            }
        }
        private void Form_Ruang_Periksa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.RuangPeriksa' table. You can move, or remove it, as needed.
            this.ruangPeriksaTableAdapter.Fill(this.dClinicDataSet.RuangPeriksa);
            cariData();
        }
        private void UpdateRuangan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateRuangPeriksa", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_RuangPeriksa", txID.Text);
            update.Parameters.AddWithValue("Nama_Ruang", txNama.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();

            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                cariData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txNama.Text.Length != 0)
            {
                UpdateRuangan();
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
        private void NonAktifRuangan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableRuangPeriksa", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_RuangPeriksa", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                cariData();
            }
        }
        private void btnNonAktif_Click(object sender, EventArgs e)
        {
            NonAktifRuangan();
        }
        private void AktifRuangan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableRuangPeriksa", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_RuangPeriksa", txID.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                cariData();
            }
        }
        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktifRuangan();
        }
        private string IDRuangPeriksa()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDRuangPeriksa()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            txID.Text = IDRuangPeriksa();
            txNama.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            cariData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            if (txCariRuangPeriksa.Text != "")
            {
                if (ditemukan)
                {
                    cariData();
                    txID.Enabled = false;
                    txNama.Enabled = true;
                    btnUpdate.Enabled = true;
                    if (status == "Non-Aktif")
                    {
                        btnAktif.Visible = true;
                        btnNonAktif.Visible = false;
                    }
                    else if (status == "Aktif")
                    {
                        btnAktif.Visible = false;
                        btnNonAktif.Visible = true;
                    }

                    txID.Text = id;
                    txNama.Text = nama;
                }
                else
                {
                    mBox.text1.Text = "Ruang Periksa " + txCariRuangPeriksa.Text + " Tidak Ditemukan, Silakan Cari Ruang Periksa Kembali!";
                    mBox.session.Text = "Ruang";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Ruang Periksa Yang Ingin Diubah!";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void tblRuangPeriksa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblRuangPeriksa.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                id = row.Cells["id_ruang"].Value.ToString();
                nama = row.Cells["nama_ruang"].Value.ToString();
                status = row.Cells["status_ruang"].Value.ToString();

                txID.Enabled = false;
                txNama.Enabled = true;
                btnUpdate.Enabled = true;
                if (status == "Non-Aktif")
                {
                    btnAktif.Visible = true;
                    btnNonAktif.Visible = false;
                }
                else if (status == "Aktif")
                {
                    btnAktif.Visible = false;
                    btnNonAktif.Visible = true;
                }

                txID.Text = id;
                txNama.Text = nama;
            }
        }

        private void txCariRuangPeriksa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariRuangPeriksa.Text))
            {
                txCariRuangPeriksa.IconLeft = Properties.Resources.green_magnifier;
                cariData();
            }
            else
            {
                txCariRuangPeriksa.IconLeft = Properties.Resources.white_magnifier;
                cariData();
            }
        }

        private void GambarTextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void TambahRuangan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertRuangPeriksa", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_RuangPeriksa", txID.Text);
            insert.Parameters.AddWithValue("Nama_Ruang", txNama.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Menambahkan Ruang Periksa";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                cariData();
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txNama.Text.Length != 0)
            {
                TambahRuangan();
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Ruang";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
    }
}
