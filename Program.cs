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
            Console.WriteLine("Enter the hourly rate of employee");
            string hourlyRate = Console.ReadLine();
            double hourlyRate_1 = Convert.ToDouble(hourlyRate);

            Console.WriteLine("Enter the number of hours worked the employee");
            string hoursworked = Console.ReadLine();
            double hoursworked_1 = Convert.ToDouble(hoursworked);

            double grosspay = hourlyRate_1 * hoursworked_1;
            Console.WriteLine("Gross pay of an employee is " + grosspay);

            System.Console.ReadLine();
        }
    }
}
