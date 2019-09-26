using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            int value1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Type another number: ");
            int value2 = Convert.ToInt16(Console.ReadLine());

            // calling method by value
            Console.WriteLine("Your values are " + value1 + " and " + value2);
            // calling method by parameters
            Numbers.ModifyValue(value1, value2);
            Console.ReadLine();
        }
    }
    
}
