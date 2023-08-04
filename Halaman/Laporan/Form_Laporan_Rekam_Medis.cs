using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace D_Clinic
{
    public partial class Form_Laporan_Rekam_Medis : Form
    {
        DateTime TanggalAwal, TanggalAkhir;
        public Form_Laporan_Rekam_Medis()
        {
            InitializeComponent();
        }

        private void btnCariDetail_Click(object sender, EventArgs e)
        {
            this.view_RekamMedisTableAdapter.Fill(this.laporan.View_RekamMedis, "%" + cbPasien.Text + "%");
            this.rpRekamMedis.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.view_RekamMedisTableAdapter.Fill(this.laporan.View_RekamMedis, "%%");
            this.rpRekamMedis.RefreshReport();
        }

        private void Form_Laporan_Rekam_Medis_Load(object sender, EventArgs e)
        {
            this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            this.view_RekamMedisTableAdapter.Fill(this.laporan.View_RekamMedis, "%%");
            this.rpRekamMedis.RefreshReport();
        }
    }
}
