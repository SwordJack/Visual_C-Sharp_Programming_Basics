using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求给出范围内的质数
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m;
            bool prime;
            Console.Write("请问你需要求多少以内的质数（不小于2的整数）：");
            m = int.Parse(Console.ReadLine());
            for(i = 2; i <= m; i++)
            {
                prime = true;
                for(int factor = 2; factor < i; factor++)
                {
                    if (i % factor == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime == true)  Console.Write(i + "  ");
            }
            Console.ReadKey();
        }
    }
}
