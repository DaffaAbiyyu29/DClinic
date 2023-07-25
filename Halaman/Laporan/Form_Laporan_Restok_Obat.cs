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
    public partial class Form_Laporan_Restok_Obat : Form
    {
        DateTime TanggalAwal, TanggalAkhir;
        public Form_Laporan_Restok_Obat()
        {
            InitializeComponent();
        }

        private void Form_Laporan_Restok_Obat_Load(object sender, EventArgs e)
        {
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            this.view_TrsRestokObatTableAdapter.Fill(this.laporan.View_TrsRestokObat, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpRestokObat.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            rpDetailRestObat.Visible = false;
            this.view_TrsRestokObatTableAdapter.Fill(this.laporan.View_TrsRestokObat, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpRestokObat.RefreshReport();
        }

        private void btnCariDetail_Click(object sender, EventArgs e)
        {
            rpDetailRestObat.Visible = true;
            this.view_DetailObatTrsRestokObatTableAdapter.Fill(this.laporan.View_DetailObatTrsRestokObat, (String)cbRestok.SelectedValue);
            this.rpDetailRestObat.RefreshReport();
        }
    }
}
