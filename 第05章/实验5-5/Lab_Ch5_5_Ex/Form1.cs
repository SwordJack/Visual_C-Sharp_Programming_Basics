using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Ch5_5_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            string words = tbInput.Text;
            int wordNum = 0;
            char c1, c2;
            c1 = Convert.ToChar(words.Substring(1, 1).ToUpper());
            for (int i = 0; i < words.Length; i++)
            {
                c2 = Convert.ToChar(words.Substring(i, 1).ToUpper());
                if ((c1 >= 'A' && c1 <= 'Z') && (c2 < 'A' || c2 > 'Z'))
                    wordNum++;
                c1 = c2;
            }
            tbOutput.Text = "总共有" + wordNum + "个单词。";
        }
    }
}
