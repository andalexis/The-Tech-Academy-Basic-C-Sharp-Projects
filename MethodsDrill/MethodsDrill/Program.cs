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
            int variableSquare = math.SquareNumber(userNumber); // calling method
            int variableDouble = math.DoubleNumber(userNumber);
            bool variableEven = math.isEven(userNumber);
            //math.Print(); // calling method
            Console.WriteLine("The square of that number is " + variableSquare);
            Console.WriteLine("The value of twice that number is " + variableDouble);
            Console.WriteLine("This number is even: " + variableEven);
            Console.ReadLine();


        }


    }
}
