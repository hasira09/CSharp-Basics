using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        public static void Main(string[] args)
        {
           var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enetr a number or 'Quit to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = GetUniqueNumbers(numbers);

            Console.WriteLine("Uniquw Numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
            Console.ReadLine();
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }
    }
}
