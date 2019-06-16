using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach语句的使用例
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] members = new int[] { 0, 1, 2, 3, 5, 8, 13 };  //定义了一个数组。
            foreach (int member in members)                      //进行foreach循环。
            {
                System.Console.WriteLine(member);                //输出结果。
            }

            Console.ReadKey();
        }
    }
}
