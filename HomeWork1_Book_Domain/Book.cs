using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Book_Domain
{
    public class Book
    {
        public Book()
        {
            
           Isdelet = false;

        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public bool Isdelet { get; set; }


    }
}
