namespace Countdown_Timer
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SecsLabel = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.TestLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(211, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(369, 31);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2022, 10, 4, 23, 55, 7, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Date to Count Down:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Days:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaysLabel
            // 
            this.DaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.ForeColor = System.Drawing.Color.Red;
            this.DaysLabel.Location = new System.Drawing.Point(162, 127);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(67, 51);
            this.DaysLabel.TabIndex = 3;
            this.DaysLabel.Text = "0";
            this.DaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hours:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursLabel
            // 
            this.HoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.ForeColor = System.Drawing.Color.Red;
            this.HoursLabel.Location = new System.Drawing.Point(325, 127);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(67, 51);
            this.HoursLabel.TabIndex = 5;
            this.HoursLabel.Text = "0";
            this.HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 51);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mins:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinsLabel
            // 
            this.MinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinsLabel.ForeColor = System.Drawing.Color.Red;
            this.MinsLabel.Location = new System.Drawing.Point(480, 127);
            this.MinsLabel.Name = "MinsLabel";
            this.MinsLabel.Size = new System.Drawing.Size(67, 51);
            this.MinsLabel.TabIndex = 7;
            this.MinsLabel.Text = "0";
            this.MinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 51);
            this.label8.TabIndex = 8;
            this.label8.Text = "Secs:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecsLabel
            // 
            this.SecsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecsLabel.ForeColor = System.Drawing.Color.Red;
            this.SecsLabel.Location = new System.Drawing.Point(635, 127);
            this.SecsLabel.Name = "SecsLabel";
            this.SecsLabel.Size = new System.Drawing.Size(67, 51);
            this.SecsLabel.TabIndex = 9;
            this.SecsLabel.Text = "0";
            this.SecsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestLabel
            // 
            this.TestLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestLabel.ForeColor = System.Drawing.Color.Red;
            this.TestLabel.Location = new System.Drawing.Point(221, 262);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(368, 51);
            this.TestLabel.TabIndex = 10;
            this.TestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestLabel2
            // 
            this.TestLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestLabel2.ForeColor = System.Drawing.Color.Red;
            this.TestLabel2.Location = new System.Drawing.Point(221, 374);
            this.TestLabel2.Name = "TestLabel2";
            this.TestLabel2.Size = new System.Drawing.Size(368, 51);
            this.TestLabel2.TabIndex = 11;
            this.TestLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Selected:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date Today:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestLabel2);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.SecsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MinsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SecsLabel;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label TestLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

