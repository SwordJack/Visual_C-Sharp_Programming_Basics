using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问Car类对象和对象数据状态
{
    class Program
    {
        static void Main(string[] args)
        {
            string pa;
            Car c = new Car();  //实例化一个class类。
            c.Brand = "奔驰";   //Brand属性。
            c.color = "黑色";   //color字段。
            pa = c.Brand;       //读取c的Brand属性。

            Console.WriteLine(pa);
            Console.ReadKey();
        }
    }

    public class Car
    {
        public int number;      //号码属性。
        public string color;    //颜色属性。
        private string _brand;  //品牌域。

        public Car()
        {

        }

        public string Brand             //“Brand”属性，此处用于控制_brand字段的访问过程和读写权限。
        {
            get                         //“读”操作。当通过Car类的Brand方法读取_brand字段的值时触发（例：a = c.Brand）。
            {
                return this._brand;
            }
            set                         //“写”操作。当通过Car类的Brand方法写入_brand字段的值时触发（例：c.Brand = a）。
            {
                this._brand = value;    //“value”关键字，指代赋给_brand的值。
            }
        }
    }
}
