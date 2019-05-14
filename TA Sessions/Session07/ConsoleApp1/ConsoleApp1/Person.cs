using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public int personid { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " " + personid + " | ";
        }
    }
}
