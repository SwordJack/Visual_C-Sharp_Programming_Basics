namespace Lab_Ch5_6_Ex
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
            this.tbInt1 = new System.Windows.Forms.TextBox();
            this.tbInt2 = new System.Windows.Forms.TextBox();
            this.tbGttComDiv = new System.Windows.Forms.TextBox();
            this.tbLesComMul = new System.Windows.Forms.TextBox();
            this.lblInt1 = new System.Windows.Forms.Label();
            this.lblInt2 = new System.Windows.Forms.Label();
            this.lblGttComDiv = new System.Windows.Forms.Label();
            this.lblLesComMul = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInt1
            // 
            this.tbInt1.Location = new System.Drawing.Point(104, 56);
            this.tbInt1.Name = "tbInt1";
            this.tbInt1.Size = new System.Drawing.Size(100, 21);
            this.tbInt1.TabIndex = 0;
            // 
            // tbInt2
            // 
            this.tbInt2.Location = new System.Drawing.Point(336, 56);
            this.tbInt2.Name = "tbInt2";
            this.tbInt2.Size = new System.Drawing.Size(100, 21);
            this.tbInt2.TabIndex = 1;
            // 
            // tbGttComDiv
            // 
            this.tbGttComDiv.Location = new System.Drawing.Point(104, 120);
            this.tbGttComDiv.Name = "tbGttComDiv";
            this.tbGttComDiv.ReadOnly = true;
            this.tbGttComDiv.Size = new System.Drawing.Size(100, 21);
            this.tbGttComDiv.TabIndex = 2;
            // 
            // tbLesComMul
            // 
            this.tbLesComMul.Location = new System.Drawing.Point(336, 120);
            this.tbLesComMul.Name = "tbLesComMul";
            this.tbLesComMul.ReadOnly = true;
            this.tbLesComMul.Size = new System.Drawing.Size(100, 21);
            this.tbLesComMul.TabIndex = 3;
            // 
            // lblInt1
            // 
            this.lblInt1.AutoSize = true;
            this.lblInt1.Location = new System.Drawing.Point(24, 59);
            this.lblInt1.Name = "lblInt1";
            this.lblInt1.Size = new System.Drawing.Size(77, 12);
            this.lblInt1.TabIndex = 4;
            this.lblInt1.Text = "第一个整数：";
            // 
            // lblInt2
            // 
            this.lblInt2.AutoSize = true;
            this.lblInt2.Location = new System.Drawing.Point(256, 59);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(77, 12);
            this.lblInt2.TabIndex = 5;
            this.lblInt2.Text = "第二个整数：";
            // 
            // lblGttComDiv
            // 
            this.lblGttComDiv.AutoSize = true;
            this.lblGttComDiv.Location = new System.Drawing.Point(24, 123);
            this.lblGttComDiv.Name = "lblGttComDiv";
            this.lblGttComDiv.Size = new System.Drawing.Size(77, 12);
            this.lblGttComDiv.TabIndex = 6;
            this.lblGttComDiv.Text = "最大公约数：";
            // 
            // lblLesComMul
            // 
            this.lblLesComMul.AutoSize = true;
            this.lblLesComMul.Location = new System.Drawing.Point(256, 123);
            this.lblLesComMul.Name = "lblLesComMul";
            this.lblLesComMul.Size = new System.Drawing.Size(77, 12);
            this.lblLesComMul.TabIndex = 7;
            this.lblLesComMul.Text = "最小公倍数：";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(169, 184);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(75, 23);
            this.btCalc.TabIndex = 8;
            this.btCalc.Text = "计算";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Location = new System.Drawing.Point(293, 189);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 12);
            this.lblWarn.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.lblLesComMul);
            this.Controls.Add(this.lblGttComDiv);
            this.Controls.Add(this.lblInt2);
            this.Controls.Add(this.lblInt1);
            this.Controls.Add(this.tbLesComMul);
            this.Controls.Add(this.tbGttComDiv);
            this.Controls.Add(this.tbInt2);
            this.Controls.Add(this.tbInt1);
            this.Name = "Form1";
            this.Text = "最大公约数与最小公倍数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInt1;
        private System.Windows.Forms.TextBox tbInt2;
        private System.Windows.Forms.TextBox tbGttComDiv;
        private System.Windows.Forms.TextBox tbLesComMul;
        private System.Windows.Forms.Label lblInt1;
        private System.Windows.Forms.Label lblInt2;
        private System.Windows.Forms.Label lblGttComDiv;
        private System.Windows.Forms.Label lblLesComMul;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label lblWarn;
    }
}

