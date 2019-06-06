using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppWeekOfMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetWeekOfMonth(dateTimePicker1.Value).ToString();
        }

         GregorianCalendar _gc = new GregorianCalendar();
        public  int GetWeekOfMonth(DateTime time)
        {
            DateTime first = new DateTime(time.Year, time.Month, 1);
            return GetWeekOfYear(time) - GetWeekOfYear(first) + 1;
        }

        int GetWeekOfYear(DateTime time)
        {
            return _gc.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
    }
}
