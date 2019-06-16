using System;
using System.IO;

namespace 文件流的写入
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件流。
            FileStream fs = new FileStream(@"Myfile.txt", FileMode.Create); //创建一个文件流。
            
            //将字符串内容存入缓冲区。
            string str = "Do you hear the people sing?";
            byte[] buffer = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                buffer[i] = (byte)str[i];
            }

            //将缓冲区内容写入文件流。
            fs.Write(buffer, 0, buffer.Length);     //.Write(数据缓冲区（数组形式）, 缓冲区字节偏移量（从第几位开始写入）, 写入的长度)

            string msg = "";

            //定位到流开始的位置。
            fs.Seek(0, SeekOrigin.Begin);

            //读取流中的前若干字符，这里设置为12。
            for (int i = 0; i < 12; i++)
            {
                msg += Convert.ToChar(fs.ReadByte());
            }

            //显示读取的信息和流的长度。
            Console.WriteLine("读取内容为：{0}；", msg);
            Console.WriteLine("文件长度为：{0}。", fs.Length);

            //关闭文件流。
            fs.Close();

            Console.ReadKey();
        }
    }
}
