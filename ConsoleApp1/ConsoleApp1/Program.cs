using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan timeSpan = DateTime.Now.TimeOfDay;

            if ((timeSpan.Hours >= 9) && (timeSpan.Hours <= 12))
            {
                Console.WriteLine("Good morning, guys");
            }
            else if ((timeSpan.Hours > 12) && (timeSpan.Hours < 15))
            {
                Console.WriteLine("Good day, guys");
            }
            else Console.WriteLine("Good evening, guys");

            Console.ReadKey();
        }
    }
}
