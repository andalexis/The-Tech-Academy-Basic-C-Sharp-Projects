using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightMax = 50;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(weight);
            //Console.ReadLine();

            if (weight > weightMax)
            {
                Console.WriteLine("Oops. Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(width);
            // Console.ReadLine();

            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(height);
            // Console.ReadLine();

            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(length);
            // Console.ReadLine();

            int dimMax = 50;
            double dim = (width + length + height);
            if (dim > dimMax)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                double total = ((dim * weight) / 100);
                string yourCost = string.Format("Your estimated total for shipping this package is: {0:C} ", total);
                Console.WriteLine(yourCost);
                //Console.WriteLine("Your estimated total for shipping this package is: $" + total);
                Console.WriteLine("Thank you");
                Console.ReadLine();
            }

            
        }
    }
}
