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
           var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            //IndexOf
            Console.WriteLine();
            Console.WriteLine("Index of 1 is: "+ numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1 is: " + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("Count is: "+ numbers.Count);

            //Remove
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach(var number in numbers)
                Console.WriteLine(number);

            //Clear
            numbers.Clear();
            Console.WriteLine("Count is: " + numbers.Count);

            Console.ReadLine();

        }
                                      
        
    }
}
