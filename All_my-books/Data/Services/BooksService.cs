using All_my_books.Data.Models;
using All_my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace All_my_books.Data.Services
{
    public class BooksService
    {
        private readonly AppDbContext _context;

        public BooksService(AppDbContext Context)
        {
            _context = Context;                
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdd = DateTime.Now,
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int IdBooktoGet)
        {
            return _context.Books.FirstOrDefault(b => b.Id.Equals(IdBooktoGet));
        }


        public Book UpdateBook(int bookId, BookVM book)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == bookId);
            if(bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Description = book.Description;
                bookToUpdate.IsRead = book.IsRead;
                bookToUpdate.DateRead = book.IsRead ? book.DateRead.Value : null;
                bookToUpdate.Rate = book.IsRead ? book.Rate.Value : null;
                bookToUpdate.Genre = book.Genre;
                bookToUpdate.Author = book.Author;
                bookToUpdate.CoverUrl = book.CoverUrl;
                bookToUpdate.DateAdd = DateTime.Now;

                _context.SaveChanges();
            }

            return bookToUpdate;

        }


        public int DeleteBook(int idBookToDelete)
        {
            var bookToDelete = _context.Books.FirstOrDefault(b => b.Id == idBookToDelete);
            if(bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
                return 1;
            }
            return 0;
        }


    }
}
