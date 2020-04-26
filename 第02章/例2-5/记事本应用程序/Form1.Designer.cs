namespace 记事本应用程序
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
            this.btCut = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.btPaste = new System.Windows.Forms.Button();
            this.btFormat = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCut
            // 
            this.btCut.Location = new System.Drawing.Point(194, 12);
            this.btCut.Name = "btCut";
            this.btCut.Size = new System.Drawing.Size(75, 50);
            this.btCut.TabIndex = 0;
            this.btCut.Text = "剪切";
            this.btCut.UseVisualStyleBackColor = true;
            this.btCut.Click += new System.EventHandler(this.BtCut_Click);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(194, 68);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(75, 50);
            this.btCopy.TabIndex = 1;
            this.btCopy.Text = "复制";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.BtCopy_Click);
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(194, 124);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(75, 50);
            this.btPaste.TabIndex = 2;
            this.btPaste.Text = "粘贴";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.BtPaste_Click);
            // 
            // btFormat
            // 
            this.btFormat.Location = new System.Drawing.Point(194, 180);
            this.btFormat.Name = "btFormat";
            this.btFormat.Size = new System.Drawing.Size(75, 25);
            this.btFormat.TabIndex = 3;
            this.btFormat.Text = "格式";
            this.btFormat.UseVisualStyleBackColor = true;
            this.btFormat.Click += new System.EventHandler(this.BtFormat_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(194, 211);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 25);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "结束";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(12, 12);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(176, 224);
            this.tbContent.TabIndex = 5;
            this.tbContent.Text = "建立一个类似记事本的应用程序，该程序主要提供两类操作：（1）剪切、复制和粘贴的编辑操作；（2）字体大小的格式设置。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 250);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btFormat);
            this.Controls.Add(this.btPaste);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btCut);
            this.Name = "Form1";
            this.Text = "记事本功能实现";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCut;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Button btPaste;
        private System.Windows.Forms.Button btFormat;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbContent;
    }
}

