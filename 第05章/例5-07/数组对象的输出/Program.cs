using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组对象的输出
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[4];
            bool[] b = new bool[3];
            object[] c = new object[5];  //object类型可以4字节地址形式存储任意形式的值，默认为空。
            Console.WriteLine("int");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\t a[{0}]={1}", i, a[i]);
            }
            Console.WriteLine("\n bool");
            for (i = 0; i < b.Length; i++)
            {
                Console.WriteLine("\t b[{0}]=" + b[i], i);
            }
            Console.WriteLine("\n object");
            for (i = 0; i < c.Length; i++)
            {
                Console.WriteLine("\t c[{0}]=" + c[i], i);
            }
            _ = Console.ReadKey();
        }
    }
}
