using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using CsvHelper.Configuration.Attributes;
using System.IO;

namespace graph
{
    public partial class Form1 : Form
    {
        string dataReceive;
        GraphPane myPane;
        PointPairList listPoint = new PointPairList();
        int i = 0;
        const int range = 60;
        double pressureRxValue;
        double rangeScale = DateTime.Now.AddSeconds(range + 1).ToOADate() - DateTime.Now.ToOADate();
        bool flagConnect = false;
        bool flagDataReceived = false;
        string[] arrListStr;
        public static System.IO.Ports.SerialPort sPort;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Graph of pressure at the compressor";
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Presuse (mbar)";
            myPane.XAxis.Type = AxisType.Date;
            myPane.XAxis.Scale.Format = "HH:mm:ss";

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.Scale.MajorUnit = DateUnit.Second;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.XAxis.Scale.MinorUnit = DateUnit.Second;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.FontSpec.Angle = 0;
            myPane.YAxis.Scale.Min = -50;
            myPane.YAxis.Scale.Max = 2050;

            //serial
            COMport.SelectedItem = "COM3";
            Baudrate.SelectedItem = "115200";
            dataBit.SelectedItem = "8";
            Parity.SelectedItem = "none";
            stopBit.SelectedItem = "1";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = COMport.Text;
            serialPort1.BaudRate = Convert.ToInt32(Baudrate.Text);
            serialPort1.DataBits = Convert.ToInt32(dataBit.Text);
            switch (Parity.Text)
            {
                case "None":
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    break;
                case "even":
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                    break;
                case "odd":
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "mark":
                    serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    break;
            }
            switch (stopBit.Text)
            {
                case "1":
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case "1.5":
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    break;
            }

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    buttonConnect.Visible = false;
                    buttonDisconnect.Visible = true;
                    COMport.Enabled = false;
                    buttonOn.Enabled = true;
                    buttonOff.Enabled = true;
                    flagConnect = true;
                    buttonManual.Enabled = true;
                    buttonSet.Enabled = true;

                }
                catch
                {
                    MessageBox.Show($"Can't open {COMport.Text}");
                }
            }
            sPort = serialPort1;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            flagConnect = false;
            serialPort1.Close();
            buttonConnect.Visible = true;
            buttonDisconnect.Visible = false;
            COMport.Enabled = true;
            buttonOn.Enabled = false;
            buttonOff.Enabled = false;
            buttonManual.Enabled = false;
            buttonSet.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DateTime now = DateTime.Now;
            if (serialPort1.IsOpen)
            {
                try
                {
                    while (serialPort1.BytesToRead > 0)
                    {
                        dataReceive = serialPort1.ReadLine();
                        char[] charsToTrim = { '\r', '\n' };
                        dataReceive = dataReceive.Trim(charsToTrim);
                        arrListStr = dataReceive.Split(' ');
                        if (arrListStr.Length == 9)
                        {
                            flagDataReceived = true;
                            if (listPoint.Count > 0)
                            {
                                while (listPoint[0].X < now.AddSeconds(-range).ToOADate())
                                {
                                    listPoint.RemoveAt(0);
                                    if (listPoint.Count == 0)
                                    {
                                        break;
                                    }
                                }
                                if (listPoint.Count == 0)
                                {
                                    myPane.XAxis.Scale.Min = now.ToOADate();
                                    myPane.XAxis.Scale.Max = now.AddSeconds(range + 1).ToOADate();
                                }
                                else
                                {
                                    myPane.XAxis.Scale.Min = listPoint[0].X;
                                    myPane.XAxis.Scale.Max = listPoint[0].X + rangeScale;
                                }
                            }
                            pressureRxValue = Convert.ToDouble(arrListStr[0]);
                            listPoint.Add(now.ToOADate(), pressureRxValue);
                            i++;
                        }
                    }
                }
                catch { }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                if (flagConnect)
                {
                    buttonConnect.Visible = true;
                    buttonDisconnect.Visible = false;
                    flagConnect = false;
                    MessageBox.Show($"{COMport.Text} is disconected!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                if (flagDataReceived)
                {
                    flagDataReceived = false;
                    PressureLabel.Text = arrListStr[0];
                    MotorSpeedLabel.Text = Math.Abs(Convert.ToDouble(arrListStr[1])).ToString();
                    //Motor Status
                    if (arrListStr[2] == "1")
                    {
                        MotorStatusLabel.Text = "ON";
                        MotorStatusLabel.ForeColor = Color.Green;
                    }
                    else if (arrListStr[2] == "0")
                    {
                        MotorStatusLabel.Text = "OFF";
                        MotorStatusLabel.ForeColor = Color.Red;
                    }
                    //Motor Direction
                    if (arrListStr[3] == "1")
                    {
                        MotorDirectionLabel.Text = "FORWARD";
                        MotorDirectionLabel.ForeColor = Color.Green;
                    }
                    else if (arrListStr[3] == "0")
                    {
                        MotorDirectionLabel.Text = "BACK";
                        MotorDirectionLabel.ForeColor = Color.Red;
                    }
                    //Valse Status Label
                    if (arrListStr[4] == "0")
                    {
                        ValseStatusLabel.Text = "CLOSE";
                        ValseStatusLabel.ForeColor = Color.Green;
                    }
                    else if (arrListStr[4] == "1")
                    {
                        ValseStatusLabel.Text = "OPEN";
                        ValseStatusLabel.ForeColor = Color.Red;
                    }
                    //Extreme Positions Label
                    if (arrListStr[5] == "1" && arrListStr[6] == "1")
                    {
                        ExtremePositionsLabel.Text = "HEAD+END";
                        ExtremePositionsLabel.ForeColor = Color.Red;
                    }
                    else if (arrListStr[5] == "0" && arrListStr[6] == "0")
                    {
                        ExtremePositionsLabel.Text = "NOT";
                        ExtremePositionsLabel.ForeColor = Color.Green;
                    }
                    else if (arrListStr[5] == "1")
                    {
                        ExtremePositionsLabel.Text = "HEAD";
                        ExtremePositionsLabel.ForeColor = Color.Red;
                    }
                    else if (arrListStr[6] == "1")
                    {
                        ExtremePositionsLabel.Text = "END";
                        ExtremePositionsLabel.ForeColor = Color.Red;
                    }
                    //Motor woking ability
                    if (arrListStr[7] == "0")
                    {
                        MotorWorkingAbilityLabel.Text = "OK";
                        MotorWorkingAbilityLabel.ForeColor = Color.Green;
                    }
                    else if (arrListStr[7] == "1")
                    {
                        MotorWorkingAbilityLabel.Text = "ERROR";
                        MotorWorkingAbilityLabel.ForeColor = Color.Red;
                    }
                    //Working Mode Label
                    if (arrListStr[8] == "1")
                    {
                        WorkingModeLabel.Text = "AUTO";
                        WorkingModeLabel.ForeColor = Color.Green;

                    }
                    else if (arrListStr[8] == "0")
                    {
                        WorkingModeLabel.Text = "MANUAL";
                        WorkingModeLabel.ForeColor = Color.Red;
                    }
                    zedGraphControl1.GraphPane.CurveList.Clear();
                    myPane.AddCurve(null, listPoint, Color.Blue, SymbolType.None);
                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Invalidate();
                    /*
                                        try
                                        {
                                            using (var stream = File.Open("data.csv", FileMode.Append))
                                            using (var writer = new StreamWriter(stream))
                                            {
                                                var line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                                                    DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),PressureLabel.Text ,MotorSpeedLabel.Text,
                                                    MotorStatusLabel.Text,MotorDirectionLabel.Text,ValseStatusLabel.Text,
                                                    ExtremePositionsLabel.Text,MotorWorkingAbilityLabel.Text,WorkingModeLabel.Text);
                                                writer.WriteLine(line);
                                                writer.Flush();
                                            }
                                        }
                                        catch
                                        {
                                            //MessageBox.Show("Can't open file to save data", "File error",
                                            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }*/
                }
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e\n");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s\n");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupSpeed_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    serialPort1.Write("a" + f2.presusre + "\n");
                }
            }
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            using (Form3 f3 = new Form3())
            {
                f3.ShowDialog();
            }
        }
    }
    public class DataToSave
    {
        [Format("dd/MM/yyyy HH:mm:ss")]
        public DateTime TimeNow { get; set; }
        public double pressure { get; set; }
        public string statusSystem { get; set; }

    }
}
