using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wisol_Vacuum.Common
{
    public static class Global
    {
        public static string API_URL_CHECK_LOT_EXISTS = ConfigurationManager.AppSettings["API_GET_CHECK_EXISTS_LOT_ID"];
        public static string API_URL_START_MES = ConfigurationManager.AppSettings["API_POST_START_MES"];
        public static string API_URL_END_MES = ConfigurationManager.AppSettings["API_POST_END_MES"];

        public static string CurrentBarcode = string.Empty;
        public static long TotalLot = 0;
        private static readonly HttpClient httpClient = new HttpClient();
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

        //Get method
        public static async Task<string> ApiCheckExistLotId(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("API call failed with status code: " + response.StatusCode);
            }
        }

        //Post method
        public static async Task<string> ApiStartMES(string url, object data)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    ShowBoxError($"Error can not start API MES");
                    return "Error_API_Start_MES";
                }
            }
            catch (Exception ex)
            {
                ShowBoxError($"Error can not start API MES, error: {ex.Message}");
                return "Error_API_Start_MES";
            }
        }

        //Post method
        public static async Task<string> ApiEndMES(string url, object data)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    ShowBoxError($"Error can not start API MES");
                    return "Error_API_Start_MES";
                }
            }
            catch (Exception ex)
            {
                ShowBoxError($"Error can not start API MES, error: {ex.Message}");
                return "Error_API_Start_MES";
            }
        }
    }
}
