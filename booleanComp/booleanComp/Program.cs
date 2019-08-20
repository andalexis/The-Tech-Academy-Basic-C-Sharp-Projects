using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanComp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is an example of a bool
            // comparison using while
            bool userReply = false;
            while (userReply == false)
            {
                Console.WriteLine("What month is your birthday?: ");
                string userBday = Console.ReadLine().ToUpper();
                Console.WriteLine("Cool!");
                Console.ReadLine();

                userReply = true;
            }

            // This is an example of a bool comparison
            // using do while
            int i = 1;
            Console.WriteLine("Let's count to 10!");
            Console.ReadLine();
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 11);

            Console.ReadLine();


        }
    }
}
