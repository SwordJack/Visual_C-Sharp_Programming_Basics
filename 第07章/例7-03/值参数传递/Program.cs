using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值参数传递
{
    class FormalParameters  //中文名：形式参数。
    {
        static void Main(string[] args)
        {
            double a = 100, b = 150;
            CzMath c = new CzMath();

            c.Swap(a, b);
            Console.WriteLine("a={0}，b={1}", a, b);

            /*
             * 在此例题中，方法Swap试图通过一个临时变量交换a和b的值，但是在程序运行后的结果中，a和b并没有发生交换。
             * 这是因为，当调用Swap方法时，首先将主方法Main中定义的变量a和b（实参）进行了一次复制，而后传递给方法的形参，在方法是执行代码中所改变的只是复制的值，而不是实际参数的原始值，因此达不到交换数值的效果。
             * 上面这种传递参数的方式叫做“值传递”，如果希望改变实参的值，则需要使用另一种传递参数的方式：“引用传递”。
             */

            Console.ReadKey();
        }
    }

    class CzMath
    {
        //交换两个数的值。
        public void Swap(double x, double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
