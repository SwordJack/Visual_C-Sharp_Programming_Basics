using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 通过构造函数对类的字段进行初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.m_name = "Tom";

            Console.WriteLine(p.m_name);
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string m_name;
        protected int m_age;
        protected bool m_gender;

        //类的构造函数：
        public Person()
        {
            m_name = "Unknown";
            m_age = 0;
            m_gender = false;
        }
    }
}
