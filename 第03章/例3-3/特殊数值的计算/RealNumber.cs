using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 特殊数值的计算
{
    class RealNumber
    {
        static void Main(string[] args)
        {
            float f = System.Single.PositiveInfinity;
            SpecialRealValue(f);    //个人理解，此段语句是指，在上一步“f”被赋值之后，执行“SpecialRealNumber()”函数，函数执行完毕后再返回执行下一行语句。
            f = System.Single.NegativeInfinity;
            SpecialRealValue(f);
            f = System.Single.NaN;
            SpecialRealValue(f);
        }

        private static void SpecialRealValue(float f1)
        {
            float f2 = -1 * f1;
            double d1 = 1 / f1;
            double d2 = -1 / d1;
            Console.WriteLine("-1 * {0} = {1}", f1, f2);
            Console.WriteLine("-1 / {0} = {1}", f1, d1);
            Console.WriteLine("-1 / {0} = {1}", d1, d2);
        }
    }
}
