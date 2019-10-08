using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Numbers ob = new Numbers();

            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt16(Console.ReadLine());
            // call the method on user's number
            ob.Divide(userNum);

            Console.WriteLine("Enter another number: ");
            int userNum1 = Convert.ToInt16(Console.ReadLine());
            ob.Divide(userNum, userNum1);

            // call the method that uses output parameters
            Console.WriteLine("Enter a number: ");
            int userA = Convert.ToInt16(Console.ReadLine());
            ob.Change(out userA);
            Console.WriteLine("After calling method, value is now : {0}", userA);
            Console.ReadLine();

            // static 
            Console.WriteLine("What's the best baseball team? " + Team.BestTeam);
            Console.WriteLine("No debate. " + Team.Reason);
            Console.ReadLine();
        }
    }
}
