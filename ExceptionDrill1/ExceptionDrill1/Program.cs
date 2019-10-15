using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrill1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            //int userAge = Convert.ToInt32(Console.ReadLine());
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                int born = 2019 - userAge;
                Console.WriteLine("You were born in the year {0}", born);
                Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("...you didn't enter anything.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("That wasn't a valid entry.");
                Console.ReadLine();
            }
            

            Console.WriteLine("exited");
            Console.ReadLine();
        }
    }
}
