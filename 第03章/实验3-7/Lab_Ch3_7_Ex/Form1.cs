using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch3_7_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(int.Parse(textBox1.Text), 2);
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text), 8);
            textBox4.Text = Convert.ToString(int.Parse(textBox1.Text), 16).ToUpper();    //ToUpper()，此函数将十六进制中的小写字母转换为大写字母显示。
        }
    }
}
