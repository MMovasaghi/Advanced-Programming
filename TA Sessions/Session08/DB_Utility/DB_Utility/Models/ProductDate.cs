using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB_Utility.Models
{
    public class ProductDate
    {
        public int ProductDateId { get; set; }

        [Required(ErrorMessage = "Production Date is required")]
        public DateTime P_Date { get; set; }

        [Required(ErrorMessage = "Expiration Date is required")]
        public DateTime E_Date { get; set; }
    }
}
