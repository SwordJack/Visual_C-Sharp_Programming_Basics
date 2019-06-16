using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算折叠次数
{
    class Program
    {
        static void Main(string[] args)
        {
            //设有一张纸厚度为h毫米、面积足够大的纸张，将它不断地对折。试问对折多少次后，其厚度可以达到珠穆朗玛峰的高度（8844.43米）？
            int n = 0;
            double h;
            Console.Write("请输入纸张厚度（单位：mm）：");
            h = double.Parse(Console.ReadLine());
            while (h < 8844430)
            {
                n++;
                h *= 2;
            }
            Console.WriteLine("答：需要折叠{0}次", n);
            Console.ReadKey();
        }
    }
}
