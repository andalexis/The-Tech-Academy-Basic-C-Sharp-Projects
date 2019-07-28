using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favoriteNumber);
            //int total = favNumber + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            // casting string to int
            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            // casting bool to string
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(questionMark);
            Console.ReadLine();

        }
    }
}
