using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;

namespace OOP.Controller
{
    public class AdminController : MainController<Models.Admin> , MainInterface<Models.Admin>
    {
        public AdminController(Admin co) : base(co)
        {
            //initial database
            //inital files
        }
        public bool AddNewToDB(Admin NewItem)
        {
            try
            {
                //connect to db
                //find if it's exsist
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CheckLogin(Admin C_object)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromDB(Admin RemovedItem)
        {
            throw new NotImplementedException();
        }

        public bool ShowAllEntity()
        {
            throw new NotImplementedException();
        }
    }
}
