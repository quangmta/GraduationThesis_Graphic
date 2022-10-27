using System;
using System.Windows.Forms;

namespace graph
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string presusre { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxConst_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonConst_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxConst.Visible = true;
            pictureBoxLinear.Visible = false;
            pictureBoxSine.Visible = false;
            pictureBoxTriagular.Visible = false;
            pictureBoxTrapezoidal.Visible = false;

            labelAmplitude.Text = "Const A0 (mbar)";
            labelPressure.Text = "Pressure: 0 -> 2000 mbar";
            labelAmplitude.Visible = true;
            labelPeriod.Visible = false;
            labelInteval1.Visible = false;
            labelInteval2.Visible = false;

            textBoxAmplitude.Visible = true;
            textBoxPeriod.Visible = false;
            textBoxInterval1.Visible = false;
            textBoxInterval2.Visible=false;
        }

        private void radioButtonLinear_CheckedChanged(object sender, EventArgs e)
        {
            labelPressure.Text = "Coefient: -500 -> 500 mbar/s";
            pictureBoxConst.Visible = false;
            pictureBoxLinear.Visible = true;
            pictureBoxSine.Visible = false;
            pictureBoxTriagular.Visible = false;
            pictureBoxTrapezoidal.Visible = false;

            labelAmplitude.Text = "Coeffient k (mbar/s)";
            labelAmplitude.Visible = true;
            labelPeriod.Visible = false;
            labelInteval1.Visible = false;
            labelInteval2.Visible = false;

            textBoxAmplitude.Visible = true;
            textBoxPeriod.Visible = false;
            textBoxInterval1.Visible = false;
            textBoxInterval2.Visible = false;
        }

        private void radioButtonSine_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxConst.Visible = false;
            pictureBoxLinear.Visible = false;
            pictureBoxSine.Visible = true;
            pictureBoxTriagular.Visible = false;
            pictureBoxTrapezoidal.Visible = false;

            labelPressure.Text = "Amplitude: 0 -> 1000 mbar";
            labelAmplitude.Text = "Amplitude A (mbar)";
            labelAmplitude.Visible = true;
            labelPeriod.Visible = true;
            labelInteval1.Visible = false;
            labelInteval2.Visible = false;

            textBoxAmplitude.Visible = true;
            textBoxPeriod.Visible = true;
            textBoxInterval1.Visible = false;
            textBoxInterval2.Visible = false;


        }

        private void radioButtonTriangular_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxConst.Visible = false;
            pictureBoxLinear.Visible = false;
            pictureBoxSine.Visible = false;
            pictureBoxTriagular.Visible = true;
            pictureBoxTrapezoidal.Visible = false;

            labelPressure.Text = "Amplitude: 0 -> 1000 mbar";
            labelAmplitude.Text = "Amplitude A (mbar)";
            labelAmplitude.Visible = true;
            labelPeriod.Visible = true;
            labelInteval1.Visible = false;
            labelInteval2.Visible = false;

            textBoxAmplitude.Visible = true;
            textBoxPeriod.Visible = true;
            textBoxInterval1.Visible = false;
            textBoxInterval2.Visible = false;
        }

        private void radioButtonTrapezoidial_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxConst.Visible = false;
            pictureBoxLinear.Visible = false;
            pictureBoxSine.Visible = false;
            pictureBoxTriagular.Visible = false;
            pictureBoxTrapezoidal.Visible = true;

            labelPressure.Text = "Amplitude: 0 -> 1000 mbar";
            labelAmplitude.Text = "Amplitude A (mbar)";
            labelAmplitude.Visible = true;
            labelPeriod.Visible = true;
            labelInteval1.Visible = true;
            labelInteval2.Visible = true;

            textBoxAmplitude.Visible = true;
            textBoxPeriod.Visible = true;
            textBoxInterval1.Visible = true;
            textBoxInterval2.Visible = true;
        }

        private void textBoxPressure_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonConst.Checked)
            {
                double offset;
                try
                {
                    offset = Convert.ToDouble(textBoxAmplitude.Text);
                    if (offset < 0 || offset > 3000)
                    {
                        MessageBox.Show($"Const's out of range!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        presusre = "a" + textBoxAmplitude.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show($"This's not number!", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            else if (radioButtonLinear.Checked)
            {
                double Amplitude;
                try
                {
                    Amplitude = Convert.ToDouble(textBoxAmplitude.Text);
                    if (Amplitude < -1000 || Amplitude > 1000)
                    {
                        MessageBox.Show($"Coefficient's out of range! Must be from -1000 to 1000", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        presusre = "b" + textBoxAmplitude.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show($"This's not number!", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }

            }
            else if (radioButtonSine.Checked)
            {
                double Amplitude, Period = 0;
                string error1 = "", error2 = "", error = "";

                //Aplitude
                try
                {
                    Amplitude = Convert.ToDouble(textBoxAmplitude.Text);
                    if (Amplitude < 0 || Amplitude > 1000)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Amplitude";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Amplitude";
                }
                //Period
                try
                {
                    Period = Convert.ToDouble(textBoxPeriod.Text);
                    if (Period <= 0)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Period";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Period";
                }
                //check error
                if (error1 != "")
                {
                    error1 += ": not number";
                    error += error1;
                }
                if (error2 != "")
                {
                    error2 += ": out of range";
                    if (error != "") error += "\n";
                    error += error2;
                }
                //output
                if (error == "")
                {
                    presusre = "c" + textBoxAmplitude.Text + "," + textBoxPeriod.Text;
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioButtonTriangular.Checked)
            {
                double Amplitude, Period=0;
                string error1 = "", error2 = "",error="";
                //Aplitude
                try
                {
                    Amplitude = Convert.ToDouble(textBoxAmplitude.Text);
                    if (Amplitude < 0 || Amplitude > 1000)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Amplitude";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Amplitude";
                }
                //Period
                try
                {
                    Period = Convert.ToDouble(textBoxPeriod.Text);
                    if (Period <= 0)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Period";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Period";
                }
                //check error
                if (error1 != "")
                {
                    error1 += ": not number";
                    error+=error1;
                }
                if (error2 != "")
                {
                    error2 += ": out of range";
                    if (error != "") error += "\n";
                    error += error2;
                }
                //output
                if (error=="")
                {
                    presusre = "d" + textBoxAmplitude.Text + "," + textBoxPeriod.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            else if (radioButtonTrapezoidal.Checked)
            {
                double Amplitude, Period = 0, Interval1 = 0, Interval2 = 0;
                string error1 = "", error2 = "", error3 = "", error = "";
                //Aplitude
                try
                {
                    Amplitude = Convert.ToDouble(textBoxAmplitude.Text);
                    if (Amplitude < 0 || Amplitude>1000)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Amplitude";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Amplitude";
                }
                //Period
                try
                {
                    Period = Convert.ToDouble(textBoxPeriod.Text);
                    if (Period <= 0)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Period";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Period";
                }
                //Interval1
                try
                {
                    Interval1 = Convert.ToDouble(textBoxInterval1.Text);
                    if (Interval1 <= 0)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Interval1";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Interval1";
                }
                //Interval2
                try
                {
                    Interval2 = Convert.ToDouble(textBoxInterval2.Text);
                    if (Interval2 < 0)
                    {
                        if (error2 != "") error2 += ", ";
                        error2 += "Interval2";
                    }
                    else if (Interval1 > 0)
                    {
                        if (2 * Interval2 + Interval1 > Period)
                            error3 = "Invalid value: 2*t2+t1>T";
                    }
                }
                catch
                {
                    if (error1 != "") error1 += ", ";
                    error1 += "Interval2";
                }
                if (error1 != "")
                {
                    error1 += ": not number";
                    error += error1;
                }
                if (error2 != "")
                {
                    error2 += ": out of range";
                    if (error != "") error += "\n";
                    error += error2;
                }
                if (error3 != "")
                {
                    if (error != "") error += "\n";
                    error += error3;
                }
                if (error=="")
                {
                    presusre = "e" + textBoxAmplitude.Text + "," + textBoxPeriod.Text 
                        + "," + textBoxInterval1.Text + "," + textBoxInterval2.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }        

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
