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
            Console.WriteLine("Enter the Student Marks ");
            string number1;
            number1 = Console.ReadLine();
            int marks = Convert.ToInt32(number1);

            if (marks >= 75)
                Console.WriteLine("your results is A");
            else if (marks >= 65)
                Console.WriteLine("your resuls is B");

            else if (marks >= 50)
                Console.WriteLine("your results is C");
            else if (marks >= 40)
                Console.WriteLine("your results is S");
            else
                Console.WriteLine("your results is F");

            System.Console.ReadLine();
        }
    }
}
