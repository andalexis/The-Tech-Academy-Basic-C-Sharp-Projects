using System;
using System.Collections.Generic;

namespace exceptionDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drill
            try
            {
                List<int> numberList = new List<int> { 2, 4, 6, 10, 100 };
                Console.WriteLine("This is a list of numbers:");
                foreach (int i in numberList)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\nType a number for me to divide all these numbers by: ");
                int userNum = Convert.ToInt16(Console.ReadLine());

                foreach (int num in numberList)
                {
                    Console.WriteLine(" {0}/{1}={2} ", num, userNum, (num / userNum));
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Oops, please don't try to divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Oops that wasn't a number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("You've now exited this try/catch block");
            Console.ReadLine();
            
        }
    }
}
