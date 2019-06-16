using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = new int[10];
            Random rd = new Random();
            int randomProducer;
            for (int n = 0; n < arrInput.Length; n++)
            {
                //通过死循环反复生成新的随机数。
                while (true)
                {
                    randomProducer = rd.Next(50);
                    bool judgeDifference = true;

                    //遍历arrInput数组进行查重。
                    foreach (int x in arrInput)
                    {
                        if (randomProducer == x)
                        {
                            //如果遇到相同的值，则跳出循环，重新生成随机数。
                            judgeDifference = false;
                            break;
                        }
                    }
                    if (judgeDifference) break;
                }

                arrInput[n] = randomProducer;
            }

            //输出一次输入的数组。
            Console.Write("输入的数组为：");
            for (int i = 0; i <= arrInput.Length - 1; i++)
            {
                if (i <= arrInput.Length - 2)
                {
                    Console.Write(arrInput[i] + "、");
                }
                else Console.WriteLine(arrInput[i] + "。");
            }

            //冒泡排序法将数列从小到大排列。
            ArrayBubble(arrInput);

            Console.ReadKey();
        }

        private static void ArrayBubble(int[] arrBubble)  //这亦是一个本人之前造好的函数，在此直接引用之。
        {
            //进行冒泡排序。
            for (int i = 1; i <= arrBubble.Length - 1; i++)
            {
                for (int j = 0; j <= arrBubble.Length - 1 - i; j++)
                {
                    if (arrBubble[j] > arrBubble[j + 1])
                    {
                        arrBubble[j] = arrBubble[j + 1] + arrBubble[j];
                        arrBubble[j + 1] = arrBubble[j] - arrBubble[j + 1];
                        arrBubble[j] -= arrBubble[j + 1];
                    }
                }

                //输出选择排序法排序后的数组。
                Console.Write("第{0}轮冒泡排序得到的数组为：", i);
                for (int j = 0; j <= arrBubble.Length - 1; j++)
                {
                    if (j <= arrBubble.Length - 2)
                    {
                        Console.Write(arrBubble[j] + "、");
                    }
                    else Console.WriteLine(arrBubble[j] + "。");
                }

            }
        }
    }
}
