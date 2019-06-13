using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FileSave : Test,Interface1
    {
        public bool Save(string text, string filename = "Output.txt")
        {
            return this.FileWrite(text);
        }
    }
}
