using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch8_2_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcDistance_Click(object sender, EventArgs e)
        {
            CPoint point = new CPoint();
            bool whetherOutput = true;
            
            try
            {
                point.X = double.Parse(tbValueX.Text);
            }
            catch
            {
                lblWarnX.Visible = true;
                whetherOutput = false;
            }

            try
            {
                point.Y = double.Parse(tbValueY.Text);
            }
            catch
            {
                lblWarnY.Visible = true;
                whetherOutput = false;
            }

            if (whetherOutput)
            {
                tbDisplay.Text = Convert.ToString(Math.Sqrt(Math.Pow(point.X, 2) + Math.Pow(point.Y, 2)));
            }
        }
    }

    class CPoint
    {
        private double _x, _y;

        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
    }
}
