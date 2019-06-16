using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出参数传递
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            double ave;

            /* 
             * 在传递的参数前加out，即设置该参数为一个输出参数。输出参数也不开辟新的内存区域，但是输出参数在调用方法前无需对变量进行初始化。
             * 输出型参数用于传递方法返回的数据。
             * out修饰符后应跟随与形参的类型相同的类型声明，在方法返回后，传递的变量被认为已经完成了初始化。
             * 
             * 此例中，ave仅仅被声明，但并未对其赋值，即ave并未被初始化。
             * 如果使用引用传递的方式来传递参数，则需要对ave变量进行初始化，如：double ave = 0;
             */

            CzMath m = new CzMath();
            m.Average(a, b, out ave);
            Console.Write("a与b的平均值为：{0}", ave);

            Console.ReadKey();
        }
    }

    class CzMath
    {
        public void Average(int x, int y, out double z)
        {
            z = Convert.ToDouble((x + y) / 2);
        }
    }
}
