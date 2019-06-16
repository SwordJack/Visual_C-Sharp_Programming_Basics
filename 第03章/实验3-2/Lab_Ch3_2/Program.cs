using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个三位正整数:");
            int x = int.Parse(Console.ReadLine());
            int a = x / 100;                        //除以100所得商，即为百位之数码。
            int b = x / 10 - a * 10;                //除以10所得商，减去百位数字的十倍，即为十位之数码。
            int c = x % 10;                         //x模10所得余数，即为个位之数码。
            Console.WriteLine("{0},{1},{2}", c, b, a);
        }
    }
}
