using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch6_18_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput;
            string[] hex = new string[50];
            Console.WriteLine("请输入十进制非负整数（不超过32678，输入不在范围内的数即退出）：");
            while (true)
            {

                //数组清零。
                for (int i = 0; i < hex.Length; i++)
                {
                    hex[i] = "0";
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

                if (numInput > 0)
                {
                    int digitCapacity;
                    for (digitCapacity = 0; numInput > 0; digitCapacity++)
                    {
                        int remain = numInput % 16;
                        if (remain <= 9)
                        {
                            hex[digitCapacity] = remain.ToString();
                        }
                        else
                        {
                            hex[digitCapacity] = Convert.ToChar(remain + 55).ToString();
                        }

                        numInput /= 16;
                    }

                    Array.Reverse(hex);
                    Console.Write("    输出（十六进制）：");
                    for (int i = hex.Length - digitCapacity; i < hex.Length; i++)
                    {
                        Console.Write(hex[i]);
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    break;
                }
            }
        }
    }
}