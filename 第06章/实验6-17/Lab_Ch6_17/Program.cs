using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[26];
            Console.WriteLine("请输入一行英语字符串：");
            string s = Console.ReadLine();
            s = s.ToUpper();
            foreach (char letter in s)  //遍历字符串s中的每一个字符。
            {
                if(letter >= 'A' && letter <= 'Z')
                {
                    count[Convert.ToInt32(letter) - 65]++;  //“A”在ASCII码中对应序号为65。
                }
            }

            Console.WriteLine("各个字母出现的次数为：");
            for (int i = 0; i < count.Length; i++)
            {
                Console.Write("{0}：{1}次  ", Convert.ToChar(i + 65), count[i]);
            }

            Console.ReadKey();
        }
    }
}
