using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch3_1_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            a = a + b;    //a的值A = a + b
            b = a - b;    //b的值B = A - b = a + b - b = a
            a = a - b;    //a的值A = A - B = a + b - a = b，至此，两个变量值交换完成。
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
        }
    }
}
