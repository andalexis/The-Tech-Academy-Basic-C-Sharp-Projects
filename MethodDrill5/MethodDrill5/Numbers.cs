using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class Numbers
    {
        //Void method divides the data passed to it by 2.
        public void Divide(int a)
        {
            int result = a / 2;
            Console.WriteLine("That number divided by 2 is {0}", result);
            //Console.ReadLine();
        }

        //Method overloading
        public void Divide(int a, int c)
        {
            int result = a / c;
            Console.WriteLine("Divided by your first number is an integer of {0}", result);
            Console.ReadLine();
        }

        //Method with output parameters.
        public void Change(out int b)
        {
            int num = 10;
            b = num;
        }

        

    }
}
