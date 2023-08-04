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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Supplier : Form
    {
        Msg_Box mBox = new Msg_Box();
        string id, nama, telp, status;
        bool ditemukan = false;
        int validNamaSupplier = 0, validNomorTelpSupplier = 0;
        public Form_Master_Supplier()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariSupplier.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txTelp.Clear();
            status = "";
            validNamaSupplier = 0;
            epWarning.SetError(txNama, "");
            epWarning.SetError(txTelp, "");
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txTelp.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariSupplier.Text))
            {
                txCariSupplier.IconLeft = Properties.Resources.green_magnifier;
                cariData();
            }
            else
            {
                txCariSupplier.IconLeft = Properties.Resources.white_magnifier;
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
            if (!string.IsNullOrEmpty(txTelp.Text))
            {
                txTelp.IconLeft = Properties.Resources.green_telephone;
            }
            else
            {
                txTelp.IconLeft = Properties.Resources.white_telephone;
            }
        }
        private void Form_Master_Supplier_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.dClinicDataSet.Supplier);
            cariData();
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariSupplier.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchSupplier", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", "");
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblSupplier.DataSource = table;
            }
        }
        private void tblSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblSupplier.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            cariData();
        }

        private void NonAktifSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableSupplier", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_Supplier", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Supplier";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Supplier";
                mBox.session.Text = "Supplier";
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
            NonAktifSupplier();
        }
        private void AktifSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableSupplier", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_Supplier", txID.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Supplier";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Supplier";
                mBox.session.Text = "Supplier";
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
            AktifSupplier();
        }
        private void UpdateSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateSupplier", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Supplier", txID.Text);
            update.Parameters.AddWithValue("Nama_Supplier", txNama.Text);
            update.Parameters.AddWithValue("Telp", txTelp.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Supplier";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Supplier";
                mBox.session.Text = "Supplier";
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
            if (txNama.Text.Length != 0 || txTelp.Text.Length != 0)
            {
                if (validNamaSupplier == 0)
                {
                    if (validNomorTelpSupplier == 0)
                    {
                        if (txTelp.Text.Length < 12)
                        {
                            mBox.text1.Text = "Nomor Telepon Tidak Valid";
                            mBox.session.Text = "Supplier";
                            mBox.Show();
                            mBox.WarningMessage();
                        }
                        else
                        {
                            TambahSupplier();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Nomor Telepon Sudah Terdaftar!";
                        mBox.session.Text = "Supplier";
                        mBox.Show();
                        mBox.WarningMessage();
                    }

                }
                else
                {
                    mBox.text1.Text = "Supplier Sudah Terdaftar!";
                    mBox.session.Text = "Supplier";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Harap Masukkan Semua Data!";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int CekNamaSupplier(string Nama, string id)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNamaSupplier(@Nama, @ID)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Nama", Nama);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }

        private int CekNomorTelpSupplier(string Telp, string id)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNomorTelpSupplier(@Telp, @ID)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Telp", Telp);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void TambahSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Supplier", txID.Text);
            insert.Parameters.AddWithValue("Nama_Supplier", txNama.Text);
            insert.Parameters.AddWithValue("Telp", txTelp.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Supplier";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Gagal Menambahkan Supplier";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txNama.Text.Length != 0 || txTelp.Text.Length != 0)
            {
                if (validNamaSupplier == 0)
                {
                    if (validNomorTelpSupplier == 0)
                    {
                        if (txTelp.Text.Length < 12)
                        {
                            mBox.text1.Text = "Nomor Telepon Tidak Valid";
                            mBox.session.Text = "Supplier";
                            mBox.Show();
                            mBox.WarningMessage();
                        }
                        else
                        {
                            TambahSupplier();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Nomor Telepon Sudah Terdaftar!";
                        mBox.session.Text = "Supplier";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    
                }
                else
                {
                    mBox.text1.Text = "Supplier Sudah Terdaftar!";
                    mBox.session.Text = "Supplier";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Harap Masukkan Semua Data!";
                mBox.session.Text = "Supplier";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void ValidasiNamaSupplier(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txNama.Text))
            {
                validNamaSupplier = CekNamaSupplier(txNama.Text, txID.Text);
                if (validNamaSupplier != 0)
                {
                    epWarning.SetError(txNama, "Supplier Sudah Terdaftar!");
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
                validNomorTelpSupplier = CekNomorTelpSupplier(txTelp.Text, txID.Text);
                if (validNomorTelpSupplier != 0)
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

        private void tblSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblSupplier.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                id = row.Cells["id_supplier"].Value.ToString();
                nama = row.Cells["nama_supplier"].Value.ToString();
                telp = row.Cells["telp_supplier"].Value.ToString();
                status = row.Cells["status_supplier"].Value.ToString();

                txID.Enabled = false;
                txNama.Enabled = true;
                txTelp.Enabled = true;
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
            }
        }
        private string IDSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDSupplier()"; // Ganti "dbo" dengan skema fungsi Anda

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
            txID.Text = IDSupplier();
            txNama.Enabled = true;
            txTelp.Enabled = true;
            btnSimpan.Enabled = true;
        }
    }
}
