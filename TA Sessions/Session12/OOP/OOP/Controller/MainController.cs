using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;

namespace OOP.Controller
{
    public class MainController<T>
    {
        private T CurrentObject;
        public MainController(T co)
        {
            CurrentObject = co;
        }
        public override string ToString()
        {
            return (CurrentObject as Person).Username;
        }
    }
}
