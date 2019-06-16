using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入您需要骰子被掷出的次数：");
            int times = int.Parse(Console.ReadLine());  //对课本代码进行小的修改，用times变量计次。
            Random rd = new Random();
            int[] count = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < times; i++)
            {
                count[rd.Next(6)]++;
            }

            Console.WriteLine("\n在骰子被掷出{0}次的过程中：" +
                "\n“1”被掷出了{1}次，" +
                "\n“2”被掷出了{2}次，" +
                "\n“3”被掷出了{3}次，" +
                "\n“4”被掷出了{4}次，" +
                "\n“5”被掷出了{5}次，" +
                "\n“6”被掷出了{6}次。",
                times, count[0], count[1], count[2], count[3], count[4], count[5]);
            Console.ReadKey();
        }
    }
}
