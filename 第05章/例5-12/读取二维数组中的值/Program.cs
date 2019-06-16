using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 读取二维数组中的值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < array2D.GetLength(0); i++)  //GetLength(0)，获取第0维的长度，即“行数”。
            {
                for (int j = 0; j < array2D.GetLength(1); j++)  //GetLength(1)，获取第1维的长度，即“列数”。
                {
                    Console.Write("{0,2}", array2D[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
