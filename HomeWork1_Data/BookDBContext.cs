using HomeWork1_Book_Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeWork1_Data
{
    public class BookDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog = BookDB");
        }


    }
}