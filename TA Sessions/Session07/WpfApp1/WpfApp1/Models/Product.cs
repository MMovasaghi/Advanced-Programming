using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controllers.Models
{
    public class Product
    {
        public int Productid { get; set; }
        public string Name { get; set; }
        public long NumberOfExsistance { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
