using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false); // is false since it asks if both are true
            //Console.WriteLine(true || true); // true or true

            //Console.WriteLine(true == true); //does true equal true
            //Console.WriteLine(true == false); //does true equal false
            //Console.WriteLine(true != true); // says does true does not equal true? result false

            Console.WriteLine(true ^ true); //operator evaulates to true
            Console.WriteLine(true ^ false); //if ones of these are true but not both
            Console.WriteLine(false ^ false); // xor operator

            Console.ReadLine();
        }
    }
}
