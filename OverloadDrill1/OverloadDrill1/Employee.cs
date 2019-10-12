using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDrill1
{
    public class Employee
    {
        //public int Id; // ID
        public int Id { get; set; }
        //
        public static bool operator == (Employee employee1, Employee employee2)
        {
            employee1.Id.Equals(employee2.Id);
            return true;
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            return false;
        }
    }
}
