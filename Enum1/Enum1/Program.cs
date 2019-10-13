using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week: ");
            //Assign the value to a variable of that enum data type you just created.
            string value = Console.ReadLine().ToUpper();
            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine("Cool, have a great day.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thats not a day of the week");
                Console.ReadLine();
            }
        }



        public enum DaysOfTheWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }

}
