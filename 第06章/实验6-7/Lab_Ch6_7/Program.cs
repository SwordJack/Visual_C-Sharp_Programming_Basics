using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用随机数输入十个数字于数组。
            int[] arrInput = new int[10];
            Random rd = new Random();
            int randomProducer;
            for (int n = 0; n < arrInput.Length; n++)
            {
                //通过死循环反复生成新的随机数。
                while (true)
                {
                    randomProducer = rd.Next(100);
                    bool judgeDifference = true;

                    //遍历arrInput数组进行查重。
                    foreach(int x in arrInput)
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

            //选择排序法将数列从小到大排列。
            ArraySelect(arrInput);

            Console.ReadKey();
        }

        private static void ArraySelect(int[] arrSelect)
        {
            //进行选择排序。
            for (int i = 0; i <= arrSelect.Length - 2; i++)
            {
                //先假定第i项数是第i项起最小的一项，如果在其后检索到比它更小的数，则将min变量的值改成那一项的下标（索引）值。
                int min = i;
                for (int j = i + 1; j <= arrSelect.Length - 1; j++)
                {
                    if (arrSelect[min] > arrSelect[j])
                    {
                        min = j;
                    }
                }

                if (min != i)    //若不设置这一判断，会使得当“min == i”成立的时候，arrSelect[min]的值变成0。
                {
                    arrSelect[i] = arrSelect[i] + arrSelect[min];
                    arrSelect[min] = arrSelect[i] - arrSelect[min];
                    arrSelect[i] = arrSelect[i] - arrSelect[min];
                }

                //输出选择排序法排序后的数组。
                Console.Write("第{0}轮选择排序得到的数组为：", i + 1);
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
}
