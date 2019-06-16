using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文本编辑器的实现
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbInput.SelectedText != "")
            {
                Clipboard.SetDataObject(tbInput.SelectedText, true);  //将选中内容保存至剪贴板。
                tbInput.SelectedText = "";  //清除选中内容。
            }
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbInput.SelectedText != "")
                Clipboard.SetDataObject(tbInput.SelectedText, true);
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))  //使用“类：剪贴板，方法：获取剪贴板中内容”获取剪贴板中的内容，若为文本格式，则将之添加到文本框中。
                tbInput.SelectedText = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString();
            else
                Console.Beep();
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.SelectedText = tbInput.Text;
        }
    }
}
