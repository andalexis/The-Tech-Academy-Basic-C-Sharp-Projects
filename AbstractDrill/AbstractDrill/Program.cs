using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrill
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.Id = 1;
            person.SayName();

            //Employee person = new Employee();
            person.FirstName = "Um";
            person.LastName = "sure";
            person.Id = 2;
            person.SayName();

            //IQuittable employee = new Employee();
            //employee.Quit();
        }
    }
}
