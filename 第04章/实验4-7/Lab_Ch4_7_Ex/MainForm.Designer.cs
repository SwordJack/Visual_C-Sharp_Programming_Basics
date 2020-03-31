namespace Lab_Ch4_7_Ex
{
    partial class MainForm
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
            this.gbInputLength = new System.Windows.Forms.GroupBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.gbInputLength.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputLength
            // 
            this.gbInputLength.Controls.Add(this.btCalc);
            this.gbInputLength.Controls.Add(this.tbD);
            this.gbInputLength.Controls.Add(this.tbC);
            this.gbInputLength.Controls.Add(this.tbB);
            this.gbInputLength.Controls.Add(this.tbA);
            this.gbInputLength.Controls.Add(this.lblD);
            this.gbInputLength.Controls.Add(this.lblC);
            this.gbInputLength.Controls.Add(this.lblB);
            this.gbInputLength.Controls.Add(this.lblA);
            this.gbInputLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbInputLength.Location = new System.Drawing.Point(13, 38);
            this.gbInputLength.Margin = new System.Windows.Forms.Padding(4);
            this.gbInputLength.Name = "gbInputLength";
            this.gbInputLength.Padding = new System.Windows.Forms.Padding(4);
            this.gbInputLength.Size = new System.Drawing.Size(638, 157);
            this.gbInputLength.TabIndex = 0;
            this.gbInputLength.TabStop = false;
            this.gbInputLength.Text = "请输入4条线段长度：";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(515, 50);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(100, 26);
            this.tbD.TabIndex = 7;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(357, 50);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 26);
            this.tbC.TabIndex = 6;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(210, 50);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 26);
            this.tbB.TabIndex = 5;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(54, 50);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 26);
            this.tbA.TabIndex = 4;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD.Location = new System.Drawing.Point(484, 53);
            this.lblD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 16);
            this.lblD.TabIndex = 3;
            this.lblD.Text = "d:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblC.Location = new System.Drawing.Point(321, 53);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 16);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "c:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblB.Location = new System.Drawing.Point(179, 53);
            this.lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 16);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblA.Location = new System.Drawing.Point(23, 53);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(120, 48);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "判定结果：\r\n\r\n该四边形周长：";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(263, 116);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(112, 31);
            this.btCalc.TabIndex = 8;
            this.btCalc.Text = "判定与计算";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.BtCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 321);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbInputLength);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "四边形判定";
            this.gbInputLength.ResumeLayout(false);
            this.gbInputLength.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputLength;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btCalc;
    }
}

