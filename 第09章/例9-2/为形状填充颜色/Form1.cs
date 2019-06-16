using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 为形状填充颜色
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //绘制实心矩形。
        //
        private void BtDrawRectangle_Click(object sender, EventArgs e)
        {            
            Graphics g = panelDrawingBoard.CreateGraphics();
            g.Clear(panelDrawingBoard.BackColor);               //此行代码用于清空画图界面，用控件自身的背景色作为填充。
            Pen p = new Pen(Color.Red, 3);                      //画笔的颜色：红色，宽度：3像素。
            Brush b = p.Brush;
            g.DrawRectangle(p, 50, 50, 200, 100);
            g.FillRectangle(b, 50, 50, 100, 100);               //书本例题是(b, 50, 50, 200, 100)，此处作如此修改，有助于认识Draw和Fill的差别。
            //g.FillRectangle(p.Brush, 50, 50, 100, 100);         //此行代码和上一行代码在此处起到的效果是相同的，使用此行代码可以少声明一个Brush类变量b。
            p.Dispose();
            g.Dispose();
        }

        //
        //绘制实心圆形。
        //
        private void BtDrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            g.Clear(panelDrawingBoard.BackColor);
            Pen p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, 50, 50, 100, 100);
            g.FillEllipse(p.Brush, 50, 50, 100, 100);
            p.Dispose();
            g.Dispose();
        }

    }
}
