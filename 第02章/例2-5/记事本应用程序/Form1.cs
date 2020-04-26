using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本应用程序
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string stext = "";  //一个字符串变量，这里用来在内存中保存从文本框中“剪切”或“复制”的文字内容。

        /// <summary>
        /// 点击“剪切”按钮后触发。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCut_Click(object sender, EventArgs e)
        {
            stext = tbContent.SelectedText; //将stext变量赋以文本框中选中的字符串内容。
            tbContent.SelectedText = "";    //将文本框中选中的字符串内容清除。
        }

        /// <summary>
        /// 点击“复制”按钮后触发。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCopy_Click(object sender, EventArgs e)
        {
            stext = tbContent.SelectedText; //将stext变量赋以文本框中选中的字符串内容。
        }

        /// <summary>
        /// 点击“粘贴”按钮后触发。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtPaste_Click(object sender, EventArgs e)
        {
            tbContent.SelectedText = stext; //使文本框中选中的字符串内容更新为stext变量值，如果当前没有选中文字，就会在光标位置插入文字。
        }

        /// <summary>
        /// 点击“格式”按钮后触发。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtFormat_Click(object sender, EventArgs e)
        {
            tbContent.Font = new Font("隶书" , 16);   //更新字体和字号。
        }

        /// <summary>
        /// 点击“结束”按钮后触发。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
