using System;
using System.IO;

namespace 当前目录下所有文件的时间信息
{
    class FileSample
    {
        static void Main(string[] args)
        {
            string sPath;
            if (args.Length == 0)
                sPath = Directory.GetCurrentDirectory();
            else                
                sPath = args[0];
            Console.WriteLine("路径：{0}", sPath);
            try
            {
                ShowFileDetail(sPath);
            }
            catch(Exception exc)
            {
                Console.WriteLine("访问出现错误！\n{0}", exc);
                throw;
            }

            Console.ReadKey();
        }

        //
        //获取文件详细信息。
        //
        public static void ShowFileDetail(string sPath)
        {
            string[] files = Directory.GetFiles(sPath);     //获取文件夹下的所有文件的绝对路径，组成字符串数组。
            foreach (string sFile in files)                 //对每一个文件及其路径进行操作。
            {
                //Console.WriteLine(sFile);                   //将显示文件的绝对路径。
                Console.WriteLine(GetRelativeName(sFile));
                Console.WriteLine("{0}创建，{1}访问，{2}修改；", File.GetCreationTime(sFile), File.GetLastAccessTime(sFile), File.GetLastWriteTime(sFile));
            }
        }

        //
        //获取文件相对路径。
        //
        public static string GetRelativeName(string sPath)
        {
            int pos;                                        //声明一个整数pos；
            for (pos = sPath.Length - 1; pos > 0; pos--)    //从路径的最后一位开始，向前检索，读到“\”分隔符时停止，并记下此时的pos值。
            {
                if (sPath[pos] == '\\')
                    break;
            }
            if (pos == sPath.Length - 1)                    //最后一位为“\”分隔符时发生；
            {
                return sPath;                               //返回完整路径。
            }
            else
                return sPath.Substring(pos + 1, sPath.Length - pos - 1);    //最后一位不为“\”，返回“\”之后的内容。
        }
    }
}
