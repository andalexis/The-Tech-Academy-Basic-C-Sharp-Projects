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

            
            // calling method by parameters
            Numbers.ModifyValue(value1, value2);
            // calling method by named parameters
            Numbers.ModifyValue(i: value1, j: value2);
            Console.ReadLine();
        }
    }
    
}
