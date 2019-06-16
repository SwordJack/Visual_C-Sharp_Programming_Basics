using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 月份号码对应月份英文名称
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int getUserWrite;
            Console.Write("请输入数字（月）：");
            getUserWrite = int.Parse(Console.ReadLine());
            switch ( getUserWrite )
            {
                case 1:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[0]);
                    break;
                case 2:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[1]);
                    break;
                case 3:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[2]);
                    break;
                case 4:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[3]);
                    break;
                case 5:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[4]);
                    break;
                case 6:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[5]);
                    break;
                case 7:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[6]);
                    break;
                case 8:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[7]);
                    break;
                case 9:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[8]);
                    break;
                case 10:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[9]);
                    break;
                case 11:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[10]);
                    break;
                case 12:
                    Console.WriteLine("该月份的英文名称为：{0}", Month[11]);
                    break;
                default:
                    Console.WriteLine("输入项不合法（输入的值应为1～12之间的整数。");
                    break;
            }

            Console.ReadKey();
        }
    }
}
