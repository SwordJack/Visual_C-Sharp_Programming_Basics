namespace Windows窗体进行流的文本读写
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
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.tbRead = new System.Windows.Forms.TextBox();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.lblMessageWrite = new System.Windows.Forms.Label();
            this.lblMessageRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(12, 12);
            this.tbWrite.Multiline = true;
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWrite.Size = new System.Drawing.Size(209, 231);
            this.tbWrite.TabIndex = 0;
            this.tbWrite.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // tbRead
            // 
            this.tbRead.Location = new System.Drawing.Point(243, 54);
            this.tbRead.Multiline = true;
            this.tbRead.Name = "tbRead";
            this.tbRead.ReadOnly = true;
            this.tbRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRead.Size = new System.Drawing.Size(209, 231);
            this.tbRead.TabIndex = 1;
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(12, 250);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(209, 35);
            this.btWrite.TabIndex = 2;
            this.btWrite.Text = "写入文件";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.BtWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(243, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(209, 35);
            this.btRead.TabIndex = 3;
            this.btRead.Text = "读取文件";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.BtRead_Click);
            // 
            // lblMessageWrite
            // 
            this.lblMessageWrite.AutoSize = true;
            this.lblMessageWrite.Location = new System.Drawing.Point(13, 297);
            this.lblMessageWrite.Name = "lblMessageWrite";
            this.lblMessageWrite.Size = new System.Drawing.Size(0, 12);
            this.lblMessageWrite.TabIndex = 4;
            // 
            // lblMessageRead
            // 
            this.lblMessageRead.AutoSize = true;
            this.lblMessageRead.Location = new System.Drawing.Point(241, 297);
            this.lblMessageRead.Name = "lblMessageRead";
            this.lblMessageRead.Size = new System.Drawing.Size(0, 12);
            this.lblMessageRead.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.lblMessageRead);
            this.Controls.Add(this.lblMessageWrite);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.tbRead);
            this.Controls.Add(this.tbWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "文本读写";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWrite;
        private System.Windows.Forms.TextBox tbRead;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lblMessageWrite;
        private System.Windows.Forms.Label lblMessageRead;
    }
}

