using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            F(a);
            F(10, 20, 30, 40);
            F();

            /*
             * 方法的参数类型可以是数组。
             * 如果在形参前面加上关键字 params，该形参就成为了参数数组。
             * C-sharp开发语言中 params 是关键字，可以指定在参数数目可变处采用参数的方法参数。在函数的参数数目可变而执行的代码差异很小的时候很有用！
             * 在方法声明中的 params 关键字之后不允许任何其他参数，并且在方法声明中只允许一个 params 关键字。
             * 关于参数数组，需要注意以下几点。
             * （1）若形参表中含一个参数数组，则该参数数组必须位于形参列表的最后；
             * （2）参数数组必须是一维数组；
             * （3）不允许将params修饰符与ref和out修饰符组合起来使用；
             * （4）与参数数组对应的实参可以是同一类型的数组名，也可以是任意多个与该数组的元素属于同一类型的变量；
             * （5）若实参是数组则按引用传递，若实参是变量或表达式则按值传递。
             */

            Console.ReadKey();
        }

        static void F(params int[] args)  //params是parameter（参数）的简称，作为关键字放在数组类型形参前，即表示参数数组。
        {
            Console.WriteLine("数组含有{0}个元素。", args.Length);
            foreach(int i in args)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
