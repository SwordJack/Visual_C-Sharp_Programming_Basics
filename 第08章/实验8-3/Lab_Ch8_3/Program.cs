using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ch8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;

            Date dateInput = new Date(2008, 7, 18);
            dateInput.DisplayDate();

            Date dateNow = new Date(currentTime);
            dateNow.DisplayDate();

            Console.ReadKey();
        }
    }

    public class Date
    {
        private int Year, Month, Day;
        public Date(int yearInput, int monthInput, int dayInput)
        {
            Year = yearInput;
            Month = monthInput;
            Day = dayInput;
        }

        public Date(DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Day = dt.Day;
        }

        public void DisplayDate()
        {
            Console.WriteLine("{0}年{1}月{2}日", Year, Month, Day);
        }
    }
}
