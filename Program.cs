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
            var fullName = "Tharushi Umayanga";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper; '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName  = fullName.Substring(index + 1);
            Console.WriteLine("First Name is: " +firstName);
            Console.WriteLine("Last Name is: " + lastName);

            Console.WriteLine();

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var replace = fullName.Replace("Tharushi", "Ummah");
            var replace1 = fullName.Replace(' ', '-');

            Console.WriteLine();
            Console.WriteLine(replace);
            Console.WriteLine(replace1);

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 34.78f;
            Console.WriteLine(price.ToString("C0"));

            Console.ReadLine();

        }
                                      
        
    }
}
