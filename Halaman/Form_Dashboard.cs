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
using System.Xml.Linq;

namespace D_Clinic.Halaman
{
    public partial class Form_Dashboard : Form
    {
        Msg_Box mBox = new Msg_Box();
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            lblKaryawan.Text = HitungKaryawan().ToString() + " Karyawan";
            lblObat.Text = HitungObat().ToString() + " Obat";
            lblPasien.Text = HitungPasien().ToString() + " Pasien";
            lblJadwal.Text = HitungJadwalDokter().ToString() + " Jadwal";
            lblRuang.Text = HitungRuangPeriksa().ToString() + " Ruangan";
            lblRS.Text = HitungRumahSakitRekanan().ToString() + " RS";
            lblSupplier.Text = HitungSupplier().ToString() +" Supplier";
        }

        private int HitungKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountKaryawan()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountObat()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountPasien()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungJadwalDokter()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountJadwalDokter()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungRuangPeriksa()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountRuangPeriksa()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungRumahSakitRekanan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountRSRekanan()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
        private int HitungSupplier()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT dbo.CountSupplier()"; // Ganti "dbo" dengan skema fungsi Anda

                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }
    }
}
