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
            //creting

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: "+ duration);

            //properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //add

            Console.WriteLine("Add Example: "+ timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //to string
           Console.WriteLine("ToString" + timeSpan.ToString());

            //parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
            Console.ReadLine();
        }
        
    }
}
