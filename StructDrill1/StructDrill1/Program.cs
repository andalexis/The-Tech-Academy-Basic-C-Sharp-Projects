using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create an object of data type Number and assign an amount to it.
            Number number = new Number();
            number.Amount = 4;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
