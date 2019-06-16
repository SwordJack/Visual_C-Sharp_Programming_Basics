namespace 滚动条与进度条
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hSBarArray = new System.Windows.Forms.HScrollBar();
            this.pBarShow = new System.Windows.Forms.ProgressBar();
            this.btCalc = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hSBarArray
            // 
            this.hSBarArray.LargeChange = 10000;
            this.hSBarArray.Location = new System.Drawing.Point(69, 56);
            this.hSBarArray.Maximum = 600000;
            this.hSBarArray.Name = "hSBarArray";
            this.hSBarArray.Size = new System.Drawing.Size(171, 17);
            this.hSBarArray.SmallChange = 1000;
            this.hSBarArray.TabIndex = 0;
            // 
            // pBarShow
            // 
            this.pBarShow.Location = new System.Drawing.Point(57, 142);
            this.pBarShow.Name = "pBarShow";
            this.pBarShow.Size = new System.Drawing.Size(191, 23);
            this.pBarShow.TabIndex = 1;
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(92, 86);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(120, 23);
            this.btCalc.TabIndex = 2;
            this.btCalc.Text = "开始计算";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.BtCalc_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(67, 34);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(101, 12);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "请设定数组大小：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.pBarShow);
            this.Controls.Add(this.hSBarArray);
            this.Name = "Form1";
            this.Text = "滚动条和进度条演示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hSBarArray;
        private System.Windows.Forms.ProgressBar pBarShow;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label lblTip;
    }
}

