using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入球半径：");
            double r = Convert.ToDouble(Console.ReadLine());
            MyBall mb = new MyBall(r);

            Console.Write("\n请输入圆柱体高度：");
            double h1 = Convert.ToDouble(Console.ReadLine());
            MyCylinder mCy = new MyCylinder(r, h1);
            Console.WriteLine("圆柱体体积为：{0:F2}", mCy.Volumn);

            Console.Write("\n请输入圆锥体高度：");
            double h2 = Convert.ToDouble(Console.ReadLine());
            MyCone mCo = new MyCone(r, h2);
            Console.WriteLine("圆柱体体积为：{0:F2}", mCo.Volumn);

            Console.ReadKey();
        }
    }

    class MyCircle              //圆类。
    {
        protected double radius;

        public MyCircle() { }       //MyCircle类的无参构造函数

        public MyCircle(double r)   //MyCircle类的含参构造函数。
        {
            radius = r;
        }
    }

    class MyBall : MyCircle     //球体类：继承自圆类。
    {
        double _volumn;             //球体的体积。

        public MyBall(double r) : base(r)
        {
            _volumn = 4 / 3 * Math.PI * Math.Pow(r, 3);     //球体体积为：(4 / 3) * PI * r ^ 3
            Console.WriteLine("球的体积为{0:F2}。", _volumn);
        }

        public double Volumn
        {
            get
            {
                return _volumn;
            }
        }        
    }

    class MyCylinder : MyCircle //圆柱类：继承自圆类。
    {
        double _height, _volumn;    //圆柱的高度和体积。

        public MyCylinder(double r, double h) : base(r)
        {
            Height = h;
        }

        public double Volumn
        {
            get
            {
                return _volumn;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                _volumn = Math.PI * Math.Pow(radius, 2) * _height; //当圆柱的高度发生变化时，圆柱的体积必然会发生相应的变化。
            }
        }
    }

    class MyCone : MyCircle     //圆锥类：继承自圆类。
    {
        double _height, _volumn;    //圆锥的高度和体积。

        public MyCone(double r, double h) : base(r)
        {
            Height = h;
        }

        public double Volumn
        {
            get
            {
                return _volumn;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                _volumn = Math.PI * Math.Pow(radius, 2) * _height / 3; //当圆锥的高度发生变化时，圆锥的体积必然会发生相应的变化。
            }
        }
    }
}
