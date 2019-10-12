using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDrill1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();  // first employee
            employee1.Id = 1;
            

            Employee employee2 = new Employee();  // second employee
            employee2.Id = 2; // changing the ID to one returns true

            Console.WriteLine(employee1.Id == employee2.Id);
            Console.ReadLine();

            
        }
    }
}
