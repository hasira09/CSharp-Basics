
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{



    class program
    {

        static void Main(string[] args)
        {
            var fullName = "Tharushi Umayanga ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());


            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastname = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("Lastname: " + lastname);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Tharushi", "umayanga"));
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.86f;
            Console.WriteLine(price.ToString("c0"));


            Console.ReadLine();
        }
    }
}
