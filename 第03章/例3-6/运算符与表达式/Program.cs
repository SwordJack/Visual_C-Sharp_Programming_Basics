using System;

namespace 运算符与表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int series = 0;

            //测试1：四则运算与求余运算。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：四则运算与求余运算");
            ModOperation();

            //测试2：字符串运算符与字符串表达式。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：字符串运算符与字符串表达式");
            StringOperation();

            //测试3：关系、逻辑运算符与表达式。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：关系、逻辑运算符与表达式");
            RelationAndLogicOperation();

            //测试4：条件、赋值运算符与表达式。
            Console.WriteLine("");
            Console.WriteLine("测试" + ++series + "：条件、赋值运算符与表达式");
            ConditionalAndAssignmentOperation();

            //测试结束。
            Console.WriteLine("");
            Console.WriteLine("测试结束。");
            Console.ReadKey();
        }

        private static void ModOperation()
        {
            Console.WriteLine("5%2结果为" + (5 % 2));
            Console.WriteLine("-5%2结果为" + (-5 % 2));
            Console.WriteLine("5.0%2.2结果为" + (5.0 % 2.2));
            Console.WriteLine("-5.2%2.0结果为" + (-5.2 % 2.0));
        }

        private static void StringOperation()
        {
            string connec = "abcd" + "ef";
            Console.WriteLine(connec);
            connec = "这是什么？" + '我' + '不' + '会' + '！';
            Console.WriteLine(connec);
        }

        private static void RelationAndLogicOperation()
        {
            double a = 3, b = 5, c = 2;
            Console.WriteLine("a=" + a + "，b=" + b + "，c=" + c);
            Console.WriteLine("a > b 的运算结果为" + (a > b));
            Console.WriteLine("a > c 的运算结果为" + (a > c));
            Console.WriteLine("a > b && a > c 的运算结果为" + (a > b && a > c));    //“&&”为“与”运算，二元运算符，两个操作数只要有一个为“false”，结果即为“true”。
            Console.WriteLine("a > b || a > c 的运算结果为" + (a > b || a > c));    //“||”为“或”运算，二元运算符，两个操作数只要有一个为“true”，结果即为“true”。
            Console.WriteLine("!(a > b) 的运算结果为" + !(a > b));                  //“!”为“非”运算，一元运算符，如果操作数为非零，则其逻辑“非”为“false”，否则为“true”。
        }

        private static void ConditionalAndAssignmentOperation()
        {
            Console.WriteLine("第（1）部分：");
            Console.WriteLine("请输入一个数。注意，若输入内容不为数字，程序会出现故障。");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            double judge = x > 0 ? x : -x;
            Console.WriteLine("经过处理后，输出的数值为" + judge);
            Console.WriteLine("");
            Console.WriteLine("第（2）部分：");
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";
            Console.WriteLine("字符串1为“" + s1 + "”，字符串2为“" + s2 + "”，\n" + "s1与s2相加的结果为“" + (s1 += s2) + "”");    //字符串运算符只有一个“+”，表示将两个字符串连接起来。
        }
    }
}
