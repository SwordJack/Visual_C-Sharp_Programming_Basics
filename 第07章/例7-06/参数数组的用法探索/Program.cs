using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数数组的用法探索
{
    class Program
    {
        static void Main(string[] args)
        {
            //区块一
            F(10, 20, 30, 40);      //四个实参中，第一个赋值为形参中的x，后三个赋值给形参中的参数数组。


            {  
                //区块二
                int[] arrInput = { 1, 2, 3, 4 };
                int a1 = 1, a2 = 2, a3 = 3, a4 = 4;

                //以数组作为实参，实践证明，其进行引用传递。
                Console.WriteLine("调用G方法前的数组arrInput：");
                foreach (int i in arrInput)
                    Console.Write("{0} ", i);
                Console.WriteLine();
                G(arrInput);            
                Console.WriteLine("调用G方法后的数组arrInput：");
                foreach (int i in arrInput)
                    Console.Write("{0} ", i);
                Console.WriteLine();

                //以变量作为实参，实践证明，其进行值传递。
                Console.WriteLine("调用G方法前的a1～a4：{0}、{1}、{2}、{3}", a1, a2, a3, a4);
                G(a1, a2, a3, a4);      
                Console.WriteLine("调用G方法后的a1～a4：{0}、{1}、{2}、{3}", a1, a2, a3, a4);

                Console.ReadKey();
            }
        }

        static void F(int x, params int[] args)
        {
            Console.WriteLine("赋给F的参数数组含有{0}个元素。", args.Length);
            foreach (int i in args)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void G(params int[] args)
        {
            Console.WriteLine("赋给G的数组含有{0}个元素。", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                args[i]++;
                Console.Write(args[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
