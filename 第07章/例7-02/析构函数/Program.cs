using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 析构函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.m_name);

            Console.ReadKey();  //通过“开始执行——不调试”可以看见析构函数被执行。
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
            Console.WriteLine("一个Person类的新实例构造完成！");
        }

        //类的析构函数：
        ~Person()
        {
            Console.WriteLine("Person类的析构函数被执行一次！");
        }

        /*
         * 使用析构函数释放资源
         * 析构函数用于析构类的实例。
         *    1、不能在结构中定义析构函数。只能对类使用析构函数。
         *    2、一个类只能有一个析构函数。
         *    3、无法继承或重载析构函数。
         *    4、无法调用析构函数。它们是被自动调用的。
         *    5、析构函数既没有修饰符，也没有参数。
         */
    }
}
