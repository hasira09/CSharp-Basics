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
            Console.Write("Enter Your Amount: ");
            int number1 = Int16.Parse(Console.ReadLine());
            

            if (number1 >= 90) 
                Console.WriteLine("10 Royalty Rewards");
            
            else if (number1 >= 75)
                Console.WriteLine("8 Royalty Rewards");

            else if (number1 >= 60)
                Console.WriteLine("6 Royalty Rewards");

            else if (number1 >= 45)
                Console.WriteLine("4 Royalty Rewards");

            else if (number1 >= 30)
                Console.WriteLine("2 Royalty Rewards");

            else
                Console.WriteLine("0 Royalty Rewards");

            System.Console.ReadLine();
        }
    }
}
