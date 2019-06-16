using System;

namespace 乘法运算时的溢出现象
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 12345;
            short b = 17890;
            char ch = 'a';
            //short c = a * b;    //若取消注释此语句，运算结果会溢出，程序无法通过编译。
            Console.WriteLine(a * b);
            Console.WriteLine(a * ch);
        }
    }
}
