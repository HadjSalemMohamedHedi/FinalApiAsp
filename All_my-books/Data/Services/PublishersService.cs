using All_my_books.Data.Models;
using All_my_books.Data.ViewModels;
using System.Linq;

namespace All_my_books.Data.Services
{
    public class PublishersService
    {

        private readonly AppDbContext _context;

        public PublishersService(AppDbContext Context)
        {
            _context = Context;
        }


        public void AddPublisher(PublisherVM publisher)
        {
            var _Publisher = new Publisher()
            {
                Name = publisher.Name,
            
            };
            _context.Publishers.Add(_Publisher);
            _context.SaveChanges();
        }


        public PublisherWithBooksAndAuthorsVM GetPublisherData(int PublisherId)
        {
            var _publisherData = _context.Publishers.Where(p => p.Id == PublisherId)
                .Select(n => new PublisherWithBooksAndAuthorsVM()
                {
                    Name = n.Name,
                    BookAuthors = n.Books.Select(n => new BookAuthorVM
                    {
                        BookName = n.Title,
                        BookAuthors = n.book_Authors.Select(n => n.Author.FullName).ToList()
                    }).ToList()
                }).FirstOrDefault();
            return _publisherData;

        }

    }
}
