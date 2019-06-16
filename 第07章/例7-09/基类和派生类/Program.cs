using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基类和派生类
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLeader stuExample = new StudentLeader("990001", "李明", 80, "班长");
            stuExample.NewPrintInfo();

            Console.ReadKey();
        }
    }

    class Student
    {
        protected string No;    //protected，表示仅限于当前类和继承该类的类访问该字段。
        protected string Name;
        protected int Score;

        public Student()        //具有派生类的基类必须带有一个无参构造函数。
        {
            
        }

        public Student(string numBase, string nameBase, int scoreBase)
        {
            No = numBase;
            Name = nameBase;
            Score = scoreBase;
        }

        public void PrintInfo()
        {
            Console.WriteLine("编号：" + No);
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("成绩：" + Score);
        }
    }

    class StudentLeader : Student
    {
        private string Duty;

        public StudentLeader(string noLeader, string nameLeader, int scoreLeader, string dutyLeader)
        {
            No = noLeader;
            Name = nameLeader;
            Score = scoreLeader;
            Duty = dutyLeader;
        }

        public void NewPrintInfo()
        {
            Console.WriteLine("编号：" + No);
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("成绩：" + Score);
            Console.WriteLine("岗位：" + Duty);
        }
    }
}
