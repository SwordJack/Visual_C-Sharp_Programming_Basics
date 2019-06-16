using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Xyz[] xyz = { new Xyz(), new Xyz(5) };

            foreach (Xyz var in xyz)
            {
                Console.WriteLine(var.X);   //输出类的实例的属性。
            }
            Console.ReadKey();
        }
    }

    public class Xyz
    {
        int x;
        public Xyz()        //参数表为空的构造函数。
        {
            this.X = 0;     //设定对象的属性为默认值。
        }

        public Xyz(int i)   //带有参数的构造函数。
        {
            this.X = i;     //用参数设定对象的属性。
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
    }
}
