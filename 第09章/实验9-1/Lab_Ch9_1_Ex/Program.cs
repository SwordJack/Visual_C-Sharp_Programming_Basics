using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch9_1_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("张三", 30);
            p1.Print();

            Teacher p2 = new Teacher("李四", 40);
            p2.Print();

            Teacher p3 = new Teacher("王五", 50, 23360891, 25);
            p3.Print();

            Console.ReadKey();
        }
    }

    class Person
    {
        string _name;     //姓名，只读字段。
        public int Age;                  //年龄。
        private int _birthYear;           //出生年份。

        public Person()                     //一个空构造函数的存在是必需的。
        {

        }

        public Person(string name, int age)
        {
            this._name = name;
            this.Age = age;
            this._birthYear = DateTime.Today.Year - this.Age;
        }

        public string Name      //将姓名设置为只读属性。
        {
            get
            {
                return _name;
            }
        }

        public int BirthYear    //将出生年份设置为只读属性。
        {
            get
            {
                _birthYear = DateTime.Today.Year - this.Age;
                return _birthYear;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}，出生年份：{2}；", Name, Age, BirthYear);
        }
    }

    class Teacher : Person
    {
        long _No;   //教师的工号。
        int _Ta;    //教师的教龄。

        public Teacher(string name, int age) : base(name, age)
        {
            _No = 99999999;     //工号的默认值。
            _Ta = -1;           //教龄的默认值。
        }

        public Teacher(string name, int age, long facultyNumber, int teachingAge) : base(name, age)
        {
            this._No = facultyNumber;
            this._Ta = teachingAge;
        }

        public long FacultyNumber   //工号（属性）。
        {
            get
            {
                return _No;
            }
            set
            {
                _No = value;
            }
        }

        public int TeachingAge      //教龄（属性）。
        {
            get
            {
                return _Ta;
            }
            set
            {
                _Ta = value;
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("职业：教师，工号：{0}，教龄{1}。", FacultyNumber, TeachingAge);
        }
    }
}
