using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrill
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + Id);
            Console.ReadLine();
        }

        //public override void SayName()
        //{
        //    base.SayName(); 
        //}

        public void Quit()
        {
            Console.WriteLine("i quit!");
            Console.ReadLine();
        }

        
    }
}
