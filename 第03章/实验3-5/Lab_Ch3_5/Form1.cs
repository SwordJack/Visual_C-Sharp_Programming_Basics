using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbOperation.Text = btAdd.Text;
            tbResult.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            tbOperation.Text = btSub.Text;
            tbResult.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            tbOperation.Text = btMul.Text;
            tbResult.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            tbOperation.Text = btDiv.Text;
            tbResult.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
        }

        private void btRem_Click(object sender, EventArgs e)
        {
            tbOperation.Text = btRem.Text;
            tbResult.Text = (double.Parse(textBox1.Text) % double.Parse(textBox2.Text)).ToString();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tbOperation.Clear();
            textBox2.Clear();
            tbResult.Clear();
        }
    }
}
