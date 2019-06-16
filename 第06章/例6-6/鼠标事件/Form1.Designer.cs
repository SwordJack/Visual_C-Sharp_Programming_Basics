namespace 鼠标事件
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
            this.pl = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl.Location = new System.Drawing.Point(13, 13);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(180, 256);
            this.pl.TabIndex = 0;
            this.pl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pl_MouseDown);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(200, 13);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(172, 256);
            this.tbLog.TabIndex = 1;
            this.tbLog.Text = "事件记录：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.pl);
            this.Name = "Form1";
            this.Text = "鼠标事件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.TextBox tbLog;
    }
}

