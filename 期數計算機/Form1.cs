using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期數計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = String.Format("相差{0}年", 0);
            label5.Text = String.Format("相差{0}個月", 0);
            label6.Text = String.Format("民國{0}年", (dateTimePicker1.Value.Year - 1911));
            label7.Text = String.Format("民國{0}年", (dateTimePicker2.Value.Year - 1911));
            label8.Text = String.Format("下一期時間為{0}年{1}月{2}日", 0, 0, 0);
            label9.Text = String.Format("也就是民國{0}年{1}月{2}日", 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            //TimeSpan Diff_dates = dt2.Subtract(dt1);
            int year = dt2.Year - dt1.Year;
            int month = dt2.Month - dt1.Month;
            //label3.Text = String.Format("第{0}期", month);
            month += year * 12;
            if(dt2.Day < dt1.Day)
            {
                label8.Text = String.Format("下一期時間為{0}年{1}月{2}日",dt2.Year, dt2.Month, dt1.Day);
                label9.Text = String.Format("也就是民國{0}年{1}月{2}日", dt2.Year-1911, dt2.Month, dt1.Day);
                --month;
            }
            else
            {
                label8.Text = String.Format("下一期時間為{0}年{1}月{2}日", dt2.Year, dt2.Month+1, dt1.Day);
                label9.Text = String.Format("也就是民國{0}年{1}月{2}日", dt2.Year - 1911, dt2.Month+1, dt1.Day);
            }
            label3.Text = String.Format("第{0}期",month);
            label4.Text = String.Format("相差{0}年", year);
            label5.Text = String.Format("相差{0}個月", month);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = String.Format("民國{0}年", (dateTimePicker1.Value.Year - 1911));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = String.Format("民國{0}年", (dateTimePicker2.Value.Year - 1911));
        }
    }
}
