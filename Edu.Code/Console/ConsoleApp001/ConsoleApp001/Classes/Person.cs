using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp001.Classes.Enum;

namespace ConsoleApp001.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender? gender { get; set; }
        public BirthDate birthdate { get; set; }

        private bool IsIdTrue()
        {
            if (Id >= 0)
                return true;
            return false;
        }
        protected bool IsFirstNameTrue()
        {
            if (FirstName.Length >= 3)
                return true;
            return false;
        }
        public bool IslastNameTrue()
        {
            if (LastName.Length >= 4 && LastName.Length <= 10)
                return true;
            return false;
        }
    }
}
