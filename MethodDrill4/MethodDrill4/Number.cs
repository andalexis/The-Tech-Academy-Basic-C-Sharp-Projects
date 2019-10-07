using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    public class Number
    {
        public void Multiply(int a, int b = 0)
        {
            
            if (b != 0)
            {
                b = 0;
            }
            int result = a * b;
            Console.WriteLine("first number: {0}", a);
            Console.WriteLine("second number: {0}", b);
            Console.WriteLine("Multiplied out to be: {0}", result);
        }

        
    }
}
