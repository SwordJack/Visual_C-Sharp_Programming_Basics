using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 号码对应月份英文名称
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int userWrite;
            while (true)
            {
                Console.Write("请输入1~12的整数（输入0退出）：");
                userWrite = int.Parse(Console.ReadLine());
                if (userWrite >=1 && userWrite <= 12)
                {
                    Console.WriteLine(Month[userWrite - 1] + "\n");
                }
                else if (userWrite == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("输入项不合法！\a\n");
                    continue;
                }
            }
        }
    }
}
