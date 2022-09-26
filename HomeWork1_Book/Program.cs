using HomeWork1_Book_Domain;
using HomeWork1_Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace HomeWork1_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");

            
           
            json();
            Console.WriteLine(" Enter 1  to get  info all book & Enter 2 to get info one book & Enter 3 to delet book & Enter 4 to Update info book");
            string num;
            num = Console.ReadLine();
            int n;
            n=int.Parse(num);
            if(n==1) GetAllBook();
            if(n==2) GetOneBook();
            if(n==3) DeletBook();
          //  if (num == 4) UpdateOfBook();


        }

        private static void json()
        {
            string Register = File.ReadAllText("defaultbook.json");
            var DefaultUser = JsonSerializer.Deserialize<List<User>>(Register);
            bool x = false;
            using (var context = new BookDBContext())
            {
                foreach (var f in DefaultUser)
                {
                    foreach (var user in context.Users)
                    {
                        if (f.UserName == user.UserName)
                            x = true;
                    }
                }
                if (x == false)
                {
                    context.Users.AddRange(DefaultUser);
                    context.SaveChanges();
                
                    }
                }


            
        }
       
        private static void UpdateOfBook()
        {
            using(var context =new BookDBContext()) {
                var book = context.Books
                     .Where(b => b.BookId == 2);
                book.Title = "dddd";
                book.price = 10;
                   
           
            }
        }

        private static void DeletBook()
        {
            
            using (var context = new BookDBContext())
            {

                var books = context.Books
                    .Where(b => b.BookId == 2)
                   .Include(e => new { Id = e.BookId, Price = e.price, Countofbook = e.count, Title = e.Title + " " })
                   .Where(e => e.Isdelet != true);
                

                context.SaveChanges();
            }
        }
        private static void GetOneBook()
        {
            int sum = 0;
            using (var context = new BookDBContext())
            {
                var books = context.Books
                    .Where(e => e.BookId == 4)
                    .Select(e => new { Id=e.BookId, Price = e.price ,Countofbook=e.count, Title = e.Title + " " });
                     
                foreach (var book in books)
                {
                    Console.WriteLine(book.Id + book.Title + " " + book.Price);
                    sum += book.Countofbook;
                
                        }
                Console.WriteLine("the total numbers of this  book is = " + sum);
                context.SaveChanges();
                    
            } }

            private static void GetAllBook()
        {
            
            using (var context = new BookDBContext())
            {
                int s = 0;
                var books = context.Books
                     .Select(e => new { Id = e.BookId, Count = e.count ,Title = e.Title+"" });
                foreach (var book in books) {

                    Console.WriteLine(book.Id + " " + book.Title);
                    s+= book.Count;
                        }
                Console.WriteLine("the total numbers of book is = " + s);
                context.SaveChanges();
                
                 



            }
        }

        
    }
}