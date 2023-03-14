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
            /*
            // Implicit Casting | Automatic Casting

            int number = 15;

            double nextnumber = number;

            Console.WriteLine(number);
            Console.WriteLine(nextnumber); */

            // Explicit Casting | Manual Casting

            double number = 10;

            int isNumber = (int)number;

            Console.WriteLine(number);
            Console.WriteLine(isNumber);
            System.Console.ReadLine();
        }
    }
}
