using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 输入成绩
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("姓名不能为空！");
            else if (textBox2.Text == "")
                MessageBox.Show("成绩不能为空！");
            else if (double.Parse(textBox2.Text) < 0 || double.Parse(textBox2.Text) > 100)
                MessageBox.Show("成绩应当在0～100之间！");
            else if (radioButton1.Checked == false && radioButton2.Checked == false)                //radioButton控件只能有一个被选中，所以不需要考虑两个同时被选中的情形。
                MessageBox.Show("请选择一门课程！");
            else if (radioButton1.Checked == true)
                lblResult.Text = (textBox1.Text + "的" + radioButton1.Text + "成绩是：" + textBox2.Text + "分。");
            else if (radioButton2.Checked == true)
                lblResult.Text = (textBox1.Text + "的" + radioButton2.Text + "成绩是：" + textBox2.Text + "分。");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
