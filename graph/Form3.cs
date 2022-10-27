using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string cmd { get; set; }
        private void buttonSetSpeed_Click(object sender, EventArgs e)
        {
            double speed;
            try
            {
                speed = Convert.ToDouble(textBoxSpeed.Text);
                if (speed < 0 || speed > 3500)
                {
                    MessageBox.Show($"Value's out of range!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    Form1.sPort.Write($"f{textBoxSpeed.Text}\n");
                }
            }
            catch
            {
                MessageBox.Show($"This's not number!", "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("g\n");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("b\n");
        }

        private void buttonCloseValse_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("c\n");
        }

        private void buttonOpenValse_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("o\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("e\n");
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            Form1.sPort.Write("s\n");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
