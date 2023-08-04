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
    public partial class Struk_Pembayaran : Form
    {
        public string id = "";
        public Struk_Pembayaran()
        {
            InitializeComponent();
        }

        private void Struk_Pembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laporan.Struk_Pembayaran' table. You can move, or remove it, as needed.
            this.struk_PembayaranTableAdapter.Fill(this.laporan.Struk_Pembayaran, id);

            this.rpStruk.RefreshReport();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
