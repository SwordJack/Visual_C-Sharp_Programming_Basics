using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_13_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] scoreA = { 10.4, 10.6, 10.7, 10.6, 10.7, 10.5, 11, 10.4, 10.5, 10.4 };
            double[] scoreB = { 10.6, 10.5, 10.8, 11.1, 10.6, 10.4, 10.3, 10.4, 10.5, 10.6 };
            double sumScoreA = 0, avgScoreA;
            double sumScoreB = 0, avgScoreB;

            Console.Write("甲同学的成绩为：", scoreA.Length);
            foreach (double x in scoreA)
            {
                Console.Write("{0,-5}", Math.Round(x, 1));
                sumScoreA += x;
            }
            Console.WriteLine();
            avgScoreA = sumScoreA / scoreA.Length;

            Console.Write("乙同学的成绩为：", scoreB.Length);
            foreach (double x in scoreB)
            {
                Console.Write("{0,-5}", Math.Round(x, 1));
                sumScoreB += x;
            }
            Console.WriteLine();
            avgScoreB = sumScoreB / scoreB.Length;


            //求标准差。
            double varianceSumA = 0, standardDeviationA;
            foreach (double x in scoreA)
            {
                varianceSumA += Math.Pow((x - avgScoreA), 2);
            }
            standardDeviationA = Math.Pow((varianceSumA / (scoreA.Length - 1)), 0.5);  //自由度 = 测试次数 - 1。
            Console.WriteLine("甲同学的平均成绩为{1}，成绩标准差为{2}。", scoreA.Length, Math.Round(avgScoreA, 4), Math.Round(standardDeviationA, 4));  //将输出值圆整至小数点后四位。

            double varianceSumB = 0, standardDeviationB;
            foreach (double x in scoreB)
            {
                varianceSumB += Math.Pow((x - avgScoreB), 2);
            }
            standardDeviationB = Math.Pow((varianceSumB / (scoreB.Length - 1)), 0.5);  //自由度 = 测试次数 - 1。
            Console.WriteLine("乙同学的平均成绩为{1}，成绩标准差为{2}。", scoreB.Length, Math.Round(avgScoreB, 4), Math.Round(standardDeviationB, 4));  //将输出值圆整至小数点后四位。


            //选拔两位同学中平均用时较低者，如果平均用时相等，则选拔成绩较稳定者。
            if (Math.Round(avgScoreA, 4) < Math.Round(avgScoreB, 4)) Console.WriteLine("甲同学成绩较好，选拔甲同学。");
            else if (Math.Round(avgScoreA, 4) > Math.Round(avgScoreB, 4)) Console.WriteLine("乙同学成绩较好，选拔乙同学。");
            else
            {
                if (standardDeviationA < standardDeviationB) Console.WriteLine("甲同学发挥稳定，选拔甲同学。");
                else if (standardDeviationA > standardDeviationB) Console.WriteLine("乙同学发挥稳定，选拔乙同学。");
                else Console.WriteLine("甲、乙两位同学旗鼓相当！");
            }

            Console.ReadKey();
        }
    }
}
