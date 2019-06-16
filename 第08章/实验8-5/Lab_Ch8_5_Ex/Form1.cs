using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Ch8_5_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtPara_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = "";
            try
            {
                int a = int.Parse(tbPara1.Text);
                int b = int.Parse(tbPara2.Text);
                lblMessage.Text += String.Format("调用之前：第一个参数为{0}，第二个参数为{1}；\n", a, b);
                Swap(ref a, ref b);
                lblMessage.Text += String.Format("调用之后：第一个参数为{0}，第二个参数为{1}。", a, b);
            }
            catch
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "异常！";
            }
        }

        private void Swap(ref int x, ref int y)
        {
            x += y;
            y = x - y;
            x -= y;
        }
    }
}
