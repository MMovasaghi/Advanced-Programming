using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConCat<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
        public string NewT(T f,T s)
        {
            string newT = f.ToString() + s.ToString();
            return newT;
        }
    }
}
