using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch6_5_Ex
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

            //计算十名同学中的最高分和最低分。
            float topScore = score[0], bottomScore = score[0];
            for (int i = 0; i <= score.Length - 1; i++)
            {
                if (score[i] > topScore) topScore = score[i];
                if (score[i] < bottomScore) bottomScore = score[i];
            }
            Console.WriteLine("{0}位同学中最高分为{1}，最低分为{2}，平均分为{3}。", n, topScore, bottomScore, (sum / score.Length));
            Console.ReadKey();
        }
    }
}
