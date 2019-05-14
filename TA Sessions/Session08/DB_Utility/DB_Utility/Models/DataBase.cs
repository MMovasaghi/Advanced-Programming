using Microsoft.EntityFrameworkCore;

namespace DB_Utility.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCard> ShoppingCards { get; set; }
        public DbSet<LikeProduct> LikeProducts { get; set; }
        public DbSet<ProductDate> ProductDates { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=S8_DB;Trusted_Connection=True;");
        }
    }
}
