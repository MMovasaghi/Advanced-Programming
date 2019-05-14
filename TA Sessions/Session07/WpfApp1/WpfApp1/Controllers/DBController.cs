using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Controllers.CExceptions;

namespace WpfApp1.Controllers
{
    public class DBController
    {
        public bool AddProduct(Models.Product newproduct)
        {
            try
            {
                var db = new DataBase();
                var exsistance = db.Products
                    .Where(i => i.Name == newproduct.Name)
                    .FirstOrDefault();

                if (exsistance == null)
                {
                    //Product is not exsist in DB
                    db.Products.Add(newproduct);
                    db.SaveChanges();
                    return true;
                }
                else
                    throw new PRODUCT_DUPLICATE_EXCEPTION();
            }
            catch (PRODUCT_DUPLICATE_EXCEPTION)
            {
                throw new PRODUCT_DUPLICATE_EXCEPTION();
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Models.Product> AllProducts()
        {
            try
            {
                var db = new DataBase();
                return db.Products.ToList<Models.Product>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
