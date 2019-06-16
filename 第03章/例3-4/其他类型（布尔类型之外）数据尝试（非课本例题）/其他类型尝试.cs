using System;

namespace 其他类型_布尔类型之外_数据尝试_非课本例题_
{
    class 其他类型尝试
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("人的认识水平的提高必须经历“实践——认识——再实践——再认识”的过程。");
            Console.WriteLine("现在测试开始。");
            int series = 0;    //第series项测试。

            //测试1。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：int型整型变量。");    // ++series 等于  series+1
            int a = 1;    //int为有符号32位整数，范围：-2^31 ～ (2^31 - 1)
            IntegarVariable(a);

            //测试2。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：双精度实数变量。");
            double b = 1949.10;    //double为双精度实数变量，范围：5.0×10E-324 ～ 1.7×10E308
            DoubleVariable(b);

            //测试3
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：字符变量。");
            char c = '习';
            CharVariable(c);

            //测试结束。
            Console.WriteLine("");
            Console.WriteLine("测试结束。");
            Console.ReadKey();
        }

        private static void IntegarVariable(int a1)
        {
            Console.WriteLine("a1=" + a1);
            Console.WriteLine("a2=" + ++a1);
        }

        private static void DoubleVariable(double b0)
        {
            Console.WriteLine("b1=" + (b0 % 2));
            Console.WriteLine("b2=" + (b0 / 2));
        }

        private static void CharVariable(char c0)
        {
            char c1 = '是';
            Console.WriteLine("学{0}科学文化知识{1}很重要的。",c0,c1);
        }
    }
}
