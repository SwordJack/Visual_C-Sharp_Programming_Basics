namespace Lab_Ch8_5_Ex
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
            this.btPara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPara1 = new System.Windows.Forms.TextBox();
            this.tbPara2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPara
            // 
            this.btPara.Location = new System.Drawing.Point(293, 152);
            this.btPara.Name = "btPara";
            this.btPara.Size = new System.Drawing.Size(75, 23);
            this.btPara.TabIndex = 0;
            this.btPara.Text = "调用参数";
            this.btPara.UseVisualStyleBackColor = true;
            this.btPara.Click += new System.EventHandler(this.BtPara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "第一个参数：";
            // 
            // tbPara1
            // 
            this.tbPara1.Location = new System.Drawing.Point(85, 32);
            this.tbPara1.Name = "tbPara1";
            this.tbPara1.Size = new System.Drawing.Size(100, 21);
            this.tbPara1.TabIndex = 2;
            // 
            // tbPara2
            // 
            this.tbPara2.Location = new System.Drawing.Point(268, 32);
            this.tbPara2.Name = "tbPara2";
            this.tbPara2.Size = new System.Drawing.Size(100, 21);
            this.tbPara2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "第二个参数：";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 85);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbPara2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPara1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "方法的参数传递";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPara1;
        private System.Windows.Forms.TextBox tbPara2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
    }
}

