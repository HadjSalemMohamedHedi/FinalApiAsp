using All_my_books.Data.Models;
using All_my_books.Data.ViewModels;

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



    }
}
