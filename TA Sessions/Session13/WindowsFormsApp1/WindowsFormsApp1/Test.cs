using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Test
    {
        public string FileName { get; set; }
        protected bool FileWrite(string text = "NULL",string filename = "Output.txt")
        {
            try
            {
                FileStream output = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter fileWriter = new StreamWriter(output);
                fileWriter.Write(text);
                fileWriter.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
