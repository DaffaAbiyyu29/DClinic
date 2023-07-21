using D_Clinic.Halaman;
using D_Clinic.Halaman.Transaksi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Transaksi_Pembayaran());
        }

        public static void CloseAllForms()
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var form in openForms)
            {
                form.Close();
            }
        }
        public static void HideAllForms()
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var form in openForms)
            {
                form.Hide();
            }
        }
    }
}
