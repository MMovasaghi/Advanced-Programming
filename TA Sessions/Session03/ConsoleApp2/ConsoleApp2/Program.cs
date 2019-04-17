using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            H hINMAIN = new H()
            {
                id = 1,
                pass = 123,
                MelliCode = 321
            };
            Person p= new Person()
            {
                Name = "ALI",
                Email = "dk@g.com",
                id = 2,
                h = hINMAIN
            };
            Employee e = new Employee()
            {
                person = p,
                Code = "ghjk"
            };

            Console.WriteLine(e.person.h.pass);
        }
    }
}
