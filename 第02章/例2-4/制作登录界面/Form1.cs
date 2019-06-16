using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 制作登录界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text.Length < 5)
            {
                lblMsg.Text = "用户名不能小于5位！";
                tbUser.Text = "";
                tbUser.Focus();
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            //这一模块是多余的，系本人注册事件时的错误导致。
        }
        
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length < 5)
            {
                lblMsg.Text = "密码不能小于5位！";
                tbUser.Text = "";
                tbUser.Focus();
            }
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || (e.KeyChar > 90 && e.KeyChar < 97)
                               || e.KeyChar > 122)
            //猜测此处应当是指ASCII码在65以下，122以上，或者90以上97以下的按键，即非大小写字母的按键，但这会导致按下退格键时整列文本被删除的问题。或可通过加入“e.KeyChar != 8”语句来优化，此处先按照书本要求输入，暂不做修改。
            {
                lblMsg.Text ="注意！用户名只能为大小写字母。";
                tbUser.Text = "";
                tbUser.Focus();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 49 || e.KeyChar > 57)
                //若上述猜测正确，则此处应当是指ASCII码在49以下，57以上的按键，即非数字的按键，同样也存在上述问题。
            {
                lblMsg.Text = "注意！用户名只能为数字。";
                tbUser.Text = "";
                tbUser.Focus();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length < 5)
            {
                lblMsg.Text = "密码不能小于5位！";
                tbPassword.Text = "";
                tbPassword.Focus();
            }
            else
            {
                if (tbUser.Text.Equals("abcde") &&
                    tbPassword.Text.Equals("12345"))
                    lblMsg.Text = "登录成功！";
                else
                    lblMsg.Text = "用户名或密码错误！";
                //这里，提示“用户名或密码错误”时，没有一个清除密码框字符的命令，这是不太的合理。
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
            tbPassword.Text = "";
            tbUser.Focus();
        }


        
    }
}
