using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue语句输出5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i < 5)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
