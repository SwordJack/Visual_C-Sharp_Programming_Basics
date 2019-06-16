using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 速度_时间_路程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCalculate_Click(object sender, EventArgs e)
        {
            double velocity;
            velocity = double.Parse(textBox1.Text);
            double time;
            time = double.Parse(textBox2.Text);
            double distance;
            distance = velocity * time;
            lblResult.Text = "行驶路程为：" + distance + "公里\n";    //此处“\n”意为开启新的一行，但不知道该字符在此处的现实意义。
        }
    }
}
