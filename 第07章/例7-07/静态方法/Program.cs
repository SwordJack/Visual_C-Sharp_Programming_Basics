using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态方法
{
    class FormalParameters  //中文名：形式参数。
    {
        static void Main(string[] args)
        {
            double a = 100, b = 150;

            Console.WriteLine("调用方法前：a={0}，b={1}", a, b);
            CzMath.Swap(ref a, ref b);
            Console.WriteLine("调用方法后：a={0}，b={1}", a, b);
            
            Console.ReadKey();
        }
    }

    class CzMath
    {
        //交换两个数的值。
        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
