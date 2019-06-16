namespace Lab_Ch8_2_Ex
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPointPositin = new System.Windows.Forms.GroupBox();
            this.lblWarnY = new System.Windows.Forms.Label();
            this.lblWarnX = new System.Windows.Forms.Label();
            this.tbValueY = new System.Windows.Forms.TextBox();
            this.tbValueX = new System.Windows.Forms.TextBox();
            this.lblTipX = new System.Windows.Forms.Label();
            this.lblTipY = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.btCalcDistance = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.gbPointPositin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPointPositin
            // 
            this.gbPointPositin.Controls.Add(this.lblWarnY);
            this.gbPointPositin.Controls.Add(this.lblWarnX);
            this.gbPointPositin.Controls.Add(this.tbValueY);
            this.gbPointPositin.Controls.Add(this.tbValueX);
            this.gbPointPositin.Controls.Add(this.lblTipX);
            this.gbPointPositin.Controls.Add(this.lblTipY);
            this.gbPointPositin.Controls.Add(this.lblTip);
            this.gbPointPositin.Location = new System.Drawing.Point(13, 13);
            this.gbPointPositin.Name = "gbPointPositin";
            this.gbPointPositin.Size = new System.Drawing.Size(218, 100);
            this.gbPointPositin.TabIndex = 0;
            this.gbPointPositin.TabStop = false;
            this.gbPointPositin.Text = "点的坐标";
            // 
            // lblWarnY
            // 
            this.lblWarnY.AutoSize = true;
            this.lblWarnY.ForeColor = System.Drawing.Color.Red;
            this.lblWarnY.Location = new System.Drawing.Point(141, 53);
            this.lblWarnY.Name = "lblWarnY";
            this.lblWarnY.Size = new System.Drawing.Size(77, 12);
            this.lblWarnY.TabIndex = 9;
            this.lblWarnY.Text = "请输入数字！";
            this.lblWarnY.Visible = false;
            // 
            // lblWarnX
            // 
            this.lblWarnX.AutoSize = true;
            this.lblWarnX.ForeColor = System.Drawing.Color.Red;
            this.lblWarnX.Location = new System.Drawing.Point(141, 21);
            this.lblWarnX.Name = "lblWarnX";
            this.lblWarnX.Size = new System.Drawing.Size(77, 12);
            this.lblWarnX.TabIndex = 8;
            this.lblWarnX.Text = "请输入数字！";
            this.lblWarnX.Visible = false;
            // 
            // tbValueY
            // 
            this.tbValueY.Location = new System.Drawing.Point(35, 50);
            this.tbValueY.Name = "tbValueY";
            this.tbValueY.Size = new System.Drawing.Size(100, 21);
            this.tbValueY.TabIndex = 1;
            // 
            // tbValueX
            // 
            this.tbValueX.Location = new System.Drawing.Point(35, 18);
            this.tbValueX.Name = "tbValueX";
            this.tbValueX.Size = new System.Drawing.Size(100, 21);
            this.tbValueX.TabIndex = 0;
            // 
            // lblTipX
            // 
            this.lblTipX.AutoSize = true;
            this.lblTipX.Location = new System.Drawing.Point(6, 21);
            this.lblTipX.Name = "lblTipX";
            this.lblTipX.Size = new System.Drawing.Size(23, 12);
            this.lblTipX.TabIndex = 3;
            this.lblTipX.Text = "X：";
            // 
            // lblTipY
            // 
            this.lblTipY.AutoSize = true;
            this.lblTipY.Location = new System.Drawing.Point(6, 53);
            this.lblTipY.Name = "lblTipY";
            this.lblTipY.Size = new System.Drawing.Size(23, 12);
            this.lblTipY.TabIndex = 4;
            this.lblTipY.Text = "Y：";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(3, 85);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(197, 12);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "输入点坐标，可计算其到原点距离。";
            // 
            // btCalcDistance
            // 
            this.btCalcDistance.Location = new System.Drawing.Point(237, 23);
            this.btCalcDistance.Name = "btCalcDistance";
            this.btCalcDistance.Size = new System.Drawing.Size(75, 23);
            this.btCalcDistance.TabIndex = 2;
            this.btCalcDistance.Text = "计算距离";
            this.btCalcDistance.UseVisualStyleBackColor = true;
            this.btCalcDistance.Click += new System.EventHandler(this.btCalcDistance_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(237, 74);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(100, 21);
            this.tbDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 122);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btCalcDistance);
            this.Controls.Add(this.gbPointPositin);
            this.Name = "Form1";
            this.Text = "点类实现";
            this.gbPointPositin.ResumeLayout(false);
            this.gbPointPositin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPointPositin;
        private System.Windows.Forms.TextBox tbValueY;
        private System.Windows.Forms.TextBox tbValueX;
        private System.Windows.Forms.Label lblTipX;
        private System.Windows.Forms.Label lblTipY;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btCalcDistance;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Label lblWarnY;
        private System.Windows.Forms.Label lblWarnX;
    }
}

