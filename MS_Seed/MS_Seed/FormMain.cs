using MS_Seed.Classes;
using MS_Seed.Common;
using MS_Seed.Forms;
using MS_Seed.IndustrialCommunication.Ethernet;
using MS_Seed.SQL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MS_Seed
{
    public partial class FormMain : Form
    {
        public FormNewLot formNewLot = new FormNewLot();

        public FormMain()
        {
            InitializeComponent();

            ControlSerialPort.Instance.Connect();
            ControlSerialPort.Instance.Open();
            ControlSerialPort.Instance.formMain = this;

            SQLite.Instance.Connect();

            formNewLot.formMain = this;
            circularProgressBar.Value = 0;

            SetFont();
        }

        private void pictureBtnSetting_Click(object sender, EventArgs e)
        {
            FormSetting fs = new FormSetting();
            fs.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy | HH:mm:ss");
        }

        private void picturePLC_Click(object sender, EventArgs e)
        {
            //FormTestPLC formPLC = new FormTestPLC();
            //formPLC.ShowDialog();
        }

        private void BtnStartNewLot_Click(object sender, EventArgs e)
        {
            FormNewLot form = new FormNewLot();
            form.formMain = this;
            form.ShowDialog();
        }

        public void AddDataGridView(DataSerialPort rs)
        {
            Action SetDatagridviewAction = () =>
            {
                dataGridView1.Rows.Insert(0, new string[] {
                    Global.CurrentBarcode, rs.WaitTime, rs.Overtime, rs.Pressure, rs.TimeVacuum, rs.TemperatureOrdinary,
                    rs.TimeStartLot, rs.TimeEndLot, rs.Vent, rs.TimeVent, rs.TemperatureWorking,
                    DateTimeOffset.Now.ToString("yyyy/MM/dd HH:mm:ss:ff")
                });

                if (dataGridView1.Rows.Count > 50)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            };

            if (this.InvokeRequired)
                this.Invoke(SetDatagridviewAction);
            else
                SetDatagridviewAction();
        }

        public void SetTotalLot(string totalLot)
        {
            Action SetTotalLotAction = () =>
            {
                lblTotalLot.Text = Global.FormatNumber(int.Parse(totalLot));

                int x = (groupBoxTotalLot.Width - lblTotalLot.Width) / 2;
                int y = (groupBoxTotalLot.Height - lblTotalLot.Height) / 2;

                lblTotalLot.Location = new Point(x, y);
            };

            if (this.InvokeRequired)
                this.Invoke(SetTotalLotAction);
            else
                SetTotalLotAction();
        }

        public void SetCurrentBarcode()
        {
            lblCurrentBarcode.Text = Global.CurrentBarcode;
            lblProgress.Visible = true;
            lblTitleLot.Visible = true;
            lblCurrentBarcode.Visible = true;
        }

        public void SetFont()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 12, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
