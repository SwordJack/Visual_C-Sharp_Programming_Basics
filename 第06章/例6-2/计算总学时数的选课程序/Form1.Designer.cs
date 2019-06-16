namespace 计算总学时数的选课程序
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
            this.lblTip = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbCourse = new System.Windows.Forms.ListBox();
            this.lblHourTitle = new System.Windows.Forms.Label();
            this.lblHourNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(13, 13);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(77, 12);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "请选择课程：";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(12, 28);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 20);
            this.cbCourse.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(139, 28);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "加入";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(139, 107);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "移除";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // lbCourse
            // 
            this.lbCourse.FormattingEnabled = true;
            this.lbCourse.ItemHeight = 12;
            this.lbCourse.Location = new System.Drawing.Point(221, 28);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(151, 196);
            this.lbCourse.TabIndex = 4;
            // 
            // lblHourTitle
            // 
            this.lblHourTitle.AutoSize = true;
            this.lblHourTitle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHourTitle.Location = new System.Drawing.Point(218, 241);
            this.lblHourTitle.Name = "lblHourTitle";
            this.lblHourTitle.Size = new System.Drawing.Size(63, 14);
            this.lblHourTitle.TabIndex = 5;
            this.lblHourTitle.Text = "总学时：";
            // 
            // lblHourNumber
            // 
            this.lblHourNumber.AutoSize = true;
            this.lblHourNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHourNumber.Location = new System.Drawing.Point(287, 241);
            this.lblHourNumber.Name = "lblHourNumber";
            this.lblHourNumber.Size = new System.Drawing.Size(14, 14);
            this.lblHourNumber.TabIndex = 6;
            this.lblHourNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.lblHourNumber);
            this.Controls.Add(this.lblHourTitle);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lblTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "选课程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbCourse;
        private System.Windows.Forms.Label lblHourTitle;
        private System.Windows.Forms.Label lblHourNumber;
    }
}

