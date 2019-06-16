using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_8_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串整数数组，用英语逗号“,”分隔：");
            string[] arrType = (Console.ReadLine()).Split(',');
            int[] arrInput = new int[arrType.Length];                       //这里进行了一下优化，输入的数组不必限定在十个，而是可以任意正整数个数。
            for (int i = 0; i < arrType.Length; i++)
            {
                arrInput[i] = int.Parse(arrType[i]);
            }

            Console.Write("冒泡排序之前的数组为：");
            for (int i = 0; i <= arrInput.Length - 1; i++)
            {
                if (i <= arrInput.Length - 2)
                {
                    Console.Write(arrInput[i] + "、");
                }
                else Console.WriteLine(arrInput[i] + "。");
            }

            ArrayBubble(arrInput);

            Console.ReadKey();
        }

        private static void ArrayBubble(int[] arrBubble)
        {
            //进行冒泡排序。
            for (int i = 1; i <= arrBubble.Length - 1; i++)
            {
                for (int j = 0; j <= arrBubble.Length - 1 - i; j++)
                {
                    if (arrBubble[j] < arrBubble[j + 1])
                    {
                        arrBubble[j] = arrBubble[j + 1] + arrBubble[j];
                        arrBubble[j + 1] = arrBubble[j] - arrBubble[j + 1];
                        arrBubble[j] -= arrBubble[j + 1];
                    }
                }
            }

            //输出冒泡排序法排序后的数组。
            Console.Write("冒泡排序得到的数组为：");
            for (int i = 0; i <= arrBubble.Length - 1; i++)
            {
                if (i <= arrBubble.Length - 2)
                {
                    Console.Write(arrBubble[i] + "、");
                }
                else Console.WriteLine(arrBubble[i] + "。");
            }
        }

    }
}
