using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while语句计算1_100的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            sum = 0;
            int k = 1;
            do
            {
                sum = sum + k;
                k++;
            }
            while (k <= 100);
            Console.WriteLine("1～100的和为{0}", sum);
            Console.Write("（按任意键退出）");
            Console.ReadKey();
        }
    }
}
