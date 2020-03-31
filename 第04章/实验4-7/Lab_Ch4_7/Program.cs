using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = b = c = 0;
            try
            {
                Console.Write("请输入线段a的长度："); a = double.Parse(Console.ReadLine());
                Console.Write("请输入线段b的长度："); b = double.Parse(Console.ReadLine());
                Console.Write("请输入线段c的长度："); c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("运行异常，检查输入内容并重新运行程序。");
            }
            double aSquare = Math.Pow(a, 2);
            double bSquare = Math.Pow(b, 2);
            double cSquare = Math.Pow(c, 2);
            if (a + b > c && b + c > a && c + a > b)
            {
                double p = (a + b + c) / 2;     //半周长。
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  //海伦公式求面积。
                Console.Write($"三角形面积为{s}，该三角形是");
                if (a == b || b == c || c == a)     //有否两条边相等。
                {
                    if (a == b && b == c)   //是否三条边相等。
                    {
                        Console.WriteLine("等边三角形。");
                    }
                    else if (aSquare + bSquare == cSquare   //有否符合勾股定理。
                        || bSquare + cSquare == aSquare
                        || cSquare + aSquare == bSquare)
                    {
                        Console.WriteLine("等腰直角三角形。");
                    }
                    else
                    {
                        Console.WriteLine("等腰三角形。");
                    }
                }
                else if (aSquare + bSquare == cSquare   //有否符合勾股定理。
                       || bSquare + cSquare == aSquare
                       || cSquare + aSquare == bSquare)
                {
                    Console.WriteLine("直角三角形。");
                }
                else
                {
                    Console.WriteLine("普通三角形。");
                }
            }
            else
            {
                Console.WriteLine("不能构成三角形。");
            }
            Console.ReadKey();
        }
    }
}
