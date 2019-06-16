using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch8_4_Ex
{
    class Test
    {
        static void Main(string[] args)
        {
            //建立对象
            Student 张三 = new Student("张三", "2008050201", "08网络", 95);
            Student 李四 = new Student("李四", "2006050120", "08网络", 75);

            //输出信息。
            张三.Print();
            李四.Print();

            Console.ReadKey();
        }
    }

    class Student
    {
        private string _stuName;    //学生姓名。
        private string _stuID;      //学生学号。
        private string _stuClass;   //学生班级。
        public double averageScore; //平均分。

        //
        //（构造函数）接受外部参数给Student实例的各个成员赋值。
        //
        public Student(string name, string id, string classInput, double ave)
        {
            _stuName = name;
            _stuID = id;
            _stuClass = classInput;
            averageScore = ave;
        }

        //
        //计算成绩等第。
        //
        public string Grade()
        {
            if (averageScore >= 90) return "优秀";
            else if (averageScore >= 78) return "良好";
            else if (averageScore >= 71) return "中等";
            else if (averageScore >= 60) return "及格";
            else return "不及格";
        }

        //
        //输出实例的全部信息。
        //
        public void Print()
        {
            Console.WriteLine("学生姓名：{0,-4}，学号：{1,-10}，班级：{2,-6}，平均分：{3,-3}，等第：{4,-3}；", _stuName, _stuID, _stuClass, averageScore, Grade());
        }
    }
}
