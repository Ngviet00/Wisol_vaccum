using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace UtilCommon
{
    public static class Global
    {
        public static string API_URL_CHECK_LOT_EXISTS = ConfigurationManager.AppSettings["API_GET_CHECK_EXISTS_LOT_ID"];
        public static string API_URL_START_MES = ConfigurationManager.AppSettings["API_POST_START_MES"];
        public static string API_URL_END_MES = ConfigurationManager.AppSettings["API_POST_END_MES"];

        public static int TotalLot = 0;
        public static string CurrentBarcode = string.Empty;
        public static void ShowBoxError(string msg)
        {
            MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowBoxInfo(string msg)
        {
            MessageBox.Show($"{msg}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowBoxWarning(string msg)
        {
            MessageBox.Show($"{msg}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static string FormatNumber(int number) //format 1000 => 1.000
        {
            NumberFormatInfo customNumberFormat = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = "."
            };

            return number.ToString("#,##0", customNumberFormat);
        }

        public static void SetViewAction(Action action, Control control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
