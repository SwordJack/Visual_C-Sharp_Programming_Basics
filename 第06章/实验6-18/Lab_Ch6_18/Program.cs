using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput;
            int[] bin = new int[50];
            Console.WriteLine("请输入十进制非负整数（不超过32678，输入不在范围内的数即退出）：");
            while(true)
            {

                //数组清零，清除上一次计算的结果。
                for (int i = 0; i < bin.Length; i++)
                {
                    bin[i] = 0;
                }

                Console.Write("输入：");
                //用来捕捉输入内容不能够转化为整数型的异常。
                try
                {
                    numInput = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("  输入项不合法！\n");
                    continue;
                }

                if (numInput > 0)  //如果输入的是正整数。
                {
                    int digitCapacity;  //表示二进制数的位数
                    for (digitCapacity = 0; numInput > 0; digitCapacity++)
                    {
                        bin[digitCapacity] = numInput % 2;  //短除法，余数存储入数组中。
                        numInput /= 2;
                    }

                    Array.Reverse(bin);  //将数组倒序排列。
                    Console.Write("    输出（二进制）：");
                    for (int i = bin.Length - digitCapacity; i < bin.Length; i++)  //从第（bin.Length - digitCapacity）位开始（前面的都是0），输出0和1。
                    {
                        Console.Write(bin[i]);
                    }
                    Console.WriteLine("\n");
                }
                else  //如果输入的不是正整数，则跳出循环，结束程序。
                {
                    break;
                }
            }
        }
    }
}
