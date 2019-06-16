using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠标事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Pl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    tbLog.Text += ("\r\n左键双击，位置：(" + e.X + "," + e.Y + ")；");
                }
                else
                {
                    tbLog.Text += ("\r\n左键单击，位置：(" + e.X + "," + e.Y + ")；");
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (e.Clicks == 2)
                {
                    tbLog.Text += ("\r\n右键双击，位置：(" + e.X + "," + e.Y + ")；");
                }
                else
                {
                    tbLog.Text += ("\r\n右键单击，位置：(" + e.X + "," + e.Y + ")；");
                }
            }
        }
                
    }
}
