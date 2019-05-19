using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Sample<T>
    {
        public T Type { get; set; }
        public Sample<T> AnotherSAMPLE { get; set; }        
    }
}
