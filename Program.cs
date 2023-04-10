using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();
            MyQueue.Enqueue("This is the First Value");
            MyQueue.Enqueue(1);
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(3);
            MyQueue.Enqueue(null);
            MyQueue.Enqueue(49);
            MyQueue.Enqueue("This is the Last Value");

            Console.WriteLine($"Number of Elements = {MyQueue.Count}");


            Console.ReadLine();
        }
    }
}

//The Queue collection is the opposite of the Stack Collection
//Based in FIFO
//