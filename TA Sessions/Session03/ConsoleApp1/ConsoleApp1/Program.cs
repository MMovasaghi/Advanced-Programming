using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pInmain = new Person()
            {
                Name = "ALI",
                Id = 10
            };
            Manager manager = new Manager()
            {
                person = new Person() { Name = "HASAN", Id = 20 },
                Email = "ALI@Gmail.com"
            };

            Console.WriteLine("PERSON IN MAIN : Name : {0} - Id = {1}" +
                " \nPERSON IN MANAGER CLASS : Name : {2} - Id : {3}"
                ,pInmain.Name,pInmain.Id,manager.person.Name,manager.person.Id);

            Console.ReadKey();

        }
    }
}
