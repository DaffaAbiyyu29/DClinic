using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic
{
    public partial class DClinic_App : Form
    {
        int startpoint = 0;
        int labelCount = 0;

        public DClinic_App()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 4;
            labelCount += 4;
            loadingBar.Value = startpoint;
            lblLoading.Text = labelCount + "%";

            if(loadingBar.Value == 100 && labelCount == 104)
            {
                loadingBar.Value = 100;
                timer1.Stop();

                Form_Login login = new Form_Login();
                this.Hide();
                login.Show();
            }
        }

        private void DClinic_App_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
