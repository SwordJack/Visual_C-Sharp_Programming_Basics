using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绘制正弦曲线
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtDrawAxis1_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            Point p1 = new Point(30, panelDrawingBoard.ClientSize.Height - 100);    //设置点。ClientSize是指控件的工作区域，对panel控件而言意义不大，但对于form（窗体）而言则是有所区别的。
            Point p2 = new Point(panelDrawingBoard.ClientSize.Width - 50, panelDrawingBoard.ClientSize.Height - 100);
            g.Clear(panelDrawingBoard.BackColor);
            g.DrawLine(p, p1, p2);                                  //在两点之间绘制直线。此处绘制水平坐标轴（x轴）。
            Point p3 = new Point(30, 30);
            g.DrawLine(p, p1, p3);                                  //在两点之间绘制直线。此处绘制垂直坐标轴（y轴）。
            Font letterFont = new Font("黑体", 12, FontStyle.Bold); //书本上为“宋体”，这里改成了黑体。原因：好看。
            g.DrawString("x", letterFont, p.Brush, p2);             //在某点写字符串内容的方法重载：DrawString(string s, Font font, Brush brush, PointF point)。
            g.DrawString("y", letterFont, p.Brush, 10, 10);         //在(10, 10)点写“y”，比在p3点写更为美观。

            p.Dispose();
            g.Dispose();
        }

        private void BtDrawAxis2_Click(object sender, EventArgs e)
        {
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            Point p1 = new Point(30, (panelDrawingBoard.ClientSize.Height - 100) / 2);    //设置点。由于窗体中纵坐标的正方向是垂直向下的，所以将坐标值÷2可以使x轴进行上移。
            Point p2 = new Point(panelDrawingBoard.ClientSize.Width - 50, (panelDrawingBoard.ClientSize.Height - 100) / 2);
            g.Clear(panelDrawingBoard.BackColor);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(30, 30);
            g.DrawLine(p, p1, p3);
            Font letterFont = new Font("黑体", 12, FontStyle.Bold);
            g.DrawString("x", letterFont, p.Brush, p2);
            g.DrawString("y", letterFont, p.Brush, 10, 10);

            p.Dispose();
            g.Dispose();
        }

        private void BtDrawSin1_Click(object sender, EventArgs e)
        {
            //初始化，并绘制坐标轴。（有改动）
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            Point p1 = new Point(30, (panelDrawingBoard.ClientSize.Height - 100) / 2);  //原点。
            Point p2 = new Point(panelDrawingBoard.ClientSize.Width - 50, p1.Y);        //x轴终点。
            g.Clear(panelDrawingBoard.BackColor);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(p1.X, 30);                                             //y轴终点。
            g.DrawLine(p, p1, p3);
            Font letterFont = new Font("黑体", 12, FontStyle.Bold);
            g.DrawString("x", letterFont, p.Brush, p2);
            g.DrawString("y", letterFont, p.Brush, 10, 10);

            //绘制正弦曲线。
            float x1 = 0, x2 = 0;
            double y1 = 0;
            double y2 = p1.Y;
            for (x2 = 0; x2 < panelDrawingBoard.ClientSize.Width - 100; x2++)
            {
                double θ = 2 * Math.PI * x2 / (p2.X - p1.X);                    //预备绘制正弦曲线的一个周期，以θ表示三角函数的相位，以x轴的长度作为其范围。
                y2 = (1 - Math.Sin(θ)) * p2.Y;                                  //由于窗体控件中垂直方向的正方向是向下的，所以需要(1-sinθ)对三角函数值进行取反，然后将之放大到在控件中的位置（相对坐标x轴水平位置的所在）。
                g.DrawLine(p, x1 + p1.X, (float)y1, x2 + p1.X, (float)y2);       //绘制正弦曲线的微元直线段（以直代曲）。横坐标需要以原点为出发点，所以需要加上原点的横坐标值。
                x1 = x2;                                                         //下一循环中绘制的微元直线段以当次循环中直线段的终点为起点。
                y1 = y2;
            }

            //解除占用。
            p.Dispose();
            g.Dispose();
        }

        private void BtDrawSin2_Click(object sender, EventArgs e)
        {
            /*
             * 原本希望按照书上代码来写这个事件的函数，并进行解析，然而，书上的例题代码不说人话。
             * 所以，在此抛弃书本代码，在之前的基础上，将原本单周期曲线进行简易修改后，转化为多周期的曲线绘制。
             */


            //初始化并绘制坐标轴。
            Graphics g = panelDrawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            Point p1 = new Point(30, (panelDrawingBoard.ClientSize.Height - 100) / 2);  //原点。
            Point p2 = new Point(panelDrawingBoard.ClientSize.Width - 50, p1.Y);        //x轴终点。
            g.Clear(panelDrawingBoard.BackColor);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(p1.X, 30);                                             //y轴终点。
            g.DrawLine(p, p1, p3);
            Font letterFont = new Font("黑体", 12, FontStyle.Bold);
            g.DrawString("x", letterFont, p.Brush, p2);
            g.DrawString("y", letterFont, p.Brush, 10, 10);

            //绘制正弦曲线（3个周期）。
            double cycle = 3;       //周期数，可以根据实际需要修改。
            float x1 = 0, x2 = 0;
            double y1 = 0;
            double y2 = p1.Y;
            for (x2 = 0; x2 < panelDrawingBoard.ClientSize.Width - 100; x2++)
            {
                double θ = 2 * Math.PI * x2 * cycle / (p2.X - p1.X);            //预备绘制正弦曲线的一个周期，以θ表示三角函数的相位，以x轴的长度作为其范围。要绘制多个周期，图像在水平方向上必然需要更为紧凑，θ值的增长速度就需要相应地提高。
                y2 = (1 - Math.Sin(θ)) * p2.Y;                                  //由于窗体控件中垂直方向的正方向是向下的，所以需要(1-sinθ)对三角函数值进行取反，然后将之放大到在控件中的位置（相对坐标x轴水平位置的所在）。
                g.DrawLine(p, x1 + p1.X, (float)y1, x2 + p1.X, (float)y2);       //绘制正弦曲线的微元直线段（以直代曲）。横坐标需要以原点为出发点，所以需要加上原点的横坐标值。
                x1 = x2;                                                         //下一循环中绘制的微元直线段以当次循环中直线段的终点为起点。
                y1 = y2;
            }

            //解除占用。
            p.Dispose();
            g.Dispose();
        }
    }
}
