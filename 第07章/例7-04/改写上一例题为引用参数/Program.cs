using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 改写上一例题为引用参数
{
    class FormalParameters  //中文名：形式参数。
    {
        static void Main(string[] args)
        {
            double a = 100, b = 150;
            CzMath c = new CzMath();

            Console.WriteLine("调用方法前：a={0}，b={1}", a, b);
            c.Swap(ref a, ref b);
            Console.WriteLine("调用方法后：a={0}，b={1}", a, b);

            /*
             * “引用传递”是指实参传递给形参时，不是将实参的值复制给形参，而是将实参的引用传递给形参，实参与形参使用的是同一个内存位置中的值；
             * 这种参数传递的特点是：形参发生改变时，实参也随之改变；
             * 引用参数通过ref修饰符使得编译器知道，实参与形参之间的传递方式是“引用传递”。
             *
             * 注：“类”对象的参数（类的字段）总是按照引用传递的，所以类对象参数传递不需要使用ref关键字。
             */

            Console.ReadKey();
        }
    }

    class CzMath
    {
        //交换两个数的值。
        public void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
