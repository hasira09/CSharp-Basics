using ConsoleApp1.Maths;
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
            var builder = new StringBuilder("Hello World");

            builder.Append('-', 18);
            builder.AppendLine();
            builder.Append("Tharushi Umayanga");
            builder.AppendLine();
            builder.Append('-', 18);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " +builder[0]);

            Console.ReadLine();


        }

        
        
                                      
        
    }
    
}
