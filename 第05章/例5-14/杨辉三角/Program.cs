using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 杨辉三角
/*
 * 杨辉三角，是二项式系数在三角形中的一种几何排列，中国南宋数学家杨辉1261年所著的《详解九章算法》一书中出现。
 * 在欧洲，帕斯卡（1623----1662）在1654年发现这一规律，所以这个表又叫做帕斯卡三角形。帕斯卡的发现比杨辉要迟393年，比贾宪迟600年。
 * 杨辉三角是中国数学史上的一个伟大成就。
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("你希望输出多少行杨辉三角（请输入大于0的整数）：");
            int cols = int.Parse(Console.ReadLine());
            int[,] tri = new int[cols, cols];
            tri[0, 0] = 1;  //先将第0行、第0列的数组元素的值设为1。

            //计算杨辉三角，从第1行开始。
            for (int i = 1; i < cols; i++)
            {
                //每行第0个元素的值先设置为1。
                tri[i, 0] = 1;
                for (int j = 1; j <= i; j++)
                {
                    //由于输出的是直角三角形形式的杨辉三角，所以每一个元素等于其上方和左上方的元素值的和。
                    tri[i, j] = tri[i - 1, j - 1] + tri[i - 1, j];
                }
            }

            //将数组遍历、输出。
            for (int i = 0; i < cols; i++)
            {                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0,4}", tri[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
