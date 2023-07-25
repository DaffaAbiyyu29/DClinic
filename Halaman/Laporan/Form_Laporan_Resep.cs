using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman.Laporan
{
    public partial class Form_Laporan_Resep : Form
    {
        DateTime TanggalAwal, TanggalAkhir;
        public Form_Laporan_Resep()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rpDetailResep.Visible = false;
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            this.view_TrsPemberianResepTableAdapter.Fill(this.laporan1.View_TrsPemberianResep, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpResep.RefreshReport();
        }

        private void btnCariDetail_Click(object sender, EventArgs e)
        {
            rpDetailResep.Visible = true;
            this.view_DetailObatTrsPemberianResepTableAdapter.Fill(this.laporan.View_DetailObatTrsPemberianResep, (String)cbResep.SelectedValue);
            this.rpDetailResep.RefreshReport();
        }

        private void Forrm_Laporan_Resep_Load(object sender, EventArgs e)
        {
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            this.view_TrsPemberianResepTableAdapter.Fill(this.laporan1.View_TrsPemberianResep, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpResep.RefreshReport();
        }
    }
}
