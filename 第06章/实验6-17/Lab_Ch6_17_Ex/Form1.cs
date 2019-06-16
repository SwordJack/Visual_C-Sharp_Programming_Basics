using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Ch6_17_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCount_Click(object sender, EventArgs e)
        {
            int[] count = new int[26];
            string s = tbInput.Text;
            s = s.ToUpper();
            foreach (char letter in s)  //遍历字符串s中的每一个字符。
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    count[Convert.ToInt32(letter) - 65]++;  //“A”在ASCII码中对应序号为65。
                }
            }

            tbOutput.Text = ("各个字母出现的次数为：\r\n");
            for (int i = 0; i < count.Length; i++)
            {
                tbOutput.Text += (Convert.ToChar(i + 65)+"："+ count[i]+"次  ");
            }

        }
    }
}
