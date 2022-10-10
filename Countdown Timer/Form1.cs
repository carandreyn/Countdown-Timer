using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd"; //or whatever date you want
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd";

            DateTime startTime = DateTime.Now;
            DateTime endTime = dateTimePicker.Value.Date;
            TimeSpan span = endTime.Subtract(startTime);
           
            DaysLabel.Text = Math.Abs(span.Days).ToString();
            HoursLabel.Text = Math.Abs(span.Hours).ToString();
            MinsLabel.Text = Math.Abs(span.Minutes).ToString();
            SecsLabel.Text = Math.Abs(span.Seconds).ToString();

            TestLabel.Text = endTime.ToString();
            TestLabel2.Text = startTime.ToString();
        }
    }
}
