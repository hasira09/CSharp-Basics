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
            //String User Input

            string name;

            Console.Write("Please Enter Your Name: ");
            name = Console.ReadLine();

            //Integer User Input

            Console.Write("Please Enter Your Age: ");
            int age = Int16.Parse(Console.ReadLine());


            Console.WriteLine("Your Name is : " +name);
            Console.WriteLine("Your Age is : " + age);
            System.Console.ReadLine();
        }
    }
}
