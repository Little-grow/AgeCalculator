using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illustrated_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,Enter your date of birth");
            bool ok = true;
            DateTime date;

            ok = DateTime.TryParse(Console.ReadLine(), out date);

            while (!ok)
            {
                Console.WriteLine("Wrong input.Try agin");
                ok = DateTime.TryParse(Console.ReadLine(), out date);
            }

            TimeSpan timeSpan = DateTime.Today - date;
            TimeSpan timeSpanMnth = timeSpan.Divide(30);
            TimeSpan timeSpanYears = timeSpanMnth.Divide(12);


            Console.WriteLine("Your age is ");

            int y = int.Parse(timeSpanYears.Days.ToString());
            Console.WriteLine(y + " years");

            int x = int.Parse(timeSpanMnth.Days.ToString());
            Console.WriteLine(x + " months");

            Console.WriteLine(timeSpan.TotalDays + " days");

        }


    }


}


