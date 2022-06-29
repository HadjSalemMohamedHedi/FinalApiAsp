using All_my_books.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace All_my_books.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Book> Books { get; set; }
    }
}
