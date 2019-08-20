using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //// escape character \ ignores the character to its right
            //// new line \n
            //// a tab \t
            //string name = "Alexis";
            //string quote = "The man said, \"Hello\",\n Alexis.";
            //// the @ says there are no escape sequences
            //string filename = @"C:\Users\Alexis";

            //bool trueOrFalse = name.Contains("s");

            //int length = name.Length; // 6 (because Alexis has  letters)

            //Console.WriteLine(length);
            //Console.ReadLine();
            

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
