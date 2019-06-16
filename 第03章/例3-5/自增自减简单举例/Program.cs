using System;

namespace 自增自减简单举例
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = 2.5;
            Console.WriteLine(++x);    //将变量x加1后输出。
            x = 2.5;
            Console.WriteLine(x++);    //将变量x输出后再加1。
            Console.WriteLine(x);
        }
    }
}
