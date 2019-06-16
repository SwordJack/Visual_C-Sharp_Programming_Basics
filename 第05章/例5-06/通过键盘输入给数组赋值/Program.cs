using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 通过键盘输入给数组赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strList = null;
            Console.Write("请输入数组长度：");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("你的数组元素个数为{0}。", num);
            strList = new string[num];
            for(int i = 0; i < num; i++)
            {
                Console.Write("输入数组第{0}个值：", i + 1);
                strList[i] = Console.ReadLine();
            }
            Console.WriteLine("完成输入！");
            _ = Console.ReadKey();  //使用丢弃，即丢弃该函数的返回值，因为这个函数的返回值不会被使用到。
        }
    }
}
