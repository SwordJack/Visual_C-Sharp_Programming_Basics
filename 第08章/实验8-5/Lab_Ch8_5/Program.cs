using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;

            Power.MyPower(a, b);            //值传递，不改变原来的值。
            Console.WriteLine("a = {0}，b = {1}；", a, b);
            Console.WriteLine();

            Power.MyPower(ref a, ref b);    //引用传递，会改变原来的值。
            Console.WriteLine("a = {0}，b = {1}；", a, b);

            Console.ReadKey();
        }
    }

    public class Power
    {
        public static void MyPower(int x, int y)
        {
            x = 1; y = 2;
            Console.WriteLine("x = {0}，y = {1}；", x, y);
            Console.WriteLine("x^2 = {0}, y^2 = {1}", Math.Pow(x, 2), Math.Pow(y, 2));
        }

        public static void MyPower(ref int x, ref int y)
        {
            x = 1; y = 2;
            Console.WriteLine("x = {0}，y = {1}；", x, y);
            Console.WriteLine("x^2 = {0}, y^2 = {1}", Math.Pow(x, 2), Math.Pow(y, 2));
        }
    }
}
