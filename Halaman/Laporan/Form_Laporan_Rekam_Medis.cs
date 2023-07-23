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
        public Form_Laporan_Rekam_Medis()
        {
            InitializeComponent();
        }

        private void Form_Laporan_Rekam_Medis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laporan.View_RekamMedis' table. You can move, or remove it, as needed.
            this.view_RekamMedisTableAdapter.Fill(this.laporan.View_RekamMedis);
            this.rpRekamMedis.RefreshReport();
        }
    }
}
