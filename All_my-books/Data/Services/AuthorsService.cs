using All_my_books.Data.Models;
using All_my_books.Data.ViewModels;
using System.Linq;

namespace All_my_books.Data.Services
{
    public class AuthorsService
    {

        private readonly AppDbContext _context;

        public AuthorsService(AppDbContext Context)
        {
            _context = Context;
        }


        public void AddAuthor(AuthorVM author)
        {
            var _Author = new Author()
            {
                FullName = author.FullName,
            
            };
            _context.Authors.Add(_Author);
            _context.SaveChanges();
        }


        public AuthorWithBooksVM GetAuthorswithBookds(int authorId)
        {
            var _author = _context.Authors.Where(a => a.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();
            return _author;
        }

    }
}
