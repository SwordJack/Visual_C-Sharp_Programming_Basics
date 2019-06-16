using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 滚动条与进度条
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCalc_Click(object sender, EventArgs e)
        {
            int Counter;
            string[] array = new string [hSBarArray.Maximum];
            pBarShow.Minimum = hSBarArray.Minimum;
            pBarShow.Maximum = hSBarArray.Value;
            pBarShow.Visible = true;
            for (Counter = 0; Counter < hSBarArray.Value; Counter++)
            {
                array[Counter] = "Initial Value" + Counter;
                pBarShow.Value = Counter;
            }
            pBarShow.Visible = false;
        }
    }
}
