using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill
{
    class Math
    {
        public int square;
        public int numdouble;
        public bool iseven;

        public int SquareNumber(int userNumber)
        {
            square = userNumber * userNumber;
            return square;
        }
        
        public int DoubleNumber(int userNumber)
        {
            numdouble = userNumber * 2;
            return numdouble;
        }

        public bool isEven(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                iseven = true;    
            }
            return iseven;
        }
        
    }
}
