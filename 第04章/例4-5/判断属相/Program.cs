using System;

namespace 判断属相
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入一个0～11之间的数：\n");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("鼠年");
                    break;
                case 1:
                    Console.WriteLine("牛年");
                    break;
                case 2:
                    Console.WriteLine("虎年");
                    break;
                case 3:
                    Console.WriteLine("兔年");
                    break;
                case 4:
                    Console.WriteLine("龙年");
                    break;
                case 5:
                    Console.WriteLine("蛇年");
                    break;
                case 6:
                    Console.WriteLine("马年");
                    break;
                case 7:
                    Console.WriteLine("羊年");
                    break;
                case 8:
                    Console.WriteLine("猴年");
                    break;
                case 9:
                    Console.WriteLine("鸡年");
                    break;
                case 10:
                    Console.WriteLine("狗年");
                    break;
                case 11:
                    Console.WriteLine("猪年");
                    break;
                default:
                    Console.WriteLine("输入值不在0～11之间");
                    break;
            }
        }
    }
}
