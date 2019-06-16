using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求数组中最大_小_值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 3, 5, 7, 9 };
            int max = numbers[0];
            int min = numbers[0];
            Console.Write("The Contents of Arraylis: ");
            foreach (int item in numbers)
            {
                Console.Write("{0}\t", item);
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < max)
                    min = numbers[i];
            }
            Console.WriteLine("\nThe Largest Number is {0}", max);
            Console.WriteLine("The Smallest Number is {0}", min);
            Console.ReadKey();
        }
    }
}
