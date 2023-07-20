﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_View_Obat : Form
    {
        string status = "";
        public Form_View_Obat()
        {
            InitializeComponent();
        }

        private void Form_View_Obat_Load(object sender, EventArgs e)
        {
            cariData();
        }
        private void tblObat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblObat.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        private void cariData()
        {
            tblObat.ThemeStyle.HeaderStyle.Font = new Font("Porsche Next TT", 13);
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string data = txCariData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand search = new SqlCommand("sp_SearchObat", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", status);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tblObat.DataSource = table;
            }
        }

        private void txCariData_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txCariData.Text))
            {
                txCariData.IconLeft = Properties.Resources.green_magnifier;
                cariData();
            }
            else
            {
                txCariData.IconLeft = Properties.Resources.white_magnifier;
                cariData();
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
