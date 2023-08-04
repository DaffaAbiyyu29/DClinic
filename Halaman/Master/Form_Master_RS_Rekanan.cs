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
    public partial class Form_Master_RS_Rekanan : Form
    {
        Msg_Box mBox = new Msg_Box();

        string id, nama, alamat, telp, status;
        bool ditemukan = false;
        int validNamaRS, validNomorTelpRS = 0;
        public Form_Master_RS_Rekanan()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariRS.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txTelp.Clear();
            txAlamat.Clear();
            status = "";
            epWarning.SetError(txNama, "");
            epWarning.SetError(txTelp, "");
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txTelp.Enabled = false;
            txAlamat.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariRS.Text))
            {
                txCariRS.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                txCariRS.IconLeft = Properties.Resources.white_magnifier;
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

            if (!string.IsNullOrEmpty(txTelp.Text))
            {
                txTelp.IconLeft = Properties.Resources.green_telephone;
            }
            else
            {
                txTelp.IconLeft = Properties.Resources.white_telephone;
            }

            if (!string.IsNullOrEmpty(txAlamat.Text))
            {
                txAlamat.IconLeft = Properties.Resources.green_location;
            }
            else
            {
                txAlamat.IconLeft = Properties.Resources.white_location;
            }
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariRS.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchRumahSakitRekanan", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data); 
                search.Parameters.AddWithValue("Status", ""); 
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblRSRujukan.DataSource = table;
            }
        }
        private void tblRSRujukan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblRSRujukan.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void Form_RS_Rekanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.RumahSakitRekanan' table. You can move, or remove it, as needed.
            this.rumahSakitRekananTableAdapter.Fill(this.dClinicDataSet.RumahSakitRekanan);
            // TODO: This line of code loads data into the 'dClinicDataSet.RumahSakitRekanan' table. You can move, or remove it, as needed.
            this.rumahSakitRekananTableAdapter.Fill(this.dClinicDataSet.RumahSakitRekanan);
            cariData();
        }
        private int CekNamaRS(string Nama, string id)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNamaRS(@Nama, @ID)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Nama", Nama);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }

        private int CekNomorTelpRS(string Telp, string id)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNomorTelpRsRekanan(@Telp, @ID)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Telp", Telp);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void TambahRS()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertRumahSakitRekanan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_RumahSakit", txID.Text);
            insert.Parameters.AddWithValue("Nama", txNama.Text);
            insert.Parameters.AddWithValue("Telp", txTelp.Text);
            insert.Parameters.AddWithValue("Alamat", txAlamat.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Menambahkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
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
            if (txNama.Text.Length != 0 && txAlamat.Text.Length != 0 && txTelp.Text.Length != 0)
            {
                if (validNamaRS == 0)
                {
                    if (validNomorTelpRS == 0)
                    {
                        if (txTelp.Text.Length < 12)
                        {
                            mBox.text1.Text = "Nomor Telepon Tidak Valid";
                            mBox.session.Text = "RS";
                            mBox.Show();
                            mBox.WarningMessage();
                        }
                        else
                        {
                            TambahRS();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Nomor Telepon Sudah Terdaftar!";
                        mBox.session.Text = "RS";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    
                }
                else
                {
                    mBox.text1.Text = "Rumah Sakit Sudah Tersedia!";
                    mBox.session.Text = "RS";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
        private void UpdateRS()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateRumahSakitRekanan", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_RumahSakit", txID.Text);
            update.Parameters.AddWithValue("Nama", txNama.Text);
            update.Parameters.AddWithValue("Telp", txTelp.Text);
            update.Parameters.AddWithValue("Alamat", txAlamat.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
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
            if (txNama.Text.Length != 0 && txAlamat.Text.Length != 0 && txTelp.Text.Length != 0)
            {
                if (validNamaRS == 0)
                {
                    if (validNomorTelpRS == 0)
                    {
                        if (txTelp.Text.Length < 12)
                        {
                            mBox.text1.Text = "Nomor Telepon Tidak Valid";
                            mBox.session.Text = "RS";
                            mBox.Show();
                            mBox.WarningMessage();
                        }
                        else
                        {
                            TambahRS();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Nomor Telepon Sudah Terdaftar!";
                        mBox.session.Text = "RS";
                        mBox.Show();
                        mBox.WarningMessage();
                    }

                }
                else
                {
                    mBox.text1.Text = "Rumah Sakit Sudah Tersedia!";
                    mBox.session.Text = "RS";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
        private void NonAktifRS()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableRumahSakitRekanan", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_RumahSakit", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
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
            NonAktifRS();
        }
        private void AktifRS()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableRumahSakitRekanan", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_RumahSakit", txID.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Rumah Sakit Rekanan";
                mBox.session.Text = "RS";
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
            AktifRS();
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tblRSRujukan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblRSRujukan.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                id = row.Cells["id_rs"].Value.ToString();
                nama = row.Cells["nama_rs"].Value.ToString();
                alamat = row.Cells["alamat_rs"].Value.ToString();
                telp = row.Cells["telp_rs"].Value.ToString();
                status = row.Cells["status_rs"].Value.ToString();

                txID.Enabled = false;
                txNama.Enabled = true;
                txTelp.Enabled = true;
                txAlamat.Enabled = true;
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
                txTelp.Text = telp;
                txAlamat.Text = alamat;
            }
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void txCariRS_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariRS.Text))
            {
                cariData();
                txCariRS.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariRS.IconLeft = Properties.Resources.white_magnifier;
            }
        }

        private void ValidasiNamaRS(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txNama.Text))
            {
                validNamaRS = CekNamaRS(txNama.Text, txID.Text);
                if (validNamaRS != 0)
                {
                    epWarning.SetError(txNama, "Rumah Sakit Sudah Tersedia!");
                }
                else
                {
                    epWarning.SetError(txNama, "");
                }
            }
            Gambar();
        }

        private void txTelp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txTelp.Text))
            {
                validNomorTelpRS = CekNomorTelpRS(txTelp.Text, txID.Text);
                if (validNomorTelpRS != 0)
                {
                    epWarning.SetError(txTelp, "Nomor Telepon Sudah Terdaftar!");
                }
                else if (txTelp.Text.Length < 12)
                {
                    epWarning.SetError(txTelp, "Nomor Telepon Tidak Valid!");
                }
                else
                {
                    epWarning.SetError(txTelp, "");
                }
            }
            Gambar();
        }

        private string IDRSRekanan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDRumahSakitRekanan()"; // Ganti "dbo" dengan skema fungsi Anda

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
            txID.Text = IDRSRekanan();
            txNama.Enabled = true;
            txTelp.Enabled = true;
            txAlamat.Enabled = true;
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
            if (txCariRS.Text != "")
            {
                if (ditemukan)
                {
                    cariData();
                    txID.Enabled = false;
                    txNama.Enabled = true;
                    txTelp.Enabled = true;
                    txAlamat.Enabled = true;
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
                    txTelp.Text = telp;
                    txAlamat.Text = alamat;
                } else
                {
                    mBox.text1.Text = "Rumah Sakit Rekanan " + txCariRS.Text + " Tidak Ditemukan, Silakan Cari Rumah Sakit Rekanan Kembali!";
                    mBox.session.Text = "RS";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Rumah Sakit Rekanan Yang Ingin Diubah!";
                mBox.session.Text = "RS";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
    }
}
