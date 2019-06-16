using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四种字段的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Test T1 = new Test(100, 200);
            T1.x = 40;                          //引用实例字段的方式：“实例名.实例字段名”。
            Test.cnt = 0;                       //引用静态字段的方式：“类名.静态字段名”。
            int z = T1.y;                       //引用只读字段。
            Console.WriteLine("T1.x = {0}，T1.y = {1}，z = {2}", T1.x, T1.y, z);

            z = Test.intMax;                    //引用常量。
            Console.WriteLine("T1.x = {0}，T1.y = {1}，z = {2}",T1.x, T1.y, z);

            Console.ReadKey();
        }
    }

    public class Test
    {
        public const int intMax = int.MaxValue; //常量，必须赋初值，此处设置为int类的最大值。
        public int x = 0;                       //实例字段，属于对象（类的实例）。
        public readonly int y = 0;              //只读字段，不可修改。
        public static int cnt = 0;              //静态字段，属于类。

        public Test(int xInput, int yInput)
        {
            //intMax = 0;                         //常量不可修改。如果取消注释，则报错。
            x = xInput;                         //修改实例字段。
            y = yInput;                         //只允许在构造函数修改只读字段。
            cnt++;                              //属于类的静态字段。此语句可用于记录构造的类的实例对象的个数。
        }

        public void Modify(int xInput, int yInput)
        {
            //intMax = 0;
            x = xInput;
            cnt = yInput;
            //y = 10;                               //不允许修改只读字段。
        }
    }
}
