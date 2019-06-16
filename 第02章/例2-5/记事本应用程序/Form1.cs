using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本应用程序
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string stext = "";

        private void Button1_Click(object sender, EventArgs e)
        {
            stext = textBox1.SelectedText;
            textBox1.SelectedText = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            stext = textBox1.SelectedText;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = stext;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("隶书" , 16);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
