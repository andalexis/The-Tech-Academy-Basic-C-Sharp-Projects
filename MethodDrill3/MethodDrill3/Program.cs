using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Math ob = new Math();

            Console.WriteLine("Type a whole number: ");
            int math1 = ob.Add(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Type a decimal number: ");
            decimal math2 = ob.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Type a word: ");
            string math3 = ob.Add(Convert.ToString(Console.ReadLine()));
            Console.WriteLine(math1);
            Console.WriteLine(math2);
            Console.WriteLine(math3);
            Console.ReadLine();
        }
    }
}
