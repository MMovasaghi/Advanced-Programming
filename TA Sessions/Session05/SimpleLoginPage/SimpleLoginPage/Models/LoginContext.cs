using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SimpleLoginPage.Models
{
    public class LoginContext : DbContext
    {
        public DbSet<Person> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SimpleDB2;Trusted_Connection=True;");
        }
    }
}
