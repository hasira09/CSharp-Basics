using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


     
    class program
    {

       static void Main(string[] args)
        {

            var dateTime = new DateTime(2023, 3, 24);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyy-MMM-dddd HH:mm"));





            Console.ReadLine();
        }
        
    }
}
