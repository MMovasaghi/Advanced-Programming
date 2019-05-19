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
            
            Sample<string> a = new Sample<string>();
            Sample<string> HEAD = a;
            Sample<string> ptr = HEAD;

            string str = "HELLO WORLD!";
            for (int i = 0; i < str.Length ; i++)
            {
                ptr.AnotherSAMPLE = new Sample<string>();
                ptr.AnotherSAMPLE.Type = str[i].ToString();
                ptr = ptr.AnotherSAMPLE;
            }
            Console.ReadKey();
        }
    }
}
