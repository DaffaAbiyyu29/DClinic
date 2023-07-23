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

namespace D_Clinic.Halaman
{
    public partial class Form_Pengaturan_Akun : Form
    {
        Msg_Box mBox = new Msg_Box();
        byte[] imageData;
        bool updateFoto = false;
        string jabatan, lastLogin;
        public Form_Pengaturan_Akun()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txEmail.Clear();
            txTelp.Clear();
            txUsername.Clear();
            txPassword.Clear();
        }
        private void GenerateLastLogin()
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
                        lastLogin = reader.GetString(0);
                    }
                }
                reader.Close();
            }
        }
        private void GenerateKaryawan()
        {
            GenerateLastLogin();
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT * FROM Karyawan WHERE Nama = @nama";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nama", lastLogin);

                SqlDataReader reader = command.ExecuteReader();

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


                        txID.Text = id;
                        txNama.Text = nama;
                        txEmail.Text = email;
                        txTelp.Text = telp;
                        txUsername.Text = username;
                        txPassword.Text = password;
                        if (imageData.Length > 2)
                        {
                            imgProfil.Image = ByteArrayToImage(imageData);
                        }
                        else
                        {
                            imgProfil.Image = null;
                        }

                        Form_Menu menu = new Form_Menu();
                        menu.lblNama.Text = txNama.Text;
                    }
                }
                reader.Close();
            }
        }

        private void Form_Pengaturan_Akun_Load(object sender, EventArgs e)
        {
            GenerateKaryawan();
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
            update.Parameters.AddWithValue("Jabatan", jabatan);

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
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        public static bool ValidasiEmail(string email)
        {
            // Pola regular expression untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Lakukan validasi menggunakan Regex.IsMatch
            return Regex.IsMatch(email, pattern);
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool validEmail = ValidasiEmail(txEmail.Text);

            if (txNama.Text.Length != 0 && txTelp.Text.Length != 0 && txEmail.Text.Length != 0 && txUsername.Text.Length != 0 && txPassword.Text.Length != 0)
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
                        Gambar();
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            GenerateKaryawan();
            Gambar();
        }
        private void Gambar()
        {
            if (txID.Text.Length != 0)
            {
                txID.IconLeft = Properties.Resources.green_id_card;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_id_card;
            }

            if (txNama.Text.Length != 0)
            {
                txNama.IconLeft = Properties.Resources.green_name;
            }
            else
            {
                txNama.IconLeft = Properties.Resources.white_name;
            }

            if (txTelp.Text.Length != 0)
            {
                txTelp.IconLeft = Properties.Resources.green_telephone;
            }
            else
            {
                txTelp.IconLeft = Properties.Resources.white_telephone;
            }

            if (txEmail.Text.Length != 0)
            {
                txEmail.IconLeft = Properties.Resources.green_email;
            }
            else
            {
                txEmail.IconLeft = Properties.Resources.white_email;
            }

            if (txUsername.Text.Length != 0)
            {
                txUsername.IconLeft = Properties.Resources.green_user;
            }
            else
            {
                txUsername.IconLeft = Properties.Resources.white_user;
            }

            if (txPassword.Text.Length != 0)
            {
                txPassword.IconLeft = Properties.Resources.green_pass;
            }
            else
            {
                txPassword.IconLeft = Properties.Resources.white_pass;
            }
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
                    // Dapatkan nama berkas gambar yang dipilih oleh pengguna
                    string selectedFileName = openFileDialog.FileName;

                    // Tampilkan gambar dalam PictureBox (Contoh)
                    imgProfil.Image = Image.FromFile(selectedFileName);
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
            disable.Parameters.AddWithValue("Jabatan", jabatan);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Karyawan";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
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

        private void btnHapusGambar_Click(object sender, EventArgs e)
        {
            updateFoto = true;
            imgProfil.Image = Properties.Resources.profil_default;
        }
    }
}
