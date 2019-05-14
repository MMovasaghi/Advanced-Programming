using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controllers
{
    public class DataBase : DbContext
    {
        public DbSet<Models.Person> Persons { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SimpleDB;Trusted_Connection=True;");
        }
    }
}
