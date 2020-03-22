using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 飘动动画窗体
{
    public partial class WaveForm : Form
    {

        int screenWidth;    //屏幕宽度。
        int screenHeight;   //屏幕高度。
        Point formPosition; //当前窗体的位置。
        
        public WaveForm()
        {
            InitializeComponent();
            screenWidth = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;    //最大化窗体的宽度作为屏幕宽度。
            screenHeight = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;  //最大化窗体的高度作为屏幕高度。
        }

        private void WaveForm_Load(object sender, EventArgs e)
        {
            this.timerHorizontal.Enabled
                = this.timerVertical.Enabled
                = this.timerMove.Enabled = false;
            this.formPosition = new Point(this.DesktopLocation.X, this.DesktopLocation.Y);   //获取当前窗体的位置。
        }

        /// <summary>
        /// 每当timerHorizontal的tick事件触发时，窗体横坐标+1。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerHorizontal_Tick(object sender, EventArgs e)
        {
            this.formPosition.X = this.DesktopLocation.X;
            this.formPosition.Y = this.DesktopLocation.Y;
            if (formPosition.X + this.Width < this.screenWidth)
            {
                this.formPosition.X += 1;
            }
            else
            {
                formPosition.X = 0;
            }
            this.DesktopLocation = this.formPosition;
        }

        /// <summary>
        /// 每当timerVertical的tick事件触发时，窗体纵坐标+1。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerVertical_Tick(object sender, EventArgs e)
        {
            this.formPosition.X = this.DesktopLocation.X;
            this.formPosition.Y = this.DesktopLocation.Y;
            if (formPosition.Y + this.Height < this.screenHeight)
            {
                this.formPosition.Y += 1;
            }
            else
            {
                formPosition.Y = 0;
            }
            this.DesktopLocation = this.formPosition;
        }

        /// <summary>
        /// 每当timerMove的tick事件触发时，窗体位置横纵坐标按比例增加。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerMove_Tick(object sender, EventArgs e)
        {
            this.formPosition.X = this.DesktopLocation.X;
            this.formPosition.Y = this.DesktopLocation.Y;
            if (this.formPosition.X + this.Width < screenWidth 
                && this.formPosition.Y + this.Height < screenHeight)
            {
                this.formPosition.X += 1;
                this.formPosition.Y += 1;
            }
            else
            {
                this.formPosition.X = this.formPosition.Y = 0;
            }
            this.DesktopLocation = this.formPosition;
        }

        private void BtHorizontal_Click(object sender, EventArgs e)
        {
            timerHorizontal.Enabled = true;
            timerVertical.Enabled = timerMove.Enabled = false;
        }

        private void btVertical_Click(object sender, EventArgs e)
        {
            timerVertical.Enabled = true;
            timerHorizontal.Enabled = timerMove.Enabled = false;
        }

        private void btMove_Click(object sender, EventArgs e)
        {
            timerMove.Enabled = true;
            timerHorizontal.Enabled = timerVertical.Enabled = false;
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            timerHorizontal.Enabled = timerVertical.Enabled = timerMove.Enabled = false;
        }
    }
}
