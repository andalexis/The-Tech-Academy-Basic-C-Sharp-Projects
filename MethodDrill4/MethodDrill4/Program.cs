using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number ob = new Number();
            Console.WriteLine("Type a number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Would you like to type another number? (y/n): ");


            int num2 = Convert.ToInt16(Console.ReadLine());
            //ob.Multiply(num1);
           ob.Multiply(num1, b: num2);
            Console.ReadLine();
        }
    }
}
