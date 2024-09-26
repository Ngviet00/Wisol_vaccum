using System;
using System.Windows.Forms;
using UtilCommon;

namespace Wisol_Vacuum.Forms
{
    public partial class FormNewLot : Form
    {
        public FormMain formMain { get; set; }
        public FormNewLot()
        {
            InitializeComponent();
        }

        private void FormNewLot_Load(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

        private void BtnStartLot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                Global.ShowBoxError("Barcode can not empty");
                txtBarcode.Focus();
                return;
            }

            //string barcodeLotId = string.Empty;

            ////call api check exist 
            //bool checkCheckLotId = true; //CALL API CHECK LOT ID BARCODE IS OK OR NOT

            ////IF CHECK FROM MES IS OK
            //if (checkCheckLotId)
            //{
            //    ControlSerialPort.Instance.SendData("ok");
            //    ControlSerialPort.Instance.SendData(barcodeLotId);

            //    //SEND POST API POST START MES

            //    Global.CurrentBarcode = txtBarcode.Text;
            //    formMain.SetCurrentBarcode();
            //    Close();
            //}
            //else
            //{
            //    Global.ShowBoxWarning("LotID không đúng!");
            //    return;
            //}
        }
    }
}
