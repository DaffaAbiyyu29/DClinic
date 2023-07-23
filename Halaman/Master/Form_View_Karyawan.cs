using D_Clinic.Resources;
using Guna.UI2.AnimatorNS;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_Clinic.Halaman
{
    public partial class Form_View_Karyawan : Form
    {
        string status = "";
        public Form_View_Karyawan()
        {
            InitializeComponent();
        }

        private void Form_View_Karyawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet1.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.dClinicDataSet1.Karyawan);
            // TODO: This line of code loads data into the 'dClinicDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);
            // TODO: This line of code loads data into the 'dClinicDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);
            cariData();
        }

        private void tblKaryawan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblKaryawan.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        private void cariData()
        {
            tblKaryawan.ThemeStyle.HeaderStyle.Font = new Font("Porsche Next TT", 13);
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchKaryawan", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", status);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblKaryawan.DataSource = table;
            }
        }

        private void txCariData_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariData.Text))
            {
                cariData();
                txCariData.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                cariData();
                txCariData.IconLeft = Properties.Resources.white_magnifier;
            }
        }

        private void CariData(object sender, EventArgs e)
        {
            if (rbSemua.Checked)
            {
                status = "";
            }
            else if (rbAktif.Checked)
            {
                status = "Aktif";
            }
            else if (rbNonAktif.Checked)
            {
                status = "Non";
            }
            cariData();
        }
    }
}
