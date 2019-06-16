using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算总学时数的选课程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Course[] courses = new Course[7]
            {
                  new Course ("英语", 50),
                  new Course ("高等数学", 60),
                  new Course ("数理统计", 35),
                  new Course ("大学物理", 40),
                  new Course ("电子电工", 45),
                  new Course ("计算机应用基础", 40),
                  new Course ("计算机语言程序设计", 45)
            };

            for (int i = 0; i < courses.Length; i++)
            {
                cbCourse.Items.Add(courses[i]);
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (cbCourse.SelectedIndex != -1)
            {
                Course courselected = (Course)cbCourse.SelectedItem;  //将获取的项目转换为Course类。
                if (!lbCourse.Items.Contains(courselected))
                {
                    lbCourse.Items.Add(courselected);
                    lblHourNumber.Text = (int.Parse(lblHourNumber.Text) + courselected.courseHour).ToString();
                }
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (lbCourse.SelectedIndex != -1)
            {
                Course courselected = (Course)lbCourse.SelectedItem;
                if (lbCourse.Items.Contains(courselected))
                {
                    lbCourse.Items.Remove(courselected);
                    lblHourNumber.Text = (int.Parse(lblHourNumber.Text) - courselected.courseHour).ToString();
                }
            }
        }
    }

    public class Course
    {
        public string courseName;
        public int courseHour;

        public Course(string name, int hour)  //构造函数，用以给对象赋值，从而初始化对象。
        {
            this.courseName = name;
            this.courseHour = hour;
        }

        public override string ToString()	  //重写类的ToString()方法。
        {
            return courseName;
        }
    }
}
