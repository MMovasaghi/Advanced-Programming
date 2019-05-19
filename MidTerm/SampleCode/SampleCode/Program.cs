using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample<string> sample = new Sample<string>();

            sample.Type = "H";
            Sample<string> s;

            string a = "HELLO WORLD!";
            for (int i = 0; i < a.Length ; i++)
            {
                s = new Sample<string>();
                s.Type = a[i].ToString();
                s.AnotherSAMPLE = new Sample<string>();
                s = s.AnotherSAMPLE;
            }
            Console.ReadKey();
        }
    }
}
