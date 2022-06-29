﻿using All_my_books.Data.Models;
using All_my_books.Data.ViewModels;

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



    }
}
