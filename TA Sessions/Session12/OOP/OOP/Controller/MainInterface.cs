using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Controller
{
    public interface MainInterface<T>
    {
        bool AddNewToDB(T NewItem);
        bool RemoveFromDB(T RemovedItem);
        bool ShowAllEntity();
        bool CheckLogin(T C_object);
    }
}
