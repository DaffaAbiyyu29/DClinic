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
using System.Xml.Linq;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Jadwal_Dokter : Form
    {
        Msg_Box mBox = new Msg_Box();

        string id_jadwal, id_dokter, id_ruang, hari, jam_mulai, jam_akhir, status;
        int tarif;
        bool ditemukan = false;
        public Form_Master_Jadwal_Dokter()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariJadwal.Clear();
            txID.Enabled = true;
            txID.Clear();
            cbDokter.SelectedIndex = -1;
            cbRuang.SelectedIndex = -1;
            cbHari.SelectedIndex = -1;
            dtpJamMulai.Text = "00:00";
            dtpJamAkhir.Text = "00:00";
            txTarif.Clear();
            status = "";
            cariData();
        }

        private void disablePropherties()
        {
            txID.Enabled = false;
            cbDokter.Enabled = false;
            cbRuang.Enabled = false;
            cbHari.Enabled = false;
            dtpJamMulai.Enabled = false;
            dtpJamAkhir.Enabled = false;
            txTarif.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
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
        }
        private string IDJadwalDokter()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDJadwalDokter()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private void Form_Jadwal_Dokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_JadwalDokter' table. You can move, or remove it, as needed.
            this.view_JadwalDokterTableAdapter.Fill(this.dClinicDataSet.View_JadwalDokter);
            // TODO: This line of code loads data into the 'dClinicDataSet.View_Dokter' table. You can move, or remove it, as needed.
            this.view_DokterTableAdapter.Fill(this.dClinicDataSet.View_Dokter);
            // TODO: This line of code loads data into the 'dClinicDataSet.RuangPeriksa' table. You can move, or remove it, as needed.
            this.ruangPeriksaTableAdapter.Fill(this.dClinicDataSet.RuangPeriksa);
            // TODO: This line of code loads data into the 'dClinicDataSet.View_Dokter' table. You can move, or remove it, as needed.
            cariData();
            cbDokter.SelectedIndex = -1;
            cbRuang.SelectedIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            txID.Text = IDJadwalDokter();
            cbDokter.Enabled = true;
            cbRuang.Enabled = true;
            cbHari.Enabled = true;
            txTarif.Enabled = true;
            dtpJamMulai.Enabled = true;
            dtpJamAkhir.Enabled = true;
            btnSimpan.Enabled = true;
            Gambar();
        }
        private void NonAktifJadwal()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisableJadwalDokter", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_JadwalDokter", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnNonAktif_Click(object sender, EventArgs e)
        {
            NonAktifJadwal();
        }
        private void AktifJadwal()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand enable = new SqlCommand("sp_EnableJadwalDokter", connection);
            enable.CommandType = CommandType.StoredProcedure;
            enable.Parameters.AddWithValue("Id_JadwalDokter", txID.Text);

            try
            {
                connection.Open();
                enable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktifJadwal();
        }
        private void UpdateJadwal()
        {
            string unformatTarif = Regex.Replace(txTarif.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateJadwalDokter", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_JadwalDokter", txID.Text);
            update.Parameters.AddWithValue("Id_Dokter", cbDokter.SelectedValue);
            update.Parameters.AddWithValue("Id_RuangPeriksa", cbRuang.SelectedValue);
            update.Parameters.AddWithValue("Hari", cbHari.Text);
            update.Parameters.AddWithValue("Jam_Mulai", dtpJamMulai.Text);
            update.Parameters.AddWithValue("Jam_Akhir", dtpJamAkhir.Text);
            update.Parameters.AddWithValue("Tarif_Jasa", unformatTarif);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Memperbarui Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.SuccessMessage();
                cbDokter.SelectedIndex = -1;
                cbRuang.SelectedIndex = -1;
                cbHari.SelectedIndex = -1;
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Jadwal Dokter";
                mBox.session.Text = "Jadwal";
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
            UpdateJadwal();
        }
        private void TambahJadwal()
        {
            string unformatTarif = Regex.Replace(txTarif.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertJadwalDokter", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_JadwalDokter", txID.Text);
            insert.Parameters.AddWithValue("Id_Dokter", cbDokter.SelectedValue);
            insert.Parameters.AddWithValue("Id_RuangPeriksa", cbRuang.SelectedValue);
            insert.Parameters.AddWithValue("Hari", cbHari.Text);
            insert.Parameters.AddWithValue("Jam_Mulai", dtpJamMulai.Text);
            insert.Parameters.AddWithValue("Jam_Akhir", dtpJamAkhir.Text);
            insert.Parameters.AddWithValue("Tarif_Jasa", unformatTarif);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.SuccessMessage();
                cbDokter.SelectedIndex = -1;
                cbRuang.SelectedIndex = -1;
                cbHari.SelectedIndex = -1;
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Menambahkan Jadwal Dokter";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                cariData();
            }
        }

        private void Gambar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gambar();
        }

        private void cbDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDokter.SelectedIndex != -1)
            {
                imgDokter.Image = Properties.Resources.green_dokter;
                lblDokter.Visible = false;
            }
            else
            {
                imgDokter.Image = Properties.Resources.white_dokter;
                lblDokter.Visible = true;
            }
        }

        private void cbRuang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRuang.SelectedIndex != -1)
            {
                imgRuang.Image = Properties.Resources.green_ruang;
                lblRuang.Visible = false;
            }
            else
            {
                imgRuang.Image = Properties.Resources.white_ruang;
                lblRuang.Visible = true;
            }
        }

        private void tblJadwalDokter_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblJadwalDokter.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void txCariJadwal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txCariJadwal.TextLength != 0)
            {
                cariData();
                txCariJadwal.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariJadwal.IconLeft = Properties.Resources.white_magnifier;
            }
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void txCariJadwal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariJadwal.Text))
            {
                cariData();
                txCariJadwal.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariJadwal.IconLeft = Properties.Resources.white_magnifier;
            }
        }
        private void txTarif_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txTarif.Text))
            {
                txTarif.IconLeft = Properties.Resources.green_harga;

                // Menghapus karakter yang bukan angka dari TextBox
                string numericText = Regex.Replace(txTarif.Text, "[^0-9]", "");

                // Mengonversi string angka ke tipe data numerik (misalnya, decimal)
                decimal amount = 0;
                if (Decimal.TryParse(numericText, out amount))
                {
                    // Memformat nilai numerik ke format Rupiah
                    string formattedAmount = string.Format(new CultureInfo("id-ID"), "{0:C0}", amount);

                    // Mengatur nilai yang sudah diformat kembali ke TextBox
                    txTarif.Text = formattedAmount;

                    // Mengatur posisi kursor ke akhir TextBox
                    txTarif.SelectionStart = txTarif.Text.Length;
                }
            }
            else
            {
                txTarif.IconLeft = Properties.Resources.white_harga;
            }
        }

        private void tblJadwalDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblJadwalDokter.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                string id_jadwal = row.Cells["id"].Value.ToString();
                string nama_dokter = row.Cells["dokter"].Value.ToString();
                string nama_ruang = row.Cells["ruang"].Value.ToString();
                string hari = row.Cells["day"].Value.ToString();
                string jam_mulai = row.Cells["jam1"].Value.ToString();
                string jam_akhir = row.Cells["jam2"].Value.ToString();
                string tarif = (row.Cells["trf_jasa"].Value.ToString());
                string status = row.Cells["stts"].Value.ToString();

                txID.IconLeft = Properties.Resources.green_kode;
                txTarif.IconLeft = Properties.Resources.green_harga;
                txID.Enabled = false;
                cbDokter.Enabled = true;
                cbRuang.Enabled = true;
                cbHari.Enabled = true;
                txTarif.Enabled = true;
                dtpJamMulai.Enabled = true;
                dtpJamAkhir.Enabled = true;
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

                int tarif_dokter = (int)SqlMoney.Parse(tarif);
                string formatTarif = tarif_dokter.ToString("C0", new CultureInfo("id-ID"));

                txID.Text = id_jadwal;
                cbDokter.Text = nama_dokter;
                cbRuang.Text = nama_ruang;
                cbHari.Text = hari;
                dtpJamMulai.Value = DateTime.Parse(jam_mulai);
                dtpJamAkhir.Value = DateTime.Parse(jam_akhir);
                txTarif.Text = formatTarif;
            }
        }

        private void cbHari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHari.SelectedIndex != -1)
            {
                imgHari.Image = Properties.Resources.green_cal;
                lblHari.Visible = false;
            }
            else
            {
                imgHari.Image = Properties.Resources.white_cal;
                lblHari.Visible = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbDokter.SelectedIndex != -1 || cbRuang.SelectedIndex != -1 || cbHari.SelectedIndex != -1)
            {
                TambahJadwal();
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.WarningMessage();
            }
            Gambar();
        }
        private void cariData()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariJadwal.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchJadwalDokter", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data); 
                search.Parameters.AddWithValue("Status", ""); 
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblJadwalDokter.DataSource = table;

                SqlDataReader reader = search.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ditemukan = true;
                        // Ambil nilai-nilai kolom dari reader
                        id_jadwal = reader.GetString(0);
                        id_dokter = reader.GetString(1);
                        id_ruang = reader.GetString(3);
                        hari = reader.GetString(5);
                        jam_mulai = reader.GetString(6);
                        jam_akhir = reader.GetString(7);
                        tarif = (int)reader.GetSqlMoney(8);
                        status = reader.GetString(9);
                    }
                }
                reader.Close();
            }
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            if (txCariJadwal.Text != "")
            {
                if (ditemukan)
                {
                    cariData();
                    txID.Enabled = false;
                    cbDokter.Enabled = true;
                    cbRuang.Enabled = true;
                    cbHari.Enabled = true;
                    txTarif.Enabled = true;
                    dtpJamMulai.Enabled = true;
                    dtpJamAkhir.Enabled = true;
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

                    string formatTarif = tarif.ToString("C0", new CultureInfo("id-ID"));

                    txID.Text = id_jadwal;
                    cbDokter.SelectedValue = id_dokter;
                    cbRuang.SelectedValue = id_ruang;
                    cbHari.Text = hari;
                    dtpJamMulai.Value = DateTime.Parse(jam_mulai);
                    dtpJamAkhir.Value = DateTime.Parse(jam_akhir);
                    txTarif.Text = formatTarif;
                }
                else
                {
                    mBox.text1.Text = "Jadwal Dokter " + txCariJadwal.Text + " Tidak Ditemukan, Silakan Cari Jadwal Dokter Kembali!";
                    mBox.session.Text = "Jadwal";
                    mBox.Show();
                    mBox.WarningMessage();
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Jadwal Dokter Yang Ingin Diubah!";
                mBox.session.Text = "Jadwal";
                mBox.Show();
                mBox.WarningMessage();
            }
            Gambar();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            Gambar();
        }
    }
}
