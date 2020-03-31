using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Ch4_7_Ex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void BtCalc_Click(object sender, EventArgs e)
        {
            double a, b, c, d;  //此处使用数组是更好的选择，但是由于章节上不允许，故依旧采用声明四个变量的方式。
            a = b = c = d = 0;
            try
            {
                a = double.Parse(tbA.Text);
                b = double.Parse(tbB.Text);
                c = double.Parse(tbC.Text);
                d = double.Parse(tbD.Text);
            }
            catch
            {
                MessageBox.Show("运行异常，请检查输入内容！", "拒止", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phraseJudge = string.Empty;     //用于输出判定结论。
            if (a + b + c > d
                && b + c + d > a
                && c + d + a > b
                && d + a + b > c)
            {
                phraseJudge = "可以构成四边形，该四边形是";
                if (a == c && b == d)   //不赞成书本上的表述，因若邻边相等，会产生筝形而非平行四边形。
                {
                    if (a == b)
                    {
                        phraseJudge += "菱形（含正方形）";
                    }
                    else
                    {
                        phraseJudge += "平行四边形（含矩形）";
                    }
                }
                else
                {
                    phraseJudge += "一般四边形";
                }
            }
            else
            {
                phraseJudge = "不能构成四边形";
            }
            lblResult.Text = $@"判定结果：{phraseJudge}；

该四边形周长：{a + b + c + d}。";
        }
    }
}
