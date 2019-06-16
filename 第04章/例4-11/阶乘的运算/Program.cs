using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阶乘的运算
{
    class Program
    {
        static void Main(string[] args)
        {
            int product, k;
            Console.Write("你要计算哪个数的阶乘？ ");
            int i = int.Parse(Console.ReadLine());
            product = 1;
            for(k = 1; k <= i; k++)
            {
                product *= k;
            }
            Console.WriteLine("");
            Console.WriteLine("{0}的阶乘为{1}。", i, product);
            Console.ReadKey();
        }
    }
}
