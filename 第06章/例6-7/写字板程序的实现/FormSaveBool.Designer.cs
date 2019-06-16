namespace 写字板程序的实现
{
    partial class FormSaveBool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSaveTip = new System.Windows.Forms.TextBox();
            this.btSaveTrue = new System.Windows.Forms.Button();
            this.btSaveFalse = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSaveTip
            // 
            this.tbSaveTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSaveTip.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSaveTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbSaveTip.Location = new System.Drawing.Point(13, 13);
            this.tbSaveTip.Multiline = true;
            this.tbSaveTip.Name = "tbSaveTip";
            this.tbSaveTip.ReadOnly = true;
            this.tbSaveTip.Size = new System.Drawing.Size(448, 21);
            this.tbSaveTip.TabIndex = 0;
            // 
            // btSaveTrue
            // 
            this.btSaveTrue.Location = new System.Drawing.Point(204, 11);
            this.btSaveTrue.Name = "btSaveTrue";
            this.btSaveTrue.Size = new System.Drawing.Size(75, 23);
            this.btSaveTrue.TabIndex = 1;
            this.btSaveTrue.Text = "保存(&S)";
            this.btSaveTrue.UseVisualStyleBackColor = true;
            this.btSaveTrue.Click += new System.EventHandler(this.BtSaveTrue_Click);
            // 
            // btSaveFalse
            // 
            this.btSaveFalse.Location = new System.Drawing.Point(295, 11);
            this.btSaveFalse.Name = "btSaveFalse";
            this.btSaveFalse.Size = new System.Drawing.Size(75, 23);
            this.btSaveFalse.TabIndex = 2;
            this.btSaveFalse.Text = "不保存(&N)";
            this.btSaveFalse.UseVisualStyleBackColor = true;
            this.btSaveFalse.Click += new System.EventHandler(this.BtSaveFalse_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(386, 11);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消(&C)";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btSaveTrue);
            this.panel1.Controls.Add(this.btSaveFalse);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 50);
            this.panel1.TabIndex = 4;
            // 
            // FormSaveBool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 121);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSaveTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaveBool";
            this.Text = "文本编辑器";
            this.Load += new System.EventHandler(this.FormSaveBool_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSaveTip;
        private System.Windows.Forms.Button btSaveTrue;
        private System.Windows.Forms.Button btSaveFalse;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel1;
    }
}