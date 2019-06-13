using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface Interface1
    {
        /// <summary>
        /// Save Base Function
        /// </summary>
        /// <param name="text"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        bool Save(string text, string filename);
    }
}
