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

        public string Add(string c)
        {
            int len = c.Length;
            int num = len + 4;
            string result = num.ToString();
            return result;
        }
    }
}
