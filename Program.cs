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
            string house;
            string electricity;
            string telephone;
            string water;

            Console.WriteLine("Please enter the monthly rent");
            house = Console.ReadLine();
            double house1 = Convert.ToDouble(house);

            Console.WriteLine("Please enter the avareage electricity");
            electricity = Console.ReadLine();
            double electricity1 = Convert.ToDouble(electricity);

            Console.WriteLine("Please enter the monthly telephone bill");
            telephone = Console.ReadLine();
            double telephone1 = Convert.ToDouble(telephone);

            Console.WriteLine("Please enter the monthly water bill");
            water = Console.ReadLine();
            double water1 = Convert.ToDouble(water);

            double totalExpenditure;
            totalExpenditure = (house1 + electricity1 + telephone1 + water1) * 12;
            Console.WriteLine("Total Expenditure for one year is " + totalExpenditure);


            System.Console.ReadLine();
        }
    }
}
