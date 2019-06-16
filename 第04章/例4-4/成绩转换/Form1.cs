using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtTransform_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox1.Text);
            if (k > 100 || k < 0)
            {
                MessageBox.Show("成绩输入有误！");
            }
            else if (k >= 90)
                textBox2.Text = "优";
            else if (k >= 80)
                textBox2.Text = "良";
            else if (k >= 70)
                textBox2.Text = "中";
            else if (k >= 60)
                textBox2.Text = "合格";
            else if (k < 60)
                textBox2.Text = "不合格";
        }
    }
}
