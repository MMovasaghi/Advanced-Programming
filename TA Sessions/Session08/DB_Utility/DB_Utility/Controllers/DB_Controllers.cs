using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Utility.Models;

namespace DB_Utility.Controllers
{
    public class DB_Controllers
    {
        public bool AddNewProduct(Product product)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddNewPerson(Person person)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddNewShoppingCardToPerson(Person person)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddNewLikeProductToPerson(Person person , LikeProduct likeProduct)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditPerson(Person EditedPerson , string PersonName)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditProduct(Person EditedProduct, string ProductName)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
