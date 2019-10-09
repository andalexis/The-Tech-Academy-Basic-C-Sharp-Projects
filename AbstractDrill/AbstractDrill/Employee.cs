using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrill
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName(); 
        }

        public void Quit()
        {
            Console.WriteLine("i quit!");
            Console.ReadLine();
        }
    }
}
