using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill
{
    public class Program
    {
        //public int userNumber = 0;
        //public int square;
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();
            math.SquareNumber(userNumber); // calling method
            math.DoubleNumber(userNumber);
            math.Print(); // calling method
            
            Console.ReadLine();


        }


    }
}
