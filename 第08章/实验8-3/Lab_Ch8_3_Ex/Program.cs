using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch8_3_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //输入信息。
            //
            Console.Write("请输入房屋长度（米）："); float length = float.Parse(Console.ReadLine());
            Console.Write("请输入房屋宽度（米）："); float width = float.Parse(Console.ReadLine());
            Console.Write("请输入房屋层数（层）："); int layer = int.Parse(Console.ReadLine());
            Console.Write("请输入房屋单价（万元/平方米）："); float price = float.Parse(Console.ReadLine());

            //
            //输出信息。
            //
            Building building = new Building(length, width, layer, price);
            Console.WriteLine("房屋总面积为" + building.BuildingArea() + "平方米；");
            Console.WriteLine("房屋总价值为" + building.BuildingCost() + "万元。");

            Console.ReadKey();
        }
    }

    class Building
    {
        private float _length, _width;  //房屋的长和宽。
        private int _layerCnt;          //房屋的层数。

        private float _price;           //房屋的单价。

        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Layer
        {
            get { return _layerCnt; }
            set { _layerCnt = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Building(float lengthInput, float widthInput, int layerInput, float priceInput)
        {
            Length = lengthInput;
            Width = widthInput;
            Layer = layerInput;
            Price = priceInput;
            Console.WriteLine("\n======对象建立完成！======\n");
        }

        //
        //计算房屋面积。
        //
        public float BuildingArea()
        {
            return (Length * Width * Layer);
        }

        //
        //计算房屋价值。
        //
        public float BuildingCost()
        {
            return (BuildingArea() * Price);
        }

    }
}
