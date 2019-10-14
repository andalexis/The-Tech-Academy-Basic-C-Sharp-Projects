using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string currentSeason = "Fall";
            Console.WriteLine("We are in the season of {0}", currentSeason);
            Console.ReadLine();

            var tripDetails = new { Place = "Colorado", Month = "December", Reason = "Christmas", Length = "1 week" };
            Console.WriteLine("My trip details for my next vacation\n" + tripDetails);
            Console.ReadLine();

            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            Person person1 = new Person(name);

            Console.ReadLine(); // add breakpoint here
            

        }
    }
}
