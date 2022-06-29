using System;
using System.Collections.Generic;

namespace All_my_books.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }

    }


    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }

    }

    public class BookAuthorVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
