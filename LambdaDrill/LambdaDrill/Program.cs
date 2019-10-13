using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDrill
{
    public class Program : Employee
    {
        public static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees.
            //    Each employee should have a first and last name, as well as an Id.
            //    At least two employees should have the first name "Joe".


            Employee em1 = new Employee()
            {
                fname = "Joe",
                lname = "Smith",
                Id = 1
            };
            
            Employee em2 = new Employee()
            {
                fname = "Katie",
                lname = "Peters",
                Id = 2
            };
            Employee em3 = new Employee()
            {
                fname = "Ana",
                lname = "Lopez",
                Id = 3
            };
            Employee em4 = new Employee()
            {
                fname = "Joe",
                lname = "Rivers",
                Id = 4
            };
            Employee em5 = new Employee()
            {
                fname = "Abby",
                lname = "Nelson",
                Id = 5
            };
            Employee em6 = new Employee()
            {
                fname = "Sage",
                lname = "Greene",
                Id = 6
            };
            Employee em7 = new Employee()
            {
                fname = "Dakota",
                lname = "Greene",
                Id = 7
            };
            Employee em8 = new Employee()
            {
                fname = "Joe",
                lname = "Doe",
                Id = 8
            };
            Employee em9 = new Employee()
            {
                fname = "Sarah",
                lname = "Strong",
                Id = 9
            };
            Employee em10 = new Employee()
            {
                fname = "Nick",
                lname = "Hayes",
                Id = 10
            };

            List<Employee> Employees = new List<Employee>();
            Employees.Add(em1);  // Here Add Method is used to add the item to the list
            Employees.Add(em2);
            Employees.Add(em3);
            Employees.Add(em4);
            Employees.Add(em5);
            Employees.Add(em6);
            Employees.Add(em7);
            Employees.Add(em8);
            Employees.Add(em9);
            Employees.Add(em10);

            //List<Employee> Joe = new List<Employee>();
            //foreach (Employee e in Employees)
            //{
            //    if (e.fname == "Joe")
            //    {
            //        Joe.Add(e);
            //    }
            //}

            //foreach (Employee j in Joe)
            //{
            //    Console.WriteLine("{0} {1}, {2}", j.fname, j.lname, j.Id);
            //}

            //Console.ReadLine();

            // using Lambda
            List<Employee> Joe = Employees.FindAll(x => x.fname == "Joe").ToList();
            foreach (Employee j in Joe)
            {
                Console.WriteLine("{0} {1}, {2}", j.fname, j.lname, j.Id);
            }
            Console.ReadLine();

            List<Employee> Over5 = Employees.FindAll(x => x.Id > 5).ToList();
            foreach (Employee j in Over5)
            {
                Console.WriteLine("{0} {1}, {2}", j.fname, j.lname, j.Id);
            }
            Console.ReadLine();

        }

        

        
    }
}
