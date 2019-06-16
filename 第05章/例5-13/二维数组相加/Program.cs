using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二维数组相加
{
    class Program
    {
        static void Main(string[] args)
        {
            IIArray var = new IIArray();
            var.AcceptValue();
            var.AddValue();
            var.DisplayValue();
            Console.ReadKey();
        }
    }

    class IIArray
    {
        int[,] aArray = new int[3, 3];
        int[,] bArray = new int[3, 3];
        int[,] cArray = new int[3, 3];
        public void AcceptValue()  //接受输入值。
        {
            //录入数组a。
            Console.WriteLine("请输入数组a：");
            for (int i = 0; i < aArray.GetLength(0); i++)
            {
                for (int j = 0; j < aArray.GetLength(1); j++)
                {
                    aArray[i, j] = int.Parse(Console.ReadLine());
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //录入数组b。
            Console.WriteLine("请输入数组b：");
            for (int i = 0; i < bArray.GetLength(0); i++)
            {
                for (int j = 0; j < bArray.GetLength(1); j++)
                {
                    bArray[i, j] = int.Parse(Console.ReadLine());
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        
        public void AddValue()  //进行求和计算。
        { 
            //将数组a、b相加的结果放入数组c中的对应位置。
            for (int i = 0; i < cArray.GetLength(0); i++)
            {
                for (int j = 0; j < bArray.GetLength(1); j++)
                {
                    cArray[i, j] = aArray[i, j] + bArray[i, j];
                }
            }
        }

        public void DisplayValue()  //输出计算结果。
        {
            for (int i = 0; i < cArray.GetLength(0); i++)
            {
                for (int j = 0; j < bArray.GetLength(1); j++)
                {
                    Console.Write("{0,3}", cArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
