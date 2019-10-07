using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    public class Math
    {
        // Create a class. In that class, 
        // create a method that will take in an integer, 
        // do a math operation to it and
        // then return the answer as an integer.

        public int Add(int a)
        {
            int result = a + 10;
            return result;
        }

        public decimal Add(decimal b)
        {
            decimal result = Decimal.ToInt32(b * 10);
            return result;
        }

        public void Add(string c)
        {
            int len = c.Length; // changing to int
            int num = len + 4; // performing math operation
            Console.WriteLine(num); // writing it back

        }
    }
}
