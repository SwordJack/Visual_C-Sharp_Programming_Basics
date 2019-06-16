namespace 绘制正弦曲线
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
            this.panelDrawingBoard = new System.Windows.Forms.Panel();
            this.btDrawAxis1 = new System.Windows.Forms.Button();
            this.btDrawAxis2 = new System.Windows.Forms.Button();
            this.btDrawSin1 = new System.Windows.Forms.Button();
            this.btDrawSin2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDrawingBoard
            // 
            this.panelDrawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawingBoard.Location = new System.Drawing.Point(13, 13);
            this.panelDrawingBoard.Name = "panelDrawingBoard";
            this.panelDrawingBoard.Size = new System.Drawing.Size(775, 354);
            this.panelDrawingBoard.TabIndex = 0;
            // 
            // btDrawAxis1
            // 
            this.btDrawAxis1.Location = new System.Drawing.Point(13, 374);
            this.btDrawAxis1.Name = "btDrawAxis1";
            this.btDrawAxis1.Size = new System.Drawing.Size(151, 64);
            this.btDrawAxis1.TabIndex = 1;
            this.btDrawAxis1.Text = "坐标轴（1）";
            this.btDrawAxis1.UseVisualStyleBackColor = true;
            this.btDrawAxis1.Click += new System.EventHandler(this.BtDrawAxis1_Click);
            // 
            // btDrawAxis2
            // 
            this.btDrawAxis2.Location = new System.Drawing.Point(221, 373);
            this.btDrawAxis2.Name = "btDrawAxis2";
            this.btDrawAxis2.Size = new System.Drawing.Size(151, 64);
            this.btDrawAxis2.TabIndex = 2;
            this.btDrawAxis2.Text = "坐标轴（2）";
            this.btDrawAxis2.UseVisualStyleBackColor = true;
            this.btDrawAxis2.Click += new System.EventHandler(this.BtDrawAxis2_Click);
            // 
            // btDrawSin1
            // 
            this.btDrawSin1.Location = new System.Drawing.Point(429, 373);
            this.btDrawSin1.Name = "btDrawSin1";
            this.btDrawSin1.Size = new System.Drawing.Size(151, 64);
            this.btDrawSin1.TabIndex = 3;
            this.btDrawSin1.Text = "正弦曲线（1）";
            this.btDrawSin1.UseVisualStyleBackColor = true;
            this.btDrawSin1.Click += new System.EventHandler(this.BtDrawSin1_Click);
            // 
            // btDrawSin2
            // 
            this.btDrawSin2.Location = new System.Drawing.Point(637, 374);
            this.btDrawSin2.Name = "btDrawSin2";
            this.btDrawSin2.Size = new System.Drawing.Size(151, 64);
            this.btDrawSin2.TabIndex = 4;
            this.btDrawSin2.Text = "正弦曲线（2）";
            this.btDrawSin2.UseVisualStyleBackColor = true;
            this.btDrawSin2.Click += new System.EventHandler(this.BtDrawSin2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDrawSin2);
            this.Controls.Add(this.btDrawSin1);
            this.Controls.Add(this.btDrawAxis2);
            this.Controls.Add(this.btDrawAxis1);
            this.Controls.Add(this.panelDrawingBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrawingBoard;
        private System.Windows.Forms.Button btDrawAxis1;
        private System.Windows.Forms.Button btDrawAxis2;
        private System.Windows.Forms.Button btDrawSin1;
        private System.Windows.Forms.Button btDrawSin2;
    }
}

