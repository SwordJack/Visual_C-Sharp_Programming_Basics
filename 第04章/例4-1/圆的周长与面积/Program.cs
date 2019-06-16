using System;

namespace 圆的周长与面积
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141;
            double R, C, S;    //R为半径，C为周长，S为面积。
            Console.Write("请输入圆的半径：");
            R = double.Parse(Console.ReadLine());
            C = 2 * PI * R;
            S = PI * R * R;
            Console.WriteLine("圆的周长为{0}，面积为{0}。", C, S);
            Console.ReadKey();
        }
    }
}
