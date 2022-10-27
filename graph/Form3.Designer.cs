namespace graph
{
    partial class Form3
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
            this.Motor = new System.Windows.Forms.GroupBox();
            this.groupSpeed = new System.Windows.Forms.GroupBox();
            this.buttonSetSpeed = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.buttonOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenValse = new System.Windows.Forms.Button();
            this.buttonCloseValse = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.Motor.SuspendLayout();
            this.groupSpeed.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Motor
            // 
            this.Motor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Motor.Controls.Add(this.groupSpeed);
            this.Motor.Controls.Add(this.buttonOff);
            this.Motor.Controls.Add(this.groupBox3);
            this.Motor.Controls.Add(this.buttonOn);
            this.Motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Motor.Location = new System.Drawing.Point(12, 12);
            this.Motor.Margin = new System.Windows.Forms.Padding(2);
            this.Motor.Name = "Motor";
            this.Motor.Padding = new System.Windows.Forms.Padding(2);
            this.Motor.Size = new System.Drawing.Size(363, 164);
            this.Motor.TabIndex = 15;
            this.Motor.TabStop = false;
            this.Motor.Text = "Motor";
            // 
            // groupSpeed
            // 
            this.groupSpeed.BackColor = System.Drawing.Color.PowderBlue;
            this.groupSpeed.Controls.Add(this.buttonSetSpeed);
            this.groupSpeed.Controls.Add(this.label9);
            this.groupSpeed.Controls.Add(this.textBoxSpeed);
            this.groupSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupSpeed.Location = new System.Drawing.Point(95, 22);
            this.groupSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.groupSpeed.Name = "groupSpeed";
            this.groupSpeed.Padding = new System.Windows.Forms.Padding(2);
            this.groupSpeed.Size = new System.Drawing.Size(113, 130);
            this.groupSpeed.TabIndex = 16;
            this.groupSpeed.TabStop = false;
            this.groupSpeed.Text = "Speed";
            // 
            // buttonSetSpeed
            // 
            this.buttonSetSpeed.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSetSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetSpeed.Location = new System.Drawing.Point(18, 80);
            this.buttonSetSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetSpeed.Name = "buttonSetSpeed";
            this.buttonSetSpeed.Size = new System.Drawing.Size(66, 39);
            this.buttonSetSpeed.TabIndex = 12;
            this.buttonSetSpeed.Text = "SET";
            this.buttonSetSpeed.UseVisualStyleBackColor = false;
            this.buttonSetSpeed.Click += new System.EventHandler(this.buttonSetSpeed_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "RPM (0->1600)";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeed.Location = new System.Drawing.Point(9, 50);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(86, 24);
            this.textBoxSpeed.TabIndex = 11;
            // 
            // buttonOff
            // 
            this.buttonOff.AutoEllipsis = true;
            this.buttonOff.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.buttonOff.Location = new System.Drawing.Point(14, 96);
            this.buttonOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(71, 56);
            this.buttonOff.TabIndex = 0;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox3.Controls.Add(this.buttonBack);
            this.groupBox3.Controls.Add(this.buttonForward);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(222, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(128, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direction";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(15, 73);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 41);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForward.Location = new System.Drawing.Point(15, 21);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(96, 42);
            this.buttonForward.TabIndex = 12;
            this.buttonForward.Text = "FORWARD";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOn.Location = new System.Drawing.Point(14, 22);
            this.buttonOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(71, 56);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = false;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.buttonOpenValse);
            this.groupBox2.Controls.Add(this.buttonCloseValse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(398, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(102, 162);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valse";
            // 
            // buttonOpenValse
            // 
            this.buttonOpenValse.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonOpenValse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenValse.Location = new System.Drawing.Point(14, 96);
            this.buttonOpenValse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenValse.Name = "buttonOpenValse";
            this.buttonOpenValse.Size = new System.Drawing.Size(74, 52);
            this.buttonOpenValse.TabIndex = 12;
            this.buttonOpenValse.Text = "OPEN";
            this.buttonOpenValse.UseVisualStyleBackColor = false;
            this.buttonOpenValse.Click += new System.EventHandler(this.buttonOpenValse_Click);
            // 
            // buttonCloseValse
            // 
            this.buttonCloseValse.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonCloseValse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseValse.Location = new System.Drawing.Point(12, 28);
            this.buttonCloseValse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseValse.Name = "buttonCloseValse";
            this.buttonCloseValse.Size = new System.Drawing.Size(75, 56);
            this.buttonCloseValse.TabIndex = 13;
            this.buttonCloseValse.Text = "CLOSE";
            this.buttonCloseValse.UseVisualStyleBackColor = false;
            this.buttonCloseValse.Click += new System.EventHandler(this.buttonCloseValse_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(398, 190);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 44);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "EXIT";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 254);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Motor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Manual control";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Motor.ResumeLayout(false);
            this.groupSpeed.ResumeLayout(false);
            this.groupSpeed.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Motor;
        private System.Windows.Forms.GroupBox groupSpeed;
        private System.Windows.Forms.Button buttonSetSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenValse;
        private System.Windows.Forms.Button buttonCloseValse;
        private System.Windows.Forms.Button buttonClose;
    }
}