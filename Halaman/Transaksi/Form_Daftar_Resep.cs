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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman.Transaksi
{
    public partial class Form_Daftar_Resep : Form
    {
        Msg_Box mBox = new Msg_Box();
        string idResep;
        public Form_Daftar_Resep()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariResep.Clear();
            txID.Clear();
            txDokter.Clear();
            txTanggal.Clear();
            txKeterangan.Clear();
        }
        private void Gambar()
        {
            if (!string.IsNullOrEmpty(txCariResep.Text))
            {
                txCariResep.IconLeft = Properties.Resources.green_magnifier;
                cariResepTerkirim();
            }
            else
            {
                txCariResep.IconLeft = Properties.Resources.white_magnifier;
                cariResepTerkirim();
            }
            if (!string.IsNullOrEmpty(txID.Text))
            {
                txID.IconLeft = Properties.Resources.green_kode;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_kode;
            }
            if (!string.IsNullOrEmpty(txDokter.Text))
            {
                txDokter.IconLeft = Properties.Resources.green_dokter;
            }
            else
            {
                txDokter.IconLeft = Properties.Resources.white_dokter;
            }
            if (!string.IsNullOrEmpty(txTanggal.Text))
            {
                txTanggal.IconLeft = Properties.Resources.green_cal;
            }
            else
            {
                txTanggal.IconLeft = Properties.Resources.white_cal;
            }
            if (!string.IsNullOrEmpty(txKeterangan.Text))
            {
                txKeterangan.IconLeft = Properties.Resources.green_keluhan;
            }
            else
            {
                txKeterangan.IconLeft = Properties.Resources.white_keluhan;
            }
        }
        private void cariResepTerkirim()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariResep.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_Search_TrsPemberianResep_Terkirim", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblDaftarResep.DataSource = table;
            }
            cariDetailObat();
        }
        private void cariDetailObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_Search_Detail_TrsPemberianResep", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Id_TrsResep", txID.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblDetailObat.DataSource = table;
            }
        }
        private void Form_Daftar_Resep_Load(object sender, EventArgs e)
        {
            this.view_DetailObatTrsPemberianResepTableAdapter.Fill(this.dClinicDataSet.View_DetailObatTrsPemberianResep);
            this.view_TrsPemberianResepTableAdapter.Fill(this.dClinicDataSet.View_TrsPemberianResep);
            this.view_TrsPemberianResepDiterimaTableAdapter.Fill(this.dClinicDataSet.View_TrsPemberianResepDiterima);
            cariResepTerkirim();
        }

        private void tblDaftarResep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblDaftarResep.Rows[e.RowIndex].Cells["no_daftar"].Value = (e.RowIndex + 1).ToString();
        }
        private void tblDetailObat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblDetailObat.Rows[e.RowIndex].Cells["no_obat"].Value = (e.RowIndex + 1).ToString();
        }
        private void tblResepDiterima_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblResepDiterima.Rows[e.RowIndex].Cells["no_daftar2"].Value = (e.RowIndex + 1).ToString();
        }

        private void tblDaftarResep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow row = tblDaftarResep.Rows[e.RowIndex];
                // Mendapatkan nilai dari kolom yang sesuai dengan kolom dalam tabel
                idResep = row.Cells["id_resep"].Value.ToString();
                string namaDokter = row.Cells["dokter_resep"].Value.ToString();
                DateTime tanggal = DateTime.Parse(row.Cells["tanggal_resep"].Value.ToString());
                string ket = row.Cells["ket_resep"].Value.ToString();
                txID.Text = idResep;
                txDokter.Text = namaDokter;
                txTanggal.Text = tanggal.ToString("D");
                txKeterangan.Text = ket;
            }
            btnTerima.Enabled = true;
        }

        private void Gambar_TextChanged(object sender, EventArgs e)
        {
            Gambar();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
        }
        private void TerimaResep()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            //EXEC SP INSERT TABLE TRANSAKSI PEMBERIAN RESEP
            SqlCommand insert_trs = new SqlCommand("sp_TerimaResep", connection);
            insert_trs.CommandType = CommandType.StoredProcedure;
            insert_trs.Parameters.AddWithValue("Id_TrsResep", txID.Text);

            try
            {
                connection.Open();
                insert_trs.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Terima Resep Obat";
                mBox.session.Text = "Resep";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                btnTerima.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mBox.text1.Text = "Gagal Terima Resep Obat";
                mBox.session.Text = "Resep";
                mBox.Show();
                mBox.ErrorMessage();
            }
            finally
            {
                this.view_TrsPemberianResepDiterimaTableAdapter.Fill(this.dClinicDataSet.View_TrsPemberianResepDiterima);
                cariResepTerkirim();
            }
        }
        private void btnTerima_Click(object sender, EventArgs e)
        {
            TerimaResep();
        }
    }
}
