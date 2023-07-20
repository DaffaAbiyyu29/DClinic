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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_Clinic.Halaman.Transaksi
{
    public partial class Form_Transaksi_Restok_Obat : Form
    {
        Msg_Box mBox = new Msg_Box();

        DateTime currentDateTime = DateTime.Now;
        int nomor_keranjang = 1;

        public Form_Transaksi_Restok_Obat()
        {
            InitializeComponent();
        }

        private void Form_Transaksi_Restok_Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_TrsRestokObat' table. You can move, or remove it, as needed.
            this.view_TrsRestokObatTableAdapter.Fill(this.dClinicDataSet.View_TrsRestokObat);
            txID.Text = IDRestok();
            this.obatTableAdapter.Fill(this.dClinicDataSet.Obat);
            Supplier_Tersedia();
            txTanggal.Text = currentDateTime.ToString("dd MMMM yyyy");
            cariObat();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariObat.Clear();
            txID.Clear();
            cbSupplier.SelectedIndex = -1;
            txTotalHarga.Clear();
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariObat.Text))
            {
                txCariObat.IconLeft = Properties.Resources.green_magnifier;
                cariObat();
            }
            else
            {
                txCariObat.IconLeft = Properties.Resources.white_magnifier;
                cariObat();
            } 
            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }
        }
      
        private string IDRestok()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.GenerateIDTrsRestok()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    string result = (string)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private string GenerateIDApoteker()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_Karyawan FROM Karyawan WHERE Nama = '" + txApoteker.Text + "'";

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
        private string GenerateIDSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Id_Supplier FROM Supplier WHERE Nama_Supplier = '" + cbSupplier.Text + "'";

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
        private void Supplier_Tersedia()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand search = new SqlCommand("sp_Search_Supplier_Tersedia", connection);
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
                        string supplier = reader.GetString(0);
                        cbSupplier.Items.Add(supplier);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cariObat()
        {
            tblObat.ThemeStyle.HeaderStyle.Font = new Font("Porsche Next TT", 13);
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariObat.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchObat", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", "Aktif");
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblObat.DataSource = table;
            }
        }
        private void tblObat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblObat.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedIndex != -1)
            {
                imgSupplier.Image = Properties.Resources.green_stock;
                lblSupplier.ForeColor = Color.FromArgb(131, 235, 97);
                lblSupplier.Visible = false;
            }
            else
            {
                imgSupplier.Image = Properties.Resources.white_stock;
                lblSupplier.ForeColor = Color.White;
                lblSupplier.Visible = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            tblKeranjang.Rows.Clear();
            //tblKeranjang.Columns.Clear();
            txID.Text = IDRestok();
            btnBayar.Enabled = false;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.ForeColor = Color.White;
            txTotalHarga.IconLeft = Properties.Resources.white_harga;
        }
        private decimal HitungTotalBayar()
        {
            decimal total_harga = 0;

            // Melintasi setiap baris pada DataGridView
            foreach (DataGridViewRow row in tblKeranjang.Rows)
            {
                // Mengambil nilai harga pada setiap baris
                if (row.Cells["total_satuan"].Value != null)
                {
                    decimal kolomTotal = Convert.ToDecimal(row.Cells["total_satuan"].Value);

                    // Menjumlahkan harga ke totalHarga
                    total_harga += kolomTotal;
                }
            }
            return total_harga;
        }

        private void tambahUnit()
        {
            bool dataDitemukan = false;
            // Mendapatkan indeks baris yang dipilih di tabel sumber
            int selectedRowObat = tblObat.SelectedCells[0].RowIndex;

            // Mengambil nilai dari setiap kolom pada baris yang dipilih
            string id = tblObat.Rows[selectedRowObat].Cells["id_obat"].Value.ToString();
            string nama = tblObat.Rows[selectedRowObat].Cells["nama_obat"].Value.ToString();
            decimal harga = decimal.Parse(tblObat.Rows[selectedRowObat].Cells["harga_beli"].Value.ToString());
            decimal total = harga * 1;

            // Melintasi setiap baris pada DataGridView
            foreach (DataGridViewRow row in tblKeranjang.Rows)
            {
                string kolomID = row.Cells["id_obat_keranjang"].Value.ToString();

                if (kolomID == id)
                {
                    // Data sudah ada dalam DataGridView
                    dataDitemukan = true;

                    // Menambahkan 1 ke jumlah data yang sudah ada
                    int JumlahLama = Convert.ToInt32(row.Cells["jumlah"].Value);
                    row.Cells["jumlah"].Value = (JumlahLama + 1).ToString();

                    // Menghitung total harga
                    decimal TotalDetailLama = Convert.ToDecimal(row.Cells["total_satuan"].Value);
                    decimal TotalDetailBaru = TotalDetailLama + harga;
                    row.Cells["total_satuan"].Value = TotalDetailBaru;

                    // Berhenti melintasi baris karena data sudah ditemukan
                    break;
                }
            }

            // Jika data tidak ditemukan, tambahkan data baru ke DataGridView
            if (!dataDitemukan)
            {
                // Menambahkan data baru ke DataGridView
                int newRowIdx = tblKeranjang.Rows.Add();
                DataGridViewRow newRow = tblKeranjang.Rows[newRowIdx];
                newRow.Cells["no_keranjang"].Value = nomor_keranjang;
                newRow.Cells["id_obat_keranjang"].Value = id;
                newRow.Cells["nama_obat_keranjang"].Value = nama;
                newRow.Cells["harga_obat_keranjang"].Value = harga;
                newRow.Cells["jumlah"].Value = 1;
                newRow.Cells["total_satuan"].Value = total;
            }
            btnBayar.Enabled = true;
            nomor_keranjang += 1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txTotalHarga.IconLeft = Properties.Resources.green_harga;
            tambahUnit();
        }
        private void kurangUnit()
        {
            bool jumlahBanyak = false;
            if (tblKeranjang.SelectedRows.Count > 0)
            {
                int selectedRowKeranjang = tblKeranjang.SelectedCells[0].RowIndex;
                int jumlahObat = int.Parse(tblKeranjang.Rows[selectedRowKeranjang].Cells["jumlah"].Value.ToString());

                foreach (DataGridViewRow row in tblKeranjang.SelectedRows)
                {
                    if (jumlahObat > 1)
                    {
                        jumlahBanyak = true;

                        // Menambahkan 1 ke jumlah data yang sudah ada
                        int JumlahLama = Convert.ToInt32(row.Cells["jumlah"].Value);
                        row.Cells["jumlah"].Value = (JumlahLama - 1).ToString();

                        // Menghitung total harga
                        decimal harga = Convert.ToDecimal(row.Cells["harga_obat_keranjang"].Value);
                        decimal TotalDetailLama = Convert.ToDecimal(row.Cells["total_satuan"].Value);
                        decimal TotalDetailBaru = TotalDetailLama - harga;
                        row.Cells["total_satuan"].Value = TotalDetailBaru;

                        // Berhenti melintasi baris karena data sudah ditemukan
                        break;
                    }

                    if (!jumlahBanyak)
                    {
                        // Menghapus baris dari DataGridView
                        tblKeranjang.Rows.Remove(row);
                    }
                }
            }
        }
        private void btnKurang_Click(object sender, EventArgs e)
        {
            kurangUnit();
            lblTotalHarga.Text = HitungTotalBayar().ToString("C0");
        }
       
        private void tblKeranjang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowKeranjang= tblKeranjang.SelectedCells[0].RowIndex;
            DataGridViewRow newData = tblKeranjang.Rows[e.RowIndex];

            decimal harga = decimal.Parse(tblKeranjang.Rows[selectedRowKeranjang].Cells[3].Value.ToString());
            int stok = int.Parse(tblKeranjang.Rows[selectedRowKeranjang].Cells[4].Value.ToString());
            decimal total_detail = harga * stok;
            newData.Cells[5].Value = total_detail;
        }

        private void tblKeranjang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblTotalHarga.ForeColor = Color.FromArgb(131, 235, 97);
            lblTotalHarga.Text = HitungTotalBayar().ToString("C0");
        }
        private void InsertDetail()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();

                foreach (DataGridViewRow row in tblKeranjang.Rows)
                {
                    // Mendapatkan nilai dari setiap kolom pada baris
                    string idObat = row.Cells["id_obat_keranjang"].Value.ToString();
                    decimal hargaObat = Convert.ToDecimal(row.Cells["harga_obat_keranjang"].Value);
                    int jum = Convert.ToInt32(row.Cells["jumlah"].Value);
                    decimal totalDetail = Convert.ToDecimal(row.Cells["total_satuan"].Value);

                    // Membuat objek SqlCommand untuk memanggil stored procedure
                    using (SqlCommand insert_detail = new SqlCommand("sp_InsertDetailTrsRestokObat", connection2))
                    {
                        insert_detail.CommandType = CommandType.StoredProcedure;

                        // Menambahkan parameter ke SqlCommand sesuai dengan tipe data dan nama parameter di stored procedure
                        insert_detail.Parameters.AddWithValue("Id_TrsRestok", txID.Text);
                        insert_detail.Parameters.AddWithValue("Id_Obat", idObat);
                        insert_detail.Parameters.AddWithValue("Harga_Satuan", hargaObat);
                        insert_detail.Parameters.AddWithValue("Jumlah", jum);
                        insert_detail.Parameters.AddWithValue("Total_Detail", totalDetail);
                        // ...

                        // Menjalankan stored procedure untuk setiap baris
                        insert_detail.ExecuteNonQuery();
                    }
                }
            }
        }
        private void BayarRestok()
        {
            string unformatTotalBayar = Regex.Replace(lblTotalHarga.Text, "[^0-9]", "");

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            //EXEC SP INSERT TABLE TRANSAKSI RESTOK OBAT
            SqlCommand insert_trs = new SqlCommand("sp_InsertTrsRestokObat", connection);
            insert_trs.CommandType = CommandType.StoredProcedure;
            insert_trs.Parameters.AddWithValue("Id_TrsRestok", txID.Text);
            insert_trs.Parameters.AddWithValue("Id_Apoteker", GenerateIDApoteker());
            insert_trs.Parameters.AddWithValue("Id_Supplier", GenerateIDSupplier());
            insert_trs.Parameters.AddWithValue("Tanggal", DateTime.Parse(txTanggal.Text));
            insert_trs.Parameters.AddWithValue("Total_Bayar", int.Parse(unformatTotalBayar));

            try
            {
                connection.Open();
                insert_trs.ExecuteNonQuery();
                InsertDetail();
                mBox.text1.Text = "Restok Obat Berhasil";
                mBox.session.Text = "Restok";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Restok Obat Gagal";
                mBox.session.Text = "Restok";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                this.view_TrsRestokObatTableAdapter.Fill(this.dClinicDataSet.View_TrsRestokObat);
                cariObat();
            }
        }
        private void btnBayar_Click(object sender, EventArgs e)
        {
            BayarRestok();
            clearText();
            tblKeranjang.Rows.Clear();
            //tblKeranjang.Columns.Clear();
            txID.Text = IDRestok();
            btnBayar.Enabled = false;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.ForeColor = Color.White;
            txTotalHarga.IconLeft = Properties.Resources.white_harga;
        }

        private void tblRestok_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblRestok.Rows[e.RowIndex].Cells["nomor"].Value = (e.RowIndex + 1).ToString();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
