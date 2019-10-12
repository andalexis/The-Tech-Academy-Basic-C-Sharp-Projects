using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> Employee1 = new Employee<string>();
            Employee1.Things = new List<string>() { "apple", "pencil", "candy" };

            Employee<int> Employee2 = new Employee<int>();
            Employee2.Things = new List<int>() { 2, 5, 1, 7 };

            foreach (var Thing in Employee1.Things)
            {
                Console.WriteLine(Thing);
            }
            Console.ReadLine();

            foreach (var Thing in Employee2.Things)
            {
                Console.WriteLine(Thing);
            }
            Console.ReadLine();

        }
    }
}
