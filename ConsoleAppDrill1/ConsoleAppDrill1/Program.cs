using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an integer input: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int userResult = userInput * 50;
            Console.WriteLine(userResult);
            Console.ReadLine();

            Console.WriteLine("Please type an integer input: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            userResult = userInput + 25;
            Console.WriteLine(userResult);
            Console.ReadLine();

            Console.WriteLine("Please type an integer input: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            double userFinalResult = Convert.ToDouble(userResult);
            userFinalResult = userInput / 12.5;
            Console.WriteLine(userFinalResult);
            Console.ReadLine();

            Console.WriteLine("Please type an integer input: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            int numFifty = 50;

            bool isGreater = userInput > numFifty;
            Console.WriteLine(isGreater);
            Console.ReadLine();

            Console.WriteLine("Please type an integer input: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            userResult = userInput % 7;
            Console.WriteLine(userResult);
            Console.ReadLine();



        }
    }
}
