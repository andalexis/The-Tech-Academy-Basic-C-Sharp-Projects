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

            try
            {
                Console.WriteLine("Type another number {optional} or press y to continue: ");
                int num2 = Convert.ToInt16(Console.ReadLine());
                ob.Multiply(num1, num2);
            }
            catch (Exception ex)
            {
                ob.Multiply(num1);
            }

            Console.ReadLine();

            
        }
    }
}
