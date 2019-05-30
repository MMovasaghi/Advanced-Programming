using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Person
    {
        private static int NumberOfUser = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        private string _Username;
        public string Username
        {
            get { return _Username; }
            set
            {
                _Username = "U" + NumberOfUser + "_" + value;
                NumberOfUser++;
            }
        }

        public string Password { get; set; }
    }
}
