using System;

namespace C_sharp程序结构
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = 9 * 6;
            int thirteen;
            thirteen = 13;
            Console.WriteLine(result / thirteen);
            Console.WriteLine(result % thirteen);
            Console.ReadKey();    //非主要代码，起到使程序暂停的作用。
        }
    }
}
