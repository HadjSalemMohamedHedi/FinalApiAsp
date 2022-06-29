using System;
using System.Collections.Generic;

namespace All_my_books.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdd { get; set; }


        //Navigation Proprities

        //publisher can publish Multible Book
        // Book 1 Publisher n
        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }



        //Book and author Relation 
        //Many to Many
        public List<Book_Author> book_Authors { get; set; }


    }
}
