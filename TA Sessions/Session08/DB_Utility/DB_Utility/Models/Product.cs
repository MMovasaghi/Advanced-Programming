using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB_Utility.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public ProductDate productDate { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        public long NumberOfExsistance { get; set; }
    }
}
