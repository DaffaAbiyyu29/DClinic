using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Karyawan : Form
    {
        Msg_Box mBox = new Msg_Box();
        byte[] imageData;
        int validNamaUsername;
        bool updateFoto = false;
        string jabatan, status;
        public Form_Master_Karyawan()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariKaryawan.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txEmail.Clear();
            txTelp.Clear();
            txUsername.Clear();
            txPassword.Clear();
            cbJabatan.SelectedIndex = -1;
            cbJabatan.ForeColor = Color.White;
            imgProfil.Image = null;
            status = "";
            updateFoto = false;
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txEmail.Enabled = false;
            txTelp.Enabled = false;
            txUsername.Enabled = false;
            txPassword.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
            btnCariGambar.Enabled = false;
            btnHapusGambar.Enabled = false;
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariKaryawan.Text))
            {
                txCariKaryawan.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                txCariKaryawan.IconLeft = Properties.Resources.white_magnifier;
            }

            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_id_card;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_id_card;
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

            if (!string.IsNullOrEmpty(txEmail.Text))
            {
                txEmail.IconLeft = Properties.Resources.green_email;
            }
            else
            {
                txEmail.IconLeft = Properties.Resources.white_email;
            }

            if (!string.IsNullOrEmpty(txPassword.Text))
            {
                txPassword.IconLeft = Properties.Resources.green_pass;
            }
            else
            {
                txPassword.IconLeft = Properties.Resources.white_pass;
            }

            if (!string.IsNullOrEmpty(txUsername.Text))
            {
                txUsername.IconLeft = Properties.Resources.green_user;
            }
            else
            {
                txUsername.IconLeft = Properties.Resources.white_user;
            }
        }
        private string IDKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDKaryawan()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int CekNamaUsername(string Nama, string Username)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNamaUsername(@Nama, @Username)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Nama", Nama);
                    command.Parameters.AddWithValue("@Username", Username);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void TambahKaryawan()
        {
            // Ambil gambar yang akan disimpan
            Image image = imgProfil.Image;
            imageData = null;

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertKaryawan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Karyawan", txID.Text);
            insert.Parameters.AddWithValue("Nama", txNama.Text);
            insert.Parameters.AddWithValue("Email", txEmail.Text);
            insert.Parameters.AddWithValue("Telp", txTelp.Text);
            insert.Parameters.AddWithValue("Username", txUsername.Text);
            insert.Parameters.AddWithValue("Password", txPassword.Text);
            insert.Parameters.AddWithValue("Jabatan", cbJabatan.Text);
            imageData = ImageToByteArray(image);
            insert.Parameters.Add("@Foto", SqlDbType.VarBinary, -1).Value = imageData;

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambah " +cbJabatan.Text;
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }
        private void cariKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);
            string data = txCariKaryawan.Text;
            if (txCariKaryawan.Text.Length != 0)
            {
                SqlCommand search = new SqlCommand("sp_SearchKaryawan", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", "");

                try
                {
                    connection.Open();
                    search.ExecuteNonQuery();
                    SqlDataReader reader = search.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Ambil nilai-nilai kolom dari reader
                            string id = reader.GetString(0);
                            string nama = reader.GetString(1);
                            string email = reader.GetString(2);
                            string telp = reader.GetString(3);
                            string username = reader.GetString(4);
                            string password = reader.GetString(5);
                            jabatan = reader.GetString(6);
                            imageData = (byte[])reader["Foto"];
                            status = reader.GetString(8);
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

                            txID.Enabled = false;
                            txNama.Enabled = true;
                            txEmail.Enabled = true;
                            txTelp.Enabled = true;
                            cbJabatan.Enabled = true;
                            btnUpdate.Enabled = true;
                            btnCariGambar.Enabled = true;
                            btnHapusGambar.Enabled = true;

                            txID.Text = id;
                            txNama.Text = nama;
                            txEmail.Text = email;
                            txUsername.Text = username;
                            txPassword.Text = password;
                            txTelp.Text = telp;
                            cbJabatan.Text = jabatan;
                            imgProfil.Image = ByteArrayToImage(imageData);
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Karyawan " + txCariKaryawan.Text + " Tidak Ditemukan, Silakan Cari Karyawan Kembali!";
                        mBox.session.Text = "Karyawan";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    mBox.text1.Text = "Gagal Mencari Karyawan";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
        }
        private void NonAktifKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableKaryawan", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_Karyawan", txID.Text);
            disable.Parameters.AddWithValue("Jabatan", cbJabatan.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnNonAktif_Click(object sender, EventArgs e)
        {
            NonAktifKaryawan();
        }
        private void AktifKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableKaryawan", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_Karyawan", txID.Text);
            enable.Parameters.AddWithValue("Jabatan", cbJabatan.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktifKaryawan();
        }
        private void UpdateKaryawan()
        {
            // Ambil gambar yang akan disimpan
            Image image = imgProfil.Image;

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateKaryawan", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Karyawan", txID.Text);
            update.Parameters.AddWithValue("Nama", txNama.Text);
            update.Parameters.AddWithValue("Email", txEmail.Text);
            update.Parameters.AddWithValue("Telp", txTelp.Text);
            update.Parameters.AddWithValue("Username", txUsername.Text);
            update.Parameters.AddWithValue("Password", txPassword.Text);
            update.Parameters.AddWithValue("Jabatan", cbJabatan.Text);

            if (!updateFoto)
            {
                update.Parameters.Add("@Foto", SqlDbType.VarBinary, -1).Value = imageData;
            }
            else
            {
                imageData = ImageToByteArray(image);
                update.Parameters.Add("@Foto", SqlDbType.VarBinary, -1).Value = imageData;
            }

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool validEmail = ValidasiEmail(txEmail.Text);

            if (txNama.Text.Length != 0 && txTelp.Text.Length != 0 && txEmail.Text.Length != 0 && txUsername.Text.Length != 0 && txPassword.Text.Length != 0 && cbJabatan.SelectedIndex != -1)
            {
                if (txTelp.Text.Length < 12)
                {
                    mBox.text1.Text = "Nomor Telepon Tidak Valid";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    mBox.WarningMessage();
                }
                else
                {
                    if (validEmail)
                    {
                        UpdateKaryawan();
                    }
                    else
                    {
                        mBox.text1.Text = "Format Email Salah!\nexample@gmail.com";
                        mBox.session.Text = "Karyawan";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool validEmail = ValidasiEmail(txEmail.Text);

            if (txNama.Text.Length != 0 && txTelp.Text.Length != 0 && txEmail.Text.Length != 0 && txUsername.Text.Length != 0 && txPassword.Text.Length != 0 && cbJabatan.SelectedIndex != -1)
            {
                if(txTelp.Text.Length < 12)
                {
                    mBox.text1.Text = "Nomor Telepon Tidak Valid";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    mBox.WarningMessage();
                } else
                {
                    if(validNamaUsername == 0)
                    {
                        if (validEmail)
                        {
                            TambahKaryawan();
                        }
                        else
                        {
                            mBox.text1.Text = "Format Email Salah!\nexample@gmail.com";
                            mBox.session.Text = "Karyawan";
                            mBox.Show();
                            mBox.WarningMessage();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Nama / Username Sudah Tersedia!";
                        mBox.session.Text = "Karyawan";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                }
            } else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            // Create and configure the OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Direktori awal dialog
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Filter ekstensi berkas gambar yang ditampilkan
                openFileDialog.FilterIndex = 1; // Indeks filter yang aktif saat dialog ditampilkan

                // Tampilkan dialog "Open File" dan periksa apakah pengguna memilih berkas gambar sebelum mengambil hasilnya
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    updateFoto = true;
                    // Dapatkan nama berkas gambar yang dipilih oleh pengguna
                    string selectedFileName = openFileDialog.FileName;

                    // Tampilkan gambar dalam PictureBox (Contoh)
                    imgProfil.Image = Image.FromFile(selectedFileName);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            txID.Text = IDKaryawan();
            txNama.Enabled = true;
            txEmail.Enabled = true;
            txTelp.Enabled = true;
            txUsername.Enabled = true;
            txPassword.Enabled = true;
            cbJabatan.Enabled = true;
            btnCariGambar.Enabled = true;
            btnHapusGambar.Enabled = true;
            btnSimpan.Enabled = true;
            imgProfil.Image = Properties.Resources.profil_default;
        }

        private void btnHapusGambar_Click(object sender, EventArgs e)
        {
            updateFoto = true;
            imgProfil.Image = Properties.Resources.profil_default;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            if (txCariKaryawan.Text != "")
            {
                cariKaryawan();
            }
            else
            {
                mBox.text1.Text = "Masukkan Karyawan Yang Ingin Diubah!";
                mBox.session.Text = "Karyawan";
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

        private void cbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJabatan.SelectedIndex != -1)
            {
                imgJabatan.Image = Properties.Resources.green_jabatan;
                lblJabatan.Visible = false;
                cbJabatan.ForeColor = Color.FromArgb(131, 235, 97);
            }
            else
            {
                imgJabatan.Image = Properties.Resources.white_jabatan;
                lblJabatan.Visible = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
        }
        public static bool ValidasiEmail(string email)
        {
            // Pola regular expression untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Lakukan validasi menggunakan Regex.IsMatch
            return Regex.IsMatch(email, pattern);
        }

        private void ValidasiNamaUsername(object sender, EventArgs e)
        {
            Gambar();

            if (!string.IsNullOrEmpty(txNama.Text) || !string.IsNullOrEmpty(txUsername.Text))
            {
                validNamaUsername = CekNamaUsername(txNama.Text, txUsername.Text);
            }
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
