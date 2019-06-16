using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算机选课程序
{
    public partial class FormCourseSelection : Form
    {
        public FormCourseSelection()
        {
            InitializeComponent();
        }

        string first = "", second = "", third = "";                         

        private void RbCourse1_CheckedChanged(object sender, EventArgs e)  //先注册事件，重命名之后将其它对象的CheckedChanged事件也注册到该函数。
        {
            Course1();
            ShowText();
        }

        private void RbCourse2_CheckedChanged(object sender, EventArgs e)
        {
            Course2();
            ShowText();
        }

        private void CbCourse3_CheckedChanged(object sender, EventArgs e)
        {
            Course3();
            ShowText();
        }

        private void Course1()  //更改基础课的选课显示值。
        {
            if (rbCourse1Base.Checked)
                first = rbCourse1Base.Text;
            else if (rbCourse1Intro.Checked)
                first = rbCourse1Intro.Text;
        }

        private void Course2()  //更改语言课的选课显示值。
        {
            if (rbCourse2VB.Checked)
                second = rbCourse2VB.Text;
            else if (rbCourse2Clang.Checked)
                second = rbCourse2Clang.Text;
            else if (rbCourse2Java.Checked)
                second = rbCourse2Java.Text;
            else if (rbCourse2Cs.Checked)
                second = rbCourse2Cs.Text;
            else if (rbCourse2Web.Checked)
                second = rbCourse2Web.Text;
        }
                
        private void Course3()  //更改应用课的选课显示值。
        {
            third = "";
            if (cbCourse3Dev.Checked)
                third += (cbCourse3Dev.Text + "  ");
            if (cbCourse3Eng.Checked)
                third += (cbCourse3Eng.Text + "  ");
            if (cbCourse3Media.Checked)
                third += (cbCourse3Media.Text + "  ");
            if (cbCourse3Data.Checked)
                third += (cbCourse3Data.Text + "  ");
            if (cbCourse3Web.Checked)
                third += (cbCourse3Web.Text + "  ");
        }

        private void ShowText()  //在文本框中显示内容。
        {
            tbShow.Text = "你的选课结果如下：\r\n";
            if (!(first == "")) tbShow.Text += ("基础：" + first + "\r\n");  // !function 表达式，将function的输出结果取反（真/假）。
            if (!(second == "")) tbShow.Text += ("语言：" + second + "\r\n");
            if (!(third == "")) tbShow.Text += ("应用：" + third + "\r\n");
        }

    }
}
