﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, m1, m2, n = 0;
            Console.WriteLine("水仙花数：");
            for(i = 1; i <= 9; i++)
                for(j = 0; j <= 9; j++)
                    for (k = 0; k <= 9; k++)
                    {
                        m1 = i * 100 + j * 10 + k;
                        m2 = i * i * i + j * j * j + k * k * k;
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
