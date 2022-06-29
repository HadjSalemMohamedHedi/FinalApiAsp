using System.Collections.Generic;

namespace All_my_books.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }



        //Navigation Proprities
        //Many Book have Many Author
        public List<Book_Author> book_Authors { get; set; }

    }
}
