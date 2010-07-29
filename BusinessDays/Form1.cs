using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessDays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = AddBusinessDays(Convert.ToDateTime(dateTimePicker1.Text), 30).ToString();
        }


        private DateTime AddBusinessDays(DateTime date, int days)
        {
            while (days > 0)
            {
                date=date.AddDays(1);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                else
                    days--;
            }
            return date;
        }
    }
}
