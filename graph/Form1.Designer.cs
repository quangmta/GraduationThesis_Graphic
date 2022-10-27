
namespace graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.COMport = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.ComboBox();
            this.dataBit = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.stopBit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.dataTx = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MotorStatusLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.MotorSpeedLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MotorDirectionLabel = new System.Windows.Forms.Label();
            this.ValseStatusLabel = new System.Windows.Forms.Label();
            this.WorkingModeLabel = new System.Windows.Forms.Label();
            this.MotorWorkingAbilityLabel = new System.Windows.Forms.Label();
            this.ExtremePositionsLabel = new System.Windows.Forms.Label();
            this.DataRx = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.dataTx.SuspendLayout();
            this.DataRx.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zedGraphControl1.Location = new System.Drawing.Point(38, 217);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(682, 338);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(824, 505);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 46);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data bit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Stop bits";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(66, 203);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 46);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(66, 203);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(104, 46);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // COMport
            // 
            this.COMport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMport.FormattingEnabled = true;
            this.COMport.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.COMport.Location = new System.Drawing.Point(105, 25);
            this.COMport.Margin = new System.Windows.Forms.Padding(2);
            this.COMport.Name = "COMport";
            this.COMport.Size = new System.Drawing.Size(98, 28);
            this.COMport.TabIndex = 13;
            // 
            // Baudrate
            // 
            this.Baudrate.Enabled = false;
            this.Baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baudrate.FormattingEnabled = true;
            this.Baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.Baudrate.Location = new System.Drawing.Point(105, 62);
            this.Baudrate.Margin = new System.Windows.Forms.Padding(2);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(98, 28);
            this.Baudrate.TabIndex = 13;
            // 
            // dataBit
            // 
            this.dataBit.Enabled = false;
            this.dataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBit.FormattingEnabled = true;
            this.dataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBit.Location = new System.Drawing.Point(105, 94);
            this.dataBit.Margin = new System.Windows.Forms.Padding(2);
            this.dataBit.Name = "dataBit";
            this.dataBit.Size = new System.Drawing.Size(98, 28);
            this.dataBit.TabIndex = 13;
            // 
            // Parity
            // 
            this.Parity.Enabled = false;
            this.Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "none",
            "even",
            "odd",
            "mark"});
            this.Parity.Location = new System.Drawing.Point(105, 130);
            this.Parity.Margin = new System.Windows.Forms.Padding(2);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(98, 28);
            this.Parity.TabIndex = 13;
            // 
            // stopBit
            // 
            this.stopBit.Enabled = false;
            this.stopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBit.FormattingEnabled = true;
            this.stopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBit.Location = new System.Drawing.Point(105, 162);
            this.stopBit.Margin = new System.Windows.Forms.Padding(2);
            this.stopBit.Name = "stopBit";
            this.stopBit.Size = new System.Drawing.Size(98, 28);
            this.stopBit.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.stopBit);
            this.groupBox1.Controls.Add(this.Parity);
            this.groupBox1.Controls.Add(this.dataBit);
            this.groupBox1.Controls.Add(this.Baudrate);
            this.groupBox1.Controls.Add(this.COMport);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(758, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(238, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // buttonOn
            // 
            this.buttonOn.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonOn.Enabled = false;
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOn.Location = new System.Drawing.Point(14, 27);
            this.buttonOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(94, 57);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "TURN ON MOTOR";
            this.buttonOn.UseVisualStyleBackColor = false;
            this.buttonOn.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonOff.Enabled = false;
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonOff.Location = new System.Drawing.Point(14, 98);
            this.buttonOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(94, 57);
            this.buttonOff.TabIndex = 0;
            this.buttonOff.Text = "TURN OFF MOTOR";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSet.Enabled = false;
            this.buttonSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSet.Location = new System.Drawing.Point(114, 27);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(110, 57);
            this.buttonSet.TabIndex = 18;
            this.buttonSet.Text = "SET AUTO PRESSURE";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonManual.Enabled = false;
            this.buttonManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManual.Location = new System.Drawing.Point(114, 96);
            this.buttonManual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(110, 57);
            this.buttonManual.TabIndex = 17;
            this.buttonManual.Text = "MANUAL CONTROL";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // dataTx
            // 
            this.dataTx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataTx.Controls.Add(this.buttonManual);
            this.dataTx.Controls.Add(this.buttonSet);
            this.dataTx.Controls.Add(this.buttonOff);
            this.dataTx.Controls.Add(this.buttonOn);
            this.dataTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTx.Location = new System.Drawing.Point(758, 21);
            this.dataTx.Margin = new System.Windows.Forms.Padding(2);
            this.dataTx.Name = "dataTx";
            this.dataTx.Padding = new System.Windows.Forms.Padding(2);
            this.dataTx.Size = new System.Drawing.Size(242, 167);
            this.dataTx.TabIndex = 13;
            this.dataTx.TabStop = false;
            this.dataTx.Text = "Control system";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(58, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motor status";
            // 
            // MotorStatusLabel
            // 
            this.MotorStatusLabel.AutoSize = true;
            this.MotorStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotorStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.MotorStatusLabel.Location = new System.Drawing.Point(210, 82);
            this.MotorStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotorStatusLabel.Name = "MotorStatusLabel";
            this.MotorStatusLabel.Size = new System.Drawing.Size(45, 20);
            this.MotorStatusLabel.TabIndex = 10;
            this.MotorStatusLabel.Text = "OFF";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressureLabel.ForeColor = System.Drawing.Color.Green;
            this.PressureLabel.Location = new System.Drawing.Point(210, 32);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(19, 20);
            this.PressureLabel.TabIndex = 10;
            this.PressureLabel.Text = "0";
            // 
            // MotorSpeedLabel
            // 
            this.MotorSpeedLabel.AutoSize = true;
            this.MotorSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotorSpeedLabel.ForeColor = System.Drawing.Color.Green;
            this.MotorSpeedLabel.Location = new System.Drawing.Point(210, 57);
            this.MotorSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotorSpeedLabel.Name = "MotorSpeedLabel";
            this.MotorSpeedLabel.Size = new System.Drawing.Size(19, 20);
            this.MotorSpeedLabel.TabIndex = 10;
            this.MotorSpeedLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(362, 87);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Motor working ability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(58, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Motor direction";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(58, 57);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 20);
            this.label25.TabIndex = 10;
            this.label25.Text = "Motor speed (rpm)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(362, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valse status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(362, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Extreme positions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(58, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pressure (mbar)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(362, 117);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Working mode";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // MotorDirectionLabel
            // 
            this.MotorDirectionLabel.AutoSize = true;
            this.MotorDirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotorDirectionLabel.ForeColor = System.Drawing.Color.Green;
            this.MotorDirectionLabel.Location = new System.Drawing.Point(210, 110);
            this.MotorDirectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotorDirectionLabel.Name = "MotorDirectionLabel";
            this.MotorDirectionLabel.Size = new System.Drawing.Size(103, 20);
            this.MotorDirectionLabel.TabIndex = 14;
            this.MotorDirectionLabel.Text = "FORWARD";
            // 
            // ValseStatusLabel
            // 
            this.ValseStatusLabel.AutoSize = true;
            this.ValseStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValseStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.ValseStatusLabel.Location = new System.Drawing.Point(526, 30);
            this.ValseStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValseStatusLabel.Name = "ValseStatusLabel";
            this.ValseStatusLabel.Size = new System.Drawing.Size(71, 20);
            this.ValseStatusLabel.TabIndex = 15;
            this.ValseStatusLabel.Text = "CLOSE";
            // 
            // WorkingModeLabel
            // 
            this.WorkingModeLabel.AutoSize = true;
            this.WorkingModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkingModeLabel.ForeColor = System.Drawing.Color.Red;
            this.WorkingModeLabel.Location = new System.Drawing.Point(526, 117);
            this.WorkingModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WorkingModeLabel.Name = "WorkingModeLabel";
            this.WorkingModeLabel.Size = new System.Drawing.Size(85, 20);
            this.WorkingModeLabel.TabIndex = 15;
            this.WorkingModeLabel.Text = "MANUAL";
            // 
            // MotorWorkingAbilityLabel
            // 
            this.MotorWorkingAbilityLabel.AutoSize = true;
            this.MotorWorkingAbilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotorWorkingAbilityLabel.ForeColor = System.Drawing.Color.Green;
            this.MotorWorkingAbilityLabel.Location = new System.Drawing.Point(526, 87);
            this.MotorWorkingAbilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotorWorkingAbilityLabel.Name = "MotorWorkingAbilityLabel";
            this.MotorWorkingAbilityLabel.Size = new System.Drawing.Size(35, 20);
            this.MotorWorkingAbilityLabel.TabIndex = 15;
            this.MotorWorkingAbilityLabel.Text = "OK";
            // 
            // ExtremePositionsLabel
            // 
            this.ExtremePositionsLabel.AutoSize = true;
            this.ExtremePositionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtremePositionsLabel.ForeColor = System.Drawing.Color.Green;
            this.ExtremePositionsLabel.Location = new System.Drawing.Point(526, 57);
            this.ExtremePositionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExtremePositionsLabel.Name = "ExtremePositionsLabel";
            this.ExtremePositionsLabel.Size = new System.Drawing.Size(47, 20);
            this.ExtremePositionsLabel.TabIndex = 15;
            this.ExtremePositionsLabel.Text = "NOT";
            // 
            // DataRx
            // 
            this.DataRx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataRx.Controls.Add(this.ExtremePositionsLabel);
            this.DataRx.Controls.Add(this.MotorWorkingAbilityLabel);
            this.DataRx.Controls.Add(this.WorkingModeLabel);
            this.DataRx.Controls.Add(this.ValseStatusLabel);
            this.DataRx.Controls.Add(this.MotorDirectionLabel);
            this.DataRx.Controls.Add(this.label14);
            this.DataRx.Controls.Add(this.label5);
            this.DataRx.Controls.Add(this.label12);
            this.DataRx.Controls.Add(this.label11);
            this.DataRx.Controls.Add(this.label25);
            this.DataRx.Controls.Add(this.label10);
            this.DataRx.Controls.Add(this.label15);
            this.DataRx.Controls.Add(this.MotorSpeedLabel);
            this.DataRx.Controls.Add(this.PressureLabel);
            this.DataRx.Controls.Add(this.MotorStatusLabel);
            this.DataRx.Controls.Add(this.label6);
            this.DataRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRx.Location = new System.Drawing.Point(38, 21);
            this.DataRx.Margin = new System.Windows.Forms.Padding(2);
            this.DataRx.Name = "DataRx";
            this.DataRx.Padding = new System.Windows.Forms.Padding(2);
            this.DataRx.Size = new System.Drawing.Size(682, 167);
            this.DataRx.TabIndex = 13;
            this.DataRx.TabStop = false;
            this.DataRx.Text = "System Infomation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(165)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1046, 587);
            this.Controls.Add(this.dataTx);
            this.Controls.Add(this.DataRx);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Сompressor software for KEF system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataTx.ResumeLayout(false);
            this.DataRx.ResumeLayout(false);
            this.DataRx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ComboBox COMport;
        private System.Windows.Forms.ComboBox Baudrate;
        private System.Windows.Forms.ComboBox dataBit;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox stopBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.GroupBox dataTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MotorStatusLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label MotorSpeedLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label MotorDirectionLabel;
        private System.Windows.Forms.Label ValseStatusLabel;
        private System.Windows.Forms.Label WorkingModeLabel;
        private System.Windows.Forms.Label MotorWorkingAbilityLabel;
        private System.Windows.Forms.Label ExtremePositionsLabel;
        private System.Windows.Forms.GroupBox DataRx;
    }
}

