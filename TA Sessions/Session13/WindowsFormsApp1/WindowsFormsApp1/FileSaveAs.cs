using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FileSaveAs : Test, Interface1
    {
        public bool Save(string text, string filename)
        {
            return this.FileWrite(text, filename);
        }
    }
}
