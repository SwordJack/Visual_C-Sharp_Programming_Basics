using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for(int j = i; j <= 9; j++)
                {
                    if (j < 9)
                    {
                        Console.Write("{0}×{1} = {2}；", i, j, i * j);
                    }
                    else if(i < 9)
                    {
                        Console.WriteLine("{0}×{1} = {2}；", i, j, i * j);
                    }
                    else
                    {
                        Console.WriteLine("{0}×{1} = {2}。", i, j, i * j);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
