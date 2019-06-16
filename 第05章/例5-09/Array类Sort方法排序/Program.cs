using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array类Sort方法排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 4, 1, 3 };
            Console.Write( "数列原排序为：");
            foreach (int item in a)
            {
                Console.Write(item);
            }
            Console.Write("\n");
            Array.Sort(a);
            Console.Write("数列排序结果为：");
            foreach (int item in a)
            {
                Console.Write(item);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
