using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 算术四则运算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //在课本提供的核心代码的基础上对程序进行了简单的优化，小幅提高了容错能力和人机交互性。

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);
                tbResult.Text = ("计算结果：\r\n");
                n3 = n1 + n2;
                tbResult.Text += ("两个数的和为：" + n3 + "\r\n");
                n3 = n1 - n2;
                tbResult.Text += ("两个数的差为：" + n3 + "\r\n");
                n3 = n1 * n2;
                tbResult.Text += ("两个数乘积为：" + n3 + "\r\n");
                n3 = n1 / n2;
                tbResult.Text += ("两个数的商为：" + n3 + "\r\n");
                lblWarn.ForeColor = Color.Black;
                lblWarn.Text = "计算完成。";
            }
            else
            {
                lblWarn.ForeColor = Color.Red;
                lblWarn.Text = "输入项不合法！";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = tbResult.Text = lblWarn.Text = "";
            lblWarn.ForeColor = Color.Black;
        }
    }
}
