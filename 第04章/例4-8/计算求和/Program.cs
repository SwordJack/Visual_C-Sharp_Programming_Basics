using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算1_100的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            sum = 0;
            for (int k = 1; k <= 100; k++)
            {
                sum = sum + k;
            }
            Console.WriteLine("1～100的和为{0}", sum);
            Console.Write("（按任意键退出）");
            Console.ReadKey();
        }
    }
}
