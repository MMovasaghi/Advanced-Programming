using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;

namespace OOP.Controller
{
    public class ManagerController : MainController<Manager>, MainInterface<Manager>
    {
        public ManagerController(Manager co) : base(co)
        {
        }

        public bool AddNewToDB(Manager NewItem)
        {
            throw new NotImplementedException();
        }

        public bool CheckLogin(Manager C_object)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromDB(Manager RemovedItem)
        {
            throw new NotImplementedException();
        }

        public bool ShowAllEntity()
        {
            throw new NotImplementedException();
        }
    }
}
