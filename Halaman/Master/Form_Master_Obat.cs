using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Obat : Form
    {
        Msg_Box mBox = new Msg_Box();
        int validNama = 0;
        string status;
        public Form_Master_Obat()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            DateTime currentDateTime = DateTime.Now;
            dtpKadaluarsa.Format = DateTimePickerFormat.Long;
            dtpKadaluarsa.Value = currentDateTime;
            txCariObat.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txMerk.Clear();
            cbKemasan.SelectedIndex = -1;
            cbKemasan.ForeColor = Color.White;
            txEfek.Clear();
            txHargaBeli.Clear();
            txHargaJual.Clear();
            dtpKadaluarsa.Value.ToLocalTime();
            txStok.Clear();
            status = "";
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txMerk.Enabled = false;
            cbKemasan.Enabled = false;
            txEfek.Enabled = false;
            txHargaBeli.Enabled = false;
            txHargaJual.Enabled = false;
            dtpKadaluarsa.Checked = false;
            dtpKadaluarsa.Enabled = false;
            txStok.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
        }
        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private string IDObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDObat()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int CekNamaObat(string Nama, string id)
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CekNamaObat(@Nama, @ID)"; // Ganti "dbo" dengan skema fungsi Anda
                    command.Parameters.AddWithValue("@Nama", Nama);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            txID.Text = IDObat();
            txNama.Enabled = true;
            txMerk.Enabled = true;
            cbKemasan.Enabled = true;
            txEfek.Enabled = true;
            dtpKadaluarsa.Enabled = true;
            txHargaBeli.Enabled = true;
            txStok.Enabled = true;
            btnSimpan.Enabled = true;
        }
        private void NonAktifObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableObat", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_Obat", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnNonAktif_Click(object sender, EventArgs e)
        {
            NonAktifObat();
        }
        private void AktifObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableObat", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_Obat", txID.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktifObat();
        }
        private void UpdateObat()
        {
            dtpKadaluarsa.Format = DateTimePickerFormat.Custom;
            dtpKadaluarsa.CustomFormat = "dd/MM/yy";
            string unformatHargaBeli = Regex.Replace(txHargaBeli.Text, "[^0-9]", "");
            string unformatHargaJual = Regex.Replace(txHargaJual.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateObat", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Obat", txID.Text);
            update.Parameters.AddWithValue("Nama", txNama.Text);
            update.Parameters.AddWithValue("Merk", txMerk.Text);
            update.Parameters.AddWithValue("Kemasan", cbKemasan.Text);
            update.Parameters.AddWithValue("Efek", txEfek.Text);
            update.Parameters.AddWithValue("Harga_Beli", int.Parse(unformatHargaBeli));
            update.Parameters.AddWithValue("Harga_Jual", int.Parse(unformatHargaJual));
            update.Parameters.AddWithValue("Tgl_Kadaluarsa", dtpKadaluarsa.Value);
            update.Parameters.AddWithValue("Stok", int.Parse(txStok.Text));

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txNama.Text.Length != 0 && txMerk.Text.Length != 0 && cbKemasan.SelectedIndex != -1 && txEfek.Text.Length != 0 && txHargaBeli.Text.Length != 0 && txStok.Text.Length != 0)
            {
                if (validNama == 0)
                {
                    DateTime currentDateTime = DateTime.Now;

                    if (dtpKadaluarsa.Value < currentDateTime)
                    {
                        mBox.text1.Text = "Tanggal Kadaluarsa Tidak Boleh Kurang Dari " + currentDateTime.ToString("dd MMMM yyyy");
                        mBox.session.Text = "Obat";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    else
                    {
                        UpdateObat();
                    }
                }
                else
                {
                    mBox.text1.Text = "Obat Sudah Tersedia!";
                    mBox.session.Text = "Obat";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.WarningMessage();
            }
        }
        private void TambahObat()
        {
            dtpKadaluarsa.Format = DateTimePickerFormat.Custom;
            dtpKadaluarsa.CustomFormat = "dd/MM/yy";
            string unformatHargaBeli = Regex.Replace(txHargaBeli.Text, "[^0-9]", "");
            string unformatHargaJual = Regex.Replace(txHargaJual.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertObat", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Obat", txID.Text);
            insert.Parameters.AddWithValue("Nama", txNama.Text);
            insert.Parameters.AddWithValue("Merk", txMerk.Text);
            insert.Parameters.AddWithValue("Kemasan", cbKemasan.Text);
            insert.Parameters.AddWithValue("Efek", txEfek.Text);
            insert.Parameters.AddWithValue("Harga_Beli", int.Parse(unformatHargaBeli));
            insert.Parameters.AddWithValue("Harga_Jual", int.Parse(unformatHargaJual));
            insert.Parameters.AddWithValue("Tgl_Kadaluarsa", dtpKadaluarsa.Value);
            insert.Parameters.AddWithValue("Stok", int.Parse(txStok.Text));

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Menambahkan Obat";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txNama.Text.Length != 0 && txMerk.Text.Length != 0 && cbKemasan.SelectedIndex != -1 && txEfek.Text.Length != 0 && txHargaBeli.Text.Length != 0 && txStok.Text.Length != 0)
            {
                if(validNama == 0)
                {
                    DateTime currentDateTime = DateTime.Now;

                    if (dtpKadaluarsa.Value < currentDateTime)
                    {
                        mBox.text1.Text = "Tanggal Kadaluarsa Tidak Boleh Kurang Dari " + currentDateTime.ToString("dd MMMM yyyy");
                        mBox.session.Text = "Obat";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    else
                    {
                        TambahObat();
                    }
                }
                else
                {
                    mBox.text1.Text = "Obat Sudah Tersedia!";
                    mBox.session.Text = "Obat";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
        }
        //HARGA JUAL = HARGA BELI + 20%
        private void GenerateHargaJual()
        {
            double persen = 20;
            string unformatHarga = Regex.Replace(txHargaBeli.Text, "[^0-9]", "");
            double hargaBeli = double.Parse(unformatHarga);
            double hargaJual = hargaBeli + (hargaBeli * (persen/100));

            string formatHarga = hargaJual.ToString("C0", new CultureInfo("id-ID"));
            txHargaJual.Text = formatHarga;
        }
        private void cariObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);
            string data = txCariObat.Text;
            if (txCariObat.Text.Length != 0)
            {
                SqlCommand search = new SqlCommand("sp_SearchObat", connection);
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
                            string merk = reader.GetString(2);
                            string kemasan = reader.GetString(3);
                            string efek = reader.GetString(4);
                            DateTime tglKadaluarsa = reader.GetDateTime(5);
                            int stok = reader.GetInt32(6);
                            int hargaBeli = (int)reader.GetSqlMoney(7);
                            int hargaJual = (int)reader.GetSqlMoney(8);
                            status = reader.GetString(9);

                            txID.Enabled = false;
                            txNama.Enabled = true;
                            txMerk.Enabled = true;
                            cbKemasan.Enabled = true;
                            txEfek.Enabled = true;
                            txHargaBeli.Enabled = true;
                            dtpKadaluarsa.Enabled = true;
                            txStok.Enabled = true;
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

                            string formatHargaBeli = hargaBeli.ToString("C0", new CultureInfo("id-ID"));
                            string formatHargaJual = hargaJual.ToString("C0", new CultureInfo("id-ID"));
                            txID.Text = id;
                            txNama.Text = nama;
                            txMerk.Text = merk;
                            cbKemasan.Text = kemasan;
                            txEfek.Text = efek;
                            txHargaBeli.Text = formatHargaBeli;
                            txHargaJual.Text = formatHargaJual;
                            dtpKadaluarsa.Value = tglKadaluarsa;
                            txStok.Text = stok.ToString();
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Obat " + txCariObat.Text + " Tidak Ditemukan, Silakan Cari Obat Kembali!";
                        mBox.session.Text = "Obat";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    mBox.text1.Text = "Gagal Mencari Obat";
                    mBox.session.Text = "Obat";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
        }

        private void txHargaBeli_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txHargaBeli.Text))
            {
                txHargaBeli.IconLeft = Properties.Resources.green_harga;

                // Menghapus karakter yang bukan angka dari TextBox
                string numericText = Regex.Replace(txHargaBeli.Text, "[^0-9]", "");

                // Mengonversi string angka ke tipe data numerik (misalnya, decimal)
                decimal amount = 0;
                if (Decimal.TryParse(numericText, out amount))
                {
                    // Memformat nilai numerik ke format Rupiah
                    string formattedAmount = string.Format(new CultureInfo("id-ID"), "{0:C0}", amount);

                    // Mengatur nilai yang sudah diformat kembali ke TextBox
                    txHargaBeli.Text = formattedAmount;

                    // Mengatur posisi kursor ke akhir TextBox
                    txHargaBeli.SelectionStart = txHargaBeli.Text.Length;
                    GenerateHargaJual();
                }
            }
            else
            {
                // Jika input jumlah tidak valid, set total harga menjadi kosong atau nol
                txHargaJual.Text = "";
                txHargaBeli.IconLeft = Properties.Resources.white_harga;
            }
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariObat.Text))
            {
                txCariObat.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                txCariObat.IconLeft = Properties.Resources.white_magnifier;
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

            if (!string.IsNullOrEmpty(txMerk.Text))
            {
                txMerk.IconLeft = Properties.Resources.green_merk;
            }
            else
            {
                txMerk.IconLeft = Properties.Resources.white_merk;
            }

            if (!string.IsNullOrEmpty(txEfek.Text))
            {
                txEfek.IconLeft = Properties.Resources.green_efek;
            }
            else
            {
                txEfek.IconLeft = Properties.Resources.white_efek;
            }

            if (!string.IsNullOrEmpty(txHargaJual.Text))
            {
                txHargaJual.IconLeft = Properties.Resources.green_harga;
            }
            else
            {
                txHargaJual.IconLeft = Properties.Resources.white_harga;
            }

            if (!string.IsNullOrEmpty(txStok.Text))
            {
                txStok.IconLeft = Properties.Resources.green_stock;
            }
            else
            {
                txStok.IconLeft = Properties.Resources.white_stock;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            if (txCariObat.Text != "")
            {
                cariObat();
            }
            else
            {
                mBox.text1.Text = "Masukkan Obat Yang Ingin Diubah!";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void cbKemasan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKemasan.SelectedIndex != -1)
            {
                imgKemasan.Image = Properties.Resources.green_kemasan;
                lblKemasan.Visible = false;
                cbKemasan.ForeColor = Color.FromArgb(131, 235, 97);
            }
            else
            {
                imgKemasan.Image = Properties.Resources.white_kemasan;
                lblKemasan.Visible = true;
            }
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void Form_Master_Obat_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            dtpKadaluarsa.Value = currentDateTime;
        }

        private void txNama_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txNama.Text))
            {
                validNama = CekNamaObat(txNama.Text, txID.Text);
                if (validNama != 0)
                {
                    epWarning.SetError(txNama, "Obat Sudah Tersedia!");
                }
                else
                {
                    epWarning.SetError(txNama, "");
                }
            }
            Gambar();
        }

        private void dtpKadaluarsa_TextChanged(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            if (dtpKadaluarsa.Value < currentDateTime)
            {
                epWarning.SetError(dtpKadaluarsa, "Tanggal Kadaluarsa Tidak Boleh Kurang Dari " + currentDateTime.ToString("dd MMMM yyyy"));
            }
            else
            {
                epWarning.SetError(dtpKadaluarsa, "");
            }
        }
    }
}
