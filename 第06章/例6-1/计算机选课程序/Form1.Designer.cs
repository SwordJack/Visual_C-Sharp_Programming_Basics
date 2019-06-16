namespace 计算机选课程序
{
    partial class FormCourseSelection
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
            this.tabCourseList = new System.Windows.Forms.TabControl();
            this.tabCourse1 = new System.Windows.Forms.TabPage();
            this.gbCourse1 = new System.Windows.Forms.GroupBox();
            this.rbCourse1Base = new System.Windows.Forms.RadioButton();
            this.rbCourse1Intro = new System.Windows.Forms.RadioButton();
            this.tabCourse2 = new System.Windows.Forms.TabPage();
            this.gbCourse2 = new System.Windows.Forms.GroupBox();
            this.rbCourse2Web = new System.Windows.Forms.RadioButton();
            this.rbCourse2Java = new System.Windows.Forms.RadioButton();
            this.rbCourse2Cs = new System.Windows.Forms.RadioButton();
            this.rbCourse2VB = new System.Windows.Forms.RadioButton();
            this.rbCourse2Clang = new System.Windows.Forms.RadioButton();
            this.tabCourse3 = new System.Windows.Forms.TabPage();
            this.gbCourse3 = new System.Windows.Forms.GroupBox();
            this.cbCourse3Web = new System.Windows.Forms.CheckBox();
            this.cbCourse3Data = new System.Windows.Forms.CheckBox();
            this.cbCourse3Media = new System.Windows.Forms.CheckBox();
            this.cbCourse3Eng = new System.Windows.Forms.CheckBox();
            this.cbCourse3Dev = new System.Windows.Forms.CheckBox();
            this.tbShow = new System.Windows.Forms.TextBox();
            this.tabCourseList.SuspendLayout();
            this.tabCourse1.SuspendLayout();
            this.gbCourse1.SuspendLayout();
            this.tabCourse2.SuspendLayout();
            this.gbCourse2.SuspendLayout();
            this.tabCourse3.SuspendLayout();
            this.gbCourse3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCourseList
            // 
            this.tabCourseList.Controls.Add(this.tabCourse1);
            this.tabCourseList.Controls.Add(this.tabCourse2);
            this.tabCourseList.Controls.Add(this.tabCourse3);
            this.tabCourseList.Location = new System.Drawing.Point(12, 12);
            this.tabCourseList.Name = "tabCourseList";
            this.tabCourseList.SelectedIndex = 0;
            this.tabCourseList.Size = new System.Drawing.Size(420, 237);
            this.tabCourseList.TabIndex = 0;
            // 
            // tabCourse1
            // 
            this.tabCourse1.Controls.Add(this.gbCourse1);
            this.tabCourse1.Location = new System.Drawing.Point(4, 22);
            this.tabCourse1.Name = "tabCourse1";
            this.tabCourse1.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse1.Size = new System.Drawing.Size(412, 211);
            this.tabCourse1.TabIndex = 0;
            this.tabCourse1.Text = "第一门课";
            this.tabCourse1.UseVisualStyleBackColor = true;
            // 
            // gbCourse1
            // 
            this.gbCourse1.Controls.Add(this.rbCourse1Base);
            this.gbCourse1.Controls.Add(this.rbCourse1Intro);
            this.gbCourse1.Location = new System.Drawing.Point(6, 22);
            this.gbCourse1.Name = "gbCourse1";
            this.gbCourse1.Size = new System.Drawing.Size(400, 183);
            this.gbCourse1.TabIndex = 0;
            this.gbCourse1.TabStop = false;
            this.gbCourse1.Text = "基础";
            // 
            // rbCourse1Base
            // 
            this.rbCourse1Base.AutoSize = true;
            this.rbCourse1Base.Location = new System.Drawing.Point(36, 20);
            this.rbCourse1Base.Name = "rbCourse1Base";
            this.rbCourse1Base.Size = new System.Drawing.Size(83, 16);
            this.rbCourse1Base.TabIndex = 1;
            this.rbCourse1Base.TabStop = true;
            this.rbCourse1Base.Text = "计算机基础";
            this.rbCourse1Base.UseVisualStyleBackColor = true;
            this.rbCourse1Base.CheckedChanged += new System.EventHandler(this.RbCourse1_CheckedChanged);
            // 
            // rbCourse1Intro
            // 
            this.rbCourse1Intro.AutoSize = true;
            this.rbCourse1Intro.Location = new System.Drawing.Point(36, 42);
            this.rbCourse1Intro.Name = "rbCourse1Intro";
            this.rbCourse1Intro.Size = new System.Drawing.Size(83, 16);
            this.rbCourse1Intro.TabIndex = 2;
            this.rbCourse1Intro.TabStop = true;
            this.rbCourse1Intro.Text = "计算机导论";
            this.rbCourse1Intro.UseVisualStyleBackColor = true;
            this.rbCourse1Intro.CheckedChanged += new System.EventHandler(this.RbCourse1_CheckedChanged);
            // 
            // tabCourse2
            // 
            this.tabCourse2.Controls.Add(this.gbCourse2);
            this.tabCourse2.Location = new System.Drawing.Point(4, 22);
            this.tabCourse2.Name = "tabCourse2";
            this.tabCourse2.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse2.Size = new System.Drawing.Size(412, 211);
            this.tabCourse2.TabIndex = 1;
            this.tabCourse2.Text = "第二门课";
            this.tabCourse2.UseVisualStyleBackColor = true;
            // 
            // gbCourse2
            // 
            this.gbCourse2.Controls.Add(this.rbCourse2Web);
            this.gbCourse2.Controls.Add(this.rbCourse2Java);
            this.gbCourse2.Controls.Add(this.rbCourse2Cs);
            this.gbCourse2.Controls.Add(this.rbCourse2VB);
            this.gbCourse2.Controls.Add(this.rbCourse2Clang);
            this.gbCourse2.Location = new System.Drawing.Point(6, 22);
            this.gbCourse2.Name = "gbCourse2";
            this.gbCourse2.Size = new System.Drawing.Size(400, 183);
            this.gbCourse2.TabIndex = 1;
            this.gbCourse2.TabStop = false;
            this.gbCourse2.Text = "语言";
            // 
            // rbCourse2Web
            // 
            this.rbCourse2Web.AutoSize = true;
            this.rbCourse2Web.Location = new System.Drawing.Point(36, 108);
            this.rbCourse2Web.Name = "rbCourse2Web";
            this.rbCourse2Web.Size = new System.Drawing.Size(89, 16);
            this.rbCourse2Web.TabIndex = 7;
            this.rbCourse2Web.TabStop = true;
            this.rbCourse2Web.Text = "Web程序设计";
            this.rbCourse2Web.UseVisualStyleBackColor = true;
            this.rbCourse2Web.CheckedChanged += new System.EventHandler(this.RbCourse2_CheckedChanged);
            // 
            // rbCourse2Java
            // 
            this.rbCourse2Java.AutoSize = true;
            this.rbCourse2Java.Location = new System.Drawing.Point(36, 64);
            this.rbCourse2Java.Name = "rbCourse2Java";
            this.rbCourse2Java.Size = new System.Drawing.Size(119, 16);
            this.rbCourse2Java.TabIndex = 5;
            this.rbCourse2Java.TabStop = true;
            this.rbCourse2Java.Text = "Java语言程序设计";
            this.rbCourse2Java.UseVisualStyleBackColor = true;
            this.rbCourse2Java.CheckedChanged += new System.EventHandler(this.RbCourse2_CheckedChanged);
            // 
            // rbCourse2Cs
            // 
            this.rbCourse2Cs.AutoSize = true;
            this.rbCourse2Cs.Location = new System.Drawing.Point(36, 86);
            this.rbCourse2Cs.Name = "rbCourse2Cs";
            this.rbCourse2Cs.Size = new System.Drawing.Size(83, 16);
            this.rbCourse2Cs.TabIndex = 6;
            this.rbCourse2Cs.TabStop = true;
            this.rbCourse2Cs.Text = "C#程序设计";
            this.rbCourse2Cs.UseVisualStyleBackColor = true;
            this.rbCourse2Cs.CheckedChanged += new System.EventHandler(this.RbCourse2_CheckedChanged);
            // 
            // rbCourse2VB
            // 
            this.rbCourse2VB.AutoSize = true;
            this.rbCourse2VB.Location = new System.Drawing.Point(36, 20);
            this.rbCourse2VB.Name = "rbCourse2VB";
            this.rbCourse2VB.Size = new System.Drawing.Size(107, 16);
            this.rbCourse2VB.TabIndex = 3;
            this.rbCourse2VB.TabStop = true;
            this.rbCourse2VB.Text = "VB语言程序设计";
            this.rbCourse2VB.UseVisualStyleBackColor = true;
            this.rbCourse2VB.CheckedChanged += new System.EventHandler(this.RbCourse2_CheckedChanged);
            // 
            // rbCourse2Clang
            // 
            this.rbCourse2Clang.AutoSize = true;
            this.rbCourse2Clang.Location = new System.Drawing.Point(36, 42);
            this.rbCourse2Clang.Name = "rbCourse2Clang";
            this.rbCourse2Clang.Size = new System.Drawing.Size(101, 16);
            this.rbCourse2Clang.TabIndex = 4;
            this.rbCourse2Clang.TabStop = true;
            this.rbCourse2Clang.Text = "C语言程序设计";
            this.rbCourse2Clang.UseVisualStyleBackColor = true;
            this.rbCourse2Clang.CheckedChanged += new System.EventHandler(this.RbCourse2_CheckedChanged);
            // 
            // tabCourse3
            // 
            this.tabCourse3.Controls.Add(this.gbCourse3);
            this.tabCourse3.Location = new System.Drawing.Point(4, 22);
            this.tabCourse3.Name = "tabCourse3";
            this.tabCourse3.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse3.Size = new System.Drawing.Size(412, 211);
            this.tabCourse3.TabIndex = 2;
            this.tabCourse3.Text = "第三门课";
            this.tabCourse3.UseVisualStyleBackColor = true;
            // 
            // gbCourse3
            // 
            this.gbCourse3.Controls.Add(this.cbCourse3Web);
            this.gbCourse3.Controls.Add(this.cbCourse3Data);
            this.gbCourse3.Controls.Add(this.cbCourse3Media);
            this.gbCourse3.Controls.Add(this.cbCourse3Eng);
            this.gbCourse3.Controls.Add(this.cbCourse3Dev);
            this.gbCourse3.Location = new System.Drawing.Point(6, 22);
            this.gbCourse3.Name = "gbCourse3";
            this.gbCourse3.Size = new System.Drawing.Size(400, 183);
            this.gbCourse3.TabIndex = 2;
            this.gbCourse3.TabStop = false;
            this.gbCourse3.Text = "应用";
            // 
            // cbCourse3Web
            // 
            this.cbCourse3Web.AutoSize = true;
            this.cbCourse3Web.Location = new System.Drawing.Point(36, 108);
            this.cbCourse3Web.Name = "cbCourse3Web";
            this.cbCourse3Web.Size = new System.Drawing.Size(72, 16);
            this.cbCourse3Web.TabIndex = 17;
            this.cbCourse3Web.Text = "网络技术";
            this.cbCourse3Web.UseVisualStyleBackColor = true;
            this.cbCourse3Web.CheckedChanged += new System.EventHandler(this.CbCourse3_CheckedChanged);
            // 
            // cbCourse3Data
            // 
            this.cbCourse3Data.AutoSize = true;
            this.cbCourse3Data.Location = new System.Drawing.Point(36, 86);
            this.cbCourse3Data.Name = "cbCourse3Data";
            this.cbCourse3Data.Size = new System.Drawing.Size(60, 16);
            this.cbCourse3Data.TabIndex = 16;
            this.cbCourse3Data.Text = "数据库";
            this.cbCourse3Data.UseVisualStyleBackColor = true;
            this.cbCourse3Data.CheckedChanged += new System.EventHandler(this.CbCourse3_CheckedChanged);
            // 
            // cbCourse3Media
            // 
            this.cbCourse3Media.AutoSize = true;
            this.cbCourse3Media.Location = new System.Drawing.Point(36, 64);
            this.cbCourse3Media.Name = "cbCourse3Media";
            this.cbCourse3Media.Size = new System.Drawing.Size(60, 16);
            this.cbCourse3Media.TabIndex = 15;
            this.cbCourse3Media.Text = "多媒体";
            this.cbCourse3Media.UseVisualStyleBackColor = true;
            this.cbCourse3Media.CheckedChanged += new System.EventHandler(this.CbCourse3_CheckedChanged);
            // 
            // cbCourse3Eng
            // 
            this.cbCourse3Eng.AutoSize = true;
            this.cbCourse3Eng.Location = new System.Drawing.Point(36, 42);
            this.cbCourse3Eng.Name = "cbCourse3Eng";
            this.cbCourse3Eng.Size = new System.Drawing.Size(72, 16);
            this.cbCourse3Eng.TabIndex = 14;
            this.cbCourse3Eng.Text = "软件工程";
            this.cbCourse3Eng.UseVisualStyleBackColor = true;
            this.cbCourse3Eng.CheckedChanged += new System.EventHandler(this.CbCourse3_CheckedChanged);
            // 
            // cbCourse3Dev
            // 
            this.cbCourse3Dev.AutoSize = true;
            this.cbCourse3Dev.Location = new System.Drawing.Point(36, 20);
            this.cbCourse3Dev.Name = "cbCourse3Dev";
            this.cbCourse3Dev.Size = new System.Drawing.Size(72, 16);
            this.cbCourse3Dev.TabIndex = 13;
            this.cbCourse3Dev.Text = "软件开发";
            this.cbCourse3Dev.UseVisualStyleBackColor = true;
            this.cbCourse3Dev.CheckedChanged += new System.EventHandler(this.CbCourse3_CheckedChanged);
            // 
            // tbShow
            // 
            this.tbShow.Location = new System.Drawing.Point(16, 255);
            this.tbShow.Multiline = true;
            this.tbShow.Name = "tbShow";
            this.tbShow.ReadOnly = true;
            this.tbShow.Size = new System.Drawing.Size(412, 114);
            this.tbShow.TabIndex = 1;
            // 
            // FormCourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 381);
            this.Controls.Add(this.tbShow);
            this.Controls.Add(this.tabCourseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCourseSelection";
            this.Text = "计算机课程选课";
            this.tabCourseList.ResumeLayout(false);
            this.tabCourse1.ResumeLayout(false);
            this.gbCourse1.ResumeLayout(false);
            this.gbCourse1.PerformLayout();
            this.tabCourse2.ResumeLayout(false);
            this.gbCourse2.ResumeLayout(false);
            this.gbCourse2.PerformLayout();
            this.tabCourse3.ResumeLayout(false);
            this.gbCourse3.ResumeLayout(false);
            this.gbCourse3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCourseList;
        private System.Windows.Forms.TabPage tabCourse1;
        private System.Windows.Forms.TabPage tabCourse2;
        private System.Windows.Forms.TabPage tabCourse3;
        private System.Windows.Forms.GroupBox gbCourse1;
        private System.Windows.Forms.RadioButton rbCourse1Base;
        private System.Windows.Forms.RadioButton rbCourse1Intro;
        private System.Windows.Forms.GroupBox gbCourse2;
        private System.Windows.Forms.RadioButton rbCourse2Web;
        private System.Windows.Forms.RadioButton rbCourse2Java;
        private System.Windows.Forms.RadioButton rbCourse2Cs;
        private System.Windows.Forms.RadioButton rbCourse2VB;
        private System.Windows.Forms.RadioButton rbCourse2Clang;
        private System.Windows.Forms.GroupBox gbCourse3;
        private System.Windows.Forms.CheckBox cbCourse3Web;
        private System.Windows.Forms.CheckBox cbCourse3Data;
        private System.Windows.Forms.CheckBox cbCourse3Media;
        private System.Windows.Forms.CheckBox cbCourse3Eng;
        private System.Windows.Forms.CheckBox cbCourse3Dev;
        private System.Windows.Forms.TextBox tbShow;
    }
}

