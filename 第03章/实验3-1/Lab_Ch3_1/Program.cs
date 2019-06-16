using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个整数：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("请输入第二个整数：");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0},b={1}", a, b);
            int c;
            c = a; a = b; b = c;
            Console.WriteLine("交换后：");
            Console.WriteLine("a={0},b={1}", a, b);
        }
    }
}
