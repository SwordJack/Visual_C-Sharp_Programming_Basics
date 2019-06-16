using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绘制基本形状
{
    public partial class Form1 : Form
    {
        /*
         * 课本例题要求在窗体内直接绘制。
         * 考虑美观和在实际工作中的应用，改为在Panel中绘制图形。
         */

        public Form1()
        {
            InitializeComponent();
        }

        //
        //绘制直线。
        //
        private void BtDrawLine_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, panelDrawingBoard.Height / 2, panelDrawingBoard.Width, panelDrawingBoard.Height / 2);  //在两点之间拉出直线段的方法重载：DrawLine(Pen pen, float x1, float y1, float x2, float y2)
            p.Dispose();
            g.Dispose();    //释放使用的资源。
        }

        //
        //绘制矩形。
        //
        private void BtDrawRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, 50, 50, 200, 100);   //已知起始坐标（左上角）、宽度、高度绘制矩形的方法重载：DrawRectangle(Pen pen, float x, float y, float width, float height)
            p.Dispose();
            g.Dispose();
        }

        //
        //绘制圆。
        //
        private void BtDrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawEllipse(p, 50, 50, 100, 100);     //在已知起始坐标（左上角）、宽度、高度的矩形内绘制椭圆的方法重载：DrawEllipse(Pen pen, float x, float y, float width, float height)
            p.Dispose();
            g.Dispose();
        }
    }
}
