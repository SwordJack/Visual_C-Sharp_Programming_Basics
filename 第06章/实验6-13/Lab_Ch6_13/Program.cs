using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] score = { 81, 77, 74, 71, 78, 80, 85, 87, 69, 87, 98, 52, 66, 84, 48, 96, 95, 67, 89, 92 };
            double sumScore = 0, avgScore;
            Console.Write("{0}名同学的成绩依次为：", score.Length);
            foreach (double x in score)
            {
                Console.Write("{0,3}", x);
                sumScore += x;
            }
            Console.WriteLine();
            avgScore = sumScore / score.Length;

            //求标准差。
            double varianceSum = 0, standardDeviation;
            foreach (double x in score)
            {
                varianceSum += Math.Pow((x - avgScore), 2);
            }
            standardDeviation = Math.Pow((varianceSum / (score.Length - 1)), 0.5);  //自由度 = 测试次数 - 1。
            Console.WriteLine("{0}名同学的平均成绩为{1}，成绩标准差为{2}。", score.Length, Math.Round(avgScore, 3), Math.Round(standardDeviation, 3));  //将输出值圆整至小数点后三位。

            Console.ReadKey();
        }
    }
}
