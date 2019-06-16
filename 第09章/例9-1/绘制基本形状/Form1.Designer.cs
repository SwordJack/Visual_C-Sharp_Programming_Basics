namespace 绘制基本形状
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
            this.btDrawLine = new System.Windows.Forms.Button();
            this.btDrawRectangle = new System.Windows.Forms.Button();
            this.btDrawCircle = new System.Windows.Forms.Button();
            this.panelDrawingBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btDrawLine
            // 
            this.btDrawLine.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDrawLine.Location = new System.Drawing.Point(12, 370);
            this.btDrawLine.Name = "btDrawLine";
            this.btDrawLine.Size = new System.Drawing.Size(120, 50);
            this.btDrawLine.TabIndex = 0;
            this.btDrawLine.Text = "直线";
            this.btDrawLine.UseVisualStyleBackColor = true;
            this.btDrawLine.Click += new System.EventHandler(this.BtDrawLine_Click);
            // 
            // btDrawRectangle
            // 
            this.btDrawRectangle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDrawRectangle.Location = new System.Drawing.Point(252, 369);
            this.btDrawRectangle.Name = "btDrawRectangle";
            this.btDrawRectangle.Size = new System.Drawing.Size(120, 50);
            this.btDrawRectangle.TabIndex = 1;
            this.btDrawRectangle.Text = "矩形";
            this.btDrawRectangle.UseVisualStyleBackColor = true;
            this.btDrawRectangle.Click += new System.EventHandler(this.BtDrawRectangle_Click);
            // 
            // btDrawCircle
            // 
            this.btDrawCircle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDrawCircle.Location = new System.Drawing.Point(492, 369);
            this.btDrawCircle.Name = "btDrawCircle";
            this.btDrawCircle.Size = new System.Drawing.Size(120, 50);
            this.btDrawCircle.TabIndex = 2;
            this.btDrawCircle.Text = "圆形";
            this.btDrawCircle.UseVisualStyleBackColor = true;
            this.btDrawCircle.Click += new System.EventHandler(this.BtDrawCircle_Click);
            // 
            // panelDrawingBoard
            // 
            this.panelDrawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawingBoard.Location = new System.Drawing.Point(12, 23);
            this.panelDrawingBoard.Name = "panelDrawingBoard";
            this.panelDrawingBoard.Size = new System.Drawing.Size(600, 325);
            this.panelDrawingBoard.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panelDrawingBoard);
            this.Controls.Add(this.btDrawCircle);
            this.Controls.Add(this.btDrawRectangle);
            this.Controls.Add(this.btDrawLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDrawLine;
        private System.Windows.Forms.Button btDrawRectangle;
        private System.Windows.Forms.Button btDrawCircle;
        private System.Windows.Forms.Panel panelDrawingBoard;
    }
}

