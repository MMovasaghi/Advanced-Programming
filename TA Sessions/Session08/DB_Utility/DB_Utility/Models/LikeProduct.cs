using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Utility.Models
{
    public class LikeProduct
    {
        public int LikeProductId { get; set; }
        public List<Product> products { get; set; }
    }
}
