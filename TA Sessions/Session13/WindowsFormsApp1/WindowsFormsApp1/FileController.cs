using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class FileController : Test
    {
        /// <summary>
        /// Save text into the file (Output.txt)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Save(string text)
        {
            return this.FileWrite(text);
        }
        /// <summary>
        /// Save As
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveAs(string text,string filename)
        {
            return this.FileWrite(text,filename);
        }
    }
}
