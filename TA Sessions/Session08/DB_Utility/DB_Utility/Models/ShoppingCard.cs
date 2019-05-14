using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB_Utility.Models
{
    public class ShoppingCard
    {
        public int ShoppingCardId { get; set; }
        public List<Product> products { get; set; }

        [Required]
        public int personid { get; set; }
    }
}
