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
            int num1 = 20;
            int num2 = 30;
            int num3 = 30;

            /*
            //Arithmetic Operations
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            Console.WriteLine(num1++);
            Console.WriteLine(num1--);
            Console.WriteLine(num2--);
            Console.WriteLine(num2++);
            

            //Assignment Operations 
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num3 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num3 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num3 > num2);
            */

            //Logical Operators
            Console.WriteLine(num1 < num2 && num2 == num3);
            Console.WriteLine(num1 < num2 && num2 == num3);
            Console.WriteLine(!(num1 < num2));

            System.Console.ReadLine();
        }
    }
}
