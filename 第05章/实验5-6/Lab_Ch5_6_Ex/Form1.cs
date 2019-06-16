using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch5_6_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            if (tbInt1.Text != "" && tbInt2.Text != "")
            {
                int num1 = int.Parse(tbInt1.Text);
                int num2 = int.Parse(tbInt2.Text);
                int numMin, numMax;
                if ( num1 < num2 )
                {
                    numMin = num1;
                    numMax = num2;
                }
                else
                {
                    numMin = num2;
                    numMax = num1;               
                }

                int gttComDiv = 1, lesComMul = numMax;
                for (int i = 1; i <= numMin; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        gttComDiv = i;
                    }
                }
                while (true)
                {
                    if (lesComMul % num1 == 0 && lesComMul % num2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        lesComMul++;
                    }
                }
                tbGttComDiv.Text = Convert.ToString(gttComDiv);
                tbLesComMul.Text = Convert.ToString(lesComMul);
                lblWarn.Text = "完成！";
            }
            else
            {
                lblWarn.ForeColor = Color.Red;
                lblWarn.Text = "请在文本框中输入数字！";
            }
        }
    }
}
