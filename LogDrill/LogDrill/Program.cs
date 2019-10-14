using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogDrill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Documents\GitHub\Logging\LogDrill.txt", text);

            using (StreamReader file = new StreamReader(@"C:\Users\Student\Documents\GitHub\Logging\LogDrill.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
