using Amazon_Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Task = Amazon_Domain.Task;

namespace Amazon_Data
{
    public class AmazonDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog = AmazonDatabase").
                LogTo(log=> Console.WriteLine(log),      /*logging the EF Core events to Console*/
                  new[] { DbLoggerCategory.Database.Command.Name} ,  /* logger categories*/
                  LogLevel.Information

                ).EnableSensitiveDataLogging();
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasMany(c => c.categories)
                .WithMany(t => t.Tasks)
                .UsingEntity<CategoryTask>()
                .Property(ct => ct.CreatedDate).HasDefaultValueSql("getDate()");// using the categorytask entity to build the hoin table
        }



    }
}