using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 商场优惠    //某商场为了吸引顾客，采取以下优惠活动：所购商品在1000元以下的，打九折优惠；多余1000元的，打8折优惠。试编程实现该优惠功能。
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCalc_Click(object sender, EventArgs e)
        {
            double k, m;
            k = double.Parse(textBox1.Text);
            if (k < 1000)
            {
                m = k * 0.9;
            }
            else
            {
                m = k * 0.8;
            }
            textBox2.Text = m.ToString();
        }
    }
}
