using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实时时钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerLive_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLive.Enabled = true;
            timerLive.Interval = 100;
            lblCurrentTime.Text = DateTime.Now.ToString();
        }
    }
}
