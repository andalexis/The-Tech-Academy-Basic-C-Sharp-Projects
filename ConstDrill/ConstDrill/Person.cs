using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill
{
    public class Person
    {
        public Person(string name) : this(name, 0)
        {
        }
        public Person(string name, int numberofTokens)
        {
            Name = name;
            Tokens = numberofTokens;
        }

        public string Name { get; set; }
        public int Tokens { get; set; }

    }
}
