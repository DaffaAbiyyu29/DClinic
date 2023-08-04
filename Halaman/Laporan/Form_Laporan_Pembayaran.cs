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
    public partial class Form_Laporan_Pembayaran : Form
    {
        DateTime TanggalAwal, TanggalAkhir; 
        public Form_Laporan_Pembayaran()
        {
            InitializeComponent();
        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            this.view_TrsPembayaranTableAdapter.Fill(this.laporan.View_TrsPembayaran, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpPembayaran.RefreshReport();
        }

        private void btnCetakStruk_Click(object sender, EventArgs e)
        {
            Struk_Pembayaran struk = new Struk_Pembayaran();
            string id = cbStruk.Text;
            struk.id = id;
            struk.Show();
        }

        private void Form_Laporan_Pembayaran_Load(object sender, EventArgs e)
        {
            TanggalAwal = dtpTanggalAwal.Value;
            TanggalAkhir = dtpTanggalAkhir.Value;
            this.view_TrsPembayaranTableAdapter.Fill(this.laporan.View_TrsPembayaran, TanggalAwal.ToString(), TanggalAkhir.ToString());
            this.rpPembayaran.RefreshReport();
        }
    }
}
