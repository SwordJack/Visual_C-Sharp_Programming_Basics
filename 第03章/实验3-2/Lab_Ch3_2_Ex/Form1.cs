using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch3_2_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int a = x / 1000;
            int b = x % 1000 /100;
            int c = x % 100 / 10;
            int d = x % 10;            
            textBox2.Text = d.ToString() + c.ToString() + b.ToString() + a.ToString();
        }
    }
}
