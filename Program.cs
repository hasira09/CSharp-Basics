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
            var numbers = new[] {3,1,7,8,9,6,5,4};

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 3);

            Console.WriteLine("Cleared Array");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[4];
            Array.Copy(numbers, another, 4);

            Console.WriteLine("Copied Array");
            foreach(var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Sorted Array");
            foreach (int n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Reversed Array");
            foreach (var n in numbers)
                Console.WriteLine(n);

            Console.ReadLine();

        }
                                      
        
    }
}
