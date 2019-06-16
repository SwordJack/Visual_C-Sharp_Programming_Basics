using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 写字板程序的实现
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //“文件”菜单项。
        string s_name = "";
        string savedText = "";

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbContent.Text != savedText)
            {
                Form formSaveBool = new FormSaveBool();  //当文档有修改时，打开FormSaveBool窗体。
                DialogResult result = formSaveBool.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    保存SToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            rtbContent.Clear();
            s_name = "";  //新建文件的文件名为空。
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\%USERNAME%\\Documents";
            openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                if (rtbContent.Text != savedText)
                {
                    Form formSaveBool = new FormSaveBool();  //当文档有修改时，打开FormSaveBool窗体。
                    DialogResult result = formSaveBool.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        保存SToolStripMenuItem_Click(sender, e);
                    }
                    else if(result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                s_name = openFileDialog1.FileName;  //获取文件的文件名。
                rtbContent.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);  //以纯文本形式加载文档。
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(s_name.Length != 0)
            {
                savedText = rtbContent.Text;
                rtbContent.SaveFile(s_name, RichTextBoxStreamType.PlainText);
            }
            else
            {
                另存为AToolStripMenuItem_Click(sender, e);  //当文件未保存过时（文件名为空），调用“另存为”方法。
            }
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)  //当对话框返回值为OK。
            {
                savedText = rtbContent.Text;
                s_name = saveFileDialog1.FileName;
                rtbContent.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        // “编辑”菜单项。
        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Undo();
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Redo();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Paste();
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.SelectAll();
        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
