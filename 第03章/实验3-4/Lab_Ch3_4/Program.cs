using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("第1个整数："); int a = int.Parse(Console.ReadLine());
            Console.Write("第2个整数："); int b = int.Parse(Console.ReadLine());
            Console.Write("第3个整数："); int c = int.Parse(Console.ReadLine());

            //a是否比b、c都大吗 ? **是，那么最大的是** a : **否，那么再观察** (b大于c吗 ? **是，那么最大的是** b : **否，那么最大的是** c)
            Console.WriteLine("最大的数是：{0}", (a > b && a > c) ? a : (b > c ? b : c));

            //a是否比b、c都小吗 ? **是，那么最小的是** a : **否，那么再观察** (b小于c吗 ? **是，那么最小的是** b : **否，那么最大的是** c)
            Console.WriteLine("最小的数是：{0}", (a < b && a < c) ? a : (b < c ? b : c));
        }
    }
}
