using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeDrill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current time: " + currentTime);
            
            Console.WriteLine("\nType a number:  ");
            int userHr = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = currentTime.AddHours(userHr);
            Console.WriteLine("In {0} hours it wil exactly be: ", userHr);
            Console.Write(futureTime);
            
            Console.ReadLine();
           

            

        }
    }
}
