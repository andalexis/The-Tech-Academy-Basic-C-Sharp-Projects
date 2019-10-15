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
            
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                if (userAge == 0)
                {
                    throw new ZeroException();
                }
                int born = 2019 - userAge;
                Console.WriteLine("You were born in the year {0}", born);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("That wasn't valid.");
                Console.ReadLine();
            }
           
            catch (NegativeException)
            {
                Console.WriteLine("Ages arent in negatives!");
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("You're not 0 years old!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                Console.ReadLine();
            }


            //Console.WriteLine("exited");
            //Console.ReadLine();
        }
    }
}
