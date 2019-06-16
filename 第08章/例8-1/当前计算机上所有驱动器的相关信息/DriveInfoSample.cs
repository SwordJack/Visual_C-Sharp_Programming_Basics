using System;
using System.IO;

namespace 当前计算机上所有驱动器的相关信息
{
    class DriveInfoSample
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();    //获得当前计算机上所有逻辑驱动器的名称。
            foreach (DriveInfo driver in drivers)
            {
                try
                {
                    ShowDriveInfo(driver);
                }
                catch(System.Security.SecurityException)
                {
                    Console.WriteLine("您不拥有对该驱动器的访问权限。");
                }
                catch(Exception exc)
                {
                    Console.WriteLine("访问意外失败，失败原因：{0}", exc.Message);
                }
            }

            Console.ReadKey();
        }

        //
        //显示驱动器的状态和信息。
        //
        public static void ShowDriveInfo(DriveInfo drv)
        {
            if (drv.IsReady)    //判断驱动器是否准备好。
            {
                Console.WriteLine("驱动器名：{0}（已就绪）", drv.Name);
                //Console.WriteLine("类型：{0}", drv.DriveType);                         //显示为Fixed、CDRom、Removable等。
                Console.WriteLine("类型：{0}", GetTypeDescription(drv.DriveType));     //显示为本地磁盘、CD-ROM、可移动磁盘等。
                Console.WriteLine("文件格式：{0}", drv.DriveFormat);
                Console.WriteLine("卷标：{0}", drv.VolumeLabel);
                Console.WriteLine("根目录：{0}", drv.RootDirectory);
                Console.WriteLine("总容量：{0}KB", drv.TotalSize / 1024);
                Console.WriteLine("可用空间：{0}KB", drv.TotalFreeSpace / 1024);
                Console.WriteLine("有效可用空间：{0}KB", drv.AvailableFreeSpace / 1024);
            }
            else
            {
                Console.WriteLine("驱动器名：{0}（已就绪）", drv.Name);
                Console.WriteLine("类型：{0}", GetTypeDescription(drv.DriveType));
                Console.WriteLine("根目录：{0}", drv.RootDirectory);
            }
            Console.WriteLine();
        }

        public static string GetTypeDescription(DriveType dt)
        {
            switch (dt)
            {
                case DriveType.Fixed:
                    return "本地磁盘";

                case DriveType.CDRom:
                    return "CD-ROM";

                case DriveType.Network:
                    return "网络磁盘";

                case DriveType.Ram:
                    return "闪盘";

                case DriveType.Removable:
                    return "可移动磁盘";

                default:
                    return "未知驱动器";
            }
        }
    }
}
