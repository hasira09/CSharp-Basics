using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();

            food.Add("Kottu");
            food.Add("Fried-Rice");
            food.Add("Pizza");
            food.Add("Submarines");

            //Removing from the List
            //food.Remove("Pizza");

            //Adding an Element
            //food.Insert(0, "Biriyani");

            //Accessing with the index
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food.IndexOf("Submarines"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();

            String[] foodArray = food.ToArray();


            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }

            //Current size of the array
            //Console.WriteLine(food.Count);

            //Console.WriteLine(food.LastIndexOf("Pizza"));
            //Console.WriteLine(food.Contains("Submarine"));
            

            Console.ReadLine();
        }
    }
}

//Lists is a Data Structure that represents a list of objects that can be accessed by index.
//Similar to arrays. But can dynamically increase/decrease in size
//Using System.Collections.Generic;
