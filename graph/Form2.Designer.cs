namespace graph
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxInterval1 = new System.Windows.Forms.TextBox();
            this.textBoxInterval2 = new System.Windows.Forms.TextBox();
            this.labelInteval2 = new System.Windows.Forms.Label();
            this.labelInteval1 = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.labelAmplitude = new System.Windows.Forms.Label();
            this.textBoxAmplitude = new System.Windows.Forms.TextBox();
            this.labelPressure = new System.Windows.Forms.Label();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonTrapezoidal = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangular = new System.Windows.Forms.RadioButton();
            this.radioButtonSine = new System.Windows.Forms.RadioButton();
            this.radioButtonConst = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxConst = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrapezoidal = new System.Windows.Forms.PictureBox();
            this.pictureBoxSine = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinear = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriagular = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrapezoidal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriagular)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.textBoxInterval1);
            this.groupBox4.Controls.Add(this.textBoxInterval2);
            this.groupBox4.Controls.Add(this.labelInteval2);
            this.groupBox4.Controls.Add(this.labelInteval1);
            this.groupBox4.Controls.Add(this.labelPeriod);
            this.groupBox4.Controls.Add(this.textBoxPeriod);
            this.groupBox4.Controls.Add(this.labelAmplitude);
            this.groupBox4.Controls.Add(this.textBoxAmplitude);
            this.groupBox4.Controls.Add(this.labelPressure);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 246);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Value";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBoxInterval1
            // 
            this.textBoxInterval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval1.Location = new System.Drawing.Point(156, 157);
            this.textBoxInterval1.Name = "textBoxInterval1";
            this.textBoxInterval1.Size = new System.Drawing.Size(75, 24);
            this.textBoxInterval1.TabIndex = 36;
            this.textBoxInterval1.Visible = false;
            // 
            // textBoxInterval2
            // 
            this.textBoxInterval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval2.Location = new System.Drawing.Point(156, 201);
            this.textBoxInterval2.Name = "textBoxInterval2";
            this.textBoxInterval2.Size = new System.Drawing.Size(75, 24);
            this.textBoxInterval2.TabIndex = 35;
            this.textBoxInterval2.Visible = false;
            // 
            // labelInteval2
            // 
            this.labelInteval2.AutoSize = true;
            this.labelInteval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInteval2.Location = new System.Drawing.Point(23, 207);
            this.labelInteval2.Name = "labelInteval2";
            this.labelInteval2.Size = new System.Drawing.Size(129, 18);
            this.labelInteval2.TabIndex = 34;
            this.labelInteval2.Text = "Time interval t2 (s)";
            this.labelInteval2.Visible = false;
            // 
            // labelInteval1
            // 
            this.labelInteval1.AutoSize = true;
            this.labelInteval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInteval1.Location = new System.Drawing.Point(23, 161);
            this.labelInteval1.Name = "labelInteval1";
            this.labelInteval1.Size = new System.Drawing.Size(129, 18);
            this.labelInteval1.TabIndex = 33;
            this.labelInteval1.Text = "Time interval t1 (s)";
            this.labelInteval1.Visible = false;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(23, 113);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(86, 18);
            this.labelPeriod.TabIndex = 32;
            this.labelPeriod.Text = "Period T (s)";
            this.labelPeriod.Visible = false;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriod.Location = new System.Drawing.Point(156, 110);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(75, 24);
            this.textBoxPeriod.TabIndex = 31;
            this.textBoxPeriod.Visible = false;
            this.textBoxPeriod.WordWrap = false;
            // 
            // labelAmplitude
            // 
            this.labelAmplitude.AutoSize = true;
            this.labelAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmplitude.Location = new System.Drawing.Point(23, 68);
            this.labelAmplitude.Name = "labelAmplitude";
            this.labelAmplitude.Size = new System.Drawing.Size(117, 18);
            this.labelAmplitude.TabIndex = 29;
            this.labelAmplitude.Text = "Const A0 (mbar)";
            // 
            // textBoxAmplitude
            // 
            this.textBoxAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmplitude.Location = new System.Drawing.Point(156, 65);
            this.textBoxAmplitude.Name = "textBoxAmplitude";
            this.textBoxAmplitude.Size = new System.Drawing.Size(75, 24);
            this.textBoxAmplitude.TabIndex = 22;
            this.textBoxAmplitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.Location = new System.Drawing.Point(23, 35);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(178, 18);
            this.labelPressure.TabIndex = 7;
            this.labelPressure.Text = "Pressure: 0 -> 2000 mBar";
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(108, 23);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(75, 22);
            this.radioButtonLinear.TabIndex = 23;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            this.radioButtonLinear.CheckedChanged += new System.EventHandler(this.radioButtonLinear_CheckedChanged);
            // 
            // radioButtonTrapezoidal
            // 
            this.radioButtonTrapezoidal.AutoSize = true;
            this.radioButtonTrapezoidal.Location = new System.Drawing.Point(376, 23);
            this.radioButtonTrapezoidal.Name = "radioButtonTrapezoidal";
            this.radioButtonTrapezoidal.Size = new System.Drawing.Size(117, 22);
            this.radioButtonTrapezoidal.TabIndex = 21;
            this.radioButtonTrapezoidal.Text = "Trapezoidal";
            this.radioButtonTrapezoidal.UseVisualStyleBackColor = true;
            this.radioButtonTrapezoidal.CheckedChanged += new System.EventHandler(this.radioButtonTrapezoidial_CheckedChanged);
            // 
            // radioButtonTriangular
            // 
            this.radioButtonTriangular.AutoSize = true;
            this.radioButtonTriangular.Location = new System.Drawing.Point(266, 23);
            this.radioButtonTriangular.Name = "radioButtonTriangular";
            this.radioButtonTriangular.Size = new System.Drawing.Size(104, 22);
            this.radioButtonTriangular.TabIndex = 20;
            this.radioButtonTriangular.Text = "Triangular";
            this.radioButtonTriangular.UseVisualStyleBackColor = true;
            this.radioButtonTriangular.CheckedChanged += new System.EventHandler(this.radioButtonTriangular_CheckedChanged);
            // 
            // radioButtonSine
            // 
            this.radioButtonSine.AutoSize = true;
            this.radioButtonSine.Location = new System.Drawing.Point(193, 23);
            this.radioButtonSine.Name = "radioButtonSine";
            this.radioButtonSine.Size = new System.Drawing.Size(62, 22);
            this.radioButtonSine.TabIndex = 19;
            this.radioButtonSine.Text = "Sine";
            this.radioButtonSine.UseVisualStyleBackColor = true;
            this.radioButtonSine.CheckedChanged += new System.EventHandler(this.radioButtonSine_CheckedChanged);
            // 
            // radioButtonConst
            // 
            this.radioButtonConst.AutoSize = true;
            this.radioButtonConst.Checked = true;
            this.radioButtonConst.Location = new System.Drawing.Point(31, 23);
            this.radioButtonConst.Name = "radioButtonConst";
            this.radioButtonConst.Size = new System.Drawing.Size(74, 22);
            this.radioButtonConst.TabIndex = 18;
            this.radioButtonConst.TabStop = true;
            this.radioButtonConst.Text = "Const";
            this.radioButtonConst.UseVisualStyleBackColor = true;
            this.radioButtonConst.CheckedChanged += new System.EventHandler(this.radioButtonConst_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonSubmit.Location = new System.Drawing.Point(433, 337);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(96, 44);
            this.buttonSubmit.TabIndex = 30;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(313, 337);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 44);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonLinear);
            this.groupBox1.Controls.Add(this.radioButtonTriangular);
            this.groupBox1.Controls.Add(this.radioButtonConst);
            this.groupBox1.Controls.Add(this.radioButtonTrapezoidal);
            this.groupBox1.Controls.Add(this.radioButtonSine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 60);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type signal";
            // 
            // pictureBoxConst
            // 
            this.pictureBoxConst.Image = global::graph.Properties.Resources._const;
            this.pictureBoxConst.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxConst.InitialImage")));
            this.pictureBoxConst.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxConst.Name = "pictureBoxConst";
            this.pictureBoxConst.Size = new System.Drawing.Size(255, 201);
            this.pictureBoxConst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConst.TabIndex = 28;
            this.pictureBoxConst.TabStop = false;
            this.pictureBoxConst.WaitOnLoad = true;
            this.pictureBoxConst.Click += new System.EventHandler(this.pictureBoxConst_Click);
            // 
            // pictureBoxTrapezoidal
            // 
            this.pictureBoxTrapezoidal.Image = global::graph.Properties.Resources.trapezoid;
            this.pictureBoxTrapezoidal.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrapezoidal.InitialImage")));
            this.pictureBoxTrapezoidal.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxTrapezoidal.Name = "pictureBoxTrapezoidal";
            this.pictureBoxTrapezoidal.Size = new System.Drawing.Size(255, 201);
            this.pictureBoxTrapezoidal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrapezoidal.TabIndex = 24;
            this.pictureBoxTrapezoidal.TabStop = false;
            this.pictureBoxTrapezoidal.WaitOnLoad = true;
            this.pictureBoxTrapezoidal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxSine
            // 
            this.pictureBoxSine.Image = global::graph.Properties.Resources.sine;
            this.pictureBoxSine.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSine.InitialImage")));
            this.pictureBoxSine.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxSine.Name = "pictureBoxSine";
            this.pictureBoxSine.Size = new System.Drawing.Size(255, 201);
            this.pictureBoxSine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSine.TabIndex = 25;
            this.pictureBoxSine.TabStop = false;
            this.pictureBoxSine.WaitOnLoad = true;
            this.pictureBoxSine.Click += new System.EventHandler(this.pictureBoxSine_Click);
            // 
            // pictureBoxLinear
            // 
            this.pictureBoxLinear.Image = global::graph.Properties.Resources.linear;
            this.pictureBoxLinear.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLinear.InitialImage")));
            this.pictureBoxLinear.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxLinear.Name = "pictureBoxLinear";
            this.pictureBoxLinear.Size = new System.Drawing.Size(255, 201);
            this.pictureBoxLinear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLinear.TabIndex = 27;
            this.pictureBoxLinear.TabStop = false;
            this.pictureBoxLinear.WaitOnLoad = true;
            this.pictureBoxLinear.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxTriagular
            // 
            this.pictureBoxTriagular.Image = global::graph.Properties.Resources.triagular;
            this.pictureBoxTriagular.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTriagular.InitialImage")));
            this.pictureBoxTriagular.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxTriagular.Name = "pictureBoxTriagular";
            this.pictureBoxTriagular.Size = new System.Drawing.Size(255, 201);
            this.pictureBoxTriagular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTriagular.TabIndex = 26;
            this.pictureBoxTriagular.TabStop = false;
            this.pictureBoxTriagular.WaitOnLoad = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.pictureBoxConst);
            this.groupBox2.Controls.Add(this.pictureBoxLinear);
            this.groupBox2.Controls.Add(this.pictureBoxSine);
            this.groupBox2.Controls.Add(this.pictureBoxTriagular);
            this.groupBox2.Controls.Add(this.pictureBoxTrapezoidal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(271, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 246);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Signal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Pressure";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrapezoidal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriagular)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonLinear;
        private System.Windows.Forms.TextBox textBoxAmplitude;
        private System.Windows.Forms.RadioButton radioButtonTrapezoidal;
        private System.Windows.Forms.RadioButton radioButtonTriangular;
        private System.Windows.Forms.RadioButton radioButtonSine;
        private System.Windows.Forms.RadioButton radioButtonConst;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.PictureBox pictureBoxTrapezoidal;
        private System.Windows.Forms.PictureBox pictureBoxSine;
        private System.Windows.Forms.PictureBox pictureBoxTriagular;
        private System.Windows.Forms.PictureBox pictureBoxConst;
        private System.Windows.Forms.PictureBox pictureBoxLinear;
        private System.Windows.Forms.TextBox textBoxInterval1;
        private System.Windows.Forms.TextBox textBoxInterval2;
        private System.Windows.Forms.Label labelInteval2;
        private System.Windows.Forms.Label labelInteval1;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Label labelAmplitude;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}