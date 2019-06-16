using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 窗体属性_事件_方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = "装入窗体";
            this.BackgroundImage = Image.FromFile("Icon of ECUST.jpg");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "接收按键";
            this.Visible = false;
            Form2 frm = new Form2();
            frm.Show();
            this.Visible = true;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "双击窗体";
            this.Visible = false;
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Text = "窗体尺寸：" + this.Size.ToString();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            this.Text = "窗体位置：" + this.Location.ToString();
        }
    }
    }
