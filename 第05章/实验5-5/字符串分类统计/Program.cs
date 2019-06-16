using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char c;
            int nDigit = 0, nLetter = 0, nOther = 0;
            for (int i = 0; i < str.Length; i++)
            { 
                c = Convert.ToChar(str.Substring(i, 1));
                if (Char.IsDigit(c))
                    nDigit++;
                else if (Char.IsLetter(c))
                    nLetter++;
                else nOther++;
            }
            Console.WriteLine("字符串中数字：{0}，字母个数：{1}，其他字符数：{2}。", nDigit, nLetter, nOther);
            Console.Write("（按任意键退出……）");
            Console.ReadKey();
        }
    }
}
