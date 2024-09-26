using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using Wisol_Vacuum;
using Wisol_Vacuum.Classes;

namespace UtilCommon.Ethernet
{
    public class ControlSerialPort
    {
        public FormMain formMain { get; set; }

        public static ControlSerialPort _instance;

        private static readonly object _lock = new object();

        private SerialPort serialPort;

        private readonly string portName = ConfigurationManager.AppSettings["PORT_NAME"] ?? "COM1";

        private readonly int baudRate = int.Parse(ConfigurationManager.AppSettings["BAUD_RATE"] ?? "9600");

        private readonly Enum parity = (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["PARITY"] ?? "0");

        private readonly int dataBits = int.Parse(ConfigurationManager.AppSettings["DATA_BITS"] ?? "8");

        private readonly Enum stopBits = (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["STOP_BITS"] ?? "1");

        public static ControlSerialPort Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControlSerialPort();
                    }
                    return _instance;
                }
            }
        }

        public void Connect()
        {
            if (!PortExists(portName))
            {
                Global.ShowBoxError("Port COM not exists!");
                return;
            }

            serialPort = new SerialPort(portName, baudRate, (Parity)parity, dataBits, (StopBits)stopBits);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        public void Open()
        {
            if (serialPort != null)
            {
                if (!serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.Open();
                    }
                    catch (Exception ex)
                    {
                        Global.ShowBoxError($"Error can not connect to serial port, err: {ex.Message}");
                    }
                }
            }
        }

        public void Close()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

        public void SendData(string data)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine(data);
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort == null)
                {
                    return;
                }

                string value = serialPort.ReadExisting();

                if (value != "done")
                {
                    DataSerialPort result = new DataSerialPort();

                    var data = value.Split(',');

                    result.WaitTime = data.Length > 0 ? data[0] : string.Empty;
                    result.Overtime = data.Length > 1 ? data[1] : string.Empty;
                    result.Pressure = data.Length > 2 ? data[2] : string.Empty;
                    result.TimeVacuum = data.Length > 3 ? data[3] : string.Empty;
                    result.TemperatureOrdinary = data.Length > 4 ? data[4] : string.Empty;
                    result.TimeStartLot = data.Length > 5 ? data[5] : string.Empty;
                    result.TimeEndLot = data.Length > 6 ? data[6] : string.Empty;
                    result.Vent = data.Length > 7 ? data[7] : string.Empty;
                    result.TimeVent = data.Length > 8 ? data[8] : string.Empty;
                    result.TemperatureWorking = data.Length > 9 ? data[9] : string.Empty;

                    formMain.AddDataGridView(result);

                    Task.Run(() =>
                    {
                        //string path = string.Empty;
                        //Files.WriteCSV(path, result);
                        //SQLite.Instance.Insert(result);
                    });
                }
                else
                {
                    Global.TotalLot += 1;
                    Files.WriteFileToTxt(Files.GetFilePathSetting(), new Dictionary<string, string>
                    {
                        {"TOTAL_LOT", Global.TotalLot.ToString() }
                    });
                    formMain.SetTotalLot(Global.TotalLot.ToString());
                }
            }
            catch (Exception ex)
            {
                Global.ShowBoxError($"Error when receive data from serial port, err: {ex.Message}");
            }
        }

        private static bool PortExists(string portName)
        {
            return SerialPort.GetPortNames().Any(port => port.Equals(portName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
