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
            //ConCat<string> a = new ConCat<string>();
            //string str1 = "Salam ";
            //string str2 = "Khobi ?";

            //Console.WriteLine("New : {0}", a.NewT(str1, str2));

            ConCat<Person> conCat = new ConCat<Person>();
            Person a = new Person()
            {
                Name = "Ali",
                personid = 1
            };
            Person b = new Person()
            {
                Name = "Hasan",
                personid = 2
            };

            
            Console.WriteLine("New Person : {0}", conCat.NewT(a, b));

            Console.ReadKey();
        }
    }
}
