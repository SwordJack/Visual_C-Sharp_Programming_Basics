using System;
using System.IO;

namespace 流的文本读写器
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"Myfile.txt");
            Console.WriteLine("是否可读取：{0}", sr.BaseStream.CanRead);  //True：打开了StreamReader，所以可以进行“读”操作。
            Console.WriteLine("是否可写入：{0}", sr.BaseStream.CanWrite); //False：由于打开了StreamReader而非StreamWriter，不能够进行“写”操作。
            sr.Close();

            StreamWriter sw = new StreamWriter(@"Myfile.txt");
            Console.WriteLine("是否可读取：{0}", sw.BaseStream.CanRead);  //False：由于打开了StreamWriter而非StreamReader，不能够进行“读”操作，StreamWriter不包含进行“读”操作的功能。
            Console.WriteLine("是否可写入：{0}", sw.BaseStream.CanWrite); //True：打开了StreamWriter，能够进行“写”操作。
            sw.Close();

            Console.ReadKey();
        }
    }
}
