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

        public void SquareNumber(int userNumber)
        {
            square = userNumber * userNumber;
        }

        public void DoubleNumber(int userNumber)
        {
            numdouble = userNumber * 2;
        }

        public void isEven(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                iseven = true;
            }
        }

        public void Print()
        {
            Console.Write("The square of that number is " + square + "\n");
            Console.WriteLine("Double of that number is " + numdouble);
            Console.Write("Is this number even?: " + iseven);
        }
    }
}
