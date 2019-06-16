using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚拟方法和重写方法
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLeader stuExample = new StudentLeader("990001", "李明", 80, "班长");
            stuExample.PrintInfo();

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

        public virtual void PrintInfo()
        {
            Console.WriteLine("编号：" + No);
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("成绩：" + Score);
        }
    }

    class StudentLeader : Student
    {
        private string Duty;

        public StudentLeader(string noLeader, string nameLeader, int scoreLeader, string dutyLeader) : base(noLeader, nameLeader, scoreLeader)
        {
            //前三个继承自基类的字段调用基类的构造函数进行构造。
            Duty = dutyLeader;
        }

        public override void PrintInfo()        
        {
            base.PrintInfo();   //直接调用基类的函数进行输出。
            Console.WriteLine("岗位：" + Duty);
        }

        /*
         * override关键字定义的方法同时也默认也是一个虚拟（virtual）方法（但是不允许同时用virtual和override修饰一个方法），意即允许其派生类继续重写该方法；
         * virtual方法不能够是私有（private）的，因为定义虚拟方法即代表希望在派生类中继承并重写该方法；
         * 在基类和派生类中，对于同一个虚拟（重写）方法的访问修饰符应当相同，即都使用公共（public）修饰符或都使用受保护（protected）修饰符。
         */
    }
}
