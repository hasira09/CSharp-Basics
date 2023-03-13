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
            Console.WriteLine("Enter the first number = ");
            string number1;
            number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);


            Console.WriteLine("Enter the second number = ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            int add = num1 + num2;
            Console.WriteLine("Addition is " + add);

            int sub = num1 - num2;
            Console.WriteLine("Substraction is " + sub);

            int multi = num1 * num2;
            Console.WriteLine("Multipication is " + multi);

            int dev = num1 / num2;
            Console.WriteLine("Devition is " + dev);

            System.Console.ReadLine();
        }
    }
}
