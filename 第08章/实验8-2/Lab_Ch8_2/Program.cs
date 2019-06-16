using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ch8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stu = new Students("0001", "张三", 16);
            stu.Display();

            Console.ReadKey();
        }
    }

    public class Students
    {
        string id, name;
        int age;

        public Students(string idInput, string nameInput, int ageInput)
        {
            this.id = idInput;
            this.name = nameInput;
            this.age = ageInput;
        }

        public void Display()
        {
            Console.WriteLine("ID：{0}，姓名：{1}，年龄：{2}。", id, name, age);
        }
    }
}
