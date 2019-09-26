using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    public class Numbers
    {
        public static void ModifyValue(int i, int j)
        {
            i = i * 2;
            Console.WriteLine("Your first number was doubled to = {0}", i);
            Console.WriteLine("Your second number stayed the same = {0}", j);
            return;
        }

        
    }
}
