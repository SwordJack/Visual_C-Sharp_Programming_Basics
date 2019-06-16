using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类和抽象方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 6);
            Console.WriteLine("矩形面积为{0}", rect.Area());

            Circle circ = new Circle(2.0);
            Console.WriteLine("圆的面积为{0}", circ.Area());

            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public const double PI = Math.PI;
        public abstract double Area();  //含有抽象方法的类必须是抽象类，抽象方法不允许定义方法的执行体，强制性地要求派生类必须重写该方法为之提供执行代码。
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return (PI * radius * radius);
        }
    }

    public class Rectangle : Shape
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double Area()
        {
            return (width * height);
        }
    }
}
