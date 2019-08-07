using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            double hourRate1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(hourRate);
            Console.WriteLine("Hours worked per week? ");
            double hourWork1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(hourWork);

            double salary1 = hourRate1 * hourWork1;
            // Console.WriteLine(salary1);
            // Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            double hourRate2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(hourRate);
            Console.WriteLine("Hours worked per week? ");
            double hourWork2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(hourWork);

            double salary2 = hourRate2 * hourWork2;
            // Console.WriteLine(salary2);
            // Console.ReadLine();

            bool result = true;
            result = (salary1 > salary2);

            if (result)
            {
                result = true;
            }
            
            if (!result)
            {
                result = false;
            }

            Console.WriteLine("Weekly salary of Person 1: " + salary1);
            Console.WriteLine("Weekly salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?: " + result);
            Console.ReadLine();
        }
    }
}
