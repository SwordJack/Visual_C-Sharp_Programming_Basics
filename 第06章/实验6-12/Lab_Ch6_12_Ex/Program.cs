using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_12_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入您需要骰子被掷出的次数：");
            int times = int.Parse(Console.ReadLine());
            Random rd = new Random();
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < times; i++)
            {
                int dice1 = rd.Next(6);
                int dice2 = rd.Next(6);
                count[dice1 + dice2]++;
            }

            Console.WriteLine("\n在骰子被掷出{0}次的过程中：", times);
            int countMaxIndex = 0;
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine("“{0,2}”被掷出了{1,4}次，", i + 2, count[i]);
                if ( count[i] == count.Max())
                {
                    countMaxIndex = i;
                }
            }
                        
            Console.WriteLine("所以选择{0}获胜几率较大。", countMaxIndex + 2);

            Console.ReadKey();

        }
    }
}
