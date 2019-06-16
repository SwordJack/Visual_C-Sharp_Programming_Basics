using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows窗体进行流的文本读写
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtWrite_Click(object sender, EventArgs e)
        {
            lblMessageWrite.Text = lblMessageRead.Text = "";
            if (!File.Exists("MyFile.txt")) File.Create("MyFile.txt");      //如果不存在文本文件，创建之。
                        
            char[] buffer = new char[tbWrite.Text.Length];                  //将文本转化为字符类型的数组。
            for (int i = 0; i < tbWrite.Text.Length; i++)
            {
                buffer[i] = tbWrite.Text[i];
            }

            //
            //写入数据。
            //
            StreamWriter sw = new StreamWriter(@"MyFile.txt");
            sw.Write(buffer);
            sw.Close();

            lblMessageWrite.ForeColor = Color.Black;
            lblMessageWrite.Text = "写入完成！";
        }

        private void BtRead_Click(object sender, EventArgs e)
        {
            lblMessageRead.Text = lblMessageWrite.Text = "";

            if (File.Exists("MyFile.txt"))
            {
                //
                //创建文件流，读取数据。
                //
                StreamReader sr = new StreamReader("MyFile.txt");
                tbRead.Text = sr.ReadToEnd();
                sr.Close();

                //发出提示信息。
                lblMessageRead.ForeColor = Color.Black;
                lblMessageRead.Text = "读取完成！";
            }
            else
            {
                //文件不存在时，触发。
                lblMessageRead.ForeColor = Color.Red;
                lblMessageRead.Text = "文件不存在！";
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            lblMessageRead.Text = lblMessageWrite.Text = "";
        }
    }
}
