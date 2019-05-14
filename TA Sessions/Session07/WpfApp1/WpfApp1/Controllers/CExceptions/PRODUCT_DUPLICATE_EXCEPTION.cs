using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controllers.CExceptions
{
    public class PRODUCT_DUPLICATE_EXCEPTION : Exception
    {
        public PRODUCT_DUPLICATE_EXCEPTION()
        {
        }

        public PRODUCT_DUPLICATE_EXCEPTION(string message) : base(message)
        {
        }

        public PRODUCT_DUPLICATE_EXCEPTION(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
