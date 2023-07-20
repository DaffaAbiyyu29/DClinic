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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_Pengaturan_Akun : Form
    {
        Msg_Box mBox = new Msg_Box();
        byte[] imageData;

        string lastLogin;
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

            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    D_Clinic.Karyawan update = context.Karyawans.FirstOrDefault(data => data.Id_Karyawan == txID.Text);
                    update.Nama = txNama.Text;
                    update.Email = txEmail.Text;
                    update.Telp = txTelp.Text;
                    update.Username = txUsername.Text;
                    update.Password = txPassword.Text;
                    if (imgProfil.Image != null)
                    {
                        // Konversi gambar ke byte array
                        imageData = ImageToByteArray(image);
                        update.Foto = imageData;
                    }
                    else
                    {
                        imageData = null;
                        update.Foto = imageData;
                    }

                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Memperbarui Akun";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    mBox.SuccessMessage();
                    GenerateKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            UpdateKaryawan();
            Gambar();
        }
        private void HapusKaryawan()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    D_Clinic.Karyawan delete = context.Karyawans.FirstOrDefault(data => data.Id_Karyawan == txID.Text);

                    context.Karyawans.DeleteOnSubmit(delete);
                    context.SubmitChanges();

                    this.Hide();
                    mBox.text1.Text = "Akun Terhapus";
                    mBox.session.Text = "Akun Terhapus";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusKaryawan();
            Gambar();
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

        private void btnHapusGambar_Click(object sender, EventArgs e)
        {
            imageData = null;
            imgProfil.Image = null;
        }
    }
}
