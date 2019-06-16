using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch5_4_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, m1, m2, n = 0;
            Console.WriteLine("玫瑰花数：");
            for (i = 1; i <= 9; i++)
                for (j = 0; j <= 9; j++)
                    for (k = 0; k <= 9; k++)
                        for (l = 0; l <= 9; l++)
                    {
                        m1 = i * 1000 + j * 100 + k * 10 + l;
                        m2 = i * i * i * i + j * j * j * j + k * k * k * k + l * l * l * l;
                        if (m1 == m2)
                        {
                            Console.WriteLine(m1);
                            n++;
                        }
                    }
            Console.Write("共有{0}个。", n);
            Console.ReadKey();
        }
    }
}
