using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入学生人数：");
            int n = int.Parse(Console.ReadLine());
            float[] score = new float[n];
            float sum = 0;

            for (int i = 0; i <= score.Length - 1; i++)
            {
                Console.Write("请输入第{0}位学生的成绩：", i + 1);
                score[i] = int.Parse(Console.ReadLine());
                sum += score[i];
            }

            if (n >= 2)
            {
                int numA = 0, numB = 0;
                float sumA = 0, sumB = 0;
                for (int i = 0; i <= score.Length - 1; i++)
                {
                    if (score[i] >= (sum / score.Length))
                    {
                        numA++;
                        sumA += score[i];
                    }
                    else
                    {
                        numB++;
                        sumB += score[i];
                    }
                  
                }
                Console.WriteLine("{0}位同学总分为{1}，平均分为{2}；\nA档学生{3}人，平均分{4}分，与总平均分差值为{5}分；\nB档学生{6}人，平均分{7}分，与总平均分差值为{8}。", n, sum, (sum / score.Length), numA, (sumA / numA), ((sumA / numA) - (sum / score.Length)), numB, (sumB / numB), ((sumB / numB) - (sum / score.Length)));
            }
            else
            {
                Console.WriteLine("{0}位同学总分为{1}，平均分为{2}；人数过少，没有划档意义。", n, sum, (sum / score.Length));
            }
            Console.ReadKey();
        }
    }
}
