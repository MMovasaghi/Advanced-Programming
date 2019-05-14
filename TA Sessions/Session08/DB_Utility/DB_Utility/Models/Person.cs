using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB_Utility.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; }

        public ShoppingCard shoppingCard { get; set; }
        public LikeProduct likeProducts { get; set; }
    }
}
