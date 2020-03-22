namespace 飘动动画窗体
{
    partial class WaveForm
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
            this.components = new System.ComponentModel.Container();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPause = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.btVertical = new System.Windows.Forms.Button();
            this.btHorizontal = new System.Windows.Forms.Button();
            this.timerHorizontal = new System.Windows.Forms.Timer(this.components);
            this.timerVertical = new System.Windows.Forms.Timer(this.components);
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTitle.Location = new System.Drawing.Point(201, 75);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(222, 44);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "飘动动画窗体";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPause);
            this.groupBox1.Controls.Add(this.btMove);
            this.groupBox1.Controls.Add(this.btVertical);
            this.groupBox1.Controls.Add(this.btHorizontal);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(128, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飘动动画窗体的控制";
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPause.Location = new System.Drawing.Point(217, 119);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(90, 40);
            this.btPause.TabIndex = 3;
            this.btPause.Text = "停止飘动";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btMove
            // 
            this.btMove.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMove.Location = new System.Drawing.Point(61, 119);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(90, 40);
            this.btMove.TabIndex = 2;
            this.btMove.Text = "移动窗体";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // btVertical
            // 
            this.btVertical.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btVertical.Location = new System.Drawing.Point(217, 36);
            this.btVertical.Name = "btVertical";
            this.btVertical.Size = new System.Drawing.Size(90, 40);
            this.btVertical.TabIndex = 1;
            this.btVertical.Text = "垂直移动";
            this.btVertical.UseVisualStyleBackColor = true;
            this.btVertical.Click += new System.EventHandler(this.btVertical_Click);
            // 
            // btHorizontal
            // 
            this.btHorizontal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHorizontal.Location = new System.Drawing.Point(61, 36);
            this.btHorizontal.Name = "btHorizontal";
            this.btHorizontal.Size = new System.Drawing.Size(90, 40);
            this.btHorizontal.TabIndex = 0;
            this.btHorizontal.Text = "水平移动";
            this.btHorizontal.UseVisualStyleBackColor = true;
            this.btHorizontal.Click += new System.EventHandler(this.BtHorizontal_Click);
            // 
            // timerHorizontal
            // 
            this.timerHorizontal.Tick += new System.EventHandler(this.TimerHorizontal_Tick);
            // 
            // timerVertical
            // 
            this.timerVertical.Tick += new System.EventHandler(this.TimerVertical_Tick);
            // 
            // timerMove
            // 
            this.timerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // WaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WaveForm";
            this.Text = "飘动动画窗体";
            this.Load += new System.EventHandler(this.WaveForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btVertical;
        private System.Windows.Forms.Button btHorizontal;
        private System.Windows.Forms.Timer timerHorizontal;
        private System.Windows.Forms.Timer timerVertical;
        private System.Windows.Forms.Timer timerMove;
    }
}

