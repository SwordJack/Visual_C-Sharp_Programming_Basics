using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_7_Ex
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

            Console.Write("选择排序之前的数组为：");
            for (int i = 0; i <= arrInput.Length - 1; i++)
            {
                if (i <= arrInput.Length - 2)
                {
                    Console.Write(arrInput[i] + "、");
                }
                else Console.WriteLine(arrInput[i] + "。");
            }

            ArraySelect(arrInput);

            Console.ReadKey();
        }

        private static void ArraySelect(int[] arrSelect)  //直接复制该函数，不必重新造轮子。
        {
            for (int i = 0; i <= arrSelect.Length - 2; i++)
            {
                //将之前的小于号“<”改为大于号“>”，为了避免歧义，将min变量重命名为max。
                int max = i;
                for (int j = i + 1; j <= arrSelect.Length - 1; j++)
                {
                    if (arrSelect[max] < arrSelect[j])
                    {
                        max = j;
                    }
                }

                if (max != i)
                {
                    arrSelect[i] = arrSelect[i] + arrSelect[max];
                    arrSelect[max] = arrSelect[i] - arrSelect[max];
                    arrSelect[i] = arrSelect[i] - arrSelect[max];
                }
            }

            
            Console.Write("选择排序得到的数组为：");
            for (int j = 0; j <= arrSelect.Length - 1; j++)
            {
                if (j <= arrSelect.Length - 2)
                {
                    Console.Write(arrSelect[j] + "、");
                }
                else Console.WriteLine(arrSelect[j] + "。");
            }
        }
    }
}
