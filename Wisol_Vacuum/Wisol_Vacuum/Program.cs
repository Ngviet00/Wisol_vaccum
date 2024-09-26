using OfficeOpenXml;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using UtilCommon;

namespace Wisol_Vacuum
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            string appName = ConfigurationManager.AppSettings["PROJECT_NAME"];
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("The program is running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Files.AutoDeleteFileLog();
            Application.Run(new FormMain());
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
    }
}
