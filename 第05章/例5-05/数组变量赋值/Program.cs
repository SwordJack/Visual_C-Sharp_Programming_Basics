using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组变量赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];  //用new运算符建立一个3个元素的一维数组。
            for (int i = 0; i < arr.Length; i++)
                                     //arr.Length是数组类变量，表示数组元素个数。
                arr[i] = i * i;      //数组元素初赋值，arr[i]表示第i个元素的值。
            for (int i = 0; i < arr.Length; i++)  //数组第一个元素的下标为0。
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);

            Console.ReadKey();
        }
    }
}
