using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(age);
            Console.WriteLine("Have you ever had a DUI?: ");
            bool duiCheck = Convert.ToBoolean(Console.ReadLine());
            // Console.WriteLine(duiCheck);
            Console.WriteLine("How many speeding tickets do you have?: ");
            int speedTicket = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(speedTicket);

            Console.WriteLine("Qualified?");
            bool isQualified = (age > 15 && duiCheck == false && speedTicket < 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
