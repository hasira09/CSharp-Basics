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
            var hasira = new Person();
            hasira.FirstName = "Hasira";
            hasira.LastName = "Koswatta";
            hasira.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(8, 2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        
        
    }
}
