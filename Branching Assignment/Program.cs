using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // opening text
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine("Please follow the instructions below.");
            // get weight, height, length and width 
            Console.WriteLine("Enter package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package width.");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length.");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleae enter package height.");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            // total size calculation
            int total = (Num1 + Num2 + Num3);
            // price calculation
            decimal total1 = (Num1 * Num2 * Num3 * weight / 100);
            if (weight > 50)
                // Too heavy loop
            {
                Console.WriteLine("Your package is too heavy to be shipped by Package Express. Thankyou.");
                Console.ReadLine();
            }
            else if (total > 50)
                // too big loop
            {
                Console.WriteLine("Package exceeds sipping size for Package Express. Thankyou.");
                Console.ReadLine();
            }
            else
                // price quote loop
            {
                    Console.WriteLine("Your shipping quote is " + (total1));
                    Console.ReadLine();
            }           
        }
    }
}
