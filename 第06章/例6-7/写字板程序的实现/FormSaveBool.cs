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
    public partial class FormSaveBool : Form
    {       

        public FormSaveBool()
        {
            InitializeComponent();
            tbSaveTip.Text = "是否保存更改？";
        }
                
        private void BtSaveTrue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void BtSaveFalse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormSaveBool_Load(object sender, EventArgs e)
        {
             
        }
    }
}
