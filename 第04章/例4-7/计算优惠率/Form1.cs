using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算优惠率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtCalc_Click(object sender, EventArgs e)
        {
            int mon, sum;
            mon = Convert.ToInt32(textBox1.Text);
            sum = Convert.ToInt32(textBox2.Text);
            switch (mon)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 10:
                case 11:
                    if (sum > 20)
                    {
                        lblResult.ForeColor = Color.Black;
                        lblResult.Text = "优惠率为30%。";
                    }
                    else
                    {
                        lblResult.ForeColor = Color.Black;
                        lblResult.Text = "优惠率为20%。";
                    }
                    break;
                case 7:
                case 8:
                case 9:
                    if (sum > 20)
                    {
                        lblResult.ForeColor = Color.Black;
                        lblResult.Text = "优惠率为15%。";
                    }
                    else
                    {
                        lblResult.ForeColor = Color.Black;
                        lblResult.Text = "优惠率为5%。";
                    }
                    break;
                case 6:
                case 12:
                    {
                        lblResult.ForeColor = Color.Black;
                        lblResult.Text = "优惠率为10%。";
                    }
                    break;
                default:
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "请输入合理的月份数！";
                    }
                    break;
            }
        }
    }
}
