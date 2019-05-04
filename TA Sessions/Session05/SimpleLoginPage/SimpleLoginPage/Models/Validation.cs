using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginPage.Models
{
    public class Validation
    {
        public bool CheckUSERPASS(Person person)
        {

            using (var db = new Models.LoginContext())
            {
                var res = db.Blogs.Where(i => i.Username == person.Username && i.Password == person.Password).FirstOrDefault();
                if (res != null)
                {
                    //login Successfully
                    return true;
                }
                else
                {
                    //Password or username is not correct
                    return false;
                }
            }
        }
        public bool InitialDB()
        {
            try
            {
                using (var db = new Models.LoginContext())
                {
                    db.Blogs.Add(new Models.Person() { Name = "Ali", Username = "ali@gmail.com", Password = "1234", Cost = 123 });
                    db.Blogs.Add(new Models.Person() { Name = "Hasan", Username = "hasan@gmail.com", Password = "1234", Cost = 123 });
                    db.Blogs.Add(new Models.Person() { Name = "Hossein", Username = "hossein@gmail.com", Password = "1234", Cost = 321 });
                    db.Blogs.Add(new Models.Person() { Name = "Maryam", Username = "maryam@gmail.com", Password = "1234", Cost = 456 });
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
