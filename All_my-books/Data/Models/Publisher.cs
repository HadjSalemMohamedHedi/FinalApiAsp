using System.Collections.Generic;

namespace All_my_books.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; } 
        public string Name { get; set; }


        //Navigation Proprities
        //publisher can publish Multible Book
        // Book 1 Publisher n
        public List<Book> Books { get; set; }
    }
}
