namespace Lab_Ch3_5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbOperation = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btRem = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 0;
            // 
            // tbOperation
            // 
            this.tbOperation.Location = new System.Drawing.Point(137, 28);
            this.tbOperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbOperation.Name = "tbOperation";
            this.tbOperation.ReadOnly = true;
            this.tbOperation.Size = new System.Drawing.Size(24, 23);
            this.tbOperation.TabIndex = 2;
            this.tbOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(312, 28);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(116, 23);
            this.tbResult.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(17, 80);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(61, 28);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSub.Location = new System.Drawing.Point(86, 80);
            this.btSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(61, 28);
            this.btSub.TabIndex = 6;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMul.Location = new System.Drawing.Point(155, 80);
            this.btMul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(61, 28);
            this.btMul.TabIndex = 7;
            this.btMul.Text = "×";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDiv.Location = new System.Drawing.Point(224, 80);
            this.btDiv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(61, 28);
            this.btDiv.TabIndex = 8;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btRem
            // 
            this.btRem.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRem.Location = new System.Drawing.Point(293, 80);
            this.btRem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRem.Name = "btRem";
            this.btRem.Size = new System.Drawing.Size(61, 28);
            this.btRem.TabIndex = 9;
            this.btRem.Text = "%";
            this.btRem.UseVisualStyleBackColor = true;
            this.btRem.Click += new System.EventHandler(this.btRem_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.Location = new System.Drawing.Point(362, 80);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(61, 28);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 142);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRem);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbOperation);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "简易计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbOperation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btRem;
        private System.Windows.Forms.Button btClear;
    }
}

